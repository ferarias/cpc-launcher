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
            pbxGameCover = new PictureBox();
            tbGameDetails = new TextBox();
            lvGameList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderDirectory = new ColumnHeader();
            columnHeaderExtension = new ColumnHeader();
            lblListHeader = new Label();
            lblGameDetails = new Label();
            btnLaunch = new Button();
            btnReload = new Button();
            btnAbout = new Button();
            cbFullscreen = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).BeginInit();
            SuspendLayout();
            // 
            // pbxGameCover
            // 
            pbxGameCover.BackColor = Color.Black;
            pbxGameCover.Location = new Point(357, 2);
            pbxGameCover.Margin = new Padding(2);
            pbxGameCover.Name = "pbxGameCover";
            pbxGameCover.Size = new Size(640, 480);
            pbxGameCover.TabIndex = 0;
            pbxGameCover.TabStop = false;
            // 
            // tbGameDetails
            // 
            tbGameDetails.Location = new Point(19, 498);
            tbGameDetails.Margin = new Padding(2);
            tbGameDetails.Multiline = true;
            tbGameDetails.Name = "tbGameDetails";
            tbGameDetails.ReadOnly = true;
            tbGameDetails.Size = new Size(306, 119);
            tbGameDetails.TabIndex = 4;
            // 
            // lvGameList
            // 
            lvGameList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderDirectory, columnHeaderExtension });
            lvGameList.GridLines = true;
            lvGameList.Location = new Point(21, 78);
            lvGameList.Margin = new Padding(2);
            lvGameList.MultiSelect = false;
            lvGameList.Name = "lvGameList";
            lvGameList.Size = new Size(304, 376);
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
            columnHeaderName.Width = 152;
            // 
            // columnHeaderDirectory
            // 
            columnHeaderDirectory.Text = "Directory";
            // 
            // columnHeaderExtension
            // 
            columnHeaderExtension.Text = "Extension";
            columnHeaderExtension.Width = 111;
            // 
            // lblListHeader
            // 
            lblListHeader.Location = new Point(21, 54);
            lblListHeader.Margin = new Padding(2, 0, 2, 0);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(212, 22);
            lblListHeader.TabIndex = 6;
            lblListHeader.Text = "List of games";
            // 
            // lblGameDetails
            // 
            lblGameDetails.Location = new Point(21, 474);
            lblGameDetails.Margin = new Padding(2, 0, 2, 0);
            lblGameDetails.Name = "lblGameDetails";
            lblGameDetails.Size = new Size(259, 22);
            lblGameDetails.TabIndex = 7;
            lblGameDetails.Text = "Selected game details\r\n";
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(21, 15);
            btnLaunch.Margin = new Padding(2);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(68, 37);
            btnLaunch.TabIndex = 8;
            btnLaunch.Text = "Launch!\r\n";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += BtnLaunchClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(210, 28);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(86, 23);
            btnReload.TabIndex = 9;
            btnReload.Text = "Refresh";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReloadClick;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(302, 28);
            btnAbout.Margin = new Padding(2);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(23, 23);
            btnAbout.TabIndex = 10;
            btnAbout.Text = "?";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += BtnAboutClick;
            // 
            // cbFullscreen
            // 
            cbFullscreen.AutoSize = true;
            cbFullscreen.CheckAlign = ContentAlignment.MiddleRight;
            cbFullscreen.Location = new Point(194, 2);
            cbFullscreen.Margin = new Padding(2);
            cbFullscreen.Name = "cbFullscreen";
            cbFullscreen.Size = new Size(119, 19);
            cbFullscreen.TabIndex = 11;
            cbFullscreen.Text = "Launch fullscreen";
            cbFullscreen.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 642);
            Controls.Add(cbFullscreen);
            Controls.Add(btnAbout);
            Controls.Add(btnReload);
            Controls.Add(btnLaunch);
            Controls.Add(lblGameDetails);
            Controls.Add(lblListHeader);
            Controls.Add(lvGameList);
            Controls.Add(tbGameDetails);
            Controls.Add(pbxGameCover);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "CPC Launcher";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColumnHeader columnHeaderName;

        private ColumnHeader columnHeaderDirectory;

        private ColumnHeader columnHeaderExtension;

        private TextBox tbGameDetails;

        private Button btnAbout;

        private Button btnReload;

        private Button btnLaunch;

        private ListView lvGameList;

        private Label lblGameDetails;

        private Label lblListHeader;

        private PictureBox pbxGameCover;

        private CheckBox cbFullscreen;
    }
}
