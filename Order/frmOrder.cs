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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        bool isDataSaved = false;

        private void frmOrder_Load(object sender, EventArgs e)
        {
            cboTable.Items.Add("Blue");
            cboTable.Items.Add("Green");
            cboTable.Items.Add("Red");
            cboTable.Items.Add("Yellow");
            cboTable.Items.Add("Gray");
        }

        private void DataChanged(Object sender, EventArgs e)
        {
            isDataSaved = false;
        }

        private void btnSelectItem_Click_1(object sender, EventArgs e)
        {
            Form menuForm = new frmMenu();
            DialogResult selectedButton = menuForm.ShowDialog();
            if (selectedButton == DialogResult.OK)
            {
                lblOrder.Text = (string)menuForm.Tag;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SaveData();
            }
        }

        private void SaveData()
        {
            cboTable.SelectedIndex = -1;
            lblOrder.Text = "";
            isDataSaved = true;
            cboTable.Focus();
        }

        private bool IsValidData()
        {
            if (cboTable.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a table", "Entry Error");
                cboTable.Focus();
                return false;
            }
            if (lblOrder.Text == "")
            {
                MessageBox.Show("You must enter an order", "Entry Error");
                return false;
            }
            return true;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDataSaved == false)
            {
                string message =
                    "This form contains unsaved data. \n\n" +
                    "Do you want to save it?";

                DialogResult button =
                    MessageBox.Show(message, "Table",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (button == DialogResult.Yes)
                {
                    if (IsValidData())
                        this.SaveData();
                    else
                        e.Cancel = true;
                }
                if (button == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
