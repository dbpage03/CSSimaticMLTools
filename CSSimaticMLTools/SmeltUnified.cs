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
    public partial class SmeltUnified : Form
    {
        public SmeltUnified()
        {
            InitializeComponent();
        }

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Close();
		}

		private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.NewApp = !newVersionToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
			Application.Restart();
		}

		private void SmeltUnified_Load(object sender, EventArgs e)
		{
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
		}
	}
}
