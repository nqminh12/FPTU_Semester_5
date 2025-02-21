﻿using System;
using System.Collections.Generic;

namespace PE_FA23_Q1.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
