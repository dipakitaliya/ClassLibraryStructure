using EmpApiCrud.BusinessObjects.IEmpRepository;
using EmpApiCrud.BusinessObjects.Model;
using EmpApiCrud.DataAccess.EmpRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpApiCrud.Api.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeRepo _repo;
        public EmployeesController(IEmployeeRepo repo)
        {
            _repo = repo;
        }
        readonly IEmployeeRepo repo = new EmployeeRepo();
        public EmployeesController()
        {
            _repo = repo;
        }
        // GET: api/Employees
        public IEnumerable<EmployeeDB> Get()
        {
            return _repo.GetList();
        }

        // GET: api/Employees/5
        public EmployeeDB Get(int id)
        {
            return _repo.GetById(id);
        }

        // POST: api/Employees
        public EmployeeDB Post([FromBody]EmployeeDB employee)
        {
            return _repo.Insert(employee);
        }

        // PUT: api/Employees/5
        public bool Put([FromBody]EmployeeDB employee)
        {
            return _repo.Update(employee);
        }

        // DELETE: api/Employees/5
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
    }
}
