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
    public partial class AddProductForm : Form
    {
        private Product newProduct = new Product();

        public AddProductForm()
        {
            InitializeComponent();

            textBoxID.Text = Convert.ToString(Inventory.lastProductID + 1);

            dataGridViewAllParts.DataSource = Inventory.AllParts;
            dataGridViewAllParts.ReadOnly = true;
            dataGridViewAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllParts.MultiSelect = false;

            dataGridViewAssParts.DataSource = newProduct.AssociatedParts;
            dataGridViewAssParts.ReadOnly = true;
            dataGridViewAssParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssParts.MultiSelect = false;
        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Part selectedPart = dataGridViewAllParts.CurrentRow.DataBoundItem as Part;

            if (!newProduct.AssociatedParts.Contains(selectedPart))
            {
                newProduct.AddAssociatedPart(selectedPart);
            }
            else
            {
                MessageBox.Show("This part is already associated with the product.", "Duplicate Part", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult isDelete = MessageBox.Show("Are you sure you want to dissociate this part from the product?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isDelete == DialogResult.Yes)
            {
                Part selectedPart = dataGridViewAssParts.CurrentRow.DataBoundItem as Part;
                newProduct.RemoveAssociatedPart(selectedPart.PartID);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                newProduct.Name = textBoxName.Text;
                newProduct.Instock = Convert.ToInt32(textBoxInventory.Text);
                newProduct.Price = Convert.ToDecimal(textBoxPrice.Text);
                newProduct.Max = Convert.ToInt32(textBoxMax.Text);
                newProduct.Min = Convert.ToInt32(textBoxMin.Text);

                if(newProduct.Instock < 0 || newProduct.Price < 0 || newProduct.Min < 0 || newProduct.Max < 0)
                {
                    MessageBox.Show("Negative values are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newProduct.Min >= newProduct.Max)
                {
                    MessageBox.Show("Min should be less than Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newProduct.Instock < newProduct.Min || newProduct.Instock > newProduct.Max)
                {
                    MessageBox.Show("Inventory should be between Min and Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Inventory.AddProduct(newProduct);

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

        private void buttonSearchPart_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchPart.Text.Trim();
            bool isFound = false;

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridViewAllParts.Rows)
                {
                    Part part = row.DataBoundItem as Part;

                    if (part != null && part.Name.Contains(searchText))
                    {
                        row.Selected = true;
                        dataGridViewAllParts.FirstDisplayedScrollingRowIndex = row.Index;

                        isFound = true;

                        break;
                    }
                }
            }

            if (!isFound)
            {
                MessageBox.Show("No matching part found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
