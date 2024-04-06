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
            cboRoom = new ComboBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            cboTimeSlot = new ComboBox();
            cboMovie = new ComboBox();
            btnAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 29);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 1;
            label1.Text = "List of rooms";
            // 
            // cboRoom
            // 
            cboRoom.FormattingEnabled = true;
            cboRoom.Location = new Point(168, 26);
            cboRoom.Name = "cboRoom";
            cboRoom.Size = new Size(181, 28);
            cboRoom.TabIndex = 2;
            cboRoom.SelectedIndexChanged += cboRoom_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(772, 385);
            dataGridView1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endDate);
            groupBox1.Controls.Add(startDate);
            groupBox1.Controls.Add(cboTimeSlot);
            groupBox1.Controls.Add(cboMovie);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(841, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 385);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add schedule";
            // 
            // endDate
            // 
            endDate.CustomFormat = "dddd , MMMM";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(135, 264);
            endDate.Name = "endDate";
            endDate.Size = new Size(250, 27);
            endDate.TabIndex = 8;
            // 
            // startDate
            // 
            startDate.CustomFormat = "dddd , MMMM";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(135, 198);
            startDate.Name = "startDate";
            startDate.Size = new Size(250, 27);
            startDate.TabIndex = 7;
            // 
            // cboTimeSlot
            // 
            cboTimeSlot.FormattingEnabled = true;
            cboTimeSlot.Location = new Point(135, 126);
            cboTimeSlot.Name = "cboTimeSlot";
            cboTimeSlot.Size = new Size(255, 28);
            cboTimeSlot.TabIndex = 6;
            // 
            // cboMovie
            // 
            cboMovie.FormattingEnabled = true;
            cboMovie.Location = new Point(135, 53);
            cboMovie.Name = "cboMovie";
            cboMovie.Size = new Size(130, 28);
            cboMovie.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(135, 317);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 271);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 3;
            label6.Text = "End Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 198);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 2;
            label5.Text = "Start Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 129);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 1;
            label4.Text = "TimeSlot";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 61);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 0;
            label3.Text = "Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 86);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 5;
            label2.Text = "Schedule of selected room";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 520);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(cboRoom);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cboRoom;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnAdd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cboTimeSlot;
        private ComboBox cboMovie;
        private DateTimePicker startDate;
        private DateTimePicker endDate;
    }
}