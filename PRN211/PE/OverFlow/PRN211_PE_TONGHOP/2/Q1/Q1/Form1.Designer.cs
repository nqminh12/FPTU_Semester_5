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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTitle = new TextBox();
            txtDes = new RichTextBox();
            cbSquare = new ComboBox();
            nufloor = new NumericUpDown();
            txtComment = new RichTextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nufloor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Room title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 101);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 252);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Room Square";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 402);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 3;
            label4.Text = "Comment";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 313);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 4;
            label5.Text = "Floor";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(174, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(203, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtDes
            // 
            txtDes.Location = new Point(174, 101);
            txtDes.Name = "txtDes";
            txtDes.Size = new Size(338, 124);
            txtDes.TabIndex = 6;
            txtDes.Text = "";
            // 
            // cbSquare
            // 
            cbSquare.FormattingEnabled = true;
            cbSquare.Items.AddRange(new object[] { "133", "138", "154", "164", "180" });
            cbSquare.Location = new Point(174, 252);
            cbSquare.Name = "cbSquare";
            cbSquare.Size = new Size(203, 28);
            cbSquare.TabIndex = 7;
            // 
            // nufloor
            // 
            nufloor.Location = new Point(174, 313);
            nufloor.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nufloor.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nufloor.Name = "nufloor";
            nufloor.Size = new Size(203, 27);
            nufloor.TabIndex = 8;
            nufloor.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // txtComment
            // 
            txtComment.Location = new Point(174, 402);
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(338, 124);
            txtComment.TabIndex = 9;
            txtComment.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(174, 553);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 10;
            button1.Text = "Add new room";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 619);
            Controls.Add(button1);
            Controls.Add(txtComment);
            Controls.Add(nufloor);
            Controls.Add(cbSquare);
            Controls.Add(txtDes);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nufloor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTitle;
        private RichTextBox txtDes;
        private ComboBox cbSquare;
        private NumericUpDown nufloor;
        private RichTextBox txtComment;
        private Button button1;
    }
}
