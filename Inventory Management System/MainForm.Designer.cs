namespace Inventory_Management_System
{
    partial class MainForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSearchPart = new System.Windows.Forms.Button();
            this.textBoxSearchPart = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonModifyPart = new System.Windows.Forms.Button();
            this.buttonDeletePart = new System.Windows.Forms.Button();
            this.labelParts = new System.Windows.Forms.Label();
            this.labelProducts = new System.Windows.Forms.Label();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonModifyProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Inventory Management System";
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
            this.buttonAddPart.Location = new System.Drawing.Point(190, 204);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPart.TabIndex = 4;
            this.buttonAddPart.Text = "Add";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.buttonAddPart_Click);
            // 
            // buttonModifyPart
            // 
            this.buttonModifyPart.Location = new System.Drawing.Point(271, 204);
            this.buttonModifyPart.Name = "buttonModifyPart";
            this.buttonModifyPart.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyPart.TabIndex = 5;
            this.buttonModifyPart.Text = "Modify";
            this.buttonModifyPart.UseVisualStyleBackColor = true;
            this.buttonModifyPart.Click += new System.EventHandler(this.buttonModifyPart_Click);
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.Location = new System.Drawing.Point(352, 204);
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(75, 23);
            this.buttonDeletePart.TabIndex = 6;
            this.buttonDeletePart.Text = "Delete";
            this.buttonDeletePart.UseVisualStyleBackColor = true;
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParts.Location = new System.Drawing.Point(0, 4);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(41, 17);
            this.labelParts.TabIndex = 7;
            this.labelParts.Text = "Parts";
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(0, 5);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(64, 17);
            this.labelProducts.TabIndex = 14;
            this.labelProducts.Text = "Products";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(352, 205);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteProduct.TabIndex = 13;
            this.buttonDeleteProduct.Text = "Delete";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonModifyProduct
            // 
            this.buttonModifyProduct.Location = new System.Drawing.Point(271, 205);
            this.buttonModifyProduct.Name = "buttonModifyProduct";
            this.buttonModifyProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonModifyProduct.TabIndex = 12;
            this.buttonModifyProduct.Text = "Modify";
            this.buttonModifyProduct.UseVisualStyleBackColor = true;
            this.buttonModifyProduct.Click += new System.EventHandler(this.buttonModifyProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(190, 205);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonAddProduct.TabIndex = 11;
            this.buttonAddProduct.Text = "Add";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(327, 4);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearchProduct.TabIndex = 10;
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Location = new System.Drawing.Point(246, 2);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchProduct.TabIndex = 9;
            this.buttonSearchProduct.Text = "Search";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            this.buttonSearchProduct.Click += new System.EventHandler(this.buttonSearchProduct_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExit.Location = new System.Drawing.Point(805, 275);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewParts);
            this.panel1.Controls.Add(this.buttonSearchPart);
            this.panel1.Controls.Add(this.textBoxSearchPart);
            this.panel1.Controls.Add(this.buttonAddPart);
            this.panel1.Controls.Add(this.buttonModifyPart);
            this.panel1.Controls.Add(this.buttonDeletePart);
            this.panel1.Controls.Add(this.labelParts);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 243);
            this.panel1.TabIndex = 16;
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.Size = new System.Drawing.Size(424, 167);
            this.dataGridViewParts.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewProducts);
            this.panel2.Controls.Add(this.buttonSearchProduct);
            this.panel2.Controls.Add(this.textBoxSearchProduct);
            this.panel2.Controls.Add(this.labelProducts);
            this.panel2.Controls.Add(this.buttonAddProduct);
            this.panel2.Controls.Add(this.buttonDeleteProduct);
            this.panel2.Controls.Add(this.buttonModifyProduct);
            this.panel2.Location = new System.Drawing.Point(452, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 243);
            this.panel2.TabIndex = 17;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(422, 167);
            this.dataGridViewProducts.TabIndex = 15;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(899, 249);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.labelTitle);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.buttonExit);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(905, 301);
            this.flowLayoutPanel2.TabIndex = 19;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(907, 586);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(923, 625);
            this.MinimumSize = new System.Drawing.Size(470, 375);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSearchPart;
        private System.Windows.Forms.TextBox textBoxSearchPart;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.Button buttonModifyPart;
        private System.Windows.Forms.Button buttonDeletePart;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonModifyProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewParts;
    }
}

