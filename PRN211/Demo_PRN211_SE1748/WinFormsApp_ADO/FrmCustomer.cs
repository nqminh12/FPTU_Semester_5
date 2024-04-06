using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp_ADO
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        public void FrmCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        DataProvider d = new DataProvider();
        private void LoadCustomer()
        {
            try
            {
                DataTable dt = d.executeQuery("select * from Customers");
                dgCustomer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadCustomer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtBirthdate.Text = string.Empty;
            txtAddress.Text = string.Empty;
            rdFemale.Checked = false;
            rdMale.Checked = false;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgCustomer.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgCustomer.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtBirthdate.Text = dgCustomer.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtAddress.Text = dgCustomer.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            if (dgCustomer.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True"))
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strSql = "delete from Customers where CustomerId = @id";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", txtId.Text)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Delete success");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String strSql = "update Customers set CustomerName = @name, Birthdate = @dob, Gender = @gender, Address = @address where CustomerId = @id";
            String gender = "true";
            if (rdFemale.Checked)
            {
                gender = "false";
            }
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", txtId.Text),
            new SqlParameter("@name", txtName.Text),
            new SqlParameter("@dob", txtBirthdate.Text),
            new SqlParameter("@address", txtAddress.Text),
            new SqlParameter("@gender", gender)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Update success");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String strSql = "insert into Customers(CustomerName, Birthdate, Gender, Address) values (@name, @dob, @gender, @address) ";
            String gender = "true";
            if (rdFemale.Checked)
            {
                gender = "false";
            }
            SqlParameter[] parameters = new SqlParameter[] {

            new SqlParameter("@name", txtName.Text),
            new SqlParameter("@dob", txtBirthdate.Text),
            new SqlParameter("@address", txtAddress.Text),
            new SqlParameter("@gender", gender)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Add success");
                LoadCustomer();
            }
            else
            {
                MessageBox.Show("Add fail");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
