using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private void frmMenu_Load_1(object sender, EventArgs e)
        {
            lstItem.Items.Add("Pork Chop");
            lstItem.Items.Add("Chicken");
            lstItem.Items.Add("Fish");

            cboDessert.Items.Add("Chocolate Cake");
            cboDessert.Items.Add("Pumpkin Pie");
            cboDessert.Items.Add("Ice Cream");
            cboDessert.Items.Add("Cookie");

            cboSide.Items.Add("Baked Potato");
            cboSide.Items.Add("Side Salad");
            cboSide.Items.Add("Assorted Vegetables");
            cboSide.Items.Add("French Fries");

        }

        private bool IsValidData()
        {
            if (rdoEatIn.Checked)
            {
                if (lstItem.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select an item to order.", "Entry Error");
                    lstItem.Focus();
                    return false;
                }

                if (txtCookingInstructions.Text == "")
                {
                    MessageBox.Show("you must enter cooking instructions, enter NONE if you have no cooking instructions", "Entry Error");
                    txtCookingInstructions.Focus();
                    return false;
                }

                if (cboDessert.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a dessert.", "Entry Error");
                    cboDessert.Focus();
                    return false;
                }

                if (cboSide.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a side.", "Entry Error");
                    cboSide.Focus();
                    return false;
                }
            }

            if (rdoToGo.Checked)
            {
                if (lstItem.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select an item to order.", "Entry Error");
                    lstItem.Focus();
                    return false;
                }

                if (txtCookingInstructions.Text == "")
                {
                    MessageBox.Show("you must enter cooking instructions, enter NONE if you have no cooking instructions", "Entry Error");
                    txtCookingInstructions.Focus();
                    return false;
                }

                if (cboDessert.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a dessert.", "Entry Error");
                    cboDessert.Focus();
                    return false;
                }

                if (cboSide.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a side.", "Entry Error");
                    cboSide.Focus();
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            string msg = null;

            if (rdoEatIn.Checked)
            {
                msg += "Eat In Order" + "\n";
                msg += "\n";
                msg += "Food Item: " + lstItem.Text + "\n\n";
                msg += "Cooking Instructions: " + txtCookingInstructions.Text + "\n\n";
                msg += "Dessert: " + cboDessert.Text + "\n\n";
                msg += "Side: " + cboSide.Text + "\n\n";
            }

            if (rdoToGo.Checked)
            {
                msg += "To Go Order" + "\n";
                msg += "\n";
                msg += "Food Item: " + lstItem.Text + "\n\n";
                msg += "Cooking Instructions: " + txtCookingInstructions.Text + "\n\n";
                msg += "Dessert: " + cboDessert.Text + "\n\n";
                msg += "Side: " + cboSide.Text + "\n\n";
            }

            bool isDefaultOrder = chkDefault.Checked;
            msg += "Default Order: Yes ";

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }
    }
}
