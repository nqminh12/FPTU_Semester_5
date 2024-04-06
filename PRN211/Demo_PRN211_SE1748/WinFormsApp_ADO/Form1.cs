using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataProvider d = new DataProvider();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                //C1:
                /*string strSQL = "select * from Users where " +
                    "Account = '" + txtAccount.Text + "' and Password = '" + txtPassword.Text + "'";
                DataTable dt = d.executeQuery(strSQL);
                if(dt.Rows.Count > 0 )
                {
                    MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login Fail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
                //C2:
                //Khi sử dụng executeQuery2 và IDataReader, dữ liệu chỉ được đọc từ cơ sở dữ liệu một cách tuần tự
                //và không cần phải tải toàn bộ vào bộ nhớ như khi sử dụng executeQuery và DataTable.
                string strSQL = "select * from Users where " +
                    "Account = @account and Password = @pass";
                SqlParameter[] sp = new SqlParameter[] { 
                    new SqlParameter("@account", txtAccount.Text),
                    new SqlParameter("@pass", txtPassword.Text),
                };
                IDataReader dr = d.executeQuery2(strSQL, sp);
                if(dr.Read())
                {
                    //MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //di chuyen sang form customer
                    FrmCustomer f = new FrmCustomer();
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Fail", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message);
            }
        }
    }
}
