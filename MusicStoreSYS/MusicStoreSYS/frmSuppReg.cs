using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreSYS
{
    public partial class frmSuppReg : Form
    {
        public frmSuppReg()
        {
            InitializeComponent();
        }

        private void cboSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpGender.Visible = true;
        }

        private void chkLim_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if(cb.CheckState == CheckState.Checked)
            {
                checkboxSelect(cb.Name);
            }
        }

        private void checkboxSelect(String selectedCB)
        {
            foreach(Control ctrl in grpCounty.Controls)
            { 
                if(ctrl.Name != selectedCB)
                {
                    CheckBox cb = (CheckBox)ctrl;
                    cb.Checked = false;
                }


            }



      }

        private void btnReg_Click(object sender, EventArgs e)
        {

            if(Equals(""))
            {
                MessageBox.Show("Field not entered! This email must be entered!", "Supplier Confirmation", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;

            }

            if(cboSuppliers.Equals(""))
            {
                MessageBox.Show("No Supplier selected! Please select a Supplier!", "Supplier Confirmation", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return;
            }

            if(txtEmail.Text.Equals(""))
            {
                MessageBox.Show("No email detected! This email must be entered!", "Supplier Confirmation", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                txtEmail.Focus();
                return;

            }



            if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("No phone number detected! This phone number must be entered!", "Supplier Confirmation", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
                txtPhoneNo.Focus();
                return;

            }

            //Set Default Values
            float accBal = 0;
            String A, U;

            //Save Data in Supplier File

            //Display confirmation message

            MessageBox.Show("Supplier is now added!", "Supplier Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            return;

            //Reset UI
          
            txtEmail.Clear();
            txtPhoneNo.Clear();
            txtTownVillage.Clear();
        }

        private void frmSuppReg_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
