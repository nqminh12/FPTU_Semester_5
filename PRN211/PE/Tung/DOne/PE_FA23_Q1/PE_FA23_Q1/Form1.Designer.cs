namespace PE_FA23_Q1
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
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            btnAdd = new Button();
            cbMovie = new ComboBox();
            cbTimeSlot = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            lbRoom = new Label();
            label1 = new Label();
            cbRoom = new ComboBox();
            rbAsc = new RadioButton();
            rbDesc = new RadioButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(endDate);
            groupBox1.Controls.Add(startDate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(cbMovie);
            groupBox1.Controls.Add(cbTimeSlot);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(840, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 365);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add schedule";
            // 
            // endDate
            // 
            endDate.CustomFormat = "dddd, MMMM";
            endDate.Format = DateTimePickerFormat.Custom;
            endDate.Location = new Point(111, 233);
            endDate.Name = "endDate";
            endDate.Size = new Size(199, 27);
            endDate.TabIndex = 10;
            // 
            // startDate
            // 
            startDate.CustomFormat = "dddd, MMMM";
            startDate.Format = DateTimePickerFormat.Custom;
            startDate.Location = new Point(111, 159);
            startDate.Name = "startDate";
            startDate.Size = new Size(199, 27);
            startDate.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(111, 305);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(124, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add schedule";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbMovie
            // 
            cbMovie.FormattingEnabled = true;
            cbMovie.Location = new Point(111, 40);
            cbMovie.Name = "cbMovie";
            cbMovie.Size = new Size(159, 28);
            cbMovie.TabIndex = 7;
            // 
            // cbTimeSlot
            // 
            cbTimeSlot.FormattingEnabled = true;
            cbTimeSlot.Location = new Point(111, 96);
            cbTimeSlot.Name = "cbTimeSlot";
            cbTimeSlot.Size = new Size(296, 28);
            cbTimeSlot.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 233);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 3;
            label5.Text = "EndDate";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 159);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 2;
            label4.Text = "StartDate";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(15, 104);
            label.Name = "label";
            label.Size = new Size(68, 20);
            label.TabIndex = 1;
            label.Text = "TimeSlot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 48);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 0;
            label2.Text = "Movie";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(755, 326);
            dataGridView1.TabIndex = 1;
            // 
            // lbRoom
            // 
            lbRoom.AutoSize = true;
            lbRoom.Location = new Point(42, 61);
            lbRoom.Name = "lbRoom";
            lbRoom.Size = new Size(95, 20);
            lbRoom.TabIndex = 2;
            lbRoom.Text = "List of rooms";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 124);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 3;
            label1.Text = "Schedules of selected room";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(168, 53);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(156, 28);
            cbRoom.TabIndex = 4;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            // 
            // rbAsc
            // 
            rbAsc.AutoSize = true;
            rbAsc.Checked = true;
            rbAsc.Location = new Point(290, 120);
            rbAsc.Name = "rbAsc";
            rbAsc.Size = new Size(99, 24);
            rbAsc.TabIndex = 5;
            rbAsc.TabStop = true;
            rbAsc.Text = "Ascending";
            rbAsc.UseVisualStyleBackColor = true;
            rbAsc.CheckedChanged += rbAsc_CheckedChanged;
            // 
            // rbDesc
            // 
            rbDesc.AutoSize = true;
            rbDesc.Location = new Point(428, 120);
            rbDesc.Name = "rbDesc";
            rbDesc.Size = new Size(108, 24);
            rbDesc.TabIndex = 6;
            rbDesc.Text = "Descending";
            rbDesc.UseVisualStyleBackColor = true;
            rbDesc.CheckedChanged += rbDesc_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 636);
            Controls.Add(rbDesc);
            Controls.Add(rbAsc);
            Controls.Add(cbRoom);
            Controls.Add(label1);
            Controls.Add(lbRoom);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
        private Label lbRoom;
        private Label label1;
        private ComboBox cbRoom;
        private Label label5;
        private Label label4;
        private Label label;
        private Label label2;
        private ComboBox cbMovie;
        private ComboBox cbTimeSlot;
        private Button btnAdd;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private RadioButton rbAsc;
        private RadioButton rbDesc;
    }
}
