using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context();


        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddg();
            LoadType();
        }

        private void LoadType()
        {
            txtType.DataSource = context.Projects
                .Select(p => p.Type).Distinct().ToList();
        }

        private void Loaddg()
        {
            var data = context.Projects
                .Select(p => new
                {
                    Id = p.Id,
                    Name = p.Name,
                    Des = p.Description,
                    Date = p.StartDate,
                    Type = p.Type
                }).ToList();

            dg.DataSource = data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.Name = txtName.Text;
            p.Description = txtDes.Text;
            p.StartDate = txtDate.Value;
            p.Type = txtType.SelectedValue.ToString();
            context.Projects.Add(p);
            context.SaveChanges();
            Loaddg();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            txtDes.Clear();
            txtId.Clear();
            txtName.Clear();
            txtType.SelectedIndex = 0;
            Loaddg();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Project p = context.Projects.Where(p => p.Id == Convert.ToInt32(txtId.Text)).FirstOrDefault();
            p.Name = txtName.Text.ToString();
            p.Description = txtDes.Text.ToString();
            p.StartDate = txtDate.Value;
            p.Type = txtType.SelectedValue.ToString();
            context.SaveChanges();
            txtDes.Clear();
            txtId.Clear();
            txtName.Clear();
            txtType.SelectedIndex = 0;
            Loaddg();
        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dg.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dg.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtDes.Text = dg.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtDate.Text = dg.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            int index = txtType.FindString(dg.Rows[e.RowIndex].Cells[4].FormattedValue.ToString());
            txtType.SelectedIndex = index;
        }
    }
}