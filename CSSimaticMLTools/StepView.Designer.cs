namespace CSSimaticMLTools
{
    partial class StepView
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
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.StepInterlock = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.StepEvent = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.StepQualifier = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.StepAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.MaximumSize = new System.Drawing.Size(50, 20);
			this.label1.MinimumSize = new System.Drawing.Size(35, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "S109";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(48, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(165, 20);
			this.textBox1.TabIndex = 1;
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Text = "notifyIcon1";
			this.notifyIcon1.Visible = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.MinimumSize = new System.Drawing.Size(0, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Description:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(289, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(385, 20);
			this.textBox2.TabIndex = 3;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBox2, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 28);
			this.tableLayoutPanel1.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StepInterlock,
            this.StepEvent,
            this.StepQualifier,
            this.StepAction});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(2, 30);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 25;
			this.dataGridView1.Size = new System.Drawing.Size(677, 277);
			this.dataGridView1.TabIndex = 4;
			// 
			// StepInterlock
			// 
			this.StepInterlock.HeaderText = "Interlock";
			this.StepInterlock.Items.AddRange(new object[] {
            " ",
            "Intlk"});
			this.StepInterlock.MaxDropDownItems = 2;
			this.StepInterlock.MinimumWidth = 20;
			this.StepInterlock.Name = "StepInterlock";
			this.StepInterlock.Width = 50;
			// 
			// StepEvent
			// 
			this.StepEvent.HeaderText = "Event";
			this.StepEvent.Items.AddRange(new object[] {
            "",
            "A1",
            "L0",
            "L1",
            "R1",
            "S0",
            "S1",
            "V0",
            "V1"});
			this.StepEvent.MaxDropDownItems = 9;
			this.StepEvent.MinimumWidth = 20;
			this.StepEvent.Name = "StepEvent";
			this.StepEvent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.StepEvent.Width = 50;
			// 
			// StepQualifier
			// 
			this.StepQualifier.HeaderText = "Qualifier";
			this.StepQualifier.Items.AddRange(new object[] {
            " ",
            "CD",
            "CR",
            "CS",
            "CU",
            "D",
            "L",
            "N",
            "ON",
            "OFF",
            "R",
            "S",
            "TD",
            "TF",
            "TL",
            "TR"});
			this.StepQualifier.MaxDropDownItems = 16;
			this.StepQualifier.MinimumWidth = 20;
			this.StepQualifier.Name = "StepQualifier";
			this.StepQualifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// StepAction
			// 
			this.StepAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.StepAction.HeaderText = "Action";
			this.StepAction.Name = "StepAction";
			// 
			// StepView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(681, 309);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "StepView";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "StepView";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn StepInterlock;
        private System.Windows.Forms.DataGridViewComboBoxColumn StepEvent;
        private System.Windows.Forms.DataGridViewComboBoxColumn StepQualifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn StepAction;
    }
}