using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkCodeAlong.Models.ViewModels
{
    public class OrderIndex
    {
        public int OrderNr { get; set; }
        public string CustomerName { get; set; }
        public string MovieTitle { get; set; }
        public string FormatName { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime ShippingDate { get { return OrderDate.AddDays(5); } }

        public bool HasBeenSent { get; set; }
    }
}