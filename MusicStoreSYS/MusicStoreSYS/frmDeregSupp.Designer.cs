namespace MusicStoreSYS
{
    partial class frmDeregSupp
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
            this.lblDeregSuppName = new System.Windows.Forms.Label();
            this.cboDeregSuppliers = new System.Windows.Forms.ComboBox();
            this.lblDeregTownVill = new System.Windows.Forms.Label();
            this.lblDeregEmail = new System.Windows.Forms.Label();
            this.lblDeregPhoneNo = new System.Windows.Forms.Label();
            this.lblDeregDOB = new System.Windows.Forms.Label();
            this.btnExitDeregSupp = new System.Windows.Forms.Button();
            this.grpDeregCounty = new System.Windows.Forms.GroupBox();
            this.chkDeregLim = new System.Windows.Forms.CheckBox();
            this.chkDeregCork = new System.Windows.Forms.CheckBox();
            this.chkDeregKerry = new System.Windows.Forms.CheckBox();
            this.txtUpdTownVillage = new System.Windows.Forms.TextBox();
            this.txtUpdEmail = new System.Windows.Forms.TextBox();
            this.txtUpdPhoneNo = new System.Windows.Forms.TextBox();
            this.dtpUpdDOB = new System.Windows.Forms.DateTimePicker();
            this.txtSuppID = new System.Windows.Forms.TextBox();
            this.lblDeregSuppID = new System.Windows.Forms.Label();
            this.btnDereg = new System.Windows.Forms.Button();
            this.grpDeregCounty.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeregSuppName
            // 
            this.lblDeregSuppName.AutoSize = true;
            this.lblDeregSuppName.Location = new System.Drawing.Point(7, 20);
            this.lblDeregSuppName.Name = "lblDeregSuppName";
            this.lblDeregSuppName.Size = new System.Drawing.Size(90, 13);
            this.lblDeregSuppName.TabIndex = 3;
            this.lblDeregSuppName.Text = "Deselect Supplier";
            // 
            // cboDeregSuppliers
            // 
            this.cboDeregSuppliers.FormattingEnabled = true;
            this.cboDeregSuppliers.Items.AddRange(new object[] {
            "003 Adams",
            "007 Flowers",
            "010 Kelly",
            "004 Walsh"});
            this.cboDeregSuppliers.Location = new System.Drawing.Point(103, 17);
            this.cboDeregSuppliers.Name = "cboDeregSuppliers";
            this.cboDeregSuppliers.Size = new System.Drawing.Size(121, 21);
            this.cboDeregSuppliers.TabIndex = 2;
            // 
            // lblDeregTownVill
            // 
            this.lblDeregTownVill.AutoSize = true;
            this.lblDeregTownVill.Location = new System.Drawing.Point(12, 288);
            this.lblDeregTownVill.Name = "lblDeregTownVill";
            this.lblDeregTownVill.Size = new System.Drawing.Size(70, 13);
            this.lblDeregTownVill.TabIndex = 18;
            this.lblDeregTownVill.Text = "Town/Village";
            // 
            // lblDeregEmail
            // 
            this.lblDeregEmail.AutoSize = true;
            this.lblDeregEmail.Location = new System.Drawing.Point(12, 230);
            this.lblDeregEmail.Name = "lblDeregEmail";
            this.lblDeregEmail.Size = new System.Drawing.Size(32, 13);
            this.lblDeregEmail.TabIndex = 17;
            this.lblDeregEmail.Text = "Email";
            // 
            // lblDeregPhoneNo
            // 
            this.lblDeregPhoneNo.AutoSize = true;
            this.lblDeregPhoneNo.Location = new System.Drawing.Point(6, 183);
            this.lblDeregPhoneNo.Name = "lblDeregPhoneNo";
            this.lblDeregPhoneNo.Size = new System.Drawing.Size(78, 13);
            this.lblDeregPhoneNo.TabIndex = 16;
            this.lblDeregPhoneNo.Text = "Phone Number";
            // 
            // lblDeregDOB
            // 
            this.lblDeregDOB.AutoSize = true;
            this.lblDeregDOB.Location = new System.Drawing.Point(7, 123);
            this.lblDeregDOB.Name = "lblDeregDOB";
            this.lblDeregDOB.Size = new System.Drawing.Size(68, 13);
            this.lblDeregDOB.TabIndex = 15;
            this.lblDeregDOB.Text = "Date Of Birth";
            // 
            // btnExitDeregSupp
            // 
            this.btnExitDeregSupp.Location = new System.Drawing.Point(383, 5);
            this.btnExitDeregSupp.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitDeregSupp.Name = "btnExitDeregSupp";
            this.btnExitDeregSupp.Size = new System.Drawing.Size(87, 28);
            this.btnExitDeregSupp.TabIndex = 20;
            this.btnExitDeregSupp.Text = "Exit";
            this.btnExitDeregSupp.UseVisualStyleBackColor = true;
            // 
            // grpDeregCounty
            // 
            this.grpDeregCounty.Controls.Add(this.chkDeregLim);
            this.grpDeregCounty.Controls.Add(this.chkDeregCork);
            this.grpDeregCounty.Controls.Add(this.chkDeregKerry);
            this.grpDeregCounty.Location = new System.Drawing.Point(9, 327);
            this.grpDeregCounty.Name = "grpDeregCounty";
            this.grpDeregCounty.Size = new System.Drawing.Size(200, 100);
            this.grpDeregCounty.TabIndex = 43;
            this.grpDeregCounty.TabStop = false;
            this.grpDeregCounty.Text = "County";
            // 
            // chkDeregLim
            // 
            this.chkDeregLim.AutoSize = true;
            this.chkDeregLim.Checked = true;
            this.chkDeregLim.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDeregLim.Location = new System.Drawing.Point(31, 28);
            this.chkDeregLim.Name = "chkDeregLim";
            this.chkDeregLim.Size = new System.Drawing.Size(65, 17);
            this.chkDeregLim.TabIndex = 17;
            this.chkDeregLim.Text = "Limerick";
            this.chkDeregLim.UseVisualStyleBackColor = true;
            // 
            // chkDeregCork
            // 
            this.chkDeregCork.AutoSize = true;
            this.chkDeregCork.Location = new System.Drawing.Point(127, 28);
            this.chkDeregCork.Name = "chkDeregCork";
            this.chkDeregCork.Size = new System.Drawing.Size(48, 17);
            this.chkDeregCork.TabIndex = 19;
            this.chkDeregCork.Text = "Cork";
            this.chkDeregCork.UseVisualStyleBackColor = true;
            // 
            // chkDeregKerry
            // 
            this.chkDeregKerry.AutoSize = true;
            this.chkDeregKerry.Location = new System.Drawing.Point(31, 69);
            this.chkDeregKerry.Name = "chkDeregKerry";
            this.chkDeregKerry.Size = new System.Drawing.Size(50, 17);
            this.chkDeregKerry.TabIndex = 18;
            this.chkDeregKerry.Text = "Kerry";
            this.chkDeregKerry.UseVisualStyleBackColor = true;
            // 
            // txtUpdTownVillage
            // 
            this.txtUpdTownVillage.Location = new System.Drawing.Point(113, 288);
            this.txtUpdTownVillage.Name = "txtUpdTownVillage";
            this.txtUpdTownVillage.Size = new System.Drawing.Size(121, 20);
            this.txtUpdTownVillage.TabIndex = 42;
            // 
            // txtUpdEmail
            // 
            this.txtUpdEmail.Location = new System.Drawing.Point(103, 230);
            this.txtUpdEmail.Name = "txtUpdEmail";
            this.txtUpdEmail.Size = new System.Drawing.Size(182, 20);
            this.txtUpdEmail.TabIndex = 40;
            // 
            // txtUpdPhoneNo
            // 
            this.txtUpdPhoneNo.Location = new System.Drawing.Point(136, 183);
            this.txtUpdPhoneNo.Name = "txtUpdPhoneNo";
            this.txtUpdPhoneNo.Size = new System.Drawing.Size(136, 20);
            this.txtUpdPhoneNo.TabIndex = 38;
            // 
            // dtpUpdDOB
            // 
            this.dtpUpdDOB.Location = new System.Drawing.Point(113, 123);
            this.dtpUpdDOB.MaxDate = new System.DateTime(2049, 12, 31, 0, 0, 0, 0);
            this.dtpUpdDOB.Name = "dtpUpdDOB";
            this.dtpUpdDOB.Size = new System.Drawing.Size(200, 20);
            this.dtpUpdDOB.TabIndex = 35;
            this.dtpUpdDOB.Value = new System.DateTime(2017, 10, 6, 0, 0, 0, 0);
            // 
            // txtSuppID
            // 
            this.txtSuppID.Location = new System.Drawing.Point(76, 73);
            this.txtSuppID.Name = "txtSuppID";
            this.txtSuppID.Size = new System.Drawing.Size(67, 20);
            this.txtSuppID.TabIndex = 45;
            // 
            // lblDeregSuppID
            // 
            this.lblDeregSuppID.AutoSize = true;
            this.lblDeregSuppID.Location = new System.Drawing.Point(11, 76);
            this.lblDeregSuppID.Name = "lblDeregSuppID";
            this.lblDeregSuppID.Size = new System.Drawing.Size(46, 13);
            this.lblDeregSuppID.TabIndex = 44;
            this.lblDeregSuppID.Text = "Supp ID";
            // 
            // btnDereg
            // 
            this.btnDereg.Location = new System.Drawing.Point(158, 476);
            this.btnDereg.Name = "btnDereg";
            this.btnDereg.Size = new System.Drawing.Size(204, 70);
            this.btnDereg.TabIndex = 46;
            this.btnDereg.Text = "Deregister";
            this.btnDereg.UseVisualStyleBackColor = true;
            // 
            // frmDeregSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 548);
            this.Controls.Add(this.btnDereg);
            this.Controls.Add(this.txtSuppID);
            this.Controls.Add(this.lblDeregSuppID);
            this.Controls.Add(this.grpDeregCounty);
            this.Controls.Add(this.txtUpdTownVillage);
            this.Controls.Add(this.txtUpdEmail);
            this.Controls.Add(this.txtUpdPhoneNo);
            this.Controls.Add(this.dtpUpdDOB);
            this.Controls.Add(this.btnExitDeregSupp);
            this.Controls.Add(this.lblDeregTownVill);
            this.Controls.Add(this.lblDeregEmail);
            this.Controls.Add(this.lblDeregPhoneNo);
            this.Controls.Add(this.lblDeregDOB);
            this.Controls.Add(this.lblDeregSuppName);
            this.Controls.Add(this.cboDeregSuppliers);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDeregSupp";
            this.Text = "Deregister Supplier";
            this.grpDeregCounty.ResumeLayout(false);
            this.grpDeregCounty.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeregSuppName;
        private System.Windows.Forms.ComboBox cboDeregSuppliers;
        private System.Windows.Forms.Label lblDeregTownVill;
        private System.Windows.Forms.Label lblDeregEmail;
        private System.Windows.Forms.Label lblDeregPhoneNo;
        private System.Windows.Forms.Label lblDeregDOB;
        private System.Windows.Forms.Button btnExitDeregSupp;
        private System.Windows.Forms.GroupBox grpDeregCounty;
        private System.Windows.Forms.CheckBox chkDeregLim;
        private System.Windows.Forms.CheckBox chkDeregCork;
        private System.Windows.Forms.CheckBox chkDeregKerry;
        private System.Windows.Forms.TextBox txtUpdTownVillage;
        private System.Windows.Forms.TextBox txtUpdEmail;
        private System.Windows.Forms.TextBox txtUpdPhoneNo;
        private System.Windows.Forms.DateTimePicker dtpUpdDOB;
        private System.Windows.Forms.TextBox txtSuppID;
        private System.Windows.Forms.Label lblDeregSuppID;
        private System.Windows.Forms.Button btnDereg;
    }
}