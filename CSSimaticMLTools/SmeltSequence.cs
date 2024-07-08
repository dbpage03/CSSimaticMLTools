using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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
		private void SmeltSequence_FormClosing(object sender, FormClosingEventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			treeView1.Nodes.Clear();
			Cursor = Cursors.Default;
		}

		#region TreeView
		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.ImageIndex = 1;
			e.Node.SelectedImageIndex = 1;
			foreach (TreeNode node in e.Node.Nodes)
			{
				if (node.Text.EndsWith(".xml"))
				{
					Tuple<string, string, string> info = Program.GetInfo(node.Tag as string);
					Console.WriteLine(info.ToString());
					if (info.Item1 == "GRAPH")
					{
						node.ImageIndex = 3;
						node.SelectedImageIndex = 3;
					} else if (info.Item3.StartsWith("FB"))
					{
						node.ImageIndex = 6;
						node.SelectedImageIndex = 6;
					}
					else if (info.Item3.StartsWith("FC"))
					{
						node.ImageIndex = 7;
						node.SelectedImageIndex = 7;
					}
					else if (info.Item3.StartsWith("OB"))
					{
						node.ImageIndex = 5;
						node.SelectedImageIndex = 5;
					}
					else if (info.Item3.StartsWith("DB"))
					{
						node.ImageIndex = 8;
						node.SelectedImageIndex = 8;
					}
					else
					{
						node.ImageIndex = 4;
						node.SelectedImageIndex = 4;
					}
					
				}

			}
		}

		private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.ImageIndex = 0;
			e.Node.SelectedImageIndex = 0;
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(e.Node.FullPath);
			lblStatusPath.Text = e.Node.Tag as string;
		}

		#endregion
		#region LoadTreeView

		private void SmeltSequence_Load(object sender, EventArgs e)
		{
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
			rootPath = Properties.Settings.Default.FileTreePath;
			tbcSeqView.SelectedIndex = 1;
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
			treeNode.Tag = dirInfo.FullName;
			treeNode.ImageIndex = 0;
			treeNode.SelectedImageIndex = 0;
			treeNode.ToolTipText = dirInfo.FullName;
			LoadSubDirectories(dir, treeNode);
			LoadFiles(dir, treeNode);
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
				tds.ToolTipText = di.FullName;
				LoadFiles(subdirectory, tds);
				LoadSubDirectories(subdirectory, tds);
			}
		}
		private void LoadFiles(string dir, TreeNode td)
		{
			string[] Files = Directory.GetFiles(dir, "*.*");
			// Loop through them to see files
			foreach (string file in Files)
			{
				FileInfo fi = new FileInfo(file);
				TreeNode tds = td.Nodes.Add(fi.Name);
				tds.Tag = fi.FullName;
				tds.ToolTipText = fi.FullName;
			}
		}
		#endregion
		#region ToolStrip
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

		private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NewApp = !Properties.Settings.Default.NewApp;
			Properties.Settings.Default.Save();
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
		}

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			openFolderToolStripMenuItem_Click(sender,e);
		}
		#endregion

		private void treeView1_MouseDown(object sender, MouseEventArgs e)
		{

		}
	}
}
