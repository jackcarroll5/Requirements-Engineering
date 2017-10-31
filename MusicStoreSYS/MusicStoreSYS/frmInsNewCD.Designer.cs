namespace MusicStoreSYS
{
    partial class frmInsNewCD
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
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblYr = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.chkYr = new System.Windows.Forms.CheckedListBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.radSony = new System.Windows.Forms.RadioButton();
            this.radUniversal = new System.Windows.Forms.RadioButton();
            this.radWBros = new System.Windows.Forms.RadioButton();
            this.radPolydor = new System.Windows.Forms.RadioButton();
            this.grpArtistLbl = new System.Windows.Forms.GroupBox();
            this.lblInsCD = new System.Windows.Forms.Label();
            this.btnExitA = new System.Windows.Forms.Button();
            this.grpArtistLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(22, 81);
            this.lblAlbum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Album:";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(22, 134);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(33, 13);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Artist:";
            // 
            // lblYr
            // 
            this.lblYr.AutoSize = true;
            this.lblYr.Location = new System.Drawing.Point(22, 186);
            this.lblYr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYr.Name = "lblYr";
            this.lblYr.Size = new System.Drawing.Size(80, 13);
            this.lblYr.TabIndex = 2;
            this.lblYr.Text = "Year Released:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(256, 435);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 40);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // chkYr
            // 
            this.chkYr.FormattingEnabled = true;
            this.chkYr.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.chkYr.Location = new System.Drawing.Point(106, 186);
            this.chkYr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkYr.Name = "chkYr";
            this.chkYr.Size = new System.Drawing.Size(215, 94);
            this.chkYr.TabIndex = 5;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(68, 134);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(170, 20);
            this.txtArtist.TabIndex = 6;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(67, 82);
            this.txtAlbum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(170, 20);
            this.txtAlbum.TabIndex = 7;
            // 
            // radSony
            // 
            this.radSony.AutoSize = true;
            this.radSony.Location = new System.Drawing.Point(4, 17);
            this.radSony.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radSony.Name = "radSony";
            this.radSony.Size = new System.Drawing.Size(49, 17);
            this.radSony.TabIndex = 8;
            this.radSony.TabStop = true;
            this.radSony.Text = "Sony";
            this.radSony.UseVisualStyleBackColor = true;
            // 
            // radUniversal
            // 
            this.radUniversal.AutoSize = true;
            this.radUniversal.Checked = true;
            this.radUniversal.Location = new System.Drawing.Point(0, 76);
            this.radUniversal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radUniversal.Name = "radUniversal";
            this.radUniversal.Size = new System.Drawing.Size(69, 17);
            this.radUniversal.TabIndex = 9;
            this.radUniversal.TabStop = true;
            this.radUniversal.Text = "Universal";
            this.radUniversal.UseVisualStyleBackColor = true;
            // 
            // radWBros
            // 
            this.radWBros.AutoSize = true;
            this.radWBros.Location = new System.Drawing.Point(66, 17);
            this.radWBros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radWBros.Name = "radWBros";
            this.radWBros.Size = new System.Drawing.Size(84, 17);
            this.radWBros.TabIndex = 10;
            this.radWBros.TabStop = true;
            this.radWBros.Text = "Warner Bros";
            this.radWBros.UseVisualStyleBackColor = true;
            // 
            // radPolydor
            // 
            this.radPolydor.AutoSize = true;
            this.radPolydor.Location = new System.Drawing.Point(73, 76);
            this.radPolydor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radPolydor.Name = "radPolydor";
            this.radPolydor.Size = new System.Drawing.Size(60, 17);
            this.radPolydor.TabIndex = 11;
            this.radPolydor.TabStop = true;
            this.radPolydor.Text = "Polydor";
            this.radPolydor.UseVisualStyleBackColor = true;
            // 
            // grpArtistLbl
            // 
            this.grpArtistLbl.Controls.Add(this.radSony);
            this.grpArtistLbl.Controls.Add(this.radWBros);
            this.grpArtistLbl.Controls.Add(this.radPolydor);
            this.grpArtistLbl.Controls.Add(this.radUniversal);
            this.grpArtistLbl.Location = new System.Drawing.Point(11, 306);
            this.grpArtistLbl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpArtistLbl.Name = "grpArtistLbl";
            this.grpArtistLbl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpArtistLbl.Size = new System.Drawing.Size(150, 108);
            this.grpArtistLbl.TabIndex = 13;
            this.grpArtistLbl.TabStop = false;
            this.grpArtistLbl.Text = "Artist Label:";
            // 
            // lblInsCD
            // 
            this.lblInsCD.AutoSize = true;
            this.lblInsCD.Location = new System.Drawing.Point(12, 25);
            this.lblInsCD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsCD.Name = "lblInsCD";
            this.lblInsCD.Size = new System.Drawing.Size(255, 13);
            this.lblInsCD.TabIndex = 14;
            this.lblInsCD.Text = "Please insert the CD you want to put into the system:";
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(535, 0);
            this.btnExitA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(87, 28);
            this.btnExitA.TabIndex = 15;
            this.btnExitA.Text = "Exit";
            this.btnExitA.UseVisualStyleBackColor = true;
            // 
            // frmInsNewCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 477);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.lblInsCD);
            this.Controls.Add(this.grpArtistLbl);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.chkYr);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblYr);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblAlbum);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmInsNewCD";
            this.Text = "Insert CDs";
            this.grpArtistLbl.ResumeLayout(false);
            this.grpArtistLbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblYr;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.CheckedListBox chkYr;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.RadioButton radSony;
        private System.Windows.Forms.RadioButton radUniversal;
        private System.Windows.Forms.RadioButton radWBros;
        private System.Windows.Forms.RadioButton radPolydor;
        private System.Windows.Forms.GroupBox grpArtistLbl;
        private System.Windows.Forms.Label lblInsCD;
        private System.Windows.Forms.Button btnExitA;
    }
}