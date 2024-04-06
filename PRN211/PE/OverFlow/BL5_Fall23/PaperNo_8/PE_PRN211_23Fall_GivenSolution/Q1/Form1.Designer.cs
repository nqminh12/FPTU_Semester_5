namespace Q1
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
            dg = new DataGridView();
            groupBox1 = new GroupBox();
            btnEdit = new Button();
            btnAdd = new Button();
            btnRefesh = new Button();
            txtType = new ComboBox();
            txtDate = new DateTimePicker();
            txtDes = new RichTextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(23, 57);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(704, 473);
            dg.TabIndex = 0;
            dg.CellClick += dg_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnRefesh);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(txtDes);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(771, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(394, 468);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Project";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(280, 420);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(158, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefesh
            // 
            btnRefesh.Location = new Point(34, 420);
            btnRefesh.Name = "btnRefesh";
            btnRefesh.Size = new Size(94, 29);
            btnRefesh.TabIndex = 10;
            btnRefesh.Text = "Refesh";
            btnRefesh.UseVisualStyleBackColor = true;
            btnRefesh.Click += btnRefesh_Click;
            // 
            // txtType
            // 
            txtType.FormattingEnabled = true;
            txtType.Location = new Point(124, 365);
            txtType.Name = "txtType";
            txtType.Size = new Size(165, 28);
            txtType.TabIndex = 9;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(124, 313);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(250, 27);
            txtDate.TabIndex = 8;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(124, 171);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(250, 123);
            txtDes.TabIndex = 7;
            txtDes.Text = "";
            // 
            // txtName
            // 
            txtName.Location = new Point(124, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(124, 54);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 365);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 4;
            label5.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 318);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "StartDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 171);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 123);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 54);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 558);
            Controls.Add(groupBox1);
            Controls.Add(dg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnRefesh;
        private ComboBox txtType;
        private DateTimePicker txtDate;
        private RichTextBox txtDes;
        private TextBox txtName;
        private TextBox txtId;
    }
}