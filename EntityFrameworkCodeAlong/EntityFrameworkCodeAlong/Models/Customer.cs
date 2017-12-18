using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeAlong.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerNo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}