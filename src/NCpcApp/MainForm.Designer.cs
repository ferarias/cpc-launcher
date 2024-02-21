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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            lvGameList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderPath = new ColumnHeader();
            lblListHeader = new Label();
            splitContainer2 = new SplitContainer();
            btnReload = new Button();
            tbGameDetails = new TextBox();
            pbxGameCover = new PictureBox();
            pictureBoxMarquee = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxReleaseDate = new TextBox();
            textBoxGenre = new TextBox();
            textBoxPublisher = new TextBox();
            textBoxDeveloper = new TextBox();
            btnLaunch = new Button();
            labelReleaseDate = new Label();
            labelGenre = new Label();
            labelDeveloper = new Label();
            labelPublisher = new Label();
            statusStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMarquee).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(784, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(784, 514);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(784, 561);
            toolStripContainer1.TabIndex = 13;
            toolStripContainer1.Text = "toolStripContainer1";
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
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(784, 514);
            splitContainer1.SplitterDistance = 216;
            splitContainer1.TabIndex = 13;
            // 
            // lvGameList
            // 
            lvGameList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderPath });
            lvGameList.Dock = DockStyle.Fill;
            lvGameList.GridLines = true;
            lvGameList.Location = new Point(0, 0);
            lvGameList.Margin = new Padding(2);
            lvGameList.MultiSelect = false;
            lvGameList.Name = "lvGameList";
            lvGameList.Size = new Size(216, 514);
            lvGameList.TabIndex = 5;
            lvGameList.UseCompatibleStateImageBehavior = false;
            lvGameList.View = View.Details;
            lvGameList.SelectedIndexChanged += LvGameListSelectedIndexChanged;
            lvGameList.DoubleClick += LvGameListDoubleClick;
            lvGameList.KeyDown += LvGameListKeyDown;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 250;
            // 
            // columnHeaderPath
            // 
            columnHeaderPath.Text = "Directory";
            columnHeaderPath.Width = 250;
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
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.FixedPanel = FixedPanel.Panel2;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btnReload);
            splitContainer2.Panel1.Controls.Add(tbGameDetails);
            splitContainer2.Panel1.Controls.Add(pbxGameCover);
            splitContainer2.Panel1.Controls.Add(pictureBoxMarquee);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox1);
            splitContainer2.Size = new Size(564, 514);
            splitContainer2.SplitterDistance = 341;
            splitContainer2.TabIndex = 19;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(3, 469);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(118, 36);
            btnReload.TabIndex = 9;
            btnReload.Text = "Refresh";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReloadClick;
            // 
            // tbGameDetails
            // 
            tbGameDetails.Location = new Point(9, 88);
            tbGameDetails.Multiline = true;
            tbGameDetails.Name = "tbGameDetails";
            tbGameDetails.ReadOnly = true;
            tbGameDetails.ScrollBars = ScrollBars.Vertical;
            tbGameDetails.Size = new Size(314, 129);
            tbGameDetails.TabIndex = 12;
            // 
            // pbxGameCover
            // 
            pbxGameCover.BackColor = Color.Black;
            pbxGameCover.Location = new Point(9, 223);
            pbxGameCover.Name = "pbxGameCover";
            pbxGameCover.Size = new Size(320, 240);
            pbxGameCover.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxGameCover.TabIndex = 0;
            pbxGameCover.TabStop = false;
            // 
            // pictureBoxMarquee
            // 
            pictureBoxMarquee.BackColor = SystemColors.Window;
            pictureBoxMarquee.Dock = DockStyle.Top;
            pictureBoxMarquee.Location = new Point(0, 0);
            pictureBoxMarquee.Name = "pictureBoxMarquee";
            pictureBoxMarquee.Size = new Size(341, 82);
            pictureBoxMarquee.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMarquee.TabIndex = 13;
            pictureBoxMarquee.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxReleaseDate);
            groupBox1.Controls.Add(textBoxGenre);
            groupBox1.Controls.Add(textBoxPublisher);
            groupBox1.Controls.Add(textBoxDeveloper);
            groupBox1.Controls.Add(btnLaunch);
            groupBox1.Controls.Add(labelReleaseDate);
            groupBox1.Controls.Add(labelGenre);
            groupBox1.Controls.Add(labelDeveloper);
            groupBox1.Controls.Add(labelPublisher);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(219, 514);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // textBoxReleaseDate
            // 
            textBoxReleaseDate.BorderStyle = BorderStyle.None;
            textBoxReleaseDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxReleaseDate.Location = new Point(16, 111);
            textBoxReleaseDate.Name = "textBoxReleaseDate";
            textBoxReleaseDate.ReadOnly = true;
            textBoxReleaseDate.Size = new Size(65, 16);
            textBoxReleaseDate.TabIndex = 21;
            textBoxReleaseDate.Text = "1982";
            // 
            // textBoxGenre
            // 
            textBoxGenre.BorderStyle = BorderStyle.None;
            textBoxGenre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxGenre.Location = new Point(16, 148);
            textBoxGenre.Multiline = true;
            textBoxGenre.Name = "textBoxGenre";
            textBoxGenre.ReadOnly = true;
            textBoxGenre.Size = new Size(127, 200);
            textBoxGenre.TabIndex = 20;
            textBoxGenre.Text = "Genre 1\r\nGenre 2\r\nGenre 3";
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.BorderStyle = BorderStyle.None;
            textBoxPublisher.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPublisher.Location = new Point(16, 74);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.ReadOnly = true;
            textBoxPublisher.Size = new Size(241, 16);
            textBoxPublisher.TabIndex = 19;
            textBoxPublisher.Text = "Erbe";
            // 
            // textBoxDeveloper
            // 
            textBoxDeveloper.BorderStyle = BorderStyle.None;
            textBoxDeveloper.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxDeveloper.Location = new Point(16, 37);
            textBoxDeveloper.Name = "textBoxDeveloper";
            textBoxDeveloper.ReadOnly = true;
            textBoxDeveloper.Size = new Size(241, 16);
            textBoxDeveloper.TabIndex = 18;
            textBoxDeveloper.Text = "Durell";
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(15, 468);
            btnLaunch.Margin = new Padding(2);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(131, 37);
            btnLaunch.TabIndex = 8;
            btnLaunch.Text = "Launch!\r\n";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += BtnLaunchClick;
            // 
            // labelReleaseDate
            // 
            labelReleaseDate.AutoSize = true;
            labelReleaseDate.Location = new Point(10, 93);
            labelReleaseDate.Name = "labelReleaseDate";
            labelReleaseDate.Size = new Size(71, 15);
            labelReleaseDate.TabIndex = 14;
            labelReleaseDate.Text = "Release Year";
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(10, 130);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(43, 15);
            labelGenre.TabIndex = 17;
            labelGenre.Text = "Genres";
            // 
            // labelDeveloper
            // 
            labelDeveloper.AutoSize = true;
            labelDeveloper.Location = new Point(10, 19);
            labelDeveloper.Name = "labelDeveloper";
            labelDeveloper.Size = new Size(60, 15);
            labelDeveloper.TabIndex = 15;
            labelDeveloper.Text = "Developer";
            // 
            // labelPublisher
            // 
            labelPublisher.AutoSize = true;
            labelPublisher.Location = new Point(10, 56);
            labelPublisher.Name = "labelPublisher";
            labelPublisher.Size = new Size(56, 15);
            labelPublisher.TabIndex = 16;
            labelPublisher.Text = "Publisher";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(toolStripContainer1);
            Margin = new Padding(2);
            Name = "MainForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "CPC Launcher";
            Load += MainForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMarquee).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
