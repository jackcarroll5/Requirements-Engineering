namespace MusicStoreSYS
{
    partial class frmUpdCD
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
            this.btnUExitA = new System.Windows.Forms.Button();
            this.lblUpdCD = new System.Windows.Forms.Label();
            this.grpUArtistLbl = new System.Windows.Forms.GroupBox();
            this.radUSony = new System.Windows.Forms.RadioButton();
            this.radUWBros = new System.Windows.Forms.RadioButton();
            this.radUUniversal = new System.Windows.Forms.RadioButton();
            this.txtUAlbum = new System.Windows.Forms.TextBox();
            this.txtUArtist = new System.Windows.Forms.TextBox();
            this.chkUYr = new System.Windows.Forms.CheckedListBox();
            this.btnUInsert = new System.Windows.Forms.Button();
            this.lblUYr = new System.Windows.Forms.Label();
            this.lblUArtist = new System.Windows.Forms.Label();
            this.lblUAlbum = new System.Windows.Forms.Label();
            this.lblOrderCDID = new System.Windows.Forms.Label();
            this.txtCDID = new System.Windows.Forms.TextBox();
            this.cboDiscontinueCD = new System.Windows.Forms.ComboBox();
            this.lblSaleCD = new System.Windows.Forms.Label();
            this.grpUArtistLbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUExitA
            // 
            this.btnUExitA.Location = new System.Drawing.Point(784, 1);
            this.btnUExitA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUExitA.Name = "btnUExitA";
            this.btnUExitA.Size = new System.Drawing.Size(116, 43);
            this.btnUExitA.TabIndex = 25;
            this.btnUExitA.Text = "Exit";
            this.btnUExitA.UseVisualStyleBackColor = true;
            // 
            // lblUpdCD
            // 
            this.lblUpdCD.AutoSize = true;
            this.lblUpdCD.Location = new System.Drawing.Point(21, 15);
            this.lblUpdCD.Name = "lblUpdCD";
            this.lblUpdCD.Size = new System.Drawing.Size(253, 17);
            this.lblUpdCD.TabIndex = 24;
            this.lblUpdCD.Text = "Please update the CD you want to edit:";
            // 
            // grpUArtistLbl
            // 
            this.grpUArtistLbl.Controls.Add(this.radUSony);
            this.grpUArtistLbl.Controls.Add(this.radUWBros);
            this.grpUArtistLbl.Controls.Add(this.radUUniversal);
            this.grpUArtistLbl.Location = new System.Drawing.Point(13, 447);
            this.grpUArtistLbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUArtistLbl.Name = "grpUArtistLbl";
            this.grpUArtistLbl.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUArtistLbl.Size = new System.Drawing.Size(200, 122);
            this.grpUArtistLbl.TabIndex = 23;
            this.grpUArtistLbl.TabStop = false;
            this.grpUArtistLbl.Text = "Artist Label:";
            // 
            // radUSony
            // 
            this.radUSony.AutoSize = true;
            this.radUSony.Location = new System.Drawing.Point(5, 21);
            this.radUSony.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radUSony.Name = "radUSony";
            this.radUSony.Size = new System.Drawing.Size(61, 21);
            this.radUSony.TabIndex = 8;
            this.radUSony.Text = "Sony";
            this.radUSony.UseVisualStyleBackColor = true;
            // 
            // radUWBros
            // 
            this.radUWBros.AutoSize = true;
            this.radUWBros.Location = new System.Drawing.Point(91, 21);
            this.radUWBros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radUWBros.Name = "radUWBros";
            this.radUWBros.Size = new System.Drawing.Size(109, 21);
            this.radUWBros.TabIndex = 10;
            this.radUWBros.Text = "Warner Bros";
            this.radUWBros.UseVisualStyleBackColor = true;
            // 
            // radUUniversal
            // 
            this.radUUniversal.AutoSize = true;
            this.radUUniversal.Checked = true;
            this.radUUniversal.Location = new System.Drawing.Point(0, 94);
            this.radUUniversal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radUUniversal.Name = "radUUniversal";
            this.radUUniversal.Size = new System.Drawing.Size(88, 21);
            this.radUUniversal.TabIndex = 9;
            this.radUUniversal.TabStop = true;
            this.radUUniversal.Text = "Universal";
            this.radUUniversal.UseVisualStyleBackColor = true;
            // 
            // txtUAlbum
            // 
            this.txtUAlbum.Location = new System.Drawing.Point(104, 195);
            this.txtUAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUAlbum.Name = "txtUAlbum";
            this.txtUAlbum.Size = new System.Drawing.Size(225, 22);
            this.txtUAlbum.TabIndex = 22;
            // 
            // txtUArtist
            // 
            this.txtUArtist.Location = new System.Drawing.Point(107, 267);
            this.txtUArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUArtist.Name = "txtUArtist";
            this.txtUArtist.Size = new System.Drawing.Size(225, 22);
            this.txtUArtist.TabIndex = 21;
            // 
            // chkUYr
            // 
            this.chkUYr.FormattingEnabled = true;
            this.chkUYr.Items.AddRange(new object[] {
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
            this.chkUYr.Location = new System.Drawing.Point(133, 313);
            this.chkUYr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkUYr.Name = "chkUYr";
            this.chkUYr.Size = new System.Drawing.Size(285, 106);
            this.chkUYr.TabIndex = 20;
            // 
            // btnUInsert
            // 
            this.btnUInsert.Location = new System.Drawing.Point(320, 630);
            this.btnUInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUInsert.Name = "btnUInsert";
            this.btnUInsert.Size = new System.Drawing.Size(137, 69);
            this.btnUInsert.TabIndex = 19;
            this.btnUInsert.Text = "Insert";
            this.btnUInsert.UseVisualStyleBackColor = true;
            // 
            // lblUYr
            // 
            this.lblUYr.AutoSize = true;
            this.lblUYr.Location = new System.Drawing.Point(9, 335);
            this.lblUYr.Name = "lblUYr";
            this.lblUYr.Size = new System.Drawing.Size(106, 17);
            this.lblUYr.TabIndex = 18;
            this.lblUYr.Text = "Year Released:";
            // 
            // lblUArtist
            // 
            this.lblUArtist.AutoSize = true;
            this.lblUArtist.Location = new System.Drawing.Point(15, 267);
            this.lblUArtist.Name = "lblUArtist";
            this.lblUArtist.Size = new System.Drawing.Size(44, 17);
            this.lblUArtist.TabIndex = 17;
            this.lblUArtist.Text = "Artist:";
            // 
            // lblUAlbum
            // 
            this.lblUAlbum.AutoSize = true;
            this.lblUAlbum.Location = new System.Drawing.Point(13, 199);
            this.lblUAlbum.Name = "lblUAlbum";
            this.lblUAlbum.Size = new System.Drawing.Size(51, 17);
            this.lblUAlbum.TabIndex = 16;
            this.lblUAlbum.Text = "Album:";
            // 
            // lblOrderCDID
            // 
            this.lblOrderCDID.AutoSize = true;
            this.lblOrderCDID.Location = new System.Drawing.Point(13, 136);
            this.lblOrderCDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderCDID.Name = "lblOrderCDID";
            this.lblOrderCDID.Size = new System.Drawing.Size(44, 17);
            this.lblOrderCDID.TabIndex = 26;
            this.lblOrderCDID.Text = "CD ID";
            // 
            // txtCDID
            // 
            this.txtCDID.Location = new System.Drawing.Point(93, 132);
            this.txtCDID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCDID.Name = "txtCDID";
            this.txtCDID.Size = new System.Drawing.Size(119, 22);
            this.txtCDID.TabIndex = 27;
            // 
            // cboDiscontinueCD
            // 
            this.cboDiscontinueCD.FormattingEnabled = true;
            this.cboDiscontinueCD.Items.AddRange(new object[] {
            "002 Parachutes - Coldplay",
            "008 X - Ed Sheeran",
            "012 1989 - Taylor Swift",
            "018 Glory Days - Little Mix"});
            this.cboDiscontinueCD.Location = new System.Drawing.Point(31, 53);
            this.cboDiscontinueCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDiscontinueCD.Name = "cboDiscontinueCD";
            this.cboDiscontinueCD.Size = new System.Drawing.Size(155, 24);
            this.cboDiscontinueCD.TabIndex = 28;
            // 
            // lblSaleCD
            // 
            this.lblSaleCD.AutoSize = true;
            this.lblSaleCD.Location = new System.Drawing.Point(306, 455);
            this.lblSaleCD.Name = "lblSaleCD";
            this.lblSaleCD.Size = new System.Drawing.Size(72, 17);
            this.lblSaleCD.TabIndex = 29;
            this.lblSaleCD.Text = "Sale Price";
            // 
            // frmUpdCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 702);
            this.Controls.Add(this.lblSaleCD);
            this.Controls.Add(this.cboDiscontinueCD);
            this.Controls.Add(this.txtCDID);
            this.Controls.Add(this.lblOrderCDID);
            this.Controls.Add(this.btnUExitA);
            this.Controls.Add(this.lblUpdCD);
            this.Controls.Add(this.grpUArtistLbl);
            this.Controls.Add(this.txtUAlbum);
            this.Controls.Add(this.txtUArtist);
            this.Controls.Add(this.chkUYr);
            this.Controls.Add(this.btnUInsert);
            this.Controls.Add(this.lblUYr);
            this.Controls.Add(this.lblUArtist);
            this.Controls.Add(this.lblUAlbum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUpdCD";
            this.Text = "Update CD";
            this.grpUArtistLbl.ResumeLayout(false);
            this.grpUArtistLbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUExitA;
        private System.Windows.Forms.Label lblUpdCD;
        private System.Windows.Forms.GroupBox grpUArtistLbl;
        private System.Windows.Forms.RadioButton radUSony;
        private System.Windows.Forms.RadioButton radUWBros;
        private System.Windows.Forms.RadioButton radUUniversal;
        private System.Windows.Forms.TextBox txtUAlbum;
        private System.Windows.Forms.TextBox txtUArtist;
        private System.Windows.Forms.CheckedListBox chkUYr;
        private System.Windows.Forms.Button btnUInsert;
        private System.Windows.Forms.Label lblUYr;
        private System.Windows.Forms.Label lblUArtist;
        private System.Windows.Forms.Label lblUAlbum;
        private System.Windows.Forms.Label lblOrderCDID;
        private System.Windows.Forms.TextBox txtCDID;
        private System.Windows.Forms.ComboBox cboDiscontinueCD;
        private System.Windows.Forms.Label lblSaleCD;
    }
}