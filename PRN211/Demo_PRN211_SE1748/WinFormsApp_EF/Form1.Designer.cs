namespace WinFormsApp_EF
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
            dgProducts = new DataGridView();
            cboCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtImage = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnDelete = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnReset = new Button();
            btnSearch = new Button();
            btnSortByPrice = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            SuspendLayout();
            // 
            // dgProducts
            // 
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Location = new Point(12, 212);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersWidth = 51;
            dgProducts.RowTemplate.Height = 29;
            dgProducts.Size = new Size(737, 292);
            dgProducts.TabIndex = 0;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(523, 106);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(151, 28);
            cboCategory.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 12);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 56);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(425, 16);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 56);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 5;
            label4.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(421, 114);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 6;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 100);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 7;
            label6.Text = "Image";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(90, 6);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(90, 49);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(90, 93);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(125, 27);
            txtImage.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(523, 9);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 11;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(523, 56);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(147, 177);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 177);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(276, 177);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(396, 177);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(247, 49);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSortByPrice
            // 
            btnSortByPrice.Location = new Point(513, 177);
            btnSortByPrice.Name = "btnSortByPrice";
            btnSortByPrice.Size = new Size(125, 29);
            btnSortByPrice.TabIndex = 18;
            btnSortByPrice.Text = "Sort By Price";
            btnSortByPrice.UseVisualStyleBackColor = true;
            btnSortByPrice.Click += btnSortByPrice_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(655, 177);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 507);
            Controls.Add(btnExit);
            Controls.Add(btnSortByPrice);
            Controls.Add(btnSearch);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtImage);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboCategory);
            Controls.Add(dgProducts);
            Name = "Form1";
            Text = "Product";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProducts;
        private ComboBox cboCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtImage;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnReset;
        private Button btnSearch;
        private Button btnSortByPrice;
        private Button btnExit;
    }
}
