﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSSimaticMLTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int stepNo = -1;

        private void btnChooseXML_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Tuple<string,string,string> info;
            lblCurrentXML.Text = openFileDialog1.FileName;
            info = Program.GetInfo(openFileDialog1.FileName);
            Program.GetStepNames(openFileDialog1.FileName, dataGridView1, true);
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
                grpTable.Enabled = true;
                tabcScripts.SelectTab(0);
            }
            else
            {
                grpGRAPHScripts.Enabled = false;
                grpTable.Enabled = false;
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
            Program.GetStepNames(openFileDialog1.FileName, dataGridView1);
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
            DialogResult dialogResult = MessageBox.Show("Warning: This script can make dramatic changes to your sequence. \r\nContinue?","Warning",MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Program.InStepReplaceX(openFileDialog1.FileName);
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Program.SNameRDesc(openFileDialog1.FileName, dataGridView1);
        }
        private void btnListPaste_Click(object sender, EventArgs e)
        {
            try
            {
                string s = Clipboard.GetText();

                string[] lines = s.Replace("\n", "").Split('\r');

                dataGridView1.Rows.Add(lines.Length - 1);
                string[] fields;
                int row = 0;
                int col = 0;

                foreach (string item in lines)
                {
                    fields = item.Split('\t');
                    foreach (string f in fields)
                    {
                        Console.WriteLine(f);
                        dataGridView1[col, row].Value = f;
                        col++;
                    }
                    row++;
                    col = 0;
                }
            }
            catch { }
        }

        private void btnListClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnListGet_Click(object sender, EventArgs e)
        {
            Program.GetStepNames(openFileDialog1.FileName, dataGridView1, true);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string nPath = openFileDialog1.FileName.Replace(".xml", "") + "_" + System.DateTime.Now.Month.ToString().PadLeft(2,'0') + DateTime.Now.Day.ToString().PadLeft(2, '0') + DateTime.Now.Year + "_" + System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + DateTime.Now.Minute.ToString().PadLeft(2, '0') + DateTime.Now.Second.ToString().PadLeft(2, '0') + ".xml";
            XDocument xmlDoc = XDocument.Load(openFileDialog1.FileName);
            xmlDoc.Save(nPath);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StepView frmStep = new StepView();
            frmStep.Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int nStepNo = 0;
            if (e.ColumnIndex == 0)
            {
                if (!int.TryParse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString(), out nStepNo)) { nStepNo = -1; }
            }
            if (e.ColumnIndex == 0 && stepNo != -1 && nStepNo != -1 )
            {
                int rNo = Program.RenumberStep(openFileDialog1.FileName, stepNo,nStepNo);
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = rNo;
                if (rNo != nStepNo) { 
                    MessageBox.Show("Failed to Change Step Number","Operation Failed",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                } else 
                { 
                    Program.GetStepNames(openFileDialog1.FileName, dataGridView1); 
                }

            }
            //Needs to set the interface variables too not done yet
            if (e.ColumnIndex == 1) 
            {
                //Program.RenameStep(openFileDialog1.FileName, int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), dataGridView1[e.ColumnIndex,e.RowIndex].Value.ToString());
				//Program.GetStepNames(openFileDialog1.FileName, dataGridView1);
			}
            
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (!int.TryParse(dataGridView1[e.ColumnIndex,e.RowIndex].Value.ToString(),out stepNo)) { stepNo = -1; }
            }
        }

		private void newVersionToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Properties.Settings.Default.NewApp = !newVersionToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
            newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
            Application.Restart();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            if (Properties.Settings.Default.Form1Size.Width == 0)
            {
                Properties.Settings.Default.Form1Size = this.Size;
                Properties.Settings.Default.Save();
            }
			newVersionToolStripMenuItem.Checked = Properties.Settings.Default.NewApp;
            this.Size = Properties.Settings.Default.Form1Size;
		}

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Properties.Settings.Default.Form1Size = this.Size;
            Properties.Settings.Default.Save();
        }

		private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (e.ColumnIndex == dataGridView1["TableDescNo", e.RowIndex].ColumnIndex)
                {
                    DataGridViewCell c = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                    if (!c.Selected)
                    {
                        c.DataGridView.ClearSelection();
                        c.DataGridView.CurrentCell = c;
                        c.Selected = true;
                    }
                    cmsStepTable.Show(dataGridView1, dataGridView1.PointToClient(Cursor.Position));
                }
			}
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
            try
            {
                Console.WriteLine((cmsStepTable.SourceControl as DataGridView).CurrentCell.OwningRow.Cells[0].Value);
                int sNo = int.Parse((cmsStepTable.SourceControl as DataGridView).CurrentCell.OwningRow.Cells[0].Value.ToString());
                //Console.WriteLine(grid.CurrentCell.OwningRow.Cells[0].Value);
                Program.RemoveDesc(openFileDialog1.FileName, sNo);
				Program.GetStepNames(openFileDialog1.FileName, dataGridView1);
			} catch (Exception) { }
		}
	}
}
