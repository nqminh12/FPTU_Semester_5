namespace WinFormsApp_ADO
{
    partial class FrmCustomer
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
            dgCustomer = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtAddress = new TextBox();
            txtBirthdate = new TextBox();
            txtName = new TextBox();
            rdMale = new RadioButton();
            rdFemale = new RadioButton();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            Reset = new Button();
            Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgCustomer
            // 
            dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCustomer.Location = new Point(37, 314);
            dgCustomer.Name = "dgCustomer";
            dgCustomer.RowHeadersWidth = 51;
            dgCustomer.RowTemplate.Height = 29;
            dgCustomer.Size = new Size(683, 237);
            dgCustomer.TabIndex = 0;
            dgCustomer.CellClick += dgCustomer_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 42);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 114);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "Birthdate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 42);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 110);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 186);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 5;
            label5.Text = "Address";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(115, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(187, 27);
            txtId.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(115, 183);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(605, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtBirthdate
            // 
            txtBirthdate.Location = new Point(115, 107);
            txtBirthdate.Name = "txtBirthdate";
            txtBirthdate.Size = new Size(193, 27);
            txtBirthdate.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(516, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 9;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(536, 106);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 10;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(642, 106);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 11;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Location = new Point(37, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.Location = new Point(182, 259);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Cyan;
            btnDelete.Location = new Point(332, 259);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Reset
            // 
            Reset.BackColor = Color.Cyan;
            Reset.Location = new Point(481, 259);
            Reset.Name = "Reset";
            Reset.Size = new Size(94, 29);
            Reset.TabIndex = 15;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += Reset_Click;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Cyan;
            Exit.Location = new Point(626, 259);
            Exit.Name = "Exit";
            Exit.Size = new Size(94, 29);
            Exit.TabIndex = 16;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(773, 563);
            Controls.Add(Exit);
            Controls.Add(Reset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(rdFemale);
            Controls.Add(rdMale);
            Controls.Add(txtName);
            Controls.Add(txtBirthdate);
            Controls.Add(txtAddress);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgCustomer);
            Name = "FrmCustomer";
            Text = "FrmCustomercs";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtAddress;
        private TextBox txtBirthdate;
        private TextBox txtName;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button Reset;
        private Button Exit;
    }
}