namespace WinFormsApp
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        public FrmStudent(string text)
        {
            InitializeComponent();
            Text = "Hello " + text;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.Aqua;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Aqua;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        List<Students> data = new List<Students>();
        Dictionary<string, string> dic = new Dictionary<string, string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dic.ContainsKey(txtCode.Text))
            {
                MessageBox.Show("Code Exit");
                return;
            }

            Students sv = new Students()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Subject = cboSubject.SelectedItem.ToString(),
                Mark = (int)numMark.Value
            };
            dic.Add(txtCode.Text, txtName.Text);

            listStudent.Items.Add(sv);
            data.Add(sv);
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (listStudent.SelectedIndex == -1)
            {
                MessageBox.Show("May da chon dau ma delete");
                return;
            }
            //Lấy ra dòng items mà user chọn 
            string line = listStudent.SelectedItem.ToString();

            //Split để cắt từng thành phần để tạo Object Student 
            string[] s = line.Split("\t");
            Students sv = new Students()
            {
                Code = s[0],
                Name = s[1],
                Subject = s[2],
                Mark = int.Parse(s[3])
            };

            //remove object Student đã chọn ra khỏi data
            data.Remove(sv);
            //remove list tren form
            listStudent.Items.RemoveAt(listStudent.SelectedIndex);
            //remove khoi dictionary
            dic.Remove(s[0]);
        }

       
    }
}
