using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Order
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer customer { get; set; }
    }
}