using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Counter_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_cointsent_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {



        }

        private void entcoins_percredit_Click(object sender, EventArgs e)
        {

        }


            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }


        }


    
        private void picbox_1pence_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 
            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_1pence.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_1pence.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 1)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }


        }

     
        private void picbox_2pence_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_2pence.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_2pence.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 2)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }
        }


     
        private void picbox_5pence_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_5pence.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_5pence.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 5)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }
        }


      
        private void picbox_20pence_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_20pence.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_20pence.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 20)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }
        }


      
        private void picbox_50pence_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_50pence.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_50pence.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 50)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the Cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }
        }


        
        private void picbox_1pound_Click(object sender, EventArgs e)
        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb = Convert.ToInt32(lbl_1pound.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_1pound.Text = Convert.ToString((int)(numb + 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 100)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }
        }

      
        private void picbox_2pound_Click(object sender, EventArgs e)

        {
            int numb = 0;  //declares variable 
            int numb2 = 0;  //declares variable 

            if (Convert.ToInt32(costpercred_box.Text) > 0.0) //converts the specified integer
            {
                numb= Convert.ToInt32(lbl_2pound.Text); //converts the right lbl to integer
                numb2 = Convert.ToInt32(totalval_txtinput.Text); //converts the total value into integer
                lbl_2pound.Text = Convert.ToString((int)(numb+ 1)); //increments and adds 1 for every click
                int numb3 = Convert.ToInt32(totalval_txtinput.Text) / Convert.ToInt32(costpercred_box.Text); //converts to integer, also divides the total value by cost per credit
                numb_of_cred_box.Text = Convert.ToString(numb3); //converts number of credit into string
                totalval_txtinput.Text = Convert.ToString((int)(numb2 + 200)); //converts into string and adds the coin amount per click
                txtbox_poundinput.Text = $"{Convert.ToDouble(totalval_txtinput.Text) / 100.0:n2}"; //formats the outcome number e.g. 7000.00 will become 7,000.00

            }
            else
            {
                MessageBox.Show("You have not set the cost of a Credit!"); //message box to show user has not set a credit cost 
                costpercred_box.Focus(); //input icon will automatically go on the credit cost box
            }



        }


        private void btn_reset_Click(object sender, EventArgs e)
        {

            lbl_1pence.Text = Convert.ToString(0);
            lbl_2pence.Text = Convert.ToString(0);
            lbl_5pence.Text = Convert.ToString(0);
            lbl_10pence.Text = Convert.ToString(0);
            lbl_20pence.Text = Convert.ToString(0);
            lbl_50pence.Text = Convert.ToString(0);
            lbl_1pound.Text = Convert.ToString(0);
            lbl_2pound.Text = Convert.ToString(0);
            numb_of_cred_box.Text = Convert.ToString(0);
            costpercred_box.Text = Convert.ToString(0);
            totalval_txtinput.Text = Convert.ToString(0);
            txtbox_poundinput.Text = "0.00";

        }

    }

}

    
