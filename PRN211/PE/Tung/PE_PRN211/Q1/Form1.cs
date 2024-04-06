using Microsoft.EntityFrameworkCore;
using Q1.Models;

namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadView();
        }

        PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();

        private void LoadView()
        {
            var rooms = context.Rooms.ToList();
            cboRoom.DisplayMember = "Title";
            cboRoom.ValueMember = "Id";
            cboRoom.DataSource = rooms;

            var movie = context.Movies.ToList();
            cboMovie.DisplayMember = "Title";
            cboMovie.ValueMember = "Id";
            cboMovie.DataSource = movie;

            var timeSlot = context.TimeSlots
                           .Select(t => new
                           {
                               t.Id,
                               t.StartTime,
                               t.EndTime,
                               TimeSlot = t.StartTime + " - " + t.EndTime
                           })
                           .ToList();
            cboTimeSlot.DisplayMember = "TimeSlot";
            cboTimeSlot.ValueMember = "Id";
            cboTimeSlot.DataSource = timeSlot;

            int rid = (int)cboRoom.SelectedValue;
            var schedules = context.Schedules
                            .Include(r => r.Room)
                            .Include(m => m.Movie)
                            .Include(t => t.TimeSlot)
                            .Where(r => r.Room.Id == rid)
                            .Select(s => new
                            {
                                Id = s.Id,
                                Room = s.Room.Title,
                                Movie = s.Movie.Title,
                                TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
                                StartDate = s.StartDate,
                                EndDate = s.EndDate,
                                Note = s.Note
                            })
                            .ToList();
            dataGridView1.DataSource = schedules;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rid = (int)cboRoom.SelectedValue;
            int mid = (int)cboMovie.SelectedValue;
            int tid = (int)cboTimeSlot.SelectedValue;
            DateTime sDate = startDate.Value;
            DateTime eDate = endDate.Value;

            if (sDate < eDate)
            {
                var s = new Schedule();
                s.RoomId = rid;
                s.MovieId = mid;
                s.TimeSlotId = tid;
                s.StartDate = sDate;
                s.EndDate = eDate;

                context.Schedules.Add(s);
                context.SaveChanges();
                LoadView();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int rid = (int) cboRoom.SelectedValue;

            var schedules = context.Schedules
                            .Include(r => r.Room)
                            .Include(m => m.Movie)
                            .Include(t => t.TimeSlot)
                            .Where(r => r.Room.Id == rid)
                            .Select(s => new
                            {
                                Id = s.Id,
                                Room = s.Room.Title,
                                Movie = s.Movie.Title,
                                TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
                                StartDate = s.StartDate,
                                EndDate = s.EndDate,
                                Note = s.Note
                            })
                            .ToList();
            dataGridView1.DataSource = schedules;
        }
    }
}