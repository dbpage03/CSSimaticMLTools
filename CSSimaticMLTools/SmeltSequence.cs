using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSSimaticMLTools
{
	public partial class SmeltSequence : Form
	{
		public string rootPath { get; set; }
		public SmeltSequence()
		{
			InitializeComponent();
		}

		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.ImageIndex = 1;
			e.Node.SelectedImageIndex = 1;
		}

		private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.ImageIndex = 0;
			e.Node.SelectedImageIndex = 0;
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node.FullPath);
		}

		private void SmeltSequence_Load(object sender, EventArgs e)
		{
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
			rootPath = Properties.Settings.Default.FileTreePath;
			while (rootPath == "")
			{
				OpenFolder();
			}
			try
			{
				DirectorySecurity ds = Directory.GetAccessControl(rootPath);
			}
			catch (UnauthorizedAccessException)
			{
				OpenFolder();
			}
			LoadFileTree();

		}
		private void LoadFileTree()
		{
			Cursor = Cursors.WaitCursor;
			rootPath = Properties.Settings.Default.FileTreePath;
			if (rootPath == "")
			{
				DialogResult drFolder = folderBrowserDialog1.ShowDialog();
				if (drFolder == DialogResult.OK)
				{
					rootPath = folderBrowserDialog1.SelectedPath;
					Properties.Settings.Default.FileTreePath = rootPath;
					Properties.Settings.Default.Save();
				}
			}
			
			treeView1.Nodes.Clear();
			if (Directory.Exists(rootPath))
			{
				try
				{
					LoadDirectory(rootPath);
				} catch (UnauthorizedAccessException) 
				{
					OpenFolder();
				}
				
			}
			else 
			{
				MessageBox.Show("Error loading File Tree","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
				Application.Restart();
			}
			Cursor = Cursors.Default;
		}
		private bool OpenFolder()
		{
			DialogResult drFolder = folderBrowserDialog1.ShowDialog();
			if (drFolder == DialogResult.OK)
			{
				try
				{
					DirectorySecurity ds = Directory.GetAccessControl(folderBrowserDialog1.SelectedPath); 
				} 
				catch (UnauthorizedAccessException) 
				{
					OpenFolder();
				}
				rootPath = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.FileTreePath = rootPath;
				Properties.Settings.Default.Save();
				LoadFileTree();
				return true;
			} else return false;
		}
		private void LoadDirectory(string dir)
		{
			DirectoryInfo dirInfo = new DirectoryInfo(dir);
			TreeNode treeNode = treeView1.Nodes.Add(dirInfo.Name);
			progressBar1.Maximum = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(dir, "**", SearchOption.AllDirectories).Length;
			treeNode.Tag = dirInfo.FullName;
			treeNode.ImageIndex = 0;
			treeNode.SelectedImageIndex = 0;
			LoadSubDirectories(dir, treeNode);
			LoadFiles(dir, treeNode);
			progressBar1.Value = 0;
		}
		private void LoadSubDirectories(string dir, TreeNode td)
		{
			// Get all subdirectories
			string[] subdirectoryEntries = Directory.GetDirectories(dir);
			// Loop through them to see if they have any other subdirectories
			foreach (string subdirectory in subdirectoryEntries)
			{
				DirectoryInfo di = new DirectoryInfo(subdirectory);
				TreeNode tds = td.Nodes.Add(di.Name);
				tds.ImageIndex = 0;
				tds.SelectedImageIndex = 0;
				tds.Tag = di.FullName;
				LoadFiles(subdirectory, tds);
				LoadSubDirectories(subdirectory, tds);
				UpdateProgress();
			}
		}
		private void LoadFiles(string dir, TreeNode td)
		{
			string[] Files = Directory.GetFiles(dir, "*.xml");
			// Loop through them to see files
			foreach (string file in Files)
			{
				FileInfo fi = new FileInfo(file);
				TreeNode tds = td.Nodes.Add(fi.Name);
				tds.Tag = fi.FullName;
				if (file.EndsWith(".xml"))
				{
					tds.ImageIndex = 3;
					tds.SelectedImageIndex = 3;
				}
				else
				{
					tds.ImageIndex = 2;
					tds.SelectedImageIndex = 2;
				}
				UpdateProgress();
			}
		}
		private void UpdateProgress()
		{
			if (progressBar1.Value < progressBar1.Maximum)
			{
				progressBar1.Value++;
			}
		}

		private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult drFolder = folderBrowserDialog1.ShowDialog();
			if (drFolder == DialogResult.OK)
			{
				rootPath = folderBrowserDialog1.SelectedPath;
				Properties.Settings.Default.FileTreePath = rootPath;
				Properties.Settings.Default.Save();
				LoadFileTree();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			treeView1.Nodes.Clear();
			Cursor = Cursors.Default;
			Close();
		}

		private void SmeltSequence_FormClosing(object sender, FormClosingEventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			treeView1.Nodes.Clear();
			Cursor = Cursors.Default;
		}

		private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NewApp = !Properties.Settings.Default.NewApp;
			Properties.Settings.Default.Save();
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
		}
	}
}
