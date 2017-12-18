using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkCodeAlong.Models
{
    public class Format
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<MovieFormatStock> MFStocks{ get; set; }
    }
}