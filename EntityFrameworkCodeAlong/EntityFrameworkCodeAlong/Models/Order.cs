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
        //usefull for the edit
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName ="datetime2")]
        public DateTime OrderDate { get; set; }
        //we don't need column here because it is get (it doesn't save at the database)
        public DateTime ShippingDate { get { return OrderDate.AddDays(5); } }
        public bool HasBeenSent { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        public virtual ICollection<MovieFormatStock> MovieForamts { get; set; }
    }
}