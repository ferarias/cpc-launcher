using System.Diagnostics;
using System.IO.Compression;

using Emu.Common;

namespace Emu.LauncherApp
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Platform, GameSystem> _systems = Defaults.DefaultSystems;
        private readonly Dictionary<Platform, GamesCollection> _games = [];

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e) => ReadGames();

        private void btnReload_Click(object sender, EventArgs e) => ReadGames();

        private void lvGameList_SelectedIndexChanged(object sender, EventArgs e) => RenderGameDetails();

        private void lvGameList_MouseDoubleClick(object sender, MouseEventArgs e) => LaunchGame();

        private void btnLaunch_Click(object sender, EventArgs e) => LaunchGame();

        private void lvGameList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LaunchGame();
            }
        }

        private void ReadGames()
        {
            _games.Clear();
            foreach (var system in _systems)
            {
                DirectoryInfo rootFolder = system.Value.GamesPath ?? throw new NullReferenceException("Games path cannot be null");
                toolStripStatusLabel1.Text = rootFolder.FullName;

                var gamesRepo = new GamesCollection();
                gamesRepo.Load(rootFolder, system.Value.Emulators.SelectMany(x => x.Features.AllowedExtensions));
                _games.Add(system.Key, gamesRepo);
            }

            lvGameList.Items.Clear();
            foreach (var platformGames in _games)
            {
                foreach (var game in platformGames.Value.Games)
                {
                    var listViewItem = new ListViewItem(game.Name);
                    listViewItem.SubItems.Add(platformGames.Key.ToString());
                    listViewItem.SubItems.Add(game.Path);
                    lvGameList.Items.Add(listViewItem);
                }
            }

            lvGameList.SelectedIndices.Add(0);
            lvGameList.Focus();
        }

        private void RenderGameDetails()
        {
            if (lvGameList.SelectedIndices.Count > 0)
            {
                var selectedItem = lvGameList.Items[lvGameList.SelectedIndices[0]];
                string gameName = selectedItem.Text;
                var platform = (Platform)Enum.Parse(typeof(Platform), selectedItem.SubItems[1].Text);

                tbGameDetails.Clear();
                pbxGameCover.Image = null;

                string imagePath = string.Empty;
                string marqueePath = string.Empty;
                var gameListEntry = _games[platform].Games.Find(g => g.Name.Equals(gameName, StringComparison.CurrentCultureIgnoreCase));
                if (gameListEntry != null)
                {
                    imagePath = gameListEntry.Image;
                    marqueePath = gameListEntry.Marquee;
                    tbGameDetails.Lines = gameListEntry.Description?.Split('\n');
                    textBoxReleaseDate.Text = !string.IsNullOrWhiteSpace(gameListEntry.Releasedate)
                        ? DateTime.ParseExact(gameListEntry.Releasedate, "yyyyMMddTHHmmss", null).Year.ToString()
                        : "N/A";
                    textBoxDeveloper.Text = gameListEntry.Developer;
                    textBoxPublisher.Text = gameListEntry.Publisher;
                    textBoxGenre.Lines = gameListEntry.Genre.Split(',').Select(x => x.Trim()).ToArray();
                }
                else
                {
                    var coversPath = Properties.Settings.Default.CpcScreenshots;
                    imagePath = Path.Combine(coversPath, $"{gameName}.png");
                    tbGameDetails.Lines = ["N/A"];
                    textBoxReleaseDate.Text = string.Empty;
                    textBoxDeveloper.Text = string.Empty;
                    textBoxPublisher.Text = string.Empty;
                    textBoxGenre.Text = string.Empty;
                }

                if (File.Exists(imagePath))
                {
                    pbxGameCover.Load(imagePath);
                }
                else
                {
                    pbxGameCover.Image = null;
                }
                if (File.Exists(marqueePath))
                {
                    pictureBoxMarquee.Load(marqueePath);
                }
                else
                {
                    pictureBoxMarquee.Image = null;
                }
            }
            lvGameList.Focus();
        }

        private void LaunchGame()
        {
            var selectedItem = lvGameList.Items[lvGameList.SelectedIndices[0]];
            string gameName = selectedItem.Text;
            var platform = (Platform)Enum.Parse(typeof(Platform), selectedItem.SubItems[1].Text);
            var gamePath = selectedItem.SubItems[2].Text;
            var gameExtension = Path.GetExtension(gamePath);
            var emulator = _systems[platform].Emulators.First();
            var emulatorExe = emulator.EmulatorPath ?? throw new ApplicationException("Emulator path not set!");

            var psi = new ProcessStartInfo(emulatorExe.FullName)
            {
                WorkingDirectory = emulatorExe.DirectoryName
            };

            if (gameExtension.Equals(Consts.ZippedDiskExtension))
            {
                var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                ZipFile.ExtractToDirectory(gamePath, tempDir);
                var firstFile = Array.Find(Directory.GetFiles(tempDir), f => emulator.Features.AllowedExtensions.Contains(Path.GetExtension(f), StringComparer.InvariantCultureIgnoreCase));
                if (firstFile == null)
                    return;
#if NET6_0_OR_GREATER
                psi.ArgumentList.Add(firstFile);
#else
                psi.Arguments = $"\"{firstFile}\"";
#endif
            }

            if (emulator.Features.AllowedExtensions.Contains(gameExtension, StringComparer.InvariantCultureIgnoreCase))
            {
#if NET6_0_OR_GREATER
                psi.ArgumentList.Add(gamePath);
#else
                psi.Arguments = $"\"{gamePath}\"";
#endif
            }

            var process = Process.Start(psi);
            process?.WaitForExit();
        }
    }
}
