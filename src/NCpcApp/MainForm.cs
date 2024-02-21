using System.Diagnostics;
using System.IO.Compression;
using System.Xml.Serialization;

using CpcLauncher.Dto;

namespace CpcLauncher
{
    public partial class MainForm : Form
    {
        private GameList? _gamelist;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadGames();
            toolStripStatusLabel1.Text = Properties.Settings.Default.DisksPath;
            lvGameList.Focus();
        }

        private void BtnLaunchClick(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void LvGameListDoubleClick(object sender, EventArgs e)
        {
            LaunchGame();
        }

        private void LvGameListSelectedIndexChanged(object sender, EventArgs e)
        {
            RenderGameDetails();
        }

        private void BtnReloadClick(object sender, EventArgs e)
        {
            ReadGames();
        }

        private void LvGameListKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LaunchGame();
            }
        }

        private void ReadGames()
        {
            var disksPath = Properties.Settings.Default.DisksPath;

            // Read the gamelist.xml
            var gameListFile = Path.Combine(disksPath, "gamelist.xml");
            if (File.Exists(gameListFile))
            {
                var serializer = new XmlSerializer(typeof(GameList));
                using var reader = new StreamReader(gameListFile);
                _gamelist = serializer.Deserialize(reader) as GameList;
            }

            // Read the actual files
            var fileList = CpcFilesReader.ReadFromDirectory(disksPath);
            if (fileList.Count == 0)
            {
                MessageBox.Show("No files in " + disksPath);
                return;
            }

            // Match gameslist with actual files
            var gamesInGamesListNotFoundInDisk = new List<Game>();
            var gamesMatching = new List<Game>();
            if (_gamelist != null)
            {
                foreach (var gameListEntry in _gamelist.Games)
                {
                    string gamePath = gameListEntry.Path;
                    if (!File.Exists(gamePath))
                    {
                        gamePath = Path.Combine(disksPath, gameListEntry.Path);
                    }
                    if (!File.Exists(gamePath))
                    {
                        gamesInGamesListNotFoundInDisk.Add(gameListEntry);
                    }
                    else
                    {
                        if(fileList.Any(f => f.FullName == Path.GetFullPath(gamePath)))
                        {
                            gameListEntry.Path = Path.GetFullPath(gamePath);
                            gamesMatching.Add(gameListEntry);
                        }
                    }
                }
            }

            lvGameList.Items.Clear();
            foreach (var game in gamesMatching)
            {
                var listViewItem = new ListViewItem(game.Name);
                listViewItem.SubItems.Add(game.Path);
                listViewItem.SubItems.Add(Path.GetExtension(game.Path)[^3..]);
                lvGameList.Items.Add(listViewItem);
            }
            lvGameList.SelectedIndices.Add(0);
        }

        private void RenderGameDetails()
        {
            var disksPath = Properties.Settings.Default.DisksPath;

            if (lvGameList.SelectedIndices.Count > 0)
            {
                string game = lvGameList.Items[lvGameList.SelectedIndices[0]].Text;

                tbGameDetails.Clear();
                pbxGameCover.Image = null;

                string imagePath = string.Empty;
                var gameListEntry = _gamelist?.Games.Find(g => g.Name.Equals(game, StringComparison.CurrentCultureIgnoreCase));
                if (gameListEntry != null)
                {
                    imagePath = gameListEntry.Image;
                    if (!File.Exists(imagePath))
                    {
                        imagePath = Path.Combine(disksPath, gameListEntry.Image);
                    }
                    tbGameDetails.Lines = gameListEntry.Description?.Split('\n');
                }
                else
                {
                    var coversPath = Properties.Settings.Default.CoversPath;
                    imagePath = Path.Combine(coversPath, $"{game}.png");
                    tbGameDetails.Lines = ["N/A"];
                }

                if (File.Exists(imagePath))
                {
                    pbxGameCover.Load(imagePath);
                }
            }
            lvGameList.Focus();
        }

        private void LaunchGame()
        {
            // CPCEC
            var emulatorPath = Properties.Settings.Default.EmulatorPath;
            string emulatorExe = Path.Combine(emulatorPath, "CPCEC.EXE");

            var selectedItem = lvGameList.Items[lvGameList.SelectedIndices[0]];
            string gameName = selectedItem.Text;
            var gamePath = selectedItem.SubItems[1].Text;
            var gameExtension = selectedItem.SubItems[2].Text;

            var psi = new ProcessStartInfo(emulatorExe);

            if (gameExtension.Equals("dsk", StringComparison.InvariantCultureIgnoreCase))
            {
                psi.ArgumentList.Add(gamePath);
                psi.WorkingDirectory = emulatorPath;
            }

            if (gameExtension.Equals("zip"))
            {
                var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                ZipFile.ExtractToDirectory(gamePath, tempDir);
                var firstFile = Directory.GetFiles(tempDir, "*.dsk", SearchOption.TopDirectoryOnly).FirstOrDefault();
                if (firstFile == null)
                    return;
                psi.ArgumentList.Add(firstFile);
                psi.WorkingDirectory = emulatorPath;
            }

            var process = Process.Start(psi);
            process?.WaitForExit();
        }
    }
}
