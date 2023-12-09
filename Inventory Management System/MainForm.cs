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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridViewParts.DataSource = Inventory.AllParts;
            dataGridViewParts.ReadOnly = true;
            dataGridViewParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewParts.MultiSelect = false;

            dataGridViewProducts.DataSource = Inventory.Products;
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.MultiSelect = false;
        }

        private void buttonAddPart_Click(object sender, EventArgs e)
        {
            AddPartForm addPartForm = new AddPartForm();
            addPartForm.Show();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void buttonModifyPart_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Part selectedPart = dataGridViewParts.CurrentRow.DataBoundItem as Part;

            ModifyPartForm modifyPartForm = new ModifyPartForm(selectedPart);
            modifyPartForm.Show();
        }

        private void buttonModifyProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Product selectedPart = dataGridViewProducts.CurrentRow.DataBoundItem as Product;

            ModifyProductForm modifyProductForm = new ModifyProductForm(selectedPart);
            modifyProductForm.Show();
        }

        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            if (dataGridViewParts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult isDelete = MessageBox.Show("Are you sure you want to delete this part?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isDelete == DialogResult.Yes)
            {
                Part selectedPart = dataGridViewParts.CurrentRow.DataBoundItem as Part;
                Inventory.DeletePart(selectedPart);
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please make a selection.", "Nothing Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult isDelete = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isDelete == DialogResult.Yes)
            {
                Product selectedProduct = dataGridViewProducts.CurrentRow.DataBoundItem as Product;

                if (selectedProduct.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Cannot delete a product with associated parts.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Inventory.RemoveProduct(selectedProduct.ProductID);
            }
        }

        private void buttonSearchPart_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchPart.Text.Trim();
            bool isFound = false;

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridViewParts.Rows)
                {
                    Part part = row.DataBoundItem as Part;

                    if (part != null && part.Name.Contains(searchText))
                    {
                        row.Selected = true;
                        dataGridViewParts.FirstDisplayedScrollingRowIndex = row.Index;

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

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearchProduct.Text.Trim();
            bool isFound = false;

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                {
                    Product part = row.DataBoundItem as Product;

                    if (part != null && part.Name.Contains(searchText))
                    {
                        row.Selected = true;
                        dataGridViewProducts.FirstDisplayedScrollingRowIndex = row.Index;

                        isFound = true;

                        break;
                    }
                }
            }

            if (!isFound)
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
