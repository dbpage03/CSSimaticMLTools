namespace CSSimaticMLTools
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseXML = new System.Windows.Forms.Button();
            this.lblCurrentXML = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnScptSeq1 = new System.Windows.Forms.Button();
            this.tabcScripts = new System.Windows.Forms.TabControl();
            this.tabSeq = new System.Windows.Forms.TabPage();
            this.grpGRAPHScripts = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScptSeq3 = new System.Windows.Forms.Button();
            this.btnScptSeq2Help = new System.Windows.Forms.Button();
            this.btnScptSeq1Help = new System.Windows.Forms.Button();
            this.btnScptSeq2 = new System.Windows.Forms.Button();
            this.tabFunction = new System.Windows.Forms.TabPage();
            this.grpFCScripts = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabcScripts.SuspendLayout();
            this.tabSeq.SuspendLayout();
            this.grpGRAPHScripts.SuspendLayout();
            this.tabFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "SimaticML|*.xml";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnChooseXML
            // 
            this.btnChooseXML.Location = new System.Drawing.Point(522, 22);
            this.btnChooseXML.Name = "btnChooseXML";
            this.btnChooseXML.Size = new System.Drawing.Size(90, 27);
            this.btnChooseXML.TabIndex = 0;
            this.btnChooseXML.Text = "Choose File...";
            this.btnChooseXML.UseVisualStyleBackColor = true;
            this.btnChooseXML.Click += new System.EventHandler(this.btnChooseXML_Click);
            // 
            // lblCurrentXML
            // 
            this.lblCurrentXML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentXML.Location = new System.Drawing.Point(78, 24);
            this.lblCurrentXML.Name = "lblCurrentXML";
            this.lblCurrentXML.Size = new System.Drawing.Size(438, 23);
            this.lblCurrentXML.TabIndex = 1;
            this.lblCurrentXML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Type: ";
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Location = new System.Drawing.Point(78, 76);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(129, 18);
            this.lblType.TabIndex = 5;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblType.TextChanged += new System.EventHandler(this.lblType_TextChanged);
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(78, 100);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 18);
            this.lblName.TabIndex = 7;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name: ";
            // 
            // lblNumber
            // 
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(78, 124);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(129, 18);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumber.TextChanged += new System.EventHandler(this.lblNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number: ";
            // 
            // btnScptSeq1
            // 
            this.btnScptSeq1.Location = new System.Drawing.Point(6, 19);
            this.btnScptSeq1.Name = "btnScptSeq1";
            this.btnScptSeq1.Size = new System.Drawing.Size(161, 23);
            this.btnScptSeq1.TabIndex = 10;
            this.btnScptSeq1.Text = "Step # to DescriptorControl";
            this.btnScptSeq1.UseVisualStyleBackColor = true;
            this.btnScptSeq1.Click += new System.EventHandler(this.btnScptSeq1_Click);
            // 
            // tabcScripts
            // 
            this.tabcScripts.Controls.Add(this.tabSeq);
            this.tabcScripts.Controls.Add(this.tabFunction);
            this.tabcScripts.Location = new System.Drawing.Point(213, 76);
            this.tabcScripts.Name = "tabcScripts";
            this.tabcScripts.SelectedIndex = 0;
            this.tabcScripts.Size = new System.Drawing.Size(220, 214);
            this.tabcScripts.TabIndex = 11;
            // 
            // tabSeq
            // 
            this.tabSeq.Controls.Add(this.grpGRAPHScripts);
            this.tabSeq.Location = new System.Drawing.Point(4, 22);
            this.tabSeq.Name = "tabSeq";
            this.tabSeq.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeq.Size = new System.Drawing.Size(212, 188);
            this.tabSeq.TabIndex = 0;
            this.tabSeq.Text = "Sequence";
            this.tabSeq.UseVisualStyleBackColor = true;
            // 
            // grpGRAPHScripts
            // 
            this.grpGRAPHScripts.Controls.Add(this.button1);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq3);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq2Help);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq1Help);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq2);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq1);
            this.grpGRAPHScripts.Enabled = false;
            this.grpGRAPHScripts.Location = new System.Drawing.Point(6, 6);
            this.grpGRAPHScripts.Name = "grpGRAPHScripts";
            this.grpGRAPHScripts.Size = new System.Drawing.Size(200, 147);
            this.grpGRAPHScripts.TabIndex = 12;
            this.grpGRAPHScripts.TabStop = false;
            this.grpGRAPHScripts.Text = "Scripts";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(173, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 22);
            this.button1.TabIndex = 15;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // btnScptSeq3
            // 
            this.btnScptSeq3.Location = new System.Drawing.Point(6, 77);
            this.btnScptSeq3.Name = "btnScptSeq3";
            this.btnScptSeq3.Size = new System.Drawing.Size(161, 23);
            this.btnScptSeq3.TabIndex = 14;
            this.btnScptSeq3.Text = "Rewrite Step #";
            this.btnScptSeq3.UseVisualStyleBackColor = true;
            this.btnScptSeq3.Visible = false;
            this.btnScptSeq3.Click += new System.EventHandler(this.btnScptSeq3_Click);
            // 
            // btnScptSeq2Help
            // 
            this.btnScptSeq2Help.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnScptSeq2Help.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnScptSeq2Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScptSeq2Help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScptSeq2Help.Location = new System.Drawing.Point(173, 49);
            this.btnScptSeq2Help.Name = "btnScptSeq2Help";
            this.btnScptSeq2Help.Size = new System.Drawing.Size(21, 22);
            this.btnScptSeq2Help.TabIndex = 13;
            this.btnScptSeq2Help.Text = "?";
            this.btnScptSeq2Help.UseVisualStyleBackColor = false;
            this.btnScptSeq2Help.Click += new System.EventHandler(this.btnScptSeq2Help_Click);
            // 
            // btnScptSeq1Help
            // 
            this.btnScptSeq1Help.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnScptSeq1Help.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnScptSeq1Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScptSeq1Help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScptSeq1Help.Location = new System.Drawing.Point(173, 20);
            this.btnScptSeq1Help.Name = "btnScptSeq1Help";
            this.btnScptSeq1Help.Size = new System.Drawing.Size(21, 22);
            this.btnScptSeq1Help.TabIndex = 12;
            this.btnScptSeq1Help.Text = "?";
            this.btnScptSeq1Help.UseVisualStyleBackColor = false;
            this.btnScptSeq1Help.Click += new System.EventHandler(this.btnScptSeq1Help_Click);
            // 
            // btnScptSeq2
            // 
            this.btnScptSeq2.Location = new System.Drawing.Point(6, 48);
            this.btnScptSeq2.Name = "btnScptSeq2";
            this.btnScptSeq2.Size = new System.Drawing.Size(161, 23);
            this.btnScptSeq2.TabIndex = 11;
            this.btnScptSeq2.Text = "Generate Descriptor Text List";
            this.btnScptSeq2.UseVisualStyleBackColor = true;
            this.btnScptSeq2.Click += new System.EventHandler(this.btnScptSeq2_Click);
            // 
            // tabFunction
            // 
            this.tabFunction.Controls.Add(this.grpFCScripts);
            this.tabFunction.Location = new System.Drawing.Point(4, 22);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.Padding = new System.Windows.Forms.Padding(3);
            this.tabFunction.Size = new System.Drawing.Size(212, 188);
            this.tabFunction.TabIndex = 1;
            this.tabFunction.Text = "Function";
            this.tabFunction.UseVisualStyleBackColor = true;
            // 
            // grpFCScripts
            // 
            this.grpFCScripts.Enabled = false;
            this.grpFCScripts.Location = new System.Drawing.Point(6, 6);
            this.grpFCScripts.Name = "grpFCScripts";
            this.grpFCScripts.Size = new System.Drawing.Size(200, 147);
            this.grpFCScripts.TabIndex = 13;
            this.grpFCScripts.TabStop = false;
            this.grpFCScripts.Text = "Scripts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabcScripts);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCurrentXML);
            this.Controls.Add(this.btnChooseXML);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SimaticML Tools";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabcScripts.ResumeLayout(false);
            this.tabSeq.ResumeLayout(false);
            this.grpGRAPHScripts.ResumeLayout(false);
            this.tabFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChooseXML;
        private System.Windows.Forms.Label lblCurrentXML;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnScptSeq1;
        private System.Windows.Forms.TabControl tabcScripts;
        private System.Windows.Forms.TabPage tabSeq;
        private System.Windows.Forms.TabPage tabFunction;
        private System.Windows.Forms.Button btnScptSeq2;
        private System.Windows.Forms.GroupBox grpGRAPHScripts;
        private System.Windows.Forms.GroupBox grpFCScripts;
        private System.Windows.Forms.Button btnScptSeq1Help;
        private System.Windows.Forms.Button btnScptSeq2Help;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnScptSeq3;
    }
}

