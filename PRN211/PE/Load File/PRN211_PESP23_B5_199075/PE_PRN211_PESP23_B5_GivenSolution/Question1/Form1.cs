using System.Windows.Forms;
using static System.IO.StreamWriter;
namespace Question1
{
    public partial class Form1 : Form
    {
        // tạo list mục đích: tận dụng các method để thao tác với nó
        List<Customer> list = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            string code = txtCode.Text;
            string name = txtName.Text;
            bool gender = rbMale.Checked == true ? true : false;
            DateTime dateOfBirth = (DateTime)dob.Value;

            c.code = code;
            c.name = name;
            c.gender = gender;
            c.dob = dateOfBirth;
            list.Add(c);

            loadView();
        }
        public void loadView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                string filename = txtFileName.Text;
                try
                {
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (Customer c in list)
                        {
                            writer.WriteLine($"{c.code};{c.name};{c.gender};{c.dob.ToString("dd/MM/yyyy")}");
                        }
                    }
                    MessageBox.Show("Save success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SaveFile fail: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("List empty!");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // open 
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.ShowDialog(this);
                string filePath = openFileDialog.FileName;
                txtFileName.Text = filePath;
                // tạo đọc file
                using (StreamReader reader = new StreamReader(filePath))
                {

                    // 1 dòng đọc dc
                    string line;
                    // gắn 1 dòng đọc được
                    while ((line = reader.ReadLine()) != null)
                    {
                        // chia nhỏ thành các thuộc tính gán vào Product
                        string[] parts = line.Split(';');
                        // kiểm tra xem có 4 thuộc tính không
                        if (parts.Length == 4)
                        {
                            // gán
                            Customer c = new Customer();
                            c.code = parts[0];
                            c.name = parts[1];
                            c.gender = bool.Parse(parts[2]);
                            c.dob = DateTime.Parse(parts[3]);
                            // add list và load view
                            list.Add(c);
                            loadView();
                        }
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có hàng nào được chọn không
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                    {
                        // Lấy đối tượng Customer từ hàng được chọn
                        Customer c = (Customer)selectedRow.DataBoundItem;
                        list.Remove(c);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = list;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa hàng: " + ex.Message);
            }
        }
    }
}