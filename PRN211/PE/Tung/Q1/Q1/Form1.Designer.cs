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
            dataGridView1 = new DataGridView();
            filter = new GroupBox();
            cbPosition = new ComboBox();
            radFemale = new RadioButton();
            radMale = new RadioButton();
            radMaleFemale = new RadioButton();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            filter.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(557, 55);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(543, 568);
            dataGridView1.TabIndex = 0;
            // 
            // filter
            // 
            filter.Controls.Add(cbPosition);
            filter.Controls.Add(radFemale);
            filter.Controls.Add(radMale);
            filter.Controls.Add(radMaleFemale);
            filter.Controls.Add(txtName);
            filter.Controls.Add(label2);
            filter.Controls.Add(label1);
            filter.Location = new Point(41, 55);
            filter.Margin = new Padding(3, 4, 3, 4);
            filter.Name = "filter";
            filter.Padding = new Padding(3, 4, 3, 4);
            filter.Size = new Size(437, 568);
            filter.TabIndex = 1;
            filter.TabStop = false;
            filter.Text = "Filter";
            // 
            // cbPosition
            // 
            cbPosition.DisplayMember = "1";
            cbPosition.FormattingEnabled = true;
            cbPosition.Items.AddRange(new object[] { "All positions", "Developer", "Leader", "Tester", "Manager" });
            cbPosition.Location = new Point(139, 305);
            cbPosition.Margin = new Padding(3, 4, 3, 4);
            cbPosition.Name = "cbPosition";
            cbPosition.Size = new Size(138, 28);
            cbPosition.TabIndex = 6;
            cbPosition.SelectedIndexChanged += cbPosition_SelectedIndexChanged;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(304, 204);
            radFemale.Margin = new Padding(3, 4, 3, 4);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(78, 24);
            radFemale.TabIndex = 5;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(179, 204);
            radMale.Margin = new Padding(3, 4, 3, 4);
            radMale.Name = "radMale";
            radMale.Size = new Size(63, 24);
            radMale.TabIndex = 4;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            radMale.CheckedChanged += radMale_CheckedChanged;
            // 
            // radMaleFemale
            // 
            radMaleFemale.AutoSize = true;
            radMaleFemale.Location = new Point(37, 204);
            radMaleFemale.Margin = new Padding(3, 4, 3, 4);
            radMaleFemale.Name = "radMaleFemale";
            radMaleFemale.Size = new Size(117, 24);
            radMaleFemale.TabIndex = 3;
            radMaleFemale.TabStop = true;
            radMaleFemale.Text = "Male/Female";
            radMaleFemale.UseVisualStyleBackColor = true;
            radMaleFemale.CheckedChanged += radMaleFemale_CheckedChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 95);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 2;
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 309);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Position";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 99);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 668);
            Controls.Add(filter);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            filter.ResumeLayout(false);
            filter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox filter;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private RadioButton radMaleFemale;
        private RadioButton radMale;
        private RadioButton radFemale;
        private ComboBox cbPosition;
    }
}
