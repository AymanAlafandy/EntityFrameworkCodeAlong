using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string  Genre { get; set; }
        public string  Description { get; set; }

        public virtual ICollection<MovieFormatStock> MovieFormatStack { get; set; }
    }
}