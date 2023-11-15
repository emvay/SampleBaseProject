namespace Training.WindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label1 = new Label();
            cmbFilterCategories = new ComboBox();
            groupBox2 = new GroupBox();
            txtProducts = new TextBox();
            label2 = new Label();
            dgvSource = new DataGridView();
            groupBox3 = new GroupBox();
            cmbProductCategory = new ComboBox();
            txtUnitPrice = new TextBox();
            label7 = new Label();
            txtQuantityPerUnit = new TextBox();
            label6 = new Label();
            txtUnitsInStock = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtProductName = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSource).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbFilterCategories);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 86);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Categories";
            // 
            // cmbFilterCategories
            // 
            cmbFilterCategories.FormattingEnabled = true;
            cmbFilterCategories.Location = new Point(95, 38);
            cmbFilterCategories.Name = "cmbFilterCategories";
            cmbFilterCategories.Size = new Size(193, 23);
            cmbFilterCategories.TabIndex = 0;
            cmbFilterCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtProducts);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(13, 105);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(775, 86);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // txtProducts
            // 
            txtProducts.Location = new Point(95, 38);
            txtProducts.Name = "txtProducts";
            txtProducts.Size = new Size(193, 23);
            txtProducts.TabIndex = 2;
            txtProducts.TextChanged += txtProducts_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 41);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Products";
            // 
            // dgvSource
            // 
            dgvSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSource.Location = new Point(14, 204);
            dgvSource.Name = "dgvSource";
            dgvSource.RowTemplate.Height = 25;
            dgvSource.Size = new Size(1318, 236);
            dgvSource.TabIndex = 3;
            dgvSource.CellClick += dgvSource_CellClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnUpdate);
            groupBox3.Controls.Add(cmbProductCategory);
            groupBox3.Controls.Add(txtUnitPrice);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtQuantityPerUnit);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtUnitsInStock);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(txtProductName);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(801, 13);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(531, 178);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Product Add";
            // 
            // cmbProductCategory
            // 
            cmbProductCategory.FormattingEnabled = true;
            cmbProductCategory.Location = new Point(108, 82);
            cmbProductCategory.Name = "cmbProductCategory";
            cmbProductCategory.Size = new Size(200, 23);
            cmbProductCategory.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(108, 118);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(105, 23);
            txtUnitPrice.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 121);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 9;
            label7.Text = "Price";
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Location = new Point(425, 81);
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Size = new Size(100, 23);
            txtQuantityPerUnit.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 86);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 7;
            label6.Text = "Quantity Per Unit";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(425, 43);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(100, 23);
            txtUnitsInStock.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 46);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "Units In Stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 84);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(108, 42);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(200, 23);
            txtProductName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(238, 118);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 54);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 45);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Name";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(425, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 54);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(333, 118);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 54);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 452);
            Controls.Add(groupBox3);
            Controls.Add(dgvSource);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSource).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox cmbFilterCategories;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtProducts;
        private DataGridView dgvSource;
        private GroupBox groupBox3;
        private Button btnAdd;
        private Label label3;
        private TextBox txtUnitPrice;
        private Label label7;
        private TextBox txtQuantityPerUnit;
        private Label label6;
        private TextBox txtUnitsInStock;
        private Label label5;
        private Label label4;
        private TextBox txtProductName;
        private ComboBox cmbProductCategory;
        private Button btnDelete;
        private Button btnUpdate;
    }
}