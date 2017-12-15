using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Descripttion { get; set; }

       public virtual ICollection<MovieFormatStock> MoviewFormats { get; set; }
    }
}