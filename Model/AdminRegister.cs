using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehousesystem.Model
{
    public class AdminRegister
    {
        public string EmployeeID { get; set; }
        public string Username { get; set; }
        public string Passwords_Hash { get; set; }
    }
}
