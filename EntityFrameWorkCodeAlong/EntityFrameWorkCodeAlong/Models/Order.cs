using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<MovieFormatStock> MovieFormats { get; set; }
    }
}