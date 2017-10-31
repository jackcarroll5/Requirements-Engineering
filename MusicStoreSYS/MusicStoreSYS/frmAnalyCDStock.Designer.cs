namespace MusicStoreSYS
{
    partial class frmAnalyCDStock
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
            this.btnExitAnalyseCDStock = new System.Windows.Forms.Button();
            this.grpStockAnalysis = new System.Windows.Forms.GroupBox();
            this.chkOrderAnalysis = new System.Windows.Forms.CheckedListBox();
            this.lblDisplayCDAnalysis = new System.Windows.Forms.Label();
            this.btnAnalyseStock = new System.Windows.Forms.Button();
            this.grpStockAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExitAnalyseCDStock
            // 
            this.btnExitAnalyseCDStock.Location = new System.Drawing.Point(508, 1);
            this.btnExitAnalyseCDStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAnalyseCDStock.Name = "btnExitAnalyseCDStock";
            this.btnExitAnalyseCDStock.Size = new System.Drawing.Size(87, 28);
            this.btnExitAnalyseCDStock.TabIndex = 16;
            this.btnExitAnalyseCDStock.Text = "Exit";
            this.btnExitAnalyseCDStock.UseVisualStyleBackColor = true;
            // 
            // grpStockAnalysis
            // 
            this.grpStockAnalysis.Controls.Add(this.chkOrderAnalysis);
            this.grpStockAnalysis.Controls.Add(this.lblDisplayCDAnalysis);
            this.grpStockAnalysis.Location = new System.Drawing.Point(1, 81);
            this.grpStockAnalysis.Name = "grpStockAnalysis";
            this.grpStockAnalysis.Size = new System.Drawing.Size(247, 149);
            this.grpStockAnalysis.TabIndex = 17;
            this.grpStockAnalysis.TabStop = false;
            this.grpStockAnalysis.Text = "Order CDs for Stock Analysis";
            // 
            // chkOrderAnalysis
            // 
            this.chkOrderAnalysis.FormattingEnabled = true;
            this.chkOrderAnalysis.Items.AddRange(new object[] {
            "CD_ID",
            "Artist",
            "Number_Available"});
            this.chkOrderAnalysis.Location = new System.Drawing.Point(9, 88);
            this.chkOrderAnalysis.Name = "chkOrderAnalysis";
            this.chkOrderAnalysis.Size = new System.Drawing.Size(222, 49);
            this.chkOrderAnalysis.TabIndex = 1;
            // 
            // lblDisplayCDAnalysis
            // 
            this.lblDisplayCDAnalysis.AutoSize = true;
            this.lblDisplayCDAnalysis.Location = new System.Drawing.Point(6, 47);
            this.lblDisplayCDAnalysis.Name = "lblDisplayCDAnalysis";
            this.lblDisplayCDAnalysis.Size = new System.Drawing.Size(225, 13);
            this.lblDisplayCDAnalysis.TabIndex = 0;
            this.lblDisplayCDAnalysis.Text = "Select the order to display the CDs for analysis";
            // 
            // btnAnalyseStock
            // 
            this.btnAnalyseStock.Location = new System.Drawing.Point(62, 269);
            this.btnAnalyseStock.Name = "btnAnalyseStock";
            this.btnAnalyseStock.Size = new System.Drawing.Size(360, 130);
            this.btnAnalyseStock.TabIndex = 18;
            this.btnAnalyseStock.Text = "Analyse";
            this.btnAnalyseStock.UseVisualStyleBackColor = true;
            // 
            // frmAnalyCDStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 468);
            this.Controls.Add(this.btnAnalyseStock);
            this.Controls.Add(this.grpStockAnalysis);
            this.Controls.Add(this.btnExitAnalyseCDStock);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnalyCDStock";
            this.Text = "Analyse CD Stock";
            this.grpStockAnalysis.ResumeLayout(false);
            this.grpStockAnalysis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExitAnalyseCDStock;
        private System.Windows.Forms.GroupBox grpStockAnalysis;
        private System.Windows.Forms.CheckedListBox chkOrderAnalysis;
        private System.Windows.Forms.Label lblDisplayCDAnalysis;
        private System.Windows.Forms.Button btnAnalyseStock;
    }
}