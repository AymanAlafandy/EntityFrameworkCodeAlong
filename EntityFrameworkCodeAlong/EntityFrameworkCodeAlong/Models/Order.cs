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
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNr { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Orderdate { get; set; } 
        public DateTime Shippingdate { get { return Orderdate.AddDays(5); } }                         //those are not part of database thats y we are giving datatime and its part of class
        public bool HasBeenSent { get; set; }
                                                                                                                       //foreign key    


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        //virtual property is creating connection for this table

        public virtual ICollection<MovieFormatStock> MovieFormats { get; set;}                       //creating this to create connection bet order and mfstock 

    }
}