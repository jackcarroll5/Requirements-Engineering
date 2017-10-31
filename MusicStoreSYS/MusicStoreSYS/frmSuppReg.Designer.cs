namespace MusicStoreSYS
{
    partial class frmSuppReg
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
            this.cboSuppliers = new System.Windows.Forms.ComboBox();
            this.lblSuppName = new System.Windows.Forms.Label();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTownVill = new System.Windows.Forms.Label();
            this.txtTownVillage = new System.Windows.Forms.TextBox();
            this.chkLim = new System.Windows.Forms.CheckBox();
            this.chkKerry = new System.Windows.Forms.CheckBox();
            this.chkCork = new System.Windows.Forms.CheckBox();
            this.grpCounty = new System.Windows.Forms.GroupBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.grpCounty.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSuppliers
            // 
            this.cboSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppliers.FormattingEnabled = true;
            this.cboSuppliers.Items.AddRange(new object[] {
            "003 Smyth",
            "004 Martin",
            "007 Adams ",
            "010 Walsh"});
            this.cboSuppliers.Location = new System.Drawing.Point(143, 26);
            this.cboSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cboSuppliers.Name = "cboSuppliers";
            this.cboSuppliers.Size = new System.Drawing.Size(160, 24);
            this.cboSuppliers.TabIndex = 0;
            this.cboSuppliers.SelectedIndexChanged += new System.EventHandler(this.cboSuppliers_SelectedIndexChanged);
            // 
            // lblSuppName
            // 
            this.lblSuppName.AutoSize = true;
            this.lblSuppName.Location = new System.Drawing.Point(19, 30);
            this.lblSuppName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuppName.Name = "lblSuppName";
            this.lblSuppName.Size = new System.Drawing.Size(103, 17);
            this.lblSuppName.TabIndex = 1;
            this.lblSuppName.Text = "Select Supplier";
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(19, 132);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNo.TabIndex = 10;
            this.lblPhoneNo.Text = "Phone Number";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(131, 128);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(180, 22);
            this.txtPhoneNo.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(22, 189);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 186);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 22);
            this.txtEmail.TabIndex = 13;
            // 
            // lblTownVill
            // 
            this.lblTownVill.AutoSize = true;
            this.lblTownVill.Location = new System.Drawing.Point(17, 324);
            this.lblTownVill.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTownVill.Name = "lblTownVill";
            this.lblTownVill.Size = new System.Drawing.Size(88, 17);
            this.lblTownVill.TabIndex = 14;
            this.lblTownVill.Text = "Town/Village";
            // 
            // txtTownVillage
            // 
            this.txtTownVillage.Location = new System.Drawing.Point(119, 322);
            this.txtTownVillage.Margin = new System.Windows.Forms.Padding(4);
            this.txtTownVillage.Name = "txtTownVillage";
            this.txtTownVillage.Size = new System.Drawing.Size(160, 22);
            this.txtTownVillage.TabIndex = 15;
            // 
            // chkLim
            // 
            this.chkLim.AutoSize = true;
            this.chkLim.Checked = true;
            this.chkLim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLim.Location = new System.Drawing.Point(41, 34);
            this.chkLim.Margin = new System.Windows.Forms.Padding(4);
            this.chkLim.Name = "chkLim";
            this.chkLim.Size = new System.Drawing.Size(82, 21);
            this.chkLim.TabIndex = 17;
            this.chkLim.Text = "Limerick";
            this.chkLim.UseVisualStyleBackColor = true;
            this.chkLim.CheckedChanged += new System.EventHandler(this.chkLim_CheckedChanged);
            // 
            // chkKerry
            // 
            this.chkKerry.AutoSize = true;
            this.chkKerry.Location = new System.Drawing.Point(41, 85);
            this.chkKerry.Margin = new System.Windows.Forms.Padding(4);
            this.chkKerry.Name = "chkKerry";
            this.chkKerry.Size = new System.Drawing.Size(64, 21);
            this.chkKerry.TabIndex = 18;
            this.chkKerry.Text = "Kerry";
            this.chkKerry.UseVisualStyleBackColor = true;
            // 
            // chkCork
            // 
            this.chkCork.AutoSize = true;
            this.chkCork.Location = new System.Drawing.Point(169, 34);
            this.chkCork.Margin = new System.Windows.Forms.Padding(4);
            this.chkCork.Name = "chkCork";
            this.chkCork.Size = new System.Drawing.Size(59, 21);
            this.chkCork.TabIndex = 19;
            this.chkCork.Text = "Cork";
            this.chkCork.UseVisualStyleBackColor = true;
            // 
            // grpCounty
            // 
            this.grpCounty.Controls.Add(this.chkLim);
            this.grpCounty.Controls.Add(this.chkCork);
            this.grpCounty.Controls.Add(this.chkKerry);
            this.grpCounty.Location = new System.Drawing.Point(25, 390);
            this.grpCounty.Margin = new System.Windows.Forms.Padding(4);
            this.grpCounty.Name = "grpCounty";
            this.grpCounty.Padding = new System.Windows.Forms.Padding(4);
            this.grpCounty.Size = new System.Drawing.Size(267, 123);
            this.grpCounty.TabIndex = 20;
            this.grpCounty.TabStop = false;
            this.grpCounty.Text = "County";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(350, 580);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(224, 65);
            this.btnReg.TabIndex = 21;
            this.btnReg.Text = "Register";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(867, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(137, 47);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(86, 263);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(242, 22);
            this.txtStreet.TabIndex = 43;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(22, 263);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(46, 17);
            this.lblStreet.TabIndex = 42;
            this.lblStreet.Text = "Street";
            // 
            // frmSuppReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 654);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.grpCounty);
            this.Controls.Add(this.txtTownVillage);
            this.Controls.Add(this.lblTownVill);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.lblSuppName);
            this.Controls.Add(this.cboSuppliers);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuppReg";
            this.Text = "Register Supplier";
            this.Load += new System.EventHandler(this.frmSuppReg_Load);
            this.grpCounty.ResumeLayout(false);
            this.grpCounty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSuppliers;
        private System.Windows.Forms.Label lblSuppName;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTownVill;
        private System.Windows.Forms.TextBox txtTownVillage;
        private System.Windows.Forms.CheckBox chkLim;
        private System.Windows.Forms.CheckBox chkKerry;
        private System.Windows.Forms.CheckBox chkCork;
        private System.Windows.Forms.GroupBox grpCounty;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
    }
}

