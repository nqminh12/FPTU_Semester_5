namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nơi sẽ viết điều gì sẽ xảy ra khi sự kiện xảy ra 
            if (MessageBox.Show(this, "Do you want to exit", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            //DialogResult.No: Kiểm tra xem người dùng có chọn lựa chọn "No" từ hộp thoại MessageBox hay không
            {
                // Environment.Exit(0); // close all 
                e.Cancel = true;
                // Hãy hủy bỏ hành động đóng form này
            }

        }

        int n;
        List<TextBox> lstText = new List<TextBox>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            n = (int)numText.Value;
            lstText.Clear();
            //Được sử dụng để xóa nội dung hoặc các items trong một Control hoặc collection, nhưng không xóa Control đó khỏi Form.

            //Tạo các textbox bằng code 
            for (int i = 0; i < n; i++)
            {
                //Tạo n label 
                Label Label = new Label();
                Label.Location = new Point(12, 94 + i * 35);
                Label.Size = new Size(110, 25);
                Label.Text = "Enter text " + (i + 1) + ":";
                //Tạo n textbox
                TextBox textBox = new TextBox();
                textBox.Location = new Point(126, 94 + i * 35);
                textBox.Size = new Size(276, 25);
                //Add in form 
                this.Controls.Add(Label);
                this.Controls.Add(textBox);
                lstText.Add(textBox);
            }
        }
        List<CheckBox> listcheckBox = new List<CheckBox>();
        private void btnAddCheck_Click(object sender, EventArgs e)
        {
            n = (int)numText.Value;
            //Tạo các textbox bằng code 

            foreach (var checkboxlist in listcheckBox)
            {
                this.Controls.Remove(checkboxlist);
                //được sử dụng để xóa hoàn toàn một Control khỏi Form.
            }
            for (int i = 0; i < n; i++)
            {

                CheckBox checkBox = new CheckBox();
                checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
                checkBox.Location = new Point(409, 94 + i * 30);
                checkBox.Size = new Size(160, 27);
                checkBox.Text = lstText[i].Text;
                listcheckBox.Add(checkBox);
                // Gán sự kiện cho checkbox 
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                this.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox chkBox = (CheckBox)sender;
            string status = chkBox.Checked ? "checked" : "uncheck";
            MessageBox.Show(chkBox.Text + status);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) //nh¿n chußt trái
            MessageBox.Show("Sÿ kiện MouseClick trai ");    
            else  if (e.Button==MouseButtons.Middle)//nh¿n chußt giÿa
            MessageBox.Show("Sÿ kiện MouseClick giua");  
            else    if(e.Button==MouseButtons.Right)//nh¿n chußt ph¿i
            MessageBox.Show("Sÿ kiện MouseClick phai"); 
        }
    }
}
