using System.Collections.Generic;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Product> products = new List<Product>();

        private void Form1_Load(object sender, EventArgs e)
        {
            loadDg();
        }

        private void loadDg()
        {
            dg.DataSource = null;
            dg.DataSource = products;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = Convert.ToInt32(txtId.Text);
            product.Name = txtName.Text;
            product.Price = Convert.ToInt32(txtPrice.Value);
            if (rdFalse.Checked)
            {
                product.IsActive = false;
            }
            else
            {
                product.IsActive = true;
            }

            products.Add(product);
            loadDg();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(products.Count == 0) {
                MessageBox.Show("No product to save!");
                return;
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog(this);
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (Product p in products)
                        {
                            writer.WriteLine($"{p.Id};{p.Name};{p.Price};{p.IsActive}");
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}