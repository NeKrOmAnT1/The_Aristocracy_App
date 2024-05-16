using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrarySTI
{
    public class Models
    {
        public class ProductModel
        {
            public int Id { get; set; }
            public string Productname { get; set; }
            public decimal Productprice { get; set; }
            public string Productdescription { get; set; }
            public byte[] ProductImage { get; set; }
            public decimal Productsize { get; set; }
        }
        public class User
        {
            public int? Id { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class Admin
        {
            public int? Id { get; set; }
            public string FIO { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }
}
