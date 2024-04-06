namespace WinFormsApp
{
    partial class FrmStart
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            txtName = new TextBox();
            lblCount = new Label();
            btnAdd = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(57, 207);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter Name ";
            // 
            // txtName
            // 
            txtName.Location = new Point(152, 204);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 23);
            txtName.TabIndex = 6;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Green;
            lblCount.Location = new Point(526, 116);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(164, 128);
            lblCount.TabIndex = 7;
            lblCount.Text = "10";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.GradientActiveCaption;
            btnAdd.Location = new Point(350, 203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Start";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(lblCount);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "FrmStart";
            Text = "FrmStart";
            Load += FrmStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtName;
        private Label lblCount;
        private Button btnAdd;
        private System.Windows.Forms.Timer timer1;
    }
}