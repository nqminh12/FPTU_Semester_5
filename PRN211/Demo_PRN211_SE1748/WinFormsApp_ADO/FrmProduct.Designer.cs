namespace WinFormsApp_ADO
{
    partial class FrmProduct
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
            dgProduct = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtImage = new TextBox();
            txtUnitPrice = new TextBox();
            txtUnitsInStock = new TextBox();
            txtName = new TextBox();
            cbCategoryId = new ComboBox();
            dgCategories = new DataGridView();
            label7 = new Label();
            label8 = new Label();
            txtCategoryID = new TextBox();
            txtCategoryName = new TextBox();
            btnAddC = new Button();
            btnUpdateC = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgCategories).BeginInit();
            SuspendLayout();
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(26, 314);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 51;
            dgProduct.RowTemplate.Height = 29;
            dgProduct.Size = new Size(762, 231);
            dgProduct.TabIndex = 1;
            dgProduct.CellClick += dgProduct_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 239);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(363, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(945, 516);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 239);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1067, 516);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 7;
            label1.Text = "ProductId:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 87);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 8;
            label2.Text = "UnitPrice:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 156);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 9;
            label3.Text = "Image:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(436, 26);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 10;
            label4.Text = "ProductName:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 91);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 11;
            label5.Text = "UnitsInStock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(436, 156);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 12;
            label6.Text = "CategoryId:";
            // 
            // txtId
            // 
            txtId.Location = new Point(128, 19);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(157, 27);
            txtId.TabIndex = 13;
            // 
            // txtImage
            // 
            txtImage.Location = new Point(128, 149);
            txtImage.Name = "txtImage";
            txtImage.Size = new Size(157, 27);
            txtImage.TabIndex = 14;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(128, 84);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(157, 27);
            txtUnitPrice.TabIndex = 15;
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(555, 84);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(152, 27);
            txtUnitsInStock.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Location = new Point(555, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(152, 27);
            txtName.TabIndex = 18;
            // 
            // cbCategoryId
            // 
            cbCategoryId.AutoCompleteCustomSource.AddRange(new string[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            cbCategoryId.BackColor = SystemColors.Window;
            cbCategoryId.FormattingEnabled = true;
            cbCategoryId.Location = new Point(556, 148);
            cbCategoryId.Name = "cbCategoryId";
            cbCategoryId.Size = new Size(151, 28);
            cbCategoryId.TabIndex = 19;
            // 
            // dgCategories
            // 
            dgCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCategories.Location = new Point(822, 228);
            dgCategories.Name = "dgCategories";
            dgCategories.RowHeadersWidth = 51;
            dgCategories.RowTemplate.Height = 29;
            dgCategories.Size = new Size(328, 199);
            dgCategories.TabIndex = 20;
            dgCategories.CellClick += dgCategories_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(814, 26);
            label7.Name = "label7";
            label7.Size = new Size(87, 20);
            label7.TabIndex = 21;
            label7.Text = "CategoryID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(814, 91);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 22;
            label8.Text = "CategoryName:";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(945, 23);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.ReadOnly = true;
            txtCategoryID.Size = new Size(205, 27);
            txtCategoryID.TabIndex = 23;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(945, 88);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(205, 27);
            txtCategoryName.TabIndex = 24;
            // 
            // btnAddC
            // 
            btnAddC.Location = new Point(814, 156);
            btnAddC.Name = "btnAddC";
            btnAddC.Size = new Size(75, 42);
            btnAddC.TabIndex = 25;
            btnAddC.Text = "Add";
            btnAddC.UseVisualStyleBackColor = true;
            btnAddC.Click += btnAddC_Click;
            // 
            // btnUpdateC
            // 
            btnUpdateC.Location = new Point(1067, 156);
            btnUpdateC.Name = "btnUpdateC";
            btnUpdateC.Size = new Size(75, 42);
            btnUpdateC.TabIndex = 26;
            btnUpdateC.Text = "Update";
            btnUpdateC.UseVisualStyleBackColor = true;
            btnUpdateC.Click += btnUpdateC_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 557);
            Controls.Add(btnUpdateC);
            Controls.Add(btnAddC);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryID);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dgCategories);
            Controls.Add(cbCategoryId);
            Controls.Add(txtName);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtImage);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgProduct);
            Name = "FrmProduct";
            Text = "FrmProduct";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduct;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnReset;
        private Button btnDelete;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtId;
        private TextBox txtImage;
        private TextBox txtUnitPrice;
        private TextBox txtUnitsInStock;
        private TextBox txtName;
        private ComboBox cbCategoryId;
        private DataGridView dgCategories;
        private Label label7;
        private Label label8;
        private TextBox txtCategoryID;
        private TextBox txtCategoryName;
        private Button btnAddC;
        private Button btnUpdateC;
    }
}