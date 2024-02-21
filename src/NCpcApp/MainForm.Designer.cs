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
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStripContainer1 = new ToolStripContainer();
            splitContainer1 = new SplitContainer();
            lvGameList = new ListView();
            columnHeaderName = new ColumnHeader();
            columnHeaderPath = new ColumnHeader();
            columnHeaderType = new ColumnHeader();
            lblListHeader = new Label();
            tbGameDetails = new TextBox();
            lblGameDetails = new Label();
            pbxGameCover = new PictureBox();
            btnLaunch = new Button();
            btnReload = new Button();
            statusStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1265, 22);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
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
            toolStripContainer1.ContentPanel.Size = new Size(1265, 595);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1265, 642);
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
            splitContainer1.Panel2.Controls.Add(tbGameDetails);
            splitContainer1.Panel2.Controls.Add(lblGameDetails);
            splitContainer1.Panel2.Controls.Add(pbxGameCover);
            splitContainer1.Panel2.Controls.Add(btnLaunch);
            splitContainer1.Panel2.Controls.Add(btnReload);
            splitContainer1.Size = new Size(1265, 595);
            splitContainer1.SplitterDistance = 600;
            splitContainer1.TabIndex = 13;
            // 
            // lvGameList
            // 
            lvGameList.Columns.AddRange(new ColumnHeader[] { columnHeaderName, columnHeaderPath, columnHeaderType });
            lvGameList.Dock = DockStyle.Fill;
            lvGameList.GridLines = true;
            lvGameList.Location = new Point(0, 0);
            lvGameList.Margin = new Padding(2);
            lvGameList.MultiSelect = false;
            lvGameList.Name = "lvGameList";
            lvGameList.Size = new Size(600, 595);
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
            // columnHeaderPath
            // 
            columnHeaderPath.Text = "Directory";
            columnHeaderPath.Width = 250;
            // 
            // columnHeaderType
            // 
            columnHeaderType.Text = "Extension";
            columnHeaderType.Width = 64;
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
            // tbGameDetails
            // 
            tbGameDetails.Location = new Point(14, 27);
            tbGameDetails.Multiline = true;
            tbGameDetails.Name = "tbGameDetails";
            tbGameDetails.Size = new Size(516, 110);
            tbGameDetails.TabIndex = 12;
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
            // pbxGameCover
            // 
            pbxGameCover.BackColor = Color.Black;
            pbxGameCover.Location = new Point(14, 150);
            pbxGameCover.Name = "pbxGameCover";
            pbxGameCover.Size = new Size(640, 480);
            pbxGameCover.TabIndex = 0;
            pbxGameCover.TabStop = false;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(568, 12);
            btnLaunch.Margin = new Padding(2);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(86, 37);
            btnLaunch.TabIndex = 8;
            btnLaunch.Text = "Launch!\r\n";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += BtnLaunchClick;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(568, 114);
            btnReload.Margin = new Padding(2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(86, 23);
            btnReload.TabIndex = 9;
            btnReload.Text = "Refresh";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += BtnReloadClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 642);
            Controls.Add(toolStripContainer1);
            Margin = new Padding(2);
            Name = "MainForm";
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
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxGameCover).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private StatusStrip statusStrip1;
        private ToolStripContainer toolStripContainer1;
        private SplitContainer splitContainer1;
        private ListView lvGameList;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderPath;
        private ColumnHeader columnHeaderType;
        private Label lblListHeader;
        private TextBox tbGameDetails;
        private Label lblGameDetails;
        private PictureBox pbxGameCover;
        private Button btnLaunch;
        private Button btnReload;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}
