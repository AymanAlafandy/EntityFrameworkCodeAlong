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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNr { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [Column(TypeName ="datetime2")]
        public DateTime OrderDate { get; set; }

        public bool HasBeenSent { get; set; }

        public DateTime shippingDate { get { return OrderDate.AddDays(5); } }
        public virtual ICollection<MovieFormatStock> MovieFormats { get; set; }

           }
}