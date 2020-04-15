using EmpApiCrud.BusinessObjects.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApiCrud.BusinessObjects.IEmpRepository
{
   public interface IEmployeeRepo
    {
        List<EmployeeDB> GetList();
        EmployeeDB GetById(int id);
        EmployeeDB Insert(EmployeeDB employee);
        bool Update(EmployeeDB employee);
        bool Delete(int id);
    }
}
