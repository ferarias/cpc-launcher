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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvGameList = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblListHeader = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnReload = new System.Windows.Forms.Button();
            this.tbGameDetails = new System.Windows.Forms.TextBox();
            this.pbxGameCover = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarquee = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.textBoxDeveloper = new System.Windows.Forms.TextBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.labelReleaseDate = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarquee)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(672, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(672, 442);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(672, 486);
            this.toolStripContainer1.TabIndex = 13;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvGameList);
            this.splitContainer1.Panel1.Controls.Add(this.lblListHeader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(672, 442);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 13;
            // 
            // lvGameList
            // 
            this.lvGameList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderPath});
            this.lvGameList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvGameList.GridLines = true;
            this.lvGameList.HideSelection = false;
            this.lvGameList.Location = new System.Drawing.Point(0, 0);
            this.lvGameList.Margin = new System.Windows.Forms.Padding(2);
            this.lvGameList.MultiSelect = false;
            this.lvGameList.Name = "lvGameList";
            this.lvGameList.Size = new System.Drawing.Size(203, 442);
            this.lvGameList.TabIndex = 5;
            this.lvGameList.UseCompatibleStateImageBehavior = false;
            this.lvGameList.View = System.Windows.Forms.View.Details;
            this.lvGameList.SelectedIndexChanged += LvGameListSelectedIndexChanged;
            this.lvGameList.DoubleClick += LvGameListDoubleClick;
            this.lvGameList.KeyDown += LvGameListKeyDown;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Name";
            this.columnHeaderName.Width = 250;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Directory";
            this.columnHeaderPath.Width = 250;
            // 
            // lblListHeader
            // 
            this.lblListHeader.Location = new System.Drawing.Point(9, 0);
            this.lblListHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblListHeader.Name = "lblListHeader";
            this.lblListHeader.Size = new System.Drawing.Size(182, 19);
            this.lblListHeader.TabIndex = 6;
            this.lblListHeader.Text = "List of games";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnReload);
            this.splitContainer2.Panel1.Controls.Add(this.tbGameDetails);
            this.splitContainer2.Panel1.Controls.Add(this.pbxGameCover);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBoxMarquee);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Size = new System.Drawing.Size(466, 442);
            this.splitContainer2.SplitterDistance = 294;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 19;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(3, 406);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(101, 31);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Refresh";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += BtnReloadClick;
            // 
            // tbGameDetails
            // 
            this.tbGameDetails.Location = new System.Drawing.Point(8, 76);
            this.tbGameDetails.Multiline = true;
            this.tbGameDetails.Name = "tbGameDetails";
            this.tbGameDetails.ReadOnly = true;
            this.tbGameDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGameDetails.Size = new System.Drawing.Size(270, 112);
            this.tbGameDetails.TabIndex = 12;
            // 
            // pbxGameCover
            // 
            this.pbxGameCover.BackColor = System.Drawing.Color.Black;
            this.pbxGameCover.Location = new System.Drawing.Point(8, 193);
            this.pbxGameCover.Name = "pbxGameCover";
            this.pbxGameCover.Size = new System.Drawing.Size(274, 208);
            this.pbxGameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGameCover.TabIndex = 0;
            this.pbxGameCover.TabStop = false;
            // 
            // pictureBoxMarquee
            // 
            this.pictureBoxMarquee.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxMarquee.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxMarquee.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMarquee.Name = "pictureBoxMarquee";
            this.pictureBoxMarquee.Size = new System.Drawing.Size(294, 71);
            this.pictureBoxMarquee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMarquee.TabIndex = 13;
            this.pictureBoxMarquee.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReleaseDate);
            this.groupBox1.Controls.Add(this.textBoxGenre);
            this.groupBox1.Controls.Add(this.textBoxPublisher);
            this.groupBox1.Controls.Add(this.textBoxDeveloper);
            this.groupBox1.Controls.Add(this.btnLaunch);
            this.groupBox1.Controls.Add(this.labelReleaseDate);
            this.groupBox1.Controls.Add(this.labelGenre);
            this.groupBox1.Controls.Add(this.labelDeveloper);
            this.groupBox1.Controls.Add(this.labelPublisher);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 442);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxReleaseDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReleaseDate.Location = new System.Drawing.Point(14, 96);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.ReadOnly = true;
            this.textBoxReleaseDate.Size = new System.Drawing.Size(56, 16);
            this.textBoxReleaseDate.TabIndex = 21;
            this.textBoxReleaseDate.Text = "1982";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGenre.Location = new System.Drawing.Point(14, 128);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.ReadOnly = true;
            this.textBoxGenre.Size = new System.Drawing.Size(109, 173);
            this.textBoxGenre.TabIndex = 20;
            this.textBoxGenre.Text = "Genre 1\r\nGenre 2\r\nGenre 3";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPublisher.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisher.Location = new System.Drawing.Point(14, 64);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.ReadOnly = true;
            this.textBoxPublisher.Size = new System.Drawing.Size(207, 16);
            this.textBoxPublisher.TabIndex = 19;
            this.textBoxPublisher.Text = "Erbe";
            // 
            // textBoxDeveloper
            // 
            this.textBoxDeveloper.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDeveloper.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeveloper.Location = new System.Drawing.Point(14, 32);
            this.textBoxDeveloper.Name = "textBoxDeveloper";
            this.textBoxDeveloper.ReadOnly = true;
            this.textBoxDeveloper.Size = new System.Drawing.Size(207, 16);
            this.textBoxDeveloper.TabIndex = 18;
            this.textBoxDeveloper.Text = "Durell";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(13, 406);
            this.btnLaunch.Margin = new System.Windows.Forms.Padding(2);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(112, 32);
            this.btnLaunch.TabIndex = 8;
            this.btnLaunch.Text = "Launch!\r\n";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += BtnLaunchClick;
            // 
            // labelReleaseDate
            // 
            this.labelReleaseDate.AutoSize = true;
            this.labelReleaseDate.Location = new System.Drawing.Point(9, 81);
            this.labelReleaseDate.Name = "labelReleaseDate";
            this.labelReleaseDate.Size = new System.Drawing.Size(71, 13);
            this.labelReleaseDate.TabIndex = 14;
            this.labelReleaseDate.Text = "Release Year";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(9, 113);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(41, 13);
            this.labelGenre.TabIndex = 17;
            this.labelGenre.Text = "Genres";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(9, 16);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(56, 13);
            this.labelDeveloper.TabIndex = 15;
            this.labelDeveloper.Text = "Developer";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(9, 49);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(50, 13);
            this.labelPublisher.TabIndex = 16;
            this.labelPublisher.Text = "Publisher";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 486);
            this.Controls.Add(this.toolStripContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CPC Launcher";
            this.Load += MainForm_Load;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarquee)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripContainer toolStripContainer1;
        private SplitContainer splitContainer1;
        private ListView lvGameList;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderPath;
        private Label lblListHeader;
        private TextBox tbGameDetails;
        private PictureBox pbxGameCover;
        private Button btnLaunch;
        private Button btnReload;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private PictureBox pictureBoxMarquee;
        private Label labelReleaseDate;
        private Label labelPublisher;
        private Label labelDeveloper;
        private Label labelGenre;
        private GroupBox groupBox1;
        private TextBox textBoxPublisher;
        private TextBox textBoxDeveloper;
        private TextBox textBoxReleaseDate;
        private TextBox textBoxGenre;
        private SplitContainer splitContainer2;
    }
}
