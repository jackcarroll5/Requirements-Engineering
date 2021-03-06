﻿using System;
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
    public partial class frmInsNewCD : Form
    {

        frmMainMenu parent;

        public frmInsNewCD insNewCD;
        //private Func<RadioButton, bool> rad;

        public frmInsNewCD(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }




        private void btnInsert_Click(object sender, EventArgs e)
        {


            float number;
            int num;
            

            

            if (txtAlbum.Text.Equals("")) 
            {
                MessageBox.Show("No album entered! This album must be entered!", "Album Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtAlbum.Focus();
                return;

            }

          else if (txtArtist.Text.Equals(""))
            {
                MessageBox.Show("No artist entered! Please type in an artist!", "Artist Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                txtArtist.Focus();
                return;
            }

         


            else if (!float.TryParse(txtCost.Text, out number))
            {            
                if(number <= 0)               
                    MessageBox.Show("Cost is invalid! This cost field must be re-entered!", "Cost Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);            
                txtCost.Focus();
                return;                   
            }

            else if (!int.TryParse(txtQty.Text, out num))
            {
                if (num <= 0)               
                    MessageBox.Show("Quality is invalid! This quality field must be re-entered!", "Quality Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);            
                txtQty.Focus();
                return;
                  
            }

            //Set Default Values        
            String availability = "a";

            //Save Data in CD File
            MessageBox.Show("CD ID; " + txtCDID.Text + "\nAlbum: " + txtAlbum.Text + "\nArtist: " + txtArtist.Text + "\nYear Released: " + chkYr.GetItemText(chkYr.SelectedItem) + 
                "\nArtist Label: " + GetRadioButtonText(grpArtistLbl) + "\nCost Price: " + txtCost.Text + "\nQuality: " + txtQty.Text + "\nAvailabilty: " + availability , "CD Details: ", MessageBoxButtons.OK,
                MessageBoxIcon.Information); 
            

            
           //Display confirmation message

           MessageBox.Show("CD has now been added!", "CD Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);


            //Reset UI
            txtCDID.Text = "00002";
            txtAlbum.Clear();
            txtArtist.Clear();
            chkYr.ClearSelected();
            txtCost.Clear();
            txtQty.Clear();

            foreach (int i in chkYr.CheckedIndices)
            {
                chkYr.SetItemCheckState(i, CheckState.Unchecked);
            }
              return;

            }



       

        private void btnExitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void grpArtistLbl_Enter(object sender, EventArgs e)
        {

        }

        private string GetRadioButtonText(GroupBox grpArtistLabel)
        {
            return grpArtistLabel.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text;
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
