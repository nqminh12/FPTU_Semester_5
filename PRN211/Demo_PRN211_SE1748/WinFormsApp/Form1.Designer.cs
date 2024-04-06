namespace WinFormsApp
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
            label1 = new Label();
            numText = new NumericUpDown();
            btnAdd = new Button();
            btnAddCheck = new Button();
            ((System.ComponentModel.ISupportInitialize)numText).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter text number:";
            // 
            // numText
            // 
            numText.Location = new Point(187, 32);
            numText.Name = "numText";
            numText.Size = new Size(181, 29);
            numText.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 255, 255);
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(398, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 31);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddCheck
            // 
            btnAddCheck.BackColor = Color.FromArgb(192, 255, 255);
            btnAddCheck.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCheck.Location = new Point(19, 514);
            btnAddCheck.Name = "btnAddCheck";
            btnAddCheck.Size = new Size(160, 49);
            btnAddCheck.TabIndex = 3;
            btnAddCheck.Text = "App check";
            btnAddCheck.UseVisualStyleBackColor = false;
            btnAddCheck.Click += btnAddCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(915, 575);
            Controls.Add(btnAddCheck);
            Controls.Add(btnAdd);
            Controls.Add(numText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Auto generate control";
            FormClosing += Form1_FormClosing;
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)numText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numText;
        private Button btnAdd;
        private Button btnAddCheck;
    }
}
