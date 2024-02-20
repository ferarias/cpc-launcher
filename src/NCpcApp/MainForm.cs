using System.Diagnostics;

using CpcLauncher.Dto;

namespace CpcLauncher
{
    public partial class MainForm : Form
    {
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

            var fileList = new CpcFiles();
            fileList.ReadFromFile(disksPath);
            if(fileList.Count == 0)
            {
                MessageBox.Show("No dsk files in " + disksPath);
                return;
            }

            lvGameList.Items.Clear();
            foreach (var fi in fileList)
            {
                var listViewItem = new ListViewItem(Path.GetFileNameWithoutExtension(fi.Name));
                listViewItem.SubItems.Add(fi.FullName);
                lvGameList.Items.Add(listViewItem);
            }
            lvGameList.SelectedIndices.Add(0);
        }

        private void LaunchGame()
        {
            // CPCE Unlim
            var emulatorPath = Properties.Settings.Default.EmulatorPath;

            string text = lvGameList.Items[lvGameList.SelectedIndices[0]].Text;
            string fileName = Path.Combine(emulatorPath, "cpce95.exe");
            string text2 = "";
            if (cbFullscreen.Checked)
            {
                text2 = "/m ";
            }
            Process process = Process.Start(fileName, text2 + "\"" + text + "\"");
            process.WaitForExit();
        }

        private void RenderGameDetails()
        {
            var coversPath = Properties.Settings.Default.CoversPath;

            if (lvGameList.SelectedIndices.Count > 0)
            {
                string text = lvGameList.Items[lvGameList.SelectedIndices[0]].Text;
                string imagePath = Path.Combine(coversPath,  $"{text}.png");
                if (File.Exists(imagePath))
                {
                    pbxGameCover.Load(imagePath);
                }
                else
                {
                    pbxGameCover.Image = null;
                }
                tbGameDetails.Clear();
                tbGameDetails.Lines = [
                    "Press:",
                    "* Alt+F4 to exit game",
                    "* Alt+Enter to toggle window and fullscreen modes",
                    "",
                    "Joystick: External joystick or numeric keypad"
                    ];
            }
            lvGameList.Focus();
        }

        


    }
}
