using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehousesystem.Model
{
    public class Employee
    {
        public int RecordNumber { get; set; }

        public string EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string NameExtension { get; set; }

        public string ContactNo { get; set; }

        public string Password { get; set; }

        public int PositionID { get; set; }

        public string EmployeeName { get; set; }

        public int EmployeeStatus { get; set; }

        public DateTime DateHired { get; set; }

    }
}
