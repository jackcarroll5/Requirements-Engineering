﻿namespace MusicStoreSYS
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
            this.radArtLbl = new System.Windows.Forms.RadioButton();
            this.radCDID = new System.Windows.Forms.RadioButton();
            this.btnQueryCDExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.grdCD = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearRelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArtLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOrderCD.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOrderCD
            // 
            this.grpOrderCD.Controls.Add(this.radArtLbl);
            this.grpOrderCD.Controls.Add(this.radCDID);
            this.grpOrderCD.Location = new System.Drawing.Point(11, 53);
            this.grpOrderCD.Margin = new System.Windows.Forms.Padding(2);
            this.grpOrderCD.Name = "grpOrderCD";
            this.grpOrderCD.Padding = new System.Windows.Forms.Padding(2);
            this.grpOrderCD.Size = new System.Drawing.Size(333, 78);
            this.grpOrderCD.TabIndex = 5;
            this.grpOrderCD.TabStop = false;
            this.grpOrderCD.Text = "Choose Order";
            // 
            // radArtLbl
            // 
            this.radArtLbl.AutoSize = true;
            this.radArtLbl.Checked = true;
            this.radArtLbl.Location = new System.Drawing.Point(171, 38);
            this.radArtLbl.Name = "radArtLbl";
            this.radArtLbl.Size = new System.Drawing.Size(77, 17);
            this.radArtLbl.TabIndex = 1;
            this.radArtLbl.TabStop = true;
            this.radArtLbl.Text = "Artist Label";
            this.radArtLbl.UseVisualStyleBackColor = true;
            this.radArtLbl.CheckedChanged += new System.EventHandler(this.radArtLbl_CheckedChanged);
            // 
            // radCDID
            // 
            this.radCDID.AutoSize = true;
            this.radCDID.Location = new System.Drawing.Point(27, 38);
            this.radCDID.Name = "radCDID";
            this.radCDID.Size = new System.Drawing.Size(54, 17);
            this.radCDID.TabIndex = 0;
            this.radCDID.Text = "CD ID";
            this.radCDID.UseVisualStyleBackColor = true;
            this.radCDID.CheckedChanged += new System.EventHandler(this.radCDID_CheckedChanged);
            // 
            // btnQueryCDExit
            // 
            this.btnQueryCDExit.Location = new System.Drawing.Point(701, 0);
            this.btnQueryCDExit.Name = "btnQueryCDExit";
            this.btnQueryCDExit.Size = new System.Drawing.Size(132, 24);
            this.btnQueryCDExit.TabIndex = 6;
            this.btnQueryCDExit.Text = "Quit";
            this.btnQueryCDExit.UseVisualStyleBackColor = true;
            this.btnQueryCDExit.Click += new System.EventHandler(this.btnQueryCDExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backMenuStrip
            // 
            this.backMenuStrip.Name = "backMenuStrip";
            this.backMenuStrip.Size = new System.Drawing.Size(44, 20);
            this.backMenuStrip.Text = "Back";
            this.backMenuStrip.Click += new System.EventHandler(this.backMenuStrip_Click);
            // 
            // grdCD
            // 
            this.grdCD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Album,
            this.Artist,
            this.YearRelease,
            this.ArtLabel,
            this.CostPrice,
            this.Qty,
            this.Availability});
            this.grdCD.Location = new System.Drawing.Point(0, 172);
            this.grdCD.Name = "grdCD";
            this.grdCD.Size = new System.Drawing.Size(833, 150);
            this.grdCD.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.HeaderText = "CD ID";
            this.ID.Name = "ID";
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            // 
            // YearRelease
            // 
            this.YearRelease.HeaderText = "Year Released";
            this.YearRelease.Name = "YearRelease";
            // 
            // ArtLabel
            // 
            this.ArtLabel.HeaderText = "Artist Label";
            this.ArtLabel.Name = "ArtLabel";
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost Price";
            this.CostPrice.Name = "CostPrice";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Availability
            // 
            this.Availability.HeaderText = "Availability";
            this.Availability.Name = "Availability";
            // 
            // frmQueryCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 497);
            this.Controls.Add(this.grdCD);
            this.Controls.Add(this.btnQueryCDExit);
            this.Controls.Add(this.grpOrderCD);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQueryCD";
            this.Text = "Querying CDs";
            this.Load += new System.EventHandler(this.frmQueryCD_Load);
            this.grpOrderCD.ResumeLayout(false);
            this.grpOrderCD.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrderCD;
        private System.Windows.Forms.Button btnQueryCDExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backMenuStrip;
        private System.Windows.Forms.RadioButton radCDID;
        private System.Windows.Forms.RadioButton radArtLbl;
        private System.Windows.Forms.DataGridView grdCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearRelease;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArtLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Availability;
    }
}