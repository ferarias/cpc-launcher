using System.Xml.Serialization;

using CpcLauncher.Dto;

namespace CpcLauncher
{
    public class CpcGamesRepository
    {
        private List<Game> _gameList = [];
        private List<FileInfo> _fileList = [];

        public List<Game> Games { get; } = [];
        public List<Game> GamesNotMatching { get; private set; } = [];

        public void Load(string rootFolder)
        {
            // Read the gamelist.xml
            _gameList = ReadFromGamesListXml(rootFolder);

            // Read the actual files
            _fileList = ReadFromDirectory(rootFolder);
            if (_fileList.Count == 0)
            {
                MessageBox.Show("No files in " + rootFolder);
            }

            // Match gameslist with actual files
            CombineGames();
        }

        public static List<FileInfo> ReadFromDirectory(string path)
        {
            var list = new List<FileInfo>();
            if (Directory.Exists(path))
            {
                var di = new DirectoryInfo(path);
                foreach (var fi in di.GetFiles())
                {
                    if (fi.Extension.Equals(".dsk", StringComparison.InvariantCultureIgnoreCase))
                    {
                        list.Add(fi);
                    }
                    if (fi.Extension.Equals(".zip", StringComparison.InvariantCultureIgnoreCase))
                    {
                        list.Add(fi);
                    }
                }
            }
            return list;
        }
        public static List<Game> ReadFromGamesListXml(string rootFolder)
        {
            var gameListFile = Path.Combine(rootFolder, Constants.GameListFileName);

            var games = new List<Game>();
            if (File.Exists(gameListFile))
            {
                var serializer = new XmlSerializer(typeof(GameList));
                using var reader = new StreamReader(gameListFile);
                if (serializer.Deserialize(reader) is GameList gameList)
                {
                    games = gameList.Games;
                }
            }

            // Set absolute paths
            foreach (var game in games)
            {
                var gamePath = !File.Exists(game.Path)
                    ? Path.Combine(rootFolder, game.Path)
                    : game.Path;
                game.Path = Path.GetFullPath(gamePath);
                var imagePath = !File.Exists(game.Image)
                                    ? Path.Combine(rootFolder, game.Image)
                                    : game.Image;
                game.Image = Path.GetFullPath(imagePath);
                var marqueePath = !File.Exists(game.Marquee)
                                    ? Path.Combine(rootFolder, game.Marquee)
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