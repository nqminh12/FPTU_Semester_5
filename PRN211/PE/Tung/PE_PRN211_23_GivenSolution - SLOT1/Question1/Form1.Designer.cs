namespace Question1
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            gbProducInfo = new GroupBox();
            btnAddList = new Button();
            rbFalse = new RadioButton();
            rbTrue = new RadioButton();
            txtPrice = new NumericUpDown();
            txtPName = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbID = new Label();
            btnSave = new Button();
            btnImport = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gbProducInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(400, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(426, 355);
            dataGridView1.TabIndex = 0;
            // 
            // gbProducInfo
            // 
            gbProducInfo.Controls.Add(btnAddList);
            gbProducInfo.Controls.Add(rbFalse);
            gbProducInfo.Controls.Add(rbTrue);
            gbProducInfo.Controls.Add(txtPrice);
            gbProducInfo.Controls.Add(txtPName);
            gbProducInfo.Controls.Add(txtID);
            gbProducInfo.Controls.Add(label4);
            gbProducInfo.Controls.Add(label3);
            gbProducInfo.Controls.Add(label2);
            gbProducInfo.Controls.Add(lbID);
            gbProducInfo.Location = new Point(22, 12);
            gbProducInfo.Name = "gbProducInfo";
            gbProducInfo.Size = new Size(342, 355);
            gbProducInfo.TabIndex = 1;
            gbProducInfo.TabStop = false;
            gbProducInfo.Text = "ProductInfo";
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(185, 276);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(75, 23);
            btnAddList.TabIndex = 9;
            btnAddList.Text = "AddToList";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += btnAddList_Click;
            // 
            // rbFalse
            // 
            rbFalse.AutoSize = true;
            rbFalse.Location = new Point(103, 227);
            rbFalse.Name = "rbFalse";
            rbFalse.Size = new Size(51, 19);
            rbFalse.TabIndex = 8;
            rbFalse.TabStop = true;
            rbFalse.Text = "False";
            rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            rbTrue.AutoSize = true;
            rbTrue.Location = new Point(103, 193);
            rbTrue.Name = "rbTrue";
            rbTrue.Size = new Size(47, 19);
            rbTrue.TabIndex = 7;
            rbTrue.TabStop = true;
            rbTrue.Text = "True";
            rbTrue.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(103, 144);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(157, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtPName
            // 
            txtPName.Location = new Point(103, 86);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(157, 23);
            txtPName.TabIndex = 5;
            // 
            // txtID
            // 
            txtID.Location = new Point(103, 41);
            txtID.Name = "txtID";
            txtID.Size = new Size(157, 23);
            txtID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 197);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "IsActive";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 146);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 94);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 1;
            label2.Text = "ProductName";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(6, 44);
            lbID.Name = "lbID";
            lbID.Size = new Size(59, 15);
            lbID.TabIndex = 0;
            lbID.Text = "ProductId";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(751, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 10;
            btnSave.Text = "SaveToFile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(400, 389);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(75, 23);
            btnImport.TabIndex = 11;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(btnImport);
            Controls.Add(btnSave);
            Controls.Add(gbProducInfo);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gbProducInfo.ResumeLayout(false);
            gbProducInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox gbProducInfo;
        private TextBox txtPName;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbID;
        private RadioButton rbFalse;
        private RadioButton rbTrue;
        private NumericUpDown txtPrice;
        private Button btnAddList;
        private Button btnSave;
        private Button btnImport;
    }
}