namespace MusicStoreSYS
{
    partial class frmSuppList
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
            this.lblQuerySupp = new System.Windows.Forms.Label();
            this.btnDispSuppID = new System.Windows.Forms.Button();
            this.btnDispSuppName = new System.Windows.Forms.Button();
            this.grpOrderSupp = new System.Windows.Forms.GroupBox();
            this.btnSuppListExit = new System.Windows.Forms.Button();
            this.grpOrderSupp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuerySupp
            // 
            this.lblQuerySupp.AutoSize = true;
            this.lblQuerySupp.Location = new System.Drawing.Point(174, 120);
            this.lblQuerySupp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuerySupp.Name = "lblQuerySupp";
            this.lblQuerySupp.Size = new System.Drawing.Size(241, 13);
            this.lblQuerySupp.TabIndex = 0;
            this.lblQuerySupp.Text = "How do want the list of Suppliers to be displayed?";
            // 
            // btnDispSuppID
            // 
            this.btnDispSuppID.Location = new System.Drawing.Point(4, 68);
            this.btnDispSuppID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispSuppID.Name = "btnDispSuppID";
            this.btnDispSuppID.Size = new System.Drawing.Size(167, 278);
            this.btnDispSuppID.TabIndex = 1;
            this.btnDispSuppID.Text = "Supplier ID";
            this.btnDispSuppID.UseVisualStyleBackColor = true;
            // 
            // btnDispSuppName
            // 
            this.btnDispSuppName.Location = new System.Drawing.Point(224, 68);
            this.btnDispSuppName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDispSuppName.Name = "btnDispSuppName";
            this.btnDispSuppName.Size = new System.Drawing.Size(143, 278);
            this.btnDispSuppName.TabIndex = 2;
            this.btnDispSuppName.Text = "Supplier Name";
            this.btnDispSuppName.UseVisualStyleBackColor = true;
            // 
            // grpOrderSupp
            // 
            this.grpOrderSupp.Controls.Add(this.btnDispSuppName);
            this.grpOrderSupp.Controls.Add(this.btnDispSuppID);
            this.grpOrderSupp.Location = new System.Drawing.Point(116, 161);
            this.grpOrderSupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrderSupp.Name = "grpOrderSupp";
            this.grpOrderSupp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrderSupp.Size = new System.Drawing.Size(371, 350);
            this.grpOrderSupp.TabIndex = 3;
            this.grpOrderSupp.TabStop = false;
            this.grpOrderSupp.Text = "Order By";
            // 
            // btnSuppListExit
            // 
            this.btnSuppListExit.Location = new System.Drawing.Point(528, 3);
            this.btnSuppListExit.Name = "btnSuppListExit";
            this.btnSuppListExit.Size = new System.Drawing.Size(132, 38);
            this.btnSuppListExit.TabIndex = 4;
            this.btnSuppListExit.Text = "Quit";
            this.btnSuppListExit.UseVisualStyleBackColor = true;
            // 
            // frmSuppList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 522);
            this.Controls.Add(this.btnSuppListExit);
            this.Controls.Add(this.grpOrderSupp);
            this.Controls.Add(this.lblQuerySupp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSuppList";
            this.Text = "List of Suppliers";
            this.grpOrderSupp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDispSuppID;
        private System.Windows.Forms.Button btnDispSuppName;
        private System.Windows.Forms.GroupBox grpOrderSupp;
        private System.Windows.Forms.Button btnSuppListExit;
        public System.Windows.Forms.Label lblQuerySupp;
    }
}