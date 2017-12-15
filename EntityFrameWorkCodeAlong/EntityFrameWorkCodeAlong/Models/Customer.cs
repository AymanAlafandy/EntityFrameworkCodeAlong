using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EntityFrameWorkCodeAlong.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerNr { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}