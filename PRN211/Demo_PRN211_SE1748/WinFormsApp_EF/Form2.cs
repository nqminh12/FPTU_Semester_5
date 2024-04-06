using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp_EF.Models;

namespace WinFormsApp_EF
{
    public partial class dgCustomers : Form
    {
        public dgCustomers()
        {
            InitializeComponent();
        }

        private void dgCustomers_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        MySaleDBContext context = new MySaleDBContext();

        private void LoadView()
        {
            var customer = context.Customers
                           .Select(c => new
                           {
                               ID = c.CustomerId,
                               Name = c.CustomerName,
                               Birthdate = c.Birthdate,
                               Gender = c.Gender,
                               Address = c.Address
                           })
                           .ToList();
            dgCustomer.DataSource = customer;
        }
    }
}
