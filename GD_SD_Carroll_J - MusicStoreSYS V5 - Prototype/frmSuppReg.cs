﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStoreSYS
{
    public partial class frmSuppReg : Form
    {
        frmMainMenu parent;

        public frmSuppReg suppReg;

        public frmSuppReg()
        {
            InitializeComponent();
        }

        public frmSuppReg(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

 

        private void btnReg_Click(object sender, EventArgs e)
        {
            
    

           if(txtName.Text.Equals(""))
            {
                MessageBox.Show("No Supplier written! Please enter a Supplier!", "Supplier Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

             else if (txtPhoneNo.Text.Equals(""))
            {
                MessageBox.Show("No phone number detected! This phone number must be entered!", "Missing Phone Number", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtPhoneNo.Focus();
                return;

            }


            else if(!valEmail(txtEmail.Text))
            {
                MessageBox.Show("No email detected! This email must be entered!", "Email Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }


            else if (txtStreet.Text.Equals(""))
            {
                MessageBox.Show("No street entered! This street must be entered!", "Missing Street", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtStreet.Focus();
                return;

            }

            else if (txtTownVillage.Text.Equals(""))
            {
                MessageBox.Show("No town/village detected! This town/village must be entered!", "Missing Town/Village", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtTownVillage.Focus();
                return;

            }        



            //Set Default Values
            float accBal = 0;
            char Status = 'A';

            //Save Data in Supplier File
            MessageBox.Show("SuppID: " + txtSuppId.Text + "\nSupplier: " + txtName.Text + "\nPhone No: " +
                txtPhoneNo.Text + "\nEmail: " + txtEmail.Text + "\nStreet: " + txtStreet.Text + "\nTown/Village: " + txtTownVillage.Text + 
                "\nCounty: " + cboCounties.GetItemText(cboCounties.SelectedItem) + "\nAccount Balance: €" + accBal + "\nStatus: " + Status,  "Supplier Details", MessageBoxButtons.OK, MessageBoxIcon.Information);               

        
           
            //Display confirmation message
            MessageBox.Show("Supplier is now added!", "Supplier Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
          

            //Reset UI
            txtSuppId.Text = "012";
            txtName.Clear();          
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtStreet.Clear();
            txtTownVillage.Clear();
            cboCounties.SelectedIndex = -1;
            return;
        }

        private void frmSuppReg_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void chkCork_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkKerry_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void cboCounties_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public bool valEmail(String txtEmail)
        {
            if(Regex.IsMatch(txtEmail,@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
