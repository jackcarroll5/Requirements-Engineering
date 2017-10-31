namespace MusicStoreSYS
{
    partial class frmAnalyCDSales
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
            this.grpSalesAnalysis = new System.Windows.Forms.GroupBox();
            this.chkNoSold = new System.Windows.Forms.CheckBox();
            this.chkHighestSale = new System.Windows.Forms.CheckBox();
            this.chkAlbumName = new System.Windows.Forms.CheckBox();
            this.chkCDID = new System.Windows.Forms.CheckBox();
            this.lblDisplayCDAnalysis = new System.Windows.Forms.Label();
            this.btnExitAnalyseCDSales = new System.Windows.Forms.Button();
            this.btnAnalyseSales = new System.Windows.Forms.Button();
            this.grpSalesAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSalesAnalysis
            // 
            this.grpSalesAnalysis.Controls.Add(this.chkNoSold);
            this.grpSalesAnalysis.Controls.Add(this.chkHighestSale);
            this.grpSalesAnalysis.Controls.Add(this.chkAlbumName);
            this.grpSalesAnalysis.Controls.Add(this.chkCDID);
            this.grpSalesAnalysis.Controls.Add(this.lblDisplayCDAnalysis);
            this.grpSalesAnalysis.Location = new System.Drawing.Point(63, 95);
            this.grpSalesAnalysis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSalesAnalysis.Name = "grpSalesAnalysis";
            this.grpSalesAnalysis.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpSalesAnalysis.Size = new System.Drawing.Size(557, 213);
            this.grpSalesAnalysis.TabIndex = 0;
            this.grpSalesAnalysis.TabStop = false;
            this.grpSalesAnalysis.Text = "Order CDs for Sales Analysis";
            // 
            // chkNoSold
            // 
            this.chkNoSold.AutoSize = true;
            this.chkNoSold.Checked = true;
            this.chkNoSold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoSold.Location = new System.Drawing.Point(433, 162);
            this.chkNoSold.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkNoSold.Name = "chkNoSold";
            this.chkNoSold.Size = new System.Drawing.Size(112, 21);
            this.chkNoSold.TabIndex = 4;
            this.chkNoSold.Text = "Number Sold";
            this.chkNoSold.UseVisualStyleBackColor = true;
            this.chkNoSold.CheckedChanged += new System.EventHandler(this.chkNoSold_CheckedChanged);
            // 
            // chkHighestSale
            // 
            this.chkHighestSale.AutoSize = true;
            this.chkHighestSale.Location = new System.Drawing.Point(433, 114);
            this.chkHighestSale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHighestSale.Name = "chkHighestSale";
            this.chkHighestSale.Size = new System.Drawing.Size(110, 21);
            this.chkHighestSale.TabIndex = 3;
            this.chkHighestSale.Text = "Highest Sale";
            this.chkHighestSale.UseVisualStyleBackColor = true;
            // 
            // chkAlbumName
            // 
            this.chkAlbumName.AutoSize = true;
            this.chkAlbumName.Location = new System.Drawing.Point(8, 162);
            this.chkAlbumName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkAlbumName.Name = "chkAlbumName";
            this.chkAlbumName.Size = new System.Drawing.Size(110, 21);
            this.chkAlbumName.TabIndex = 2;
            this.chkAlbumName.Text = "Album Name";
            this.chkAlbumName.UseVisualStyleBackColor = true;
            // 
            // chkCDID
            // 
            this.chkCDID.AutoSize = true;
            this.chkCDID.Location = new System.Drawing.Point(12, 114);
            this.chkCDID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkCDID.Name = "chkCDID";
            this.chkCDID.Size = new System.Drawing.Size(66, 21);
            this.chkCDID.TabIndex = 1;
            this.chkCDID.Text = "CD ID";
            this.chkCDID.UseVisualStyleBackColor = true;
            // 
            // lblDisplayCDAnalysis
            // 
            this.lblDisplayCDAnalysis.AutoSize = true;
            this.lblDisplayCDAnalysis.Location = new System.Drawing.Point(8, 58);
            this.lblDisplayCDAnalysis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplayCDAnalysis.Name = "lblDisplayCDAnalysis";
            this.lblDisplayCDAnalysis.Size = new System.Drawing.Size(303, 17);
            this.lblDisplayCDAnalysis.TabIndex = 0;
            this.lblDisplayCDAnalysis.Text = "Select the order to display the CDs for analysis";
            // 
            // btnExitAnalyseCDSales
            // 
            this.btnExitAnalyseCDSales.Location = new System.Drawing.Point(639, 0);
            this.btnExitAnalyseCDSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExitAnalyseCDSales.Name = "btnExitAnalyseCDSales";
            this.btnExitAnalyseCDSales.Size = new System.Drawing.Size(116, 34);
            this.btnExitAnalyseCDSales.TabIndex = 16;
            this.btnExitAnalyseCDSales.Text = "Exit";
            this.btnExitAnalyseCDSales.UseVisualStyleBackColor = true;
            // 
            // btnAnalyseSales
            // 
            this.btnAnalyseSales.Location = new System.Drawing.Point(63, 354);
            this.btnAnalyseSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalyseSales.Name = "btnAnalyseSales";
            this.btnAnalyseSales.Size = new System.Drawing.Size(557, 116);
            this.btnAnalyseSales.TabIndex = 17;
            this.btnAnalyseSales.Text = "Analyse Now";
            this.btnAnalyseSales.UseVisualStyleBackColor = true;
            // 
            // frmAnalyCDSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 567);
            this.Controls.Add(this.btnAnalyseSales);
            this.Controls.Add(this.btnExitAnalyseCDSales);
            this.Controls.Add(this.grpSalesAnalysis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAnalyCDSales";
            this.Text = "Analyse CD Sales";
            this.grpSalesAnalysis.ResumeLayout(false);
            this.grpSalesAnalysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSalesAnalysis;
        private System.Windows.Forms.Label lblDisplayCDAnalysis;
        private System.Windows.Forms.Button btnExitAnalyseCDSales;
        private System.Windows.Forms.Button btnAnalyseSales;
        private System.Windows.Forms.CheckBox chkNoSold;
        private System.Windows.Forms.CheckBox chkHighestSale;
        private System.Windows.Forms.CheckBox chkAlbumName;
        private System.Windows.Forms.CheckBox chkCDID;
    }
}