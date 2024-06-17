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
    }
}
