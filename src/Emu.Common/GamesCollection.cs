using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

using CpcLauncher.Dto;

namespace CpcLauncher
{
    public class GamesCollection
    {
        private List<Game> _gameList = [];
        private List<FileInfo> _fileList = [];

        public List<Game> Games { get; } = [];
        public List<Game> GamesNotMatching { get; private set; } = [];

        public void Load(DirectoryInfo rootFolder, IEnumerable<string> allowedExtensions)
        {
            // Read the gamelist.xml
            _gameList = ReadFromGamesListXml(rootFolder);

            // Read the actual files
            _fileList = ReadFromDirectory(rootFolder, allowedExtensions);
            if (_fileList.Count == 0)
            {
                return;
            }

            // Match gameslist with actual files
            CombineGames();
        }

        public static List<FileInfo> ReadFromDirectory(DirectoryInfo rootFolder, IEnumerable<string> allowedExtensions)
        {
            var list = new List<FileInfo>();
            if (rootFolder.Exists)
            {
                foreach (var fi in rootFolder.GetFiles())
                {
                    if (allowedExtensions.Contains(fi.Extension, StringComparer.InvariantCultureIgnoreCase) || fi.Extension.Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        list.Add(fi);
                    }
                }
            }
            return list;
        }
        public static List<Game> ReadFromGamesListXml(DirectoryInfo rootFolder)
        {
            var gameListFile = new FileInfo(Path.Combine(rootFolder.FullName, Consts.GameListFileName));

            var games = new List<Game>();
            if (gameListFile.Exists)
            {
                var serializer = new XmlSerializer(typeof(GameList));
                using var reader = new StreamReader(gameListFile.FullName);
                if (serializer.Deserialize(reader) is GameList gameList)
                {
                    games = gameList.Games;
                }
            }

            // Set absolute paths
            foreach (var game in games)
            {
                var gamePath = !File.Exists(game.Path)
                    ? Path.Combine(rootFolder.FullName, game.Path)
                    : game.Path;
                game.Path = Path.GetFullPath(gamePath);
                var imagePath = !File.Exists(game.Image)
                                    ? Path.Combine(rootFolder.FullName, game.Image)
                                    : game.Image;
                game.Image = Path.GetFullPath(imagePath);
                var marqueePath = !File.Exists(game.Marquee)
                                    ? Path.Combine(rootFolder.FullName, game.Marquee)
                                    : game.Marquee;
                game.Marquee = Path.GetFullPath(marqueePath);
            }

            return games;
        }

        public void CombineGames()
        {
            Games.Clear();
            GamesNotMatching = [];
            if (_gameList != null)
            {
                foreach (var gameListEntry in _gameList)
                {
                    if (File.Exists(gameListEntry.Path))
                    {
                        if (_fileList.Any(f => f.FullName == gameListEntry.Path))
                        {
                            Games.Add(gameListEntry);
                        }
                    }
                    else
                    {
                        GamesNotMatching.Add(gameListEntry);
                    }
                }
            }
        }
    }
}