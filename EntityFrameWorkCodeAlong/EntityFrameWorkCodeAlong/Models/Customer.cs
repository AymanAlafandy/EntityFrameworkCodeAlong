using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Web;


namespace EntityFrameWorkCodeAlong.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10,ErrorMessage ="Name cannot be longer than 10 alphabets")]
        public string Name { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerNr { get; set; }
        public string Adress { get; set; }
       
        public string Phone { get; set; }
        [Column(TypeName ="datetime2")]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}