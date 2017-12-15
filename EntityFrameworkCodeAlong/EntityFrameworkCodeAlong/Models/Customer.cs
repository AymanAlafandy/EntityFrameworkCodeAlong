using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage ="The developer doesn't believe in names longer than 10 characters")]
        public string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //THE NUMBER OF THIS WILL BE GENERATED FROM THE DATABASE AND WILL BE UNIQ 
        public int CustomerNr { get; set; }
        public string Address { get; set; }
        //[RegularExpression([0-9])]
        public string Phone { get; set; }
        [Column(TypeName="datetime2")]
        public DateTime DateOfBirth { get; set; }


        // connecting customer to order(virtual is to show many connections)
        public virtual ICollection<Order> Orders { get; set; }
    }
}