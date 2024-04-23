using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_for_the_Client.Models
{
    internal class ProductModel
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public decimal Productprice { get; set; }
        public string Productdescription { get; set; }
        public byte[] ProductImage { get; set; }
        public decimal Productsize { get; set; } 
    }
}
