using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {

        }

        int n = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            n--;
            lblCount.Text = n.ToString();
            if (n == 0)
            {
                timer1.Stop();
                FrmStudent f = new FrmStudent(txtName.Text);
                f.Show();
                this.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
