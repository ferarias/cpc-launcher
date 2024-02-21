using System.Diagnostics;
using System.Globalization;
using System.IO.Compression;

namespace CpcLauncher
{
    public partial class MainForm : Form
    {
        private readonly CpcGamesRepository _repository = new();

        public MainForm() => InitializeComponent();

        private void MainForm_Load(object sender, EventArgs e) => ReadGames();

        private void BtnReloadClick(object sender, EventArgs e) => ReadGames();

        private void LvGameListSelectedIndexChanged(object sender, EventArgs e) => RenderGameDetails();

        private void LvGameListDoubleClick(object sender, EventArgs e) => LaunchGame();

        private void BtnLaunchClick(object sender, EventArgs e) => LaunchGame();

        private void LvGameListKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LaunchGame();
            }
        }

        private void ReadGames()
        {
            var rootFolder = Properties.Settings.Default.DisksPath;
            toolStripStatusLabel1.Text = rootFolder;

            _repository.Load(rootFolder);

            lvGameList.Items.Clear();
            foreach (var game in _repository.Games)
            {
                var listViewItem = new ListViewItem(game.Name);
                listViewItem.SubItems.Add(game.Path);
                lvGameList.Items.Add(listViewItem);
            }
            lvGameList.SelectedIndices.Add(0);
            lvGameList.Focus();
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
                string marqueePath = string.Empty;
                var gameListEntry = _repository.Games.Find(g => g.Name.Equals(game, StringComparison.CurrentCultureIgnoreCase));
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
                    var coversPath = Properties.Settings.Default.CoversPath;
                    imagePath = Path.Combine(coversPath, $"{game}.png");
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
            // CPCEC
            var emulatorPath = Properties.Settings.Default.EmulatorPath;
            string emulatorExe = Path.Combine(emulatorPath, "CPCEC.EXE");

            var selectedItem = lvGameList.Items[lvGameList.SelectedIndices[0]];
            string gameName = selectedItem.Text;
            var gamePath = selectedItem.SubItems[1].Text;
            var gameExtension = Path.GetExtension(gamePath);

            var psi = new ProcessStartInfo(emulatorExe);

            if (gameExtension.Equals(Constants.CpcDiskExtension, StringComparison.InvariantCultureIgnoreCase))
            {
                psi.ArgumentList.Add(gamePath);
                psi.WorkingDirectory = emulatorPath;
            }

            if (gameExtension.Equals(Constants.ZippedDiskExtension))
            {
                var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                ZipFile.ExtractToDirectory(gamePath, tempDir);
                var firstFile = Directory.GetFiles(tempDir, Constants.CpcDiskExtensionPattern, SearchOption.TopDirectoryOnly).FirstOrDefault();
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
