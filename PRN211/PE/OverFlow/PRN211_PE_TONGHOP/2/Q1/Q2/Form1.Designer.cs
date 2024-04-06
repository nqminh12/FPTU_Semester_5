namespace Q2
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
            cbRoom = new ComboBox();
            cbFee = new ComboBox();
            dg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "List Fee Of Room";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 115);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Room";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 181);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Fee Type";
            // 
            // cbRoom
            // 
            cbRoom.FormattingEnabled = true;
            cbRoom.Location = new Point(149, 107);
            cbRoom.Name = "cbRoom";
            cbRoom.Size = new Size(151, 28);
            cbRoom.TabIndex = 3;
            cbRoom.SelectedIndexChanged += cbRoom_SelectedIndexChanged;
            cbRoom.SelectedValueChanged += cbRoom_SelectedValueChanged;
            // 
            // cbFee
            // 
            cbFee.FormattingEnabled = true;
            cbFee.Location = new Point(149, 181);
            cbFee.Name = "cbFee";
            cbFee.Size = new Size(151, 28);
            cbFee.TabIndex = 4;
            cbFee.SelectedIndexChanged += cbFee_SelectedIndexChanged;
            // 
            // dg
            // 
            dg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg.Location = new Point(37, 239);
            dg.Name = "dg";
            dg.RowHeadersWidth = 51;
            dg.RowTemplate.Height = 29;
            dg.Size = new Size(729, 188);
            dg.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dg);
            Controls.Add(cbFee);
            Controls.Add(cbRoom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cbRoom;
        private ComboBox cbFee;
        private DataGridView dg;
    }
}
