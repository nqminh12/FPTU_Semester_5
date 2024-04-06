using Q1.Models;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadView();
            rbMale.Checked = true;
        }

        public void loadView()
        {
            // data view
            var employee = context.Employees
                .Select(e => new
                {
                    e.Id,
                    e.Name,
                    e.Sex,
                    e.Dob,
                    e.Position
                })
                .ToList();

            dataGridView1.DataSource = employee;
            var pos = context.Employees
                .Select(e => new
                {
                    Position = e.Position
                })
                .Distinct()
                .ToList();
            //foreach (var e in pos)
            //{
            //    cbPosition.Items.Add(e.Position);
            //}
            // c2
            cbPosition.DataSource = pos;
            cbPosition.DisplayMember = "Position";
            cbPosition.ValueMember = "Position";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                string id = selectedRow.Cells["Id"].Value.ToString();
                string name = selectedRow.Cells["Name"].Value.ToString();
                string isMale = selectedRow.Cells["Sex"].Value.ToString();
                DateTime dob = DateTime.Parse(selectedRow.Cells["Dob"].Value.ToString());
                string position = selectedRow.Cells["Position"].Value.ToString();

                txtID.Text = id;
                txtName.Text = name;
                rbMale.Checked = isMale == "Male";
                rbFemale.Checked = isMale == "Female";
                dateDob.Value = dob;
                cbPosition.SelectedValue = position;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dateDob.Value = DateTime.Now;
            cbPosition.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.Name = txtName.Text;
            emp.Dob = dateDob.Value;
            emp.Sex = rbMale.Checked ? "Male" : "Female";
            emp.Position = cbPosition.SelectedValue.ToString();
            context.Employees.Add(emp);
            context.SaveChanges();
            loadView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            // tim kiem trong DB
            emp = context.Employees.FirstOrDefault(emp => emp.Id == int.Parse(txtID.Text));

            if(emp != null)
            {
                emp.Name = txtName.Text;
                emp.Dob = dateDob.Value;
                emp.Sex = rbMale.Checked ? "Male" : "Female";
                emp.Position = cbPosition.SelectedValue.ToString();
                // Add and Save
                context.SaveChanges();
                loadView();
            }
            else
            {
                MessageBox.Show("abc");
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);

            Employee emp = context.Employees.FirstOrDefault(x => x.Id == id);
            if (emp == null)
            {
                MessageBox.Show("Id does not exits!");
            }
            else
            {
                context.Remove(emp);
                context.SaveChanges();
            }
            loadView();
        }
    }

}
