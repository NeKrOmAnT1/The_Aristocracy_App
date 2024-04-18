using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_for_Work.Models
{
    public class Model
    {
        public class User
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ?Id { get; set; }
            public string FIO { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Role {  get; set; }
        }
        public class Product
        {
            [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ?Id { get; set; }
            public string Productname { get; set; }
            public decimal Productprice { get; set; }
            public string Productdescription { get; set; }
            public decimal Productsize { get; set; }
        }
    }
}
