using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_for_the_TopAdministrator.Models
{
    class Admin
    {
        public int? Id { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
