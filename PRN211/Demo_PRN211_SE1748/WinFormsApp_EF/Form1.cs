using WinFormsApp_EF.Models;

namespace WinFormsApp_EF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        MySaleDBContext context = new MySaleDBContext();

        private void LoadView()
        {
            var data = context.Products
                       .Select(p => new
                       {
                           ID = p.ProductId,
                           Name = p.ProductName,
                           Price = p.UnitPrice,
                           Stock = p.UnitsInStock,
                           Image = p.Image,
                           Category = p.Category.CategoryName
                       })
                       .ToList();
            dgProducts.DataSource = data;

            var data2 = context.Categories.ToList();
            cboCategory.DataSource = data2;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";

            // Binding dữ liệu từ grid lên form
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("text", data, "ID");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data, "Name");

            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("text", data, "Price");

            txtStock.DataBindings.Clear();
            txtStock.DataBindings.Add("text", data, "Stock");

            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("text", data, "Image");

            cboCategory.DataBindings.Clear();
            cboCategory.DataBindings.Add("text", data, "Category");
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            // productID cần xóa
            Product p = context.Products.FirstOrDefault(p => p.ProductId == Convert.ToInt32(txtID.Text));

            // xóa khỏi db
            if (p != null)
            {
                context.Products.Remove(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Delete success!");
                    LoadView();
                }
            }
            else
            {
                MessageBox.Show("Delete fail!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductName = txtName.Text,
                UnitPrice = Decimal.Parse(txtPrice.Text),
                UnitsInStock = Int32.Parse(txtStock.Text),
                Image = txtImage.Text,
                CategoryId = (int)cboCategory.SelectedValue,

            };
            context.Products.Add(product);
            if (context.SaveChanges() > 0)
            {
                MessageBox.Show("Add success!");
                LoadView();
            }
            else
            {
                MessageBox.Show("Add fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = context.Products.FirstOrDefault(p => p.ProductId == Convert.ToInt32(txtID.Text));

            // xóa khỏi db
            if (p != null)
            {
                p.ProductName = txtName.Text;
                p.UnitPrice = Decimal.Parse(txtPrice.Text);
                p.UnitsInStock = Int32.Parse(txtStock.Text);
                p.Image = txtImage.Text;
                p.CategoryId = (int)cboCategory.SelectedValue;
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Update success!");
                    LoadView();
                }
            }
            else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtID.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtName.Text = string.Empty;
            txtImage.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            cboCategory.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var data = context.Products
                       .Where(p => p.ProductName.Contains(txtName.Text))
                       .Select(p => new
                       {
                           ID = p.ProductId,
                           Name = p.ProductName,
                           Price = p.UnitPrice,
                           Stock = p.UnitsInStock,
                           Image = p.Image,
                           Category = p.Category.CategoryName
                       })
                       .ToList();
            dgProducts.DataSource = data;

            var data2 = context.Categories.ToList();
            cboCategory.DataSource = data2;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";

            // Binding dữ liệu từ grid lên form
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("text", data, "ID");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data, "Name");

            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("text", data, "Price");

            txtStock.DataBindings.Clear();
            txtStock.DataBindings.Add("text", data, "Stock");

            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("text", data, "Image");

            cboCategory.DataBindings.Clear();
            cboCategory.DataBindings.Add("text", data, "Category");
        }

        private bool isAscending = true;

        private void btnSortByPrice_Click(object sender, EventArgs e)
        {
            var data = context.Products
                       .Select(p => new
                       {
                           ID = p.ProductId,
                           Name = p.ProductName,
                           Price = p.UnitPrice,
                           Stock = p.UnitsInStock,
                           Image = p.Image,
                           Category = p.Category.CategoryName
                       })
                       .OrderBy(p => p.Price)
                       .ToList();
            if (!isAscending)
            {
                data.Reverse();
            }

            isAscending = !isAscending;

            dgProducts.DataSource = data;

            var data2 = context.Categories.ToList();
            cboCategory.DataSource = data2;
            cboCategory.DisplayMember = "CategoryName";
            cboCategory.ValueMember = "CategoryId";

            // Binding dữ liệu từ grid lên form
            txtID.DataBindings.Clear();
            txtID.DataBindings.Add("text", data, "ID");

            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data, "Name");

            txtPrice.DataBindings.Clear();
            txtPrice.DataBindings.Add("text", data, "Price");

            txtStock.DataBindings.Clear();
            txtStock.DataBindings.Add("text", data, "Stock");

            txtImage.DataBindings.Clear();
            txtImage.DataBindings.Add("text", data, "Image");

            cboCategory.DataBindings.Clear();
            cboCategory.DataBindings.Add("text", data, "Category");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var confirmationResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
