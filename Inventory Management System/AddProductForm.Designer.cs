namespace Inventory_Management_System
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSearchPart = new System.Windows.Forms.Button();
            this.textBoxSearchPart = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.labelAddProductAllParts = new System.Windows.Forms.Label();
            this.dataGridViewAllParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelAddProductAssoParts = new System.Windows.Forms.Label();
            this.dataGridViewAssParts = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllParts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssParts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(145, 319);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 50;
            this.labelMin.Text = "Min";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(12, 319);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 49;
            this.labelMax.Text = "Max";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(12, 293);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 48;
            this.labelPrice.Text = "Price";
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(12, 267);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 13);
            this.labelInventory.TabIndex = 47;
            this.labelInventory.Text = "Inventory";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 241);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 46;
            this.labelName.Text = "Name";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 215);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "ID";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(175, 316);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(56, 20);
            this.textBoxMin.TabIndex = 44;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(69, 316);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(56, 20);
            this.textBoxMax.TabIndex = 43;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(69, 290);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 42;
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.Location = new System.Drawing.Point(69, 264);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(100, 20);
            this.textBoxInventory.TabIndex = 41;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(69, 238);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 40;
            // 
            // textBoxID
            // 
            this.textBoxID.CausesValidation = false;
            this.textBoxID.Location = new System.Drawing.Point(69, 212);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 39;
            this.textBoxID.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSearchPart);
            this.panel1.Controls.Add(this.textBoxSearchPart);
            this.panel1.Controls.Add(this.buttonAddPart);
            this.panel1.Controls.Add(this.labelAddProductAllParts);
            this.panel1.Controls.Add(this.dataGridViewAllParts);
            this.panel1.Location = new System.Drawing.Point(280, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 243);
            this.panel1.TabIndex = 51;
            // 
            // buttonSearchPart
            // 
            this.buttonSearchPart.Location = new System.Drawing.Point(246, 1);
            this.buttonSearchPart.Name = "buttonSearchPart";
            this.buttonSearchPart.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPart.TabIndex = 2;
            this.buttonSearchPart.Text = "Search";
            this.buttonSearchPart.UseVisualStyleBackColor = true;
            this.buttonSearchPart.Click += new System.EventHandler(this.buttonSearchPart_Click);
            // 
            // textBoxSearchPart
            // 
            this.textBoxSearchPart.Location = new System.Drawing.Point(327, 3);
            this.textBoxSearchPart.Name = "textBoxSearchPart";
            this.textBoxSearchPart.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchPart.TabIndex = 3;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(352, 204);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPart.TabIndex = 4;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // labelAddProductAllParts
            // 
            this.labelAddProductAllParts.AutoSize = true;
            this.labelAddProductAllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProductAllParts.Location = new System.Drawing.Point(0, 4);
            this.labelAddProductAllParts.Name = "labelAddProductAllParts";
            this.labelAddProductAllParts.Size = new System.Drawing.Size(94, 13);
            this.labelAddProductAllParts.TabIndex = 7;
            this.labelAddProductAllParts.Text = "All candidate parts";
            // 
            // dataGridViewAllParts
            // 
            this.dataGridViewAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllParts.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewAllParts.Name = "dataGridViewAllParts";
            this.dataGridViewAllParts.Size = new System.Drawing.Size(424, 168);
            this.dataGridViewAllParts.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.labelAddProductAssoParts);
            this.panel2.Controls.Add(this.dataGridViewAssParts);
            this.panel2.Location = new System.Drawing.Point(280, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 243);
            this.panel2.TabIndex = 52;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(352, 204);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelAddProductAssoParts
            // 
            this.labelAddProductAssoParts.AutoSize = true;
            this.labelAddProductAssoParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddProductAssoParts.Location = new System.Drawing.Point(0, 4);
            this.labelAddProductAssoParts.Name = "labelAddProductAssoParts";
            this.labelAddProductAssoParts.Size = new System.Drawing.Size(165, 13);
            this.labelAddProductAssoParts.TabIndex = 7;
            this.labelAddProductAssoParts.Text = "Parts associated with this product";
            // 
            // dataGridViewAssParts
            // 
            this.dataGridViewAssParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssParts.Location = new System.Drawing.Point(4, 30);
            this.dataGridViewAssParts.Name = "dataGridViewAssParts";
            this.dataGridViewAssParts.Size = new System.Drawing.Size(424, 168);
            this.dataGridViewAssParts.TabIndex = 57;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(632, 537);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 54;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(545, 537);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 53;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(86, 17);
            this.labelTitle.TabIndex = 55;
            this.labelTitle.Text = "Add Product";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 576);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.MaximumSize = new System.Drawing.Size(750, 615);
            this.MinimumSize = new System.Drawing.Size(750, 615);
            this.Name = "AddProductForm";
            this.Text = "AddProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSearchPart;
        private System.Windows.Forms.TextBox textBoxSearchPart;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.Label labelAddProductAllParts;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelAddProductAssoParts;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewAllParts;
        private System.Windows.Forms.DataGridView dataGridViewAssParts;
    }
}