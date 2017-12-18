using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeAlong.Models
{
    public class Order
    {
        public int Id { get; set; }
        //[ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<MovieFormatStock> MFStocks { get; set; }
    }
}