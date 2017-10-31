namespace MusicStoreSYS
{
    partial class frmQueryCD
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
            this.grpOrderCD = new System.Windows.Forms.GroupBox();
            this.btnArtist = new System.Windows.Forms.Button();
            this.btnAlbum = new System.Windows.Forms.Button();
            this.btnCDID = new System.Windows.Forms.Button();
            this.lblQuerySupp = new System.Windows.Forms.Label();
            this.btnQueryCDExit = new System.Windows.Forms.Button();
            this.grpOrderCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrderCD
            // 
            this.grpOrderCD.Controls.Add(this.btnArtist);
            this.grpOrderCD.Controls.Add(this.btnAlbum);
            this.grpOrderCD.Controls.Add(this.btnCDID);
            this.grpOrderCD.Location = new System.Drawing.Point(29, 203);
            this.grpOrderCD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrderCD.Name = "grpOrderCD";
            this.grpOrderCD.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOrderCD.Size = new System.Drawing.Size(530, 147);
            this.grpOrderCD.TabIndex = 5;
            this.grpOrderCD.TabStop = false;
            this.grpOrderCD.Text = "Order them by";
            // 
            // btnArtist
            // 
            this.btnArtist.Location = new System.Drawing.Point(429, 66);
            this.btnArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArtist.Name = "btnArtist";
            this.btnArtist.Size = new System.Drawing.Size(100, 77);
            this.btnArtist.TabIndex = 3;
            this.btnArtist.Text = "Artist Name";
            this.btnArtist.UseVisualStyleBackColor = true;
            // 
            // btnAlbum
            // 
            this.btnAlbum.Location = new System.Drawing.Point(215, 66);
            this.btnAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.Size = new System.Drawing.Size(100, 77);
            this.btnAlbum.TabIndex = 2;
            this.btnAlbum.Text = "Album Name";
            this.btnAlbum.UseVisualStyleBackColor = true;
            // 
            // btnCDID
            // 
            this.btnCDID.Location = new System.Drawing.Point(4, 66);
            this.btnCDID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCDID.Name = "btnCDID";
            this.btnCDID.Size = new System.Drawing.Size(98, 77);
            this.btnCDID.TabIndex = 1;
            this.btnCDID.Text = "CD ID";
            this.btnCDID.UseVisualStyleBackColor = true;
            // 
            // lblQuerySupp
            // 
            this.lblQuerySupp.AutoSize = true;
            this.lblQuerySupp.Location = new System.Drawing.Point(139, 149);
            this.lblQuerySupp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuerySupp.Name = "lblQuerySupp";
            this.lblQuerySupp.Size = new System.Drawing.Size(276, 13);
            this.lblQuerySupp.TabIndex = 4;
            this.lblQuerySupp.Text = "How do want the list of CDs to be displayed in the query?";
            this.lblQuerySupp.Click += new System.EventHandler(this.lblQuerySupp_Click);
            // 
            // btnQueryCDExit
            // 
            this.btnQueryCDExit.Location = new System.Drawing.Point(484, 1);
            this.btnQueryCDExit.Name = "btnQueryCDExit";
            this.btnQueryCDExit.Size = new System.Drawing.Size(132, 38);
            this.btnQueryCDExit.TabIndex = 6;
            this.btnQueryCDExit.Text = "Quit";
            this.btnQueryCDExit.UseVisualStyleBackColor = true;
            // 
            // frmQueryCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 497);
            this.Controls.Add(this.btnQueryCDExit);
            this.Controls.Add(this.grpOrderCD);
            this.Controls.Add(this.lblQuerySupp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQueryCD";
            this.Text = "Querying CDs";
            this.grpOrderCD.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderCD;
        private System.Windows.Forms.Button btnArtist;
        private System.Windows.Forms.Button btnAlbum;
        private System.Windows.Forms.Button btnCDID;
        private System.Windows.Forms.Label lblQuerySupp;
        private System.Windows.Forms.Button btnQueryCDExit;
    }
}