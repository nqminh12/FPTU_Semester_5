namespace WinFormsApp1
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
            txtId = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtPhone = new TextBox();
            label2 = new Label();
            nusSalary = new NumericUpDown();
            Salary = new Label();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            txtName = new TextBox();
            label1 = new Label();
            dgEmployee = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nusSalary).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nusSalary);
            groupBox1.Controls.Add(Salary);
            groupBox1.Controls.Add(rdFemale);
            groupBox1.Controls.Add(rdMale);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(603, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(465, 517);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // txtId
            // 
            txtId.Location = new Point(190, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 11;
            txtId.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(330, 446);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(129, 54);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(173, 446);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 54);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(17, 446);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 54);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(194, 370);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(241, 27);
            txtPhone.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 377);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Phone";
            // 
            // nusSalary
            // 
            nusSalary.Location = new Point(194, 262);
            nusSalary.Name = "nusSalary";
            nusSalary.Size = new Size(150, 27);
            nusSalary.TabIndex = 5;
            // 
            // Salary
            // 
            Salary.AutoSize = true;
            Salary.Location = new Point(47, 264);
            Salary.Name = "Salary";
            Salary.Size = new Size(49, 20);
            Salary.TabIndex = 4;
            Salary.Text = "Salary";
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(308, 149);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(78, 24);
            rdFemale.TabIndex = 3;
            rdFemale.TabStop = true;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Location = new Point(190, 149);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(63, 24);
            rdMale.TabIndex = 2;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(245, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 74);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee Name";
            // 
            // dgEmployee
            // 
            dgEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmployee.Location = new Point(35, 41);
            dgEmployee.Name = "dgEmployee";
            dgEmployee.RowHeadersWidth = 51;
            dgEmployee.RowTemplate.Height = 29;
            dgEmployee.Size = new Size(527, 517);
            dgEmployee.TabIndex = 1;
            dgEmployee.CellClick += dgEmployee_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 590);
            Controls.Add(dgEmployee);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nusSalary).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtPhone;
        private Label label2;
        private NumericUpDown nusSalary;
        private Label Salary;
        private RadioButton rdFemale;
        private RadioButton rdMale;
        private TextBox txtName;
        private Label label1;
        private DataGridView dgEmployee;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtId;
    }
}
