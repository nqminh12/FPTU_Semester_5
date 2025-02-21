﻿using System;
using System.Collections.Generic;

namespace PE_FA23_Q1.Models
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            Schedules = new HashSet<Schedule>();
        }

        public int Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
