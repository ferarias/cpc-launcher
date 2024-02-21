namespace CpcLauncher
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAbout = new Button();
            btnReload = new Button();
            btnLaunch = new Button();
            lvGameList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderDirectory = new ColumnHeader();
            columnHeaderExtension = new ColumnHeader();
            lblGameDetails = new Label();
            lblListHeader = new Label();
            pbxGameCover = new PictureBox();
            cbFullscreen = new CheckBox();
            splitContainer1 = new SplitContainer();
            tbGameDetails = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(631, 122);
            btnAbout.Margin = new Padding(2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(23, 23);
            btnAbout.TabIndex = 10;
            btnAbout.Text = "?";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += BtnAboutClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(568, 95);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(86, 23);
            btnReload.TabIndex = 9;
            btnReload.Text = "Refresh";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReloadClick;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(586, 12);
            btnLaunch.Margin = new Padding(2);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(68, 37);
            btnLaunch.TabIndex = 8;
            btnLaunch.Text = "Launch!\r\n";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += BtnLaunchClick;
            // 
            // lvGameList
            // 
            lvGameList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderDirectory, columnHeaderExtension });
            lvGameList.Dock = DockStyle.Fill;
            lvGameList.GridLines = true;
            lvGameList.Location = new Point(0, 0);
            lvGameList.Margin = new Padding(2);
            lvGameList.MultiSelect = false;
            lvGameList.Name = "lvGameList";
            lvGameList.Size = new Size(595, 642);
            lvGameList.TabIndex = 5;
            lvGameList.UseCompatibleStateImageBehavior = false;
            lvGameList.View = View.Details;
            lvGameList.SelectedIndexChanged += LvGameListSelectedIndexChanged;
            lvGameList.DoubleClick += LvGameListDoubleClick;
            lvGameList.KeyPress += LvGameListKeyPress;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 250;
            // 
            // columnHeaderDirectory
            // 
            columnHeaderDirectory.Text = "Directory";
            columnHeaderDirectory.Width = 250;
            // 
            // columnHeaderExtension
            // 
            columnHeaderExtension.Text = "Extension";
            columnHeaderExtension.Width = 64;
            // 
            // lblGameDetails
            // 
            lblGameDetails.Location = new Point(14, 9);
            lblGameDetails.Margin = new Padding(2, 0, 2, 0);
            lblGameDetails.Name = "lblGameDetails";
            lblGameDetails.Size = new Size(259, 22);
            lblGameDetails.TabIndex = 7;
            lblGameDetails.Text = "Game details\r\n";
            // 
            // lblListHeader
            // 
            lblListHeader.Location = new Point(11, 0);
            lblListHeader.Margin = new Padding(2, 0, 2, 0);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(212, 22);
            lblListHeader.TabIndex = 6;
            lblListHeader.Text = "List of games";
            // 
            // pbxGameCover
            // 
            pbxGameCover.BackColor = Color.Black;
            pbxGameCover.Location = new Point(14, 150);
            pbxGameCover.Name = "pbxGameCover";
            pbxGameCover.Size = new Size(640, 480);
            pbxGameCover.TabIndex = 0;
            pbxGameCover.TabStop = false;
            // 
            // cbFullscreen
            // 
            cbFullscreen.AutoSize = true;
            cbFullscreen.CheckAlign = ContentAlignment.MiddleRight;
            cbFullscreen.Location = new Point(535, 53);
            cbFullscreen.Margin = new Padding(2);
            cbFullscreen.Name = "cbFullscreen";
            cbFullscreen.Size = new Size(119, 19);
            cbFullscreen.TabIndex = 11;
            cbFullscreen.Text = "Launch fullscreen";
            cbFullscreen.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvGameList);
            splitContainer1.Panel1.Controls.Add(lblListHeader);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tbGameDetails);
            splitContainer1.Panel2.Controls.Add(lblGameDetails);
            splitContainer1.Panel2.Controls.Add(pbxGameCover);
            splitContainer1.Panel2.Controls.Add(btnAbout);
            splitContainer1.Panel2.Controls.Add(btnLaunch);
            splitContainer1.Panel2.Controls.Add(btnReload);
            splitContainer1.Panel2.Controls.Add(cbFullscreen);
            splitContainer1.Size = new Size(1265, 642);
            splitContainer1.SplitterDistance = 595;
            splitContainer1.TabIndex = 12;
            // 
            // tbGameDetails
            // 
            tbGameDetails.Location = new Point(14, 34);
            tbGameDetails.Multiline = true;
            tbGameDetails.Name = "tbGameDetails";
            tbGameDetails.Size = new Size(516, 103);
            tbGameDetails.TabIndex = 12;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 642);
            Controls.Add(splitContainer1);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "CPC Launcher";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAbout;
        private Button btnReload;
        private Button btnLaunch;
        private ListView lvGameList;
        private Label lblGameDetails;
        private Label lblListHeader;
        private PictureBox pbxGameCover;
        private CheckBox cbFullscreen;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderDirectory;
        private ColumnHeader columnHeaderExtension;
        private SplitContainer splitContainer1;
        private TextBox tbGameDetails;
    }
}
