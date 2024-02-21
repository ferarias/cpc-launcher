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
            ReadGameList();
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

        private void BtnAboutClick(object sender, EventArgs e)
        {
            MessageBox.Show("CPC Launcher\n\nA simple and fast Amstrad CPC game launcher.\nUses CPCE by CNG Soft (http://cpce.emuunlim.com)", "About");
        }

        private void LvGameListSelectedIndexChanged(object sender, EventArgs e)
        {
            RenderGameDetails();
        }

        private void BtnReloadClick(object sender, EventArgs e)
        {
            ReadGameList();
        }

        private void LvGameListKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                LaunchGame();
            }
        }

        private void ReadGameList()
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
            var fileList = new CpcFiles();
            fileList.ReadFromFile(disksPath);
            if (fileList.Count == 0)
            {
                MessageBox.Show("No dsk files in " + disksPath);
                return;
            }

            lvGameList.Items.Clear();
            foreach (var fi in fileList)
            {
                var listViewItem = new ListViewItem(Path.GetFileNameWithoutExtension(fi.Name));
                listViewItem.SubItems.Add(fi.DirectoryName);
                listViewItem.SubItems.Add(fi.Extension);
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
                    if (File.Exists(imagePath))
                    {
                        tbGameDetails.Lines = gameListEntry.Description?.Split('\n');
                    }
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
            // CPCE Unlim
            var emulatorPath = Properties.Settings.Default.EmulatorPath;
            string emulatorExe = Path.Combine(emulatorPath, "CPCEC.EXE");

            var selectedItem = lvGameList.Items[lvGameList.SelectedIndices[0]];
            string gameFileName = selectedItem.Text;
            var gameDir = selectedItem.SubItems[1].Text;
            var gameExtension = selectedItem.SubItems[2].Text;

            var psi = new ProcessStartInfo(emulatorExe);

            if (gameExtension.Equals(".dsk", StringComparison.InvariantCultureIgnoreCase))
            {
                psi.ArgumentList.Add(Path.Combine(gameDir, $"{gameFileName}{gameExtension}"));
                psi.WorkingDirectory = emulatorPath;
            }

            if (gameExtension.Equals(".zip"))
            {
                var tempDir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
                var zipFullPathName = Path.Combine(gameDir, $"{gameFileName}{gameExtension}");
                ZipFile.ExtractToDirectory(zipFullPathName, tempDir);
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
