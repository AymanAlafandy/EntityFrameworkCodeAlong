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
        [MaxLength(10,ErrorMessage ="The developer does not believe in names ")]
        public  string Name { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerNr { get; set; }
        public string Adress{ get; set; }
        public string PhoneNum { get; set; }                                                                                      //here instaed of int we are using string because int cant take too long numbers and 0 in startting
        [Column(TypeName="datetime2")]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Order> Orders { get; set; }                            //virtual-- we cant instatntiate,
    }



}