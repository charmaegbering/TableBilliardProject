using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilyaranBusinessLayer;

namespace FormsBilliard
{
    public partial class AddPTForm : Form
    {
        private BilyaranBLServices bilyaranBL = new BilyaranBLServices();
        public AddPTForm()
        {
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            int tableNumber, paymentOne, paymentTwo;
            string playerOne = tb_playerone.Text.Trim();
            string playerTwo = tb_playertwo.Text.Trim();

            if (int.TryParse(tb_tnumber.Text, out tableNumber) &&
                int.TryParse(tb_onepayment.Text, out paymentOne) &&
                int.TryParse(tb_twopayment.Text, out paymentTwo))
            {

                if (!string.IsNullOrEmpty(playerOne) && !string.IsNullOrEmpty(playerTwo))
                {
                    bool with = bilyaranBL.AddPlayerToTable(tableNumber, playerOne, playerTwo);
                    if (with)
                    {
                        bilyaranBL.UpdatePayment(tableNumber, playerOne, paymentOne);
                        bilyaranBL.UpdatePayment(tableNumber, playerTwo, paymentTwo);
                        MessageBox.Show("Players added successfully.", "SUCESSFUL!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add players. Please check the input and try again.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter both PLAYERS NAME", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Table Number and Payments.", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


