using System.Data.SqlClient;
using System.Xml.Linq;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataProvider context = new DataProvider();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text == null)
            {
                MessageBox.Show("Room Title cannot empty!");
                return;
            }

            string sql = "insert into Rooms(Title, Square, Floor, Description, Comment) Values (@Title,@Square,@Floor,@Description,@Comment)";
            SqlParameter[] parameters = new SqlParameter[] {

            new SqlParameter("@Title", txtTitle.Text),
            new SqlParameter("@Square", Convert.ToInt32(cbSquare.SelectedValue)),
            new SqlParameter("@Floor", Convert.ToInt32(nufloor.Value)),
            new SqlParameter("@Description", txtDes.Text),
            new SqlParameter("@Comment", txtComment.Text)

            };
            context.executeNonQuery(sql, parameters);

            MessageBox.Show("Adding successfully!");
        }
    }
}
