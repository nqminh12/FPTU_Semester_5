using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp_ADO
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct();
        }

        DataProvider d = new DataProvider();

        private void LoadCategory()
        {
            try
            {
                DataTable dg = d.executeQuery("select * from Categories");
                dgCategories.DataSource = dg;
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadProduct: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCategoryID.Text = string.Empty;
            txtCategoryName.Text = string.Empty;
        }
        private void LoadProduct()
        {
            try
            {
                DataTable dt = d.executeQuery("select * from Products");
                dgProduct.DataSource = dt;
                cbCategoryId.Items.Clear();
                for (int i = 0; i < dgCategories.Rows.Count; i++)
                {
                    if (dgCategories.Rows[i].Cells[0].Value != null)
                    {
                        cbCategoryId.Items.Add(dgCategories.Rows[i].Cells[0].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("LoadProduct: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
            cbCategoryId.SelectedItem = cbCategoryId.Items.Count > 0 ? cbCategoryId.Items[0] : null; // Chọn một giá trị đầu tiên nếu có, nếu không chọn giá trị null
        }

        private void dgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgProduct.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgProduct.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtUnitPrice.Text = dgProduct.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtUnitsInStock.Text = dgProduct.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtImage.Text = dgProduct.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            int index = cbCategoryId.FindStringExact(dgProduct.Rows[e.RowIndex].Cells[5].FormattedValue.ToString());
            cbCategoryId.SelectedIndex = index;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String strSql = "delete from Products where ProductID = @id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", txtId.Text)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Delete success");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String strSql = "update Products set ProductName = @name, UnitPrice = @unp, UnitsInStock = @uns, Image = @img, CategoryID = @cId where ProductID = @id";
            String cId = cbCategoryId.SelectedItem.ToString();
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", txtId.Text),
            new SqlParameter("@name", txtName.Text),
            new SqlParameter("@unp", txtUnitPrice.Text),
            new SqlParameter("@uns", txtUnitsInStock.Text),
            new SqlParameter("@img", txtImage.Text),
            new SqlParameter("@cId", cId)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Update success");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String strSql = "insert into Products(ProductName, UnitPrice, UnitsInStock, Image, CategoryID) values (@name, @unp, @uns, @img, @cId) ";
            String cId = cbCategoryId.SelectedItem.ToString();
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", txtId.Text),
            new SqlParameter("@name", txtName.Text),
            new SqlParameter("@unp", txtUnitPrice.Text),
            new SqlParameter("@uns", txtUnitsInStock.Text),
            new SqlParameter("@img", txtImage.Text),
            new SqlParameter("@cId", cId)
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Add success");
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Add fail");
            }
        }

        private void dgCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCategoryID.Text = dgCategories.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtCategoryName.Text = dgCategories.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            String strSql = "insert into Categories(CategoryName) values (@name) ";
            SqlParameter[] parameters = new SqlParameter[] {
                
            new SqlParameter("@name", txtCategoryName.Text),
            
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Add success");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Add fail");
            }
        }

        private void btnUpdateC_Click(object sender, EventArgs e)
        {
            String strSql = "update Categories set CategoryName = @name where CategoryID = @id";
            
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@id", txtCategoryID.Text),
            new SqlParameter("@name", txtCategoryName.Text),
            
            };
            if (d.executeNonQuery(strSql, parameters))
            {
                MessageBox.Show("Update success");
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Update fail");
            }
        }

        
    }
}
