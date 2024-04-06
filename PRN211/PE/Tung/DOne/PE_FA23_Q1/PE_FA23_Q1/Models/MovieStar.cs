﻿using System;
using System.Collections.Generic;

namespace PE_FA23_Q1.Models
{
    public partial class MovieStar
    {
        public int MovieId { get; set; }
        public int StarId { get; set; }
        public string? Position { get; set; }

        public virtual Movie Movie { get; set; } = null!;
        public virtual Star Star { get; set; } = null!;
    }
}
