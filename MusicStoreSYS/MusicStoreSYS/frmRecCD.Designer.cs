namespace MusicStoreSYS
{
    partial class frmRecCD
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
            this.cboSuppliersPreOrder = new System.Windows.Forms.ComboBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnSelSupplier = new System.Windows.Forms.Button();
            this.grpDeliverCD = new System.Windows.Forms.GroupBox();
            this.btnExitRecOrder = new System.Windows.Forms.Button();
            this.grpDeliverCD.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSuppliersPreOrder
            // 
            this.cboSuppliersPreOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuppliersPreOrder.FormattingEnabled = true;
            this.cboSuppliersPreOrder.Items.AddRange(new object[] {
            "003 Adams",
            "007 Flowers",
            "010 Kelly",
            "004 Walsh"});
            this.cboSuppliersPreOrder.Location = new System.Drawing.Point(23, 96);
            this.cboSuppliersPreOrder.Name = "cboSuppliersPreOrder";
            this.cboSuppliersPreOrder.Size = new System.Drawing.Size(121, 21);
            this.cboSuppliersPreOrder.TabIndex = 1;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(20, 53);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(155, 13);
            this.lblDelivery.TabIndex = 2;
            this.lblDelivery.Text = "Select Supplier for CD Delivery:";
            this.lblDelivery.Click += new System.EventHandler(this.lblDelivery_Click);
            // 
            // btnSelSupplier
            // 
            this.btnSelSupplier.Location = new System.Drawing.Point(5, 243);
            this.btnSelSupplier.Name = "btnSelSupplier";
            this.btnSelSupplier.Size = new System.Drawing.Size(334, 113);
            this.btnSelSupplier.TabIndex = 3;
            this.btnSelSupplier.Text = "Prepare for Delivery";
            this.btnSelSupplier.UseVisualStyleBackColor = true;
            // 
            // grpDeliverCD
            // 
            this.grpDeliverCD.Controls.Add(this.lblDelivery);
            this.grpDeliverCD.Controls.Add(this.cboSuppliersPreOrder);
            this.grpDeliverCD.Location = new System.Drawing.Point(5, 51);
            this.grpDeliverCD.Name = "grpDeliverCD";
            this.grpDeliverCD.Size = new System.Drawing.Size(285, 142);
            this.grpDeliverCD.TabIndex = 4;
            this.grpDeliverCD.TabStop = false;
            this.grpDeliverCD.Text = "Delivering CD for receiving pre-order";
            // 
            // btnExitRecOrder
            // 
            this.btnExitRecOrder.Location = new System.Drawing.Point(523, 0);
            this.btnExitRecOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitRecOrder.Name = "btnExitRecOrder";
            this.btnExitRecOrder.Size = new System.Drawing.Size(87, 28);
            this.btnExitRecOrder.TabIndex = 21;
            this.btnExitRecOrder.Text = "Exit";
            this.btnExitRecOrder.UseVisualStyleBackColor = true;
            // 
            // frmRecCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 457);
            this.Controls.Add(this.btnExitRecOrder);
            this.Controls.Add(this.grpDeliverCD);
            this.Controls.Add(this.btnSelSupplier);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmRecCD";
            this.Text = "Receiving CD Order";
            this.grpDeliverCD.ResumeLayout(false);
            this.grpDeliverCD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSuppliersPreOrder;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Button btnSelSupplier;
        private System.Windows.Forms.GroupBox grpDeliverCD;
        private System.Windows.Forms.Button btnExitRecOrder;
    }
}