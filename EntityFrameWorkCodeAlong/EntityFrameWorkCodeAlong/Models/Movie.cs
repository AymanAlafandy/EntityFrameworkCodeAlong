using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime2")]
        [Display(Name = "Relaese Date")]
        public DateTime ReleaseDate { get; set; }
        public int Length { get; set; }
        [Required]
        [MaxLength(25,ErrorMessage ="This title is too long")]
        [MinLength(2, ErrorMessage = "This title is too short")]
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }


        public virtual ICollection<MovieFormatStock> MovieFormats { get; set; }
    }
}