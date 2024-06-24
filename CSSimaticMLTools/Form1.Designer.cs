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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.grpTable = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListGet = new System.Windows.Forms.Button();
            this.btnListClear = new System.Windows.Forms.Button();
            this.btnListPaste = new System.Windows.Forms.Button();
            this.grpGRAPHScripts = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnScptSeq3 = new System.Windows.Forms.Button();
            this.btnScptSeq2Help = new System.Windows.Forms.Button();
            this.btnScptSeq1Help = new System.Windows.Forms.Button();
            this.btnScptSeq2 = new System.Windows.Forms.Button();
            this.tabFunction = new System.Windows.Forms.TabPage();
            this.grpFCScripts = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.TableStep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDescNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabcScripts.SuspendLayout();
            this.tabSeq.SuspendLayout();
            this.grpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpGRAPHScripts.SuspendLayout();
            this.tabFunction.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.btnChooseXML.Location = new System.Drawing.Point(848, 3);
            this.btnChooseXML.Name = "btnChooseXML";
            this.btnChooseXML.Size = new System.Drawing.Size(88, 21);
            this.btnChooseXML.TabIndex = 0;
            this.btnChooseXML.Text = "Choose File...";
            this.btnChooseXML.UseVisualStyleBackColor = true;
            this.btnChooseXML.Click += new System.EventHandler(this.btnChooseXML_Click);
            // 
            // lblCurrentXML
            // 
            this.lblCurrentXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentXML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentXML.Location = new System.Drawing.Point(74, 3);
            this.lblCurrentXML.Margin = new System.Windows.Forms.Padding(3);
            this.lblCurrentXML.MinimumSize = new System.Drawing.Size(400, 20);
            this.lblCurrentXML.Name = "lblCurrentXML";
            this.lblCurrentXML.Size = new System.Drawing.Size(768, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(969, 24);
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current File";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Type: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Location = new System.Drawing.Point(73, 28);
            this.lblType.Margin = new System.Windows.Forms.Padding(3);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(147, 18);
            this.lblType.TabIndex = 5;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblType.TextChanged += new System.EventHandler(this.lblType_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Location = new System.Drawing.Point(73, 3);
            this.lblName.Margin = new System.Windows.Forms.Padding(3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(147, 18);
            this.lblName.TabIndex = 7;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumber
            // 
            this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumber.Location = new System.Drawing.Point(73, 52);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(3);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(147, 18);
            this.lblNumber.TabIndex = 9;
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNumber.TextChanged += new System.EventHandler(this.lblNumber_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(3, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.tabcScripts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcScripts.Controls.Add(this.tabSeq);
            this.tabcScripts.Controls.Add(this.tabFunction);
            this.tabcScripts.Location = new System.Drawing.Point(241, 76);
            this.tabcScripts.Name = "tabcScripts";
            this.tabcScripts.SelectedIndex = 0;
            this.tabcScripts.Size = new System.Drawing.Size(716, 350);
            this.tabcScripts.TabIndex = 11;
            // 
            // tabSeq
            // 
            this.tabSeq.Controls.Add(this.grpTable);
            this.tabSeq.Controls.Add(this.grpGRAPHScripts);
            this.tabSeq.Location = new System.Drawing.Point(4, 22);
            this.tabSeq.Name = "tabSeq";
            this.tabSeq.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeq.Size = new System.Drawing.Size(708, 324);
            this.tabSeq.TabIndex = 0;
            this.tabSeq.Text = "Sequence";
            this.tabSeq.UseVisualStyleBackColor = true;
            // 
            // grpTable
            // 
            this.grpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTable.Controls.Add(this.btnBackup);
            this.grpTable.Controls.Add(this.dataGridView1);
            this.grpTable.Controls.Add(this.btnListGet);
            this.grpTable.Controls.Add(this.btnListClear);
            this.grpTable.Controls.Add(this.btnListPaste);
            this.grpTable.Enabled = false;
            this.grpTable.Location = new System.Drawing.Point(212, 6);
            this.grpTable.Name = "grpTable";
            this.grpTable.Size = new System.Drawing.Size(490, 312);
            this.grpTable.TabIndex = 20;
            this.grpTable.TabStop = false;
            this.grpTable.Text = "Step Name and Desc";
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.Location = new System.Drawing.Point(249, 280);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 20;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableStep,
            this.TableName,
            this.TableDescNo,
            this.TableDesc});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(478, 255);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // btnListGet
            // 
            this.btnListGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListGet.ForeColor = System.Drawing.Color.Black;
            this.btnListGet.Location = new System.Drawing.Point(168, 280);
            this.btnListGet.Name = "btnListGet";
            this.btnListGet.Size = new System.Drawing.Size(75, 23);
            this.btnListGet.TabIndex = 19;
            this.btnListGet.Text = "Get Names";
            this.btnListGet.UseVisualStyleBackColor = true;
            this.btnListGet.Click += new System.EventHandler(this.btnListGet_Click);
            // 
            // btnListClear
            // 
            this.btnListClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListClear.ForeColor = System.Drawing.Color.Black;
            this.btnListClear.Location = new System.Drawing.Point(87, 280);
            this.btnListClear.Name = "btnListClear";
            this.btnListClear.Size = new System.Drawing.Size(75, 23);
            this.btnListClear.TabIndex = 18;
            this.btnListClear.Text = "Clear";
            this.btnListClear.UseVisualStyleBackColor = true;
            this.btnListClear.Click += new System.EventHandler(this.btnListClear_Click);
            // 
            // btnListPaste
            // 
            this.btnListPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnListPaste.ForeColor = System.Drawing.Color.Black;
            this.btnListPaste.Location = new System.Drawing.Point(6, 280);
            this.btnListPaste.Name = "btnListPaste";
            this.btnListPaste.Size = new System.Drawing.Size(75, 23);
            this.btnListPaste.TabIndex = 17;
            this.btnListPaste.Text = "Paste";
            this.btnListPaste.UseVisualStyleBackColor = true;
            this.btnListPaste.Click += new System.EventHandler(this.btnListPaste_Click);
            // 
            // grpGRAPHScripts
            // 
            this.grpGRAPHScripts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpGRAPHScripts.Controls.Add(this.button2);
            this.grpGRAPHScripts.Controls.Add(this.button3);
            this.grpGRAPHScripts.Controls.Add(this.button1);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq3);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq2Help);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq1Help);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq2);
            this.grpGRAPHScripts.Controls.Add(this.btnScptSeq1);
            this.grpGRAPHScripts.Enabled = false;
            this.grpGRAPHScripts.Location = new System.Drawing.Point(6, 6);
            this.grpGRAPHScripts.Name = "grpGRAPHScripts";
            this.grpGRAPHScripts.Size = new System.Drawing.Size(200, 312);
            this.grpGRAPHScripts.TabIndex = 12;
            this.grpGRAPHScripts.TabStop = false;
            this.grpGRAPHScripts.Text = "Scripts";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(173, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "By Name Do Desc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // 
            // btnScptSeq3
            // 
            this.btnScptSeq3.Location = new System.Drawing.Point(6, 77);
            this.btnScptSeq3.Name = "btnScptSeq3";
            this.btnScptSeq3.Size = new System.Drawing.Size(161, 23);
            this.btnScptSeq3.TabIndex = 14;
            this.btnScptSeq3.Text = "Rewrite Step #";
            this.btnScptSeq3.UseVisualStyleBackColor = true;
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
            this.tabFunction.Size = new System.Drawing.Size(708, 324);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.435207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.56479F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChooseXML, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCurrentXML, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(941, 28);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.4433F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5567F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblType, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblNumber, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblName, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 76);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(223, 86);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(122, 321);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TableStep
            // 
            this.TableStep.HeaderText = "Step";
            this.TableStep.MinimumWidth = 40;
            this.TableStep.Name = "TableStep";
            this.TableStep.Width = 43;
            // 
            // TableName
            // 
            this.TableName.HeaderText = "Name";
            this.TableName.MinimumWidth = 150;
            this.TableName.Name = "TableName";
            this.TableName.ReadOnly = true;
            this.TableName.Width = 150;
            // 
            // TableDescNo
            // 
            this.TableDescNo.HeaderText = "Desc #";
            this.TableDescNo.MinimumWidth = 40;
            this.TableDescNo.Name = "TableDescNo";
            this.TableDescNo.Width = 40;
            // 
            // TableDesc
            // 
            this.TableDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TableDesc.HeaderText = "Desc";
            this.TableDesc.Name = "TableDesc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 438);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabcScripts);
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
            this.grpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpGRAPHScripts.ResumeLayout(false);
            this.tabFunction.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListPaste;
        private System.Windows.Forms.Button btnListClear;
        private System.Windows.Forms.Button btnListGet;
        private System.Windows.Forms.GroupBox grpTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableDescNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TableDesc;
    }
}

