namespace Question1
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
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            txtName = new TextBox();
            txtCode = new TextBox();
            dob = new DateTimePicker();
            btnAdd = new Button();
            lbActive = new Label();
            lbName = new Label();
            lbPrice = new Label();
            lbID = new Label();
            btnSave = new Button();
            dataGridView1 = new DataGridView();
            btnImport = new Button();
            txtFileName = new TextBox();
            btnRemove = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFemale);
            groupBox1.Controls.Add(rbMale);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCode);
            groupBox1.Controls.Add(dob);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(lbActive);
            groupBox1.Controls.Add(lbName);
            groupBox1.Controls.Add(lbPrice);
            groupBox1.Controls.Add(lbID);
            groupBox1.Location = new Point(75, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(437, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ProductInfo";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Location = new Point(231, 172);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(78, 24);
            rbFemale.TabIndex = 15;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Location = new Point(148, 172);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(63, 24);
            rbMale.TabIndex = 14;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(148, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 27);
            txtName.TabIndex = 13;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(148, 36);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(157, 27);
            txtCode.TabIndex = 12;
            // 
            // dob
            // 
            dob.Format = DateTimePickerFormat.Custom;
            dob.Location = new Point(148, 240);
            dob.Name = "dob";
            dob.Size = new Size(157, 27);
            dob.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(231, 331);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "AddToList";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbActive
            // 
            lbActive.AutoSize = true;
            lbActive.Location = new Point(45, 245);
            lbActive.Name = "lbActive";
            lbActive.Size = new Size(38, 20);
            lbActive.TabIndex = 7;
            lbActive.Text = "Dob";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(45, 107);
            lbName.Name = "lbName";
            lbName.Size = new Size(49, 20);
            lbName.TabIndex = 5;
            lbName.Text = "Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(45, 172);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(57, 20);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Gender";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(45, 43);
            lbID.Name = "lbID";
            lbID.Size = new Size(44, 20);
            lbID.TabIndex = 3;
            lbID.Text = "Code";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(716, 509);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "SaveToFile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(568, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(491, 412);
            dataGridView1.TabIndex = 3;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(568, 31);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(119, 31);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // txtFileName
            // 
            txtFileName.Enabled = false;
            txtFileName.Location = new Point(693, 31);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(366, 27);
            txtFileName.TabIndex = 5;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(568, 509);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(119, 29);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 571);
            Controls.Add(btnRemove);
            Controls.Add(txtFileName);
            Controls.Add(btnImport);
            Controls.Add(dataGridView1);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbID;
        private Label lbName;
        private Label lbPrice;
        private Label lbActive;
        private Button btnAdd;
        private DataGridView dtg1;
        private Button btnSave;
        private DataGridView dataGridView1;
        private Button btnImport;
        private TextBox txtFileName;
        private DateTimePicker dob;
        private TextBox txtCode;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private TextBox txtName;
        private Button btnRemove;
    }
}