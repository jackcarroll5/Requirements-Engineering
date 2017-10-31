namespace MusicStoreSYS
{
    partial class frmPreordCD
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
            this.btnExitPreOrder = new System.Windows.Forms.Button();
            this.grpPreorderCD = new System.Windows.Forms.GroupBox();
            this.cboDiscontinueCD = new System.Windows.Forms.ComboBox();
            this.lblPreorder = new System.Windows.Forms.Label();
            this.btnConfirmCD = new System.Windows.Forms.Button();
            this.grpPreorderCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitPreOrder
            // 
            this.btnExitPreOrder.Location = new System.Drawing.Point(476, 1);
            this.btnExitPreOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitPreOrder.Name = "btnExitPreOrder";
            this.btnExitPreOrder.Size = new System.Drawing.Size(87, 28);
            this.btnExitPreOrder.TabIndex = 16;
            this.btnExitPreOrder.Text = "Exit";
            this.btnExitPreOrder.UseVisualStyleBackColor = true;
            // 
            // grpPreorderCD
            // 
            this.grpPreorderCD.Controls.Add(this.lblPreorder);
            this.grpPreorderCD.Controls.Add(this.cboDiscontinueCD);
            this.grpPreorderCD.Location = new System.Drawing.Point(23, 52);
            this.grpPreorderCD.Name = "grpPreorderCD";
            this.grpPreorderCD.Size = new System.Drawing.Size(297, 215);
            this.grpPreorderCD.TabIndex = 17;
            this.grpPreorderCD.TabStop = false;
            this.grpPreorderCD.Text = "Order CD for Supplier";
            // 
            // cboDiscontinueCD
            // 
            this.cboDiscontinueCD.FormattingEnabled = true;
            this.cboDiscontinueCD.Items.AddRange(new object[] {
            "Parachutes - Coldplay",
            "X - Ed Sheeran",
            "25 - Adele",
            "Glory Days - Little Mix"});
            this.cboDiscontinueCD.Location = new System.Drawing.Point(9, 86);
            this.cboDiscontinueCD.Margin = new System.Windows.Forms.Padding(2);
            this.cboDiscontinueCD.Name = "cboDiscontinueCD";
            this.cboDiscontinueCD.Size = new System.Drawing.Size(117, 21);
            this.cboDiscontinueCD.TabIndex = 23;
            // 
            // lblPreorder
            // 
            this.lblPreorder.AutoSize = true;
            this.lblPreorder.Location = new System.Drawing.Point(6, 44);
            this.lblPreorder.Name = "lblPreorder";
            this.lblPreorder.Size = new System.Drawing.Size(182, 13);
            this.lblPreorder.TabIndex = 24;
            this.lblPreorder.Text = "Choose CD to be ordered by Supplier";
            // 
            // btnConfirmCD
            // 
            this.btnConfirmCD.Location = new System.Drawing.Point(70, 398);
            this.btnConfirmCD.Name = "btnConfirmCD";
            this.btnConfirmCD.Size = new System.Drawing.Size(329, 88);
            this.btnConfirmCD.TabIndex = 18;
            this.btnConfirmCD.Text = "Confirm Selection";
            this.btnConfirmCD.UseVisualStyleBackColor = true;
            // 
            // frmPreordCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 498);
            this.Controls.Add(this.btnConfirmCD);
            this.Controls.Add(this.grpPreorderCD);
            this.Controls.Add(this.btnExitPreOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPreordCD";
            this.Text = "Preordering CDs";
            this.grpPreorderCD.ResumeLayout(false);
            this.grpPreorderCD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitPreOrder;
        private System.Windows.Forms.GroupBox grpPreorderCD;
        private System.Windows.Forms.Label lblPreorder;
        private System.Windows.Forms.ComboBox cboDiscontinueCD;
        private System.Windows.Forms.Button btnConfirmCD;
    }
}