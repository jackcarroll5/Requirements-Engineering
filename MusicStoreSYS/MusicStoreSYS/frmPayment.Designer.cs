namespace MusicStoreSYS
{
    partial class frmPayment
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
            this.lblOrderCD = new System.Windows.Forms.Label();
            this.cboOrderCD = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpPreOrderCD = new System.Windows.Forms.GroupBox();
            this.btnAcceptSupp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpPreOrderCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderCD
            // 
            this.lblOrderCD.AutoSize = true;
            this.lblOrderCD.Location = new System.Drawing.Point(-3, 45);
            this.lblOrderCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderCD.Name = "lblOrderCD";
            this.lblOrderCD.Size = new System.Drawing.Size(233, 13);
            this.lblOrderCD.TabIndex = 0;
            this.lblOrderCD.Text = "Please select the Supplier who is ordering a CD:";
            // 
            // cboOrderCD
            // 
            this.cboOrderCD.FormattingEnabled = true;
            this.cboOrderCD.Items.AddRange(new object[] {
            "003 Adams",
            "007 Flowers",
            "010 Kelly",
            "004 Walsh"});
            this.cboOrderCD.Location = new System.Drawing.Point(5, 71);
            this.cboOrderCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboOrderCD.Name = "cboOrderCD";
            this.cboOrderCD.Size = new System.Drawing.Size(150, 21);
            this.cboOrderCD.TabIndex = 1;
            this.cboOrderCD.SelectedIndexChanged += new System.EventHandler(this.cboOrderCD_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // grpPreOrderCD
            // 
            this.grpPreOrderCD.Controls.Add(this.cboOrderCD);
            this.grpPreOrderCD.Controls.Add(this.lblOrderCD);
            this.grpPreOrderCD.Location = new System.Drawing.Point(0, 72);
            this.grpPreOrderCD.Name = "grpPreOrderCD";
            this.grpPreOrderCD.Size = new System.Drawing.Size(580, 121);
            this.grpPreOrderCD.TabIndex = 3;
            this.grpPreOrderCD.TabStop = false;
            this.grpPreOrderCD.Text = "PreOrder CD";
            // 
            // btnAcceptSupp
            // 
            this.btnAcceptSupp.Location = new System.Drawing.Point(22, 256);
            this.btnAcceptSupp.Name = "btnAcceptSupp";
            this.btnAcceptSupp.Size = new System.Drawing.Size(437, 167);
            this.btnAcceptSupp.TabIndex = 4;
            this.btnAcceptSupp.Text = "Accept";
            this.btnAcceptSupp.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 514);
            this.Controls.Add(this.btnAcceptSupp);
            this.Controls.Add(this.grpPreOrderCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPayment";
            this.Text = "Payment Confirmation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpPreOrderCD.ResumeLayout(false);
            this.grpPreOrderCD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderCD;
        private System.Windows.Forms.ComboBox cboOrderCD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpPreOrderCD;
        private System.Windows.Forms.Button btnAcceptSupp;
    }
}