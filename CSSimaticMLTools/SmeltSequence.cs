using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSimaticMLTools
{
	public partial class SmeltSequence : Form
	{
		public SmeltSequence()
		{
			InitializeComponent();
		}

		private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			e.Node.ImageIndex = 1;
			e.Node.SelectedImageIndex = 1;
			foreach (TreeNode n in e.Node.Nodes)
			{
				if (n.FullPath.EndsWith(".xml"))
				{
					n.ImageIndex = 2; n.SelectedImageIndex = 2;
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
		}
	}
}
