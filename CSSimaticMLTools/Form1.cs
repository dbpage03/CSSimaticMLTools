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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Tuple<string,string,string> info;
            lblCurrentXML.Text = openFileDialog1.FileName;
            info = Program.GetInfo(openFileDialog1.FileName);
            lblType.Text = info.Item1;
            lblName.Text = info.Item2;
            lblNumber.Text = info.Item3;
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frmAbout = new About();
            frmAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblType_TextChanged(object sender, EventArgs e)
        {
            if (lblType.Text == "GRAPH")
            {
                grpGRAPHScripts.Enabled = true;
                tabcScripts.SelectTab(0);
            }
            else
            {
                grpGRAPHScripts.Enabled = false;
            }
        }

        private void lblNumber_TextChanged(object sender, EventArgs e)
        {
            if (lblNumber.Text.Contains("FC"))
            {
                grpFCScripts.Enabled = true;
                tabcScripts.SelectTab(1);
            }
            else
            {
                grpFCScripts.Enabled = false;
            }
        }

        private void btnScptSeq1_Click(object sender, EventArgs e)
        {
            Program.StepNtoDescCtrl(openFileDialog1.FileName);
        }
        private void btnScptSeq1Help_Click(object sender, EventArgs e)
        {
            ScriptHelp frmHelp = new ScriptHelp();
            frmHelp.lblText.Text = "This script takes the Step numbers of a sequence and writes them to the #DescriptorControl.\nThe DescriptorControl Action must be present already.";
            frmHelp.picPicture1.Image = Properties.Resources.StepNotoDescCtrl;
            frmHelp.Show(this);
        }
        private void btnScptSeq2_Click(object sender, EventArgs e)
        {
            Program.SeqToDescTXT(openFileDialog1.FileName);
        }
        private void btnScptSeq2Help_Click(object sender, EventArgs e)
        {
            ScriptHelp frmHelp = new ScriptHelp();
            frmHelp.lblText.Text = "This script takes the #DescriptorControl number and \"Step Description\" of each step in a sequence and creates a .txt file that can be imported into WinCC Text Lists.";
            frmHelp.picPicture1.Image = Properties.Resources.DesctoTXT;
            frmHelp.Show(this);
        }
        private void btnScptSeq3_Click(object sender, EventArgs e)
        {
            Program.RewriteSteps(openFileDialog1.FileName);
        }
    }
}
