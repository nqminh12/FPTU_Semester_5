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
            rdFalse = new RadioButton();
            rdTrue = new RadioButton();
            txtPrice = new NumericUpDown();
            txtName = new TextBox();
            txtId = new TextBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(424, 43);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(350, 355);
            dg.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdFalse);
            groupBox1.Controls.Add(rdTrue);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(30, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 355);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "ProductInfo";
            // 
            // rdFalse
            // 
            rdFalse.AutoSize = true;
            rdFalse.Location = new Point(135, 250);
            rdFalse.Name = "rdFalse";
            rdFalse.Size = new Size(62, 24);
            rdFalse.TabIndex = 9;
            rdFalse.TabStop = true;
            rdFalse.Text = "False";
            rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            rdTrue.AutoSize = true;
            rdTrue.Location = new Point(135, 210);
            rdTrue.Name = "rdTrue";
            rdTrue.Size = new Size(58, 24);
            rdTrue.TabIndex = 8;
            rdTrue.TabStop = true;
            rdTrue.Text = "True";
            rdTrue.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(140, 147);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(185, 27);
            txtPrice.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 95);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 6;
            // 
            // txtId
            // 
            txtId.Location = new Point(140, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(185, 27);
            txtId.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(231, 304);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "AddToList";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 207);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "IsActive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 95);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "ProductName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "ProductId";
            // 
            // button2
            // 
            button2.Location = new Point(563, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "SaveToFile";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(dg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg;
        private GroupBox groupBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private RadioButton rdFalse;
        private RadioButton rdTrue;
        private NumericUpDown txtPrice;
        private TextBox txtName;
        private TextBox txtId;
    }
}