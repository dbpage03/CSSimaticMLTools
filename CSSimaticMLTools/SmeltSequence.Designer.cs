namespace CSSimaticMLTools
{
	partial class SmeltSequence
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("oijfd.xml");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node7");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3});
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node4");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmeltSequence));
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "123",
            "AFHSD",
            "123",
            "SDF SDFGH "}, -1);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imlFileTree = new System.Windows.Forms.ImageList(this.components);
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblStatusPath = new System.Windows.Forms.ToolStripStatusLabel();
			this.lstSteps = new System.Windows.Forms.ListView();
			this.tbcSeqView = new System.Windows.Forms.TabControl();
			this.tbpList = new System.Windows.Forms.TabPage();
			this.tbpGraph = new System.Windows.Forms.TabPage();
			this.colStepNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDescNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colDescText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tbcSeqView.SuspendLayout();
			this.tbpList.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(925, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openFolderToolStripMenuItem
			// 
			this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
			this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.openFolderToolStripMenuItem.Text = "Open Folder";
			this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.openFolderToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.exportToolStripMenuItem.Text = "Export to WinCC";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVersionToolStripMenuItem});
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// newVersionToolStripMenuItem
			// 
			this.newVersionToolStripMenuItem.Name = "newVersionToolStripMenuItem";
			this.newVersionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.newVersionToolStripMenuItem.Text = "New Version";
			this.newVersionToolStripMenuItem.Click += new System.EventHandler(this.newVersionToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 0;
			this.treeView1.ImageList = this.imlFileTree;
			this.treeView1.Indent = 10;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node5";
			treeNode1.Text = "oijfd.xml";
			treeNode2.Name = "Node7";
			treeNode2.Text = "Node7";
			treeNode3.Name = "Node6";
			treeNode3.Text = "Node6";
			treeNode4.Name = "Node2";
			treeNode4.Text = "Node2";
			treeNode5.Name = "Node4";
			treeNode5.Text = "Node4";
			treeNode6.ImageKey = "closedFolder.ico";
			treeNode6.Name = "NodeRoot";
			treeNode6.SelectedImageKey = "openFolder.ico";
			treeNode6.Text = "Root";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
			this.treeView1.PathSeparator = "\\\\";
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(304, 470);
			this.treeView1.TabIndex = 1;
			this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
			this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeExpand);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// imlFileTree
			// 
			this.imlFileTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFileTree.ImageStream")));
			this.imlFileTree.TransparentColor = System.Drawing.Color.Transparent;
			this.imlFileTree.Images.SetKeyName(0, "closedFolder.ico");
			this.imlFileTree.Images.SetKeyName(1, "openFolder.ico");
			this.imlFileTree.Images.SetKeyName(2, "defaultFile.ico");
			this.imlFileTree.Images.SetKeyName(3, "seqFile.ico");
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusPath});
			this.statusStrip1.Location = new System.Drawing.Point(0, 498);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(925, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tbcSeqView);
			this.splitContainer1.Size = new System.Drawing.Size(925, 474);
			this.splitContainer1.SplitterDistance = 308;
			this.splitContainer1.TabIndex = 3;
			// 
			// lblStatusPath
			// 
			this.lblStatusPath.AutoToolTip = true;
			this.lblStatusPath.Name = "lblStatusPath";
			this.lblStatusPath.Size = new System.Drawing.Size(23, 17);
			this.lblStatusPath.Text = "C:\\";
			// 
			// lstSteps
			// 
			this.lstSteps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStepNo,
            this.colName,
            this.colDescNo,
            this.colDescText});
			this.lstSteps.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstSteps.FullRowSelect = true;
			this.lstSteps.GridLines = true;
			this.lstSteps.HideSelection = false;
			this.lstSteps.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.lstSteps.LabelEdit = true;
			this.lstSteps.Location = new System.Drawing.Point(3, 3);
			this.lstSteps.MultiSelect = false;
			this.lstSteps.Name = "lstSteps";
			this.lstSteps.ShowGroups = false;
			this.lstSteps.Size = new System.Drawing.Size(595, 438);
			this.lstSteps.TabIndex = 0;
			this.lstSteps.UseCompatibleStateImageBehavior = false;
			this.lstSteps.View = System.Windows.Forms.View.Details;
			// 
			// tbcSeqView
			// 
			this.tbcSeqView.Controls.Add(this.tbpGraph);
			this.tbcSeqView.Controls.Add(this.tbpList);
			this.tbcSeqView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbcSeqView.Location = new System.Drawing.Point(0, 0);
			this.tbcSeqView.Multiline = true;
			this.tbcSeqView.Name = "tbcSeqView";
			this.tbcSeqView.SelectedIndex = 0;
			this.tbcSeqView.Size = new System.Drawing.Size(609, 470);
			this.tbcSeqView.TabIndex = 1;
			// 
			// tbpList
			// 
			this.tbpList.Controls.Add(this.lstSteps);
			this.tbpList.Location = new System.Drawing.Point(4, 22);
			this.tbpList.Name = "tbpList";
			this.tbpList.Padding = new System.Windows.Forms.Padding(3);
			this.tbpList.Size = new System.Drawing.Size(601, 444);
			this.tbpList.TabIndex = 0;
			this.tbpList.Text = "List View";
			this.tbpList.UseVisualStyleBackColor = true;
			// 
			// tbpGraph
			// 
			this.tbpGraph.Location = new System.Drawing.Point(4, 22);
			this.tbpGraph.Name = "tbpGraph";
			this.tbpGraph.Padding = new System.Windows.Forms.Padding(3);
			this.tbpGraph.Size = new System.Drawing.Size(520, 373);
			this.tbpGraph.TabIndex = 1;
			this.tbpGraph.Text = "Graph View";
			this.tbpGraph.UseVisualStyleBackColor = true;
			// 
			// colStepNo
			// 
			this.colStepNo.Text = "Step #";
			this.colStepNo.Width = 50;
			// 
			// colName
			// 
			this.colName.Text = "Name";
			this.colName.Width = 192;
			// 
			// colDescNo
			// 
			this.colDescNo.Text = "Desc #";
			this.colDescNo.Width = 50;
			// 
			// colDescText
			// 
			this.colDescText.Text = "Description";
			this.colDescText.Width = 294;
			// 
			// SmeltSequence
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 520);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "SmeltSequence";
			this.Text = "SmeltSequence";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmeltSequence_FormClosing);
			this.Load += new System.EventHandler(this.SmeltSequence_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tbcSeqView.ResumeLayout(false);
			this.tbpList.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imlFileTree;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripMenuItem newVersionToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel lblStatusPath;
		private System.Windows.Forms.ListView lstSteps;
		private System.Windows.Forms.TabControl tbcSeqView;
		private System.Windows.Forms.TabPage tbpList;
		private System.Windows.Forms.TabPage tbpGraph;
		private System.Windows.Forms.ColumnHeader colStepNo;
		private System.Windows.Forms.ColumnHeader colName;
		private System.Windows.Forms.ColumnHeader colDescNo;
		private System.Windows.Forms.ColumnHeader colDescText;
	}
}