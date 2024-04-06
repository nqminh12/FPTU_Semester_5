using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PE_PRN_Sum21Context context = new PE_PRN_Sum21Context();
        private void Form1_Load(object sender, EventArgs e)
        {
            dgEmployeeLoad();
        }

        private void dgEmployeeLoad()
        {
            var data = context.Employees.ToList();
            dgEmployee.DataSource = data;
        }

        private void dgEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgEmployee.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgEmployee.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtPhone.Text = dgEmployee.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            nusSalary.Text = dgEmployee.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtName.Text = dgEmployee.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            string check = dgEmployee.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            if (check.Equals("True"))
            {
                rdMale.Checked = true;
                rdFemale.Checked = false;
            }
            else
            {
                rdMale.Checked = false;
                rdFemale.Checked = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Boolean gender = true;
            if(rdMale.Checked)
            {
                gender = true;
            }
            else
            {
                gender = false;
            }
            Employee em = new Employee()
            {
                EmployeeName = txtName.Text,
                Male = gender,
                Phone = txtPhone.Text,
                Salary = (float)nusSalary.Value
                
            };
            context.Employees.Add(em);
            if (context.SaveChanges() > 0)
            {
                MessageBox.Show("Add Successfully");

            }
            else
            {
                MessageBox.Show("Add Fail");
            }
            dgEmployeeLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Employee em = context.Employees
                .Where(p => p.EmployeeId == Convert.ToInt32(txtId.Text))
                .FirstOrDefault();
            if (em != null)
            {
                em.EmployeeName = txtName.Text;
                em.Phone = txtPhone.Text;
                em.Salary = (float)nusSalary.Value;
                Boolean gender = true;
                if (rdFemale.Checked)
                {
                    gender = false;
                }
                else
                {
                    gender = true;
                }

                em.Male = gender;
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success!");
                    dgEmployeeLoad();
                }
            }
            else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            Employee em = context.Employees
                .Where(p => p.EmployeeId == Convert.ToInt32(txtId.Text))
                .FirstOrDefault();


            if (em != null)
            {
                context.Employees.Remove(em);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success!");
                    dgEmployeeLoad();
                }
            }
            else
            {
                MessageBox.Show("Delete fail!");
            }





        }
    }
}
