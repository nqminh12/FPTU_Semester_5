using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {

        List<Product> list = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            var ID = txtID.Text;
            var Name = txtPName.Text;
            var Price = txtPrice.Text;
            bool IsActive = rbTrue.Checked == true ? true : false;

            Product product = new Product();
            product.Id = int.Parse(ID);
            product.Name = Name;
            product.Price = int.Parse(Price);
            product.IsActive = IsActive;

            list.Add(product);

            loadData();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbTrue.Checked = true;
        }
        public void loadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = list;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog(this);
                string filePath = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        foreach (Product p in list)
                        {
                            writer.WriteLine($"{p.Id};{p.Name};{p.Price};{p.IsActive}");
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("List empty!");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog(this);

            string filePath = openFileDialog.FileName;

            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        list.Clear(); 
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 4)
                            {
                                int id = int.Parse(parts[0]);
                                string name = parts[1];
                                int price = int.Parse(parts[2]);
                                bool isActive = bool.Parse(parts[3]);

                                Product product = new Product();
                                product.Id = id;
                                product.Name = name;
                                product.Price = price;
                                product.IsActive = isActive;

                                list.Add(product);

                                loadData();
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn tệp!");
            }
        }
    
    }
}
