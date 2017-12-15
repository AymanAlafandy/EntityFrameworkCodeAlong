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
        public int CustomerId { get; set; }                                                //foreign key    


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        //virtual property is creating connection for this table

        public virtual ICollection<MovieFormatStock> MovieFormats { get; set;}                       //creating this to create connection bet order and mfstock 

    }
}