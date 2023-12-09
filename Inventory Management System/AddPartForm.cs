using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AddPartForm : Form
    {
        private Part newPart;

        public AddPartForm()
        {
            InitializeComponent();

            textBoxID.Text = Convert.ToString(Inventory.lastPartID + 1);
            labelCompanyName.Visible = false;
            textBoxCompanyName.Visible = false;
        }

        private void radioInHouse_Click(object sender, EventArgs e)
        {
            labelMachineID.Visible = true;
            textBoxMachineID.Visible = true;
            labelCompanyName.Visible = false;
            textBoxCompanyName.Visible = false;
        }

        private void radioOutsourced_Click(object sender, EventArgs e)
        {
            labelMachineID.Visible = false;
            textBoxMachineID.Visible = false;
            labelCompanyName.Visible = true;
            textBoxCompanyName.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                int inStock = Convert.ToInt32(textBoxInventory.Text);
                decimal price = Convert.ToDecimal(textBoxPrice.Text);
                int max = Convert.ToInt32(textBoxMax.Text);
                int min = Convert.ToInt32(textBoxMin.Text);

                if (inStock < 0 || price < 0 || min < 0 || max < 0)
                {
                    MessageBox.Show("Negative values are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (min >= max)
                {
                    MessageBox.Show("Min should be less than Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (inStock < min || inStock > max)
                {
                    MessageBox.Show("Inventory should be between Min and Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (radioInHouse.Checked)
                {
                    int machineID = Convert.ToInt32(textBoxMachineID.Text);
                    if (machineID < 0)
                    {
                        MessageBox.Show("Negative values are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    newPart = new Inhouse(0, name, price, inStock, min, max, machineID);
                }
                else if (radioOutsourced.Checked)
                {
                    string companyName = textBoxCompanyName.Text;
                    newPart = new Outsourced(0, name, price, inStock, min, max, companyName);
                }

                Inventory.AddPart(newPart);

                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
