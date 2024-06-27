namespace CSSimaticMLTools
{
    partial class ScriptHelp
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
			this.lblText = new System.Windows.Forms.Label();
			this.picPicture1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPicture1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblText
			// 
			this.lblText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblText.Location = new System.Drawing.Point(12, 9);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(390, 39);
			this.lblText.TabIndex = 0;
			this.lblText.Text = "lblText";
			// 
			// picPicture1
			// 
			this.picPicture1.Location = new System.Drawing.Point(15, 58);
			this.picPicture1.Margin = new System.Windows.Forms.Padding(10);
			this.picPicture1.Name = "picPicture1";
			this.picPicture1.Size = new System.Drawing.Size(392, 246);
			this.picPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picPicture1.TabIndex = 1;
			this.picPicture1.TabStop = false;
			// 
			// ScriptHelp
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(414, 309);
			this.Controls.Add(this.picPicture1);
			this.Controls.Add(this.lblText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScriptHelp";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Script Help";
			this.Deactivate += new System.EventHandler(this.ScriptHelp_Deactivate);
			((System.ComponentModel.ISupportInitialize)(this.picPicture1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblText;
		public System.Windows.Forms.PictureBox picPicture1;
	}
}