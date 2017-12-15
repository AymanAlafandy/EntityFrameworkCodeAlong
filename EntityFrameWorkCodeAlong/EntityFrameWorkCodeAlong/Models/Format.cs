using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Format
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<MovieFormatStock> MovieFormats { get; set; }
    }
}