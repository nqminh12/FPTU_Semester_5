using Microsoft.EntityFrameworkCore;
using PE_FA23_Q1.Models;
namespace PE_FA23_Q1
{
    public partial class Form1 : Form
    {
        PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadView();
        }

        public void loadView()
        {
            List<Room> rooms = new List<Room>();
            rooms = context.Rooms.ToList();

            cbRoom.DisplayMember = "Title";
            cbRoom.ValueMember = "Id";
            cbRoom.DataSource = rooms;

            List<Movie> movies = new List<Movie>();
            movies = context.Movies.ToList();

            cbMovie.DisplayMember = "Title";
            cbMovie.ValueMember = "Id";
            cbMovie.DataSource = movies;

            var timeSlots = context.TimeSlots
            .Select(t => new
            {
                t.Id,
                t.StartTime,
                t.EndTime,
                DisplayTimeSlot = t.StartTime + " - " + t.EndTime
            })
            .ToList();

            cbTimeSlot.DisplayMember = "DisplayTimeSlot";
            cbTimeSlot.ValueMember = "Id";
            cbTimeSlot.DataSource = timeSlots;

            // load data
            int id = (int)cbRoom.SelectedValue;
            var schedules = context.Schedules
           .Include(t => t.Room)
           .Include(t => t.Movie)
           .Include(t => t.TimeSlot)
           .Where(x => x.Room.Id == id)
           .Select(s => new
           {
               s.Id,
               Room = s.Room.Title,
               Movie = s.Movie.Title,
               TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
               StartDate = s.StartDate,
               EndDate = s.EndDate,
               s.Note
           })
           .ToList();

            dataGridView1.DataSource = schedules;
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbRoom.SelectedValue;

            var schedules = context.Schedules
           .Include(t => t.Room)
           .Include(t => t.Movie)
           .Include(t => t.TimeSlot)
           .Where(x => x.Room.Id == id)
           .Select(s => new
           {
               s.Id,
               Room = s.Room.Title,
               Movie = s.Movie.Title,
               TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
               StartDate = s.StartDate,
               EndDate = s.EndDate,
               s.Note
           })
           .ToList();

            dataGridView1.DataSource = schedules;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int mid = (int)cbMovie.SelectedValue;
            int rid = (int)cbRoom.SelectedValue;
            int tid = (int)cbTimeSlot.SelectedValue;
            DateTime sdate = startDate.Value;
            DateTime edate = endDate.Value;

            if (sdate < edate)
            {
                Schedule s = new Schedule();
                s.RoomId = rid;
                s.MovieId = mid;
                s.TimeSlotId = tid;
                s.StartDate = sdate;
                s.EndDate = edate;

                context.Schedules.Add(s);
                context.SaveChanges();
                loadView();
            }
            else
            {
                MessageBox.Show("The screening schedule does not meet" +
                    "the conditions and cannot be added to the database.");
            }

        }

        private void rbAsc_CheckedChanged(object sender, EventArgs e)
        {
            int id = (int)cbRoom.SelectedValue;

            var schedules = context.Schedules
           .Include(t => t.Room)
           .Include(t => t.Movie)
           .Include(t => t.TimeSlot)
           .Where(x => x.Room.Id == id)
           .Select(s => new
           {
               s.Id,
               Room = s.Room.Title,
               Movie = s.Movie.Title,
               TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
               StartDate = s.StartDate,
               EndDate = s.EndDate,
               s.Note
           })
           .OrderBy(x => x.Id)
           .ToList();

            dataGridView1.DataSource = schedules;
        }

        private void rbDesc_CheckedChanged(object sender, EventArgs e)
        {
            int id = (int)cbRoom.SelectedValue;

            var schedules = context.Schedules
           .Include(t => t.Room)
           .Include(t => t.Movie)
           .Include(t => t.TimeSlot)
           .Where(x => x.Room.Id == id)
           .Select(s => new
           {
               s.Id,
               Room = s.Room.Title,
               Movie = s.Movie.Title,
               TimeSlot = s.TimeSlot.StartTime + " - " + s.TimeSlot.EndTime,
               StartDate = s.StartDate,
               EndDate = s.EndDate,
               s.Note
           })
           .OrderByDescending(x => x.Id)
           .ToList();

            dataGridView1.DataSource = schedules;
        }
    }
}
