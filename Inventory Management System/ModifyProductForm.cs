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
    public partial class ModifyProductForm : Form
    {
        private Product selectedProduct;

        public ModifyProductForm(Product selectedProduct)
        {
            InitializeComponent();

            this.selectedProduct = selectedProduct;

            textBoxID.Text = selectedProduct.ProductID.ToString();
            textBoxName.Text = selectedProduct.Name;
            textBoxInventory.Text = selectedProduct.Instock.ToString();
            textBoxPrice.Text = selectedProduct.Price.ToString();
            textBoxMax.Text = selectedProduct.Max.ToString();
            textBoxMin.Text = selectedProduct.Min.ToString();

            dataGridViewAllParts.DataSource = Inventory.AllParts;
            dataGridViewAllParts.ReadOnly = true;
            dataGridViewAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAllParts.MultiSelect = false;

            dataGridViewAssocParts.DataSource = selectedProduct.AssociatedParts;
            dataGridViewAssocParts.ReadOnly = true;
            dataGridViewAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAssocParts.MultiSelect = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Part selectedPart = dataGridViewAllParts.CurrentRow.DataBoundItem as Part;

            if (!selectedProduct.AssociatedParts.Contains(selectedPart))
            {
                selectedProduct.AddAssociatedPart(selectedPart);
            }
            else
            {
                MessageBox.Show("This part is already associated with the product.", "Duplicate Part", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssocParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult isDelete = MessageBox.Show("Are you sure you want to dissociate this part from the product?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (isDelete == DialogResult.Yes)
            {
                Part selectedPart = dataGridViewAssocParts.CurrentRow.DataBoundItem as Part;
                selectedProduct.RemoveAssociatedPart(selectedPart.PartID);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                selectedProduct.Name = textBoxName.Text;
                selectedProduct.Instock = Convert.ToInt32(textBoxInventory.Text);
                selectedProduct.Price = Convert.ToDecimal(textBoxPrice.Text);
                selectedProduct.Max = Convert.ToInt32(textBoxMax.Text);
                selectedProduct.Min = Convert.ToInt32(textBoxMin.Text);

                if (selectedProduct.Instock < 0 || selectedProduct.Price < 0 || selectedProduct.Min < 0 || selectedProduct.Max < 0)
                {
                    MessageBox.Show("Negative values are not allowed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedProduct.Min >= selectedProduct.Max)
                {
                    MessageBox.Show("Min should be less than Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (selectedProduct.Instock < selectedProduct.Min || selectedProduct.Instock > selectedProduct.Max)
                {
                    MessageBox.Show("Inventory should be between Min and Max.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Inventory.UpdateProduct(selectedProduct.ProductID, selectedProduct);

                Close();
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
            Close();
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
