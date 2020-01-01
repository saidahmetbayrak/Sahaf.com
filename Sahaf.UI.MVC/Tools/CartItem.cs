using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sahaf.UI.MVC.Tools
{
    public class CartItem
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public short Amount { get; set; }
        public decimal SubTotal { get; set; }
    }
}