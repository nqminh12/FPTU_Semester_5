namespace WinFormsApp
{
    partial class FrmStudent
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            numMark = new NumericUpDown();
            cboSubject = new ComboBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnExit = new Button();
            listStudent = new ListBox();
            label6 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(213, 47);
            label1.Name = "label1";
            label1.Size = new Size(547, 60);
            label1.TabIndex = 0;
            label1.Text = "STUDENT MANAGEMENT";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numMark);
            groupBox2.Controls.Add(cboSubject);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(txtCode);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(44, 203);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(318, 313);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Input";
            // 
            // numMark
            // 
            numMark.Location = new Point(98, 239);
            numMark.Margin = new Padding(3, 4, 3, 4);
            numMark.Name = "numMark";
            numMark.Size = new Size(192, 27);
            numMark.TabIndex = 8;
            // 
            // cboSubject
            // 
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Math ", "Japanese", "English" });
            cboSubject.Location = new Point(98, 175);
            cboSubject.Margin = new Padding(3, 4, 3, 4);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(191, 28);
            cboSubject.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(98, 113);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(191, 27);
            txtName.TabIndex = 5;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(98, 44);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(191, 27);
            txtCode.TabIndex = 4;
            txtCode.Enter += txtCode_Enter;
            txtCode.Leave += txtCode_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(28, 246);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 3;
            label5.Text = "Mark";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(28, 183);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 2;
            label4.Text = "Subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(28, 120);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 1;
            label3.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(28, 51);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 0;
            label2.Text = "Code";

            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Turquoise;
            btnAdd.Location = new Point(415, 223);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(127, 31);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Turquoise;
            btnRemove.Location = new Point(415, 288);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(127, 31);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Turquoise;
            btnLoad.Location = new Point(415, 357);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(127, 31);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Turquoise;
            btnSave.Location = new Point(415, 422);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(127, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Turquoise;
            btnExit.Location = new Point(415, 493);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(127, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // listStudent
            // 
            listStudent.FormattingEnabled = true;
            listStudent.ItemHeight = 20;
            listStudent.Location = new Point(586, 204);
            listStudent.Margin = new Padding(3, 4, 3, 4);
            listStudent.Name = "listStudent";
            listStudent.Size = new Size(345, 324);
            listStudent.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Black;
            label6.Location = new Point(586, 180);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 9;
            label6.Text = "OUTPUT";
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1032, 605);
            Controls.Add(label6);
            Controls.Add(listStudent);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmStudent";
            Text = "FrmStudent";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnLoad;
        private Button btnSave;
        private Button btnExit;
        private TextBox txtName;
        private TextBox txtCode;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numMark;
        private ComboBox cboSubject;
        private ListBox listStudent;
        private Label label6;
    }
}