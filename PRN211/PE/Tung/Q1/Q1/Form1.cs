using Q1;

namespace Q1
{
    public partial class Form1 : Form
    {
        private DataProvider dp = new DataProvider();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {

            String sql = "SELECT * FROM Employee";
            dataGridView1.DataSource = dp.executeQuery(sql);

        }

        private String stateOfSex = "all";
        private String stateOfPosition = "all";

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            stateOfPosition = cbPosition.Text;
            if (stateOfPosition == "all")
            {
                if (stateOfSex == "all")
                {
                    String sql = "SELECT * FROM Employee";
                    dataGridView1.DataSource = dp.executeQuery(sql);
                }
                else
                {
                    String sql = "SELECT * FROM Employee Where sex = '" + stateOfSex + "'";
                    dataGridView1.DataSource = dp.executeQuery(sql);
                }
            }
            else
            {
                if (stateOfSex == "all")
                {
                    String sql = "SELECT * FROM Employee WHERE Position = N'" + stateOfPosition + "'";
                    dataGridView1.DataSource = dp.executeQuery(sql);
                }
                else
                {
                    String sql = "SELECT * FROM Employee WHERE Position = N'" + stateOfPosition + "'" + "sex = '" + stateOfSex + "'";
                }

            }

        }

        private void radMaleFemale_CheckedChanged(object sender, EventArgs e)
        {
            stateOfSex = "all";
            String sql = "SELECT * FROM Employee Where Position = N'" + stateOfPosition + "'";
        }

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {
            stateOfPosition = "all";
        }

       
    }
}
