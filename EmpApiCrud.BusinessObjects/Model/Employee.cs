using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApiCrud.BusinessObjects.Model
{
  public class EmployeeDB
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public string Salary { get; set; }
        public Nullable<System.DateTime> JoiningDate { get; set; }
    }
}
