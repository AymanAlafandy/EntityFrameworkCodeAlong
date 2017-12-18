﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeAlong.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int Length { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }

        public virtual ICollection<MovieFormatStock> MFStocks { get; set; }
    }
}