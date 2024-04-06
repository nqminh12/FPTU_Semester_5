
using Microsoft.EntityFrameworkCore;
using Q2.Models;
namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PRN211_Spr22Context context = new PRN211_Spr22Context();
        private void Form1_Load(object sender, EventArgs e)
        {
            var Fee = context.Services
                .Select(p => new
                {
                    FeeType = p.FeeType
                })
                .Distinct()
                .ToList();
            cbFee.DataSource = Fee;
            cbFee.DisplayMember = "FeeType";
            cbFee.ValueMember = "FeeType";
            cbFee.SelectedIndex = 0;

            var Room = context.Services.Select(p => new
            {
                room = p.RoomTitle
            }).ToList();
            cbRoom.DataSource = Room;
            cbRoom.DisplayMember = "room";
            cbRoom.ValueMember = "room";
            cbRoom.SelectedIndex = 1;

            var data = context.Services

                .Select(p => new
                {
                    p.RoomTitle,
                    p.RoomTitleNavigation.Floor,
                    p.RoomTitleNavigation.Square,
                    p.Month,
                    p.Year,
                    p.FeeType,
                    p.Amount,
                    p.PaymentDate,
                    p.Employee
                }).ToList();
            dg.DataSource = data;


        }

        private void dgLoad(string Room, string Fee)
        {
            var data = context.Services
                .Where(p => p.RoomTitle == Room && p.FeeType == Fee)
                .Select(p => new
                {
                    p.RoomTitle,
                    p.RoomTitleNavigation.Floor,
                    p.RoomTitleNavigation.Square,
                    p.Month,
                    p.Year,
                    p.FeeType,
                    p.Amount,
                    p.PaymentDate,
                    p.Employee
                }).ToList();
            dg.DataSource = data;
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room = cbRoom.SelectedValue.ToString();
            string fee = cbFee.SelectedValue.ToString();
            dgLoad(room, fee);
        }

        private void cbFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            string room = cbRoom.SelectedValue.ToString();
            string fee = cbFee.SelectedValue.ToString();
            dgLoad(room, fee);
        }

        private void cbRoom_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
