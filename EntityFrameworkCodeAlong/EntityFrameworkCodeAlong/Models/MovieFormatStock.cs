using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkCodeAlong.Models
{
    public class MovieFormatStock
    {
        public int ID { get; set; }
        public int MovieId { get; set; }
        public int FormatID { get; set; }
        public int AmountInStock { get; set; }
        public DateTime ReleaseDate { get; set; }

        [ForeignKey ("MovieId")]
        public virtual Movie movie { get; set; }

        [ForeignKey("FormatId")]
        public virtual Format format { get; set; }


    }
}