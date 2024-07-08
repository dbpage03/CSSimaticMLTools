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
	public partial class UserControl1 : UserControl
	{
		private TextBox textBox1;
		public UserControl1()
		{
			Console.WriteLine("HeHe");
			InitializeComponent();
			textBox1 = new TextBox
			{
				Visible = false,
				Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right))),
				BackColor = label1.BackColor,
				Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
				Location = new System.Drawing.Point(0, 0),
				MaxLength = 3,
				Name = "textBox1",
				Size = new System.Drawing.Size(150, 20),
				TabIndex = 0,
				Text = "Step 1234",
				TextAlign = System.Windows.Forms.HorizontalAlignment.Center,
				BorderStyle = BorderStyle.None,

			};
			Controls.Add(textBox1);
			textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);

		}
		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				label1.Text = "Step " + textBox1.Text;
				label1.Visible = true;
				textBox1.Visible = false;
				e.Handled = true;
				e.SuppressKeyPress = true;
			} else if (e.KeyCode == Keys.Escape)
			{
				label1.Visible = true;
				textBox1.Visible = false;
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void UserControl1_Paint(object sender, PaintEventArgs e)
		{
			Rectangle borderRectangle = this.ClientRectangle;
			ControlPaint.DrawBorder3D(e.Graphics, borderRectangle, Border3DStyle.Raised);
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			Console.WriteLine("Yep");
			textBox1.Text = label1.Text.Substring(5);
			textBox1.Visible = true;
			label1.Visible = false;
			textBox1.Focus();
			textBox1.SelectAll();
			
		}
	}
}
