using EmpApiCrud.BusinessObjects.IEmpRepository;
using EmpApiCrud.BusinessObjects.Model;
using EmpApiCrud.DataAccess.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApiCrud.DataAccess.EmpRepository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public bool Delete(int id)
        {
            try
            {
                using (Employee_RecoredEntities db = new Employee_RecoredEntities())
                {
                    Employee employee = (from x in db.Employees
                                         where x.Id == id
                                         select x).FirstOrDefault();
                    if (employee==null)
                    {
                        return false;
                    }
                    else
                    {
                        db.Employees.Remove(employee);
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public EmployeeDB GetById(int id)
        {
            try
            {
                using (Employee_RecoredEntities db = new Employee_RecoredEntities())
                {
                    Employee x = (from m in db.Employees
                                  where m.Id == id
                                  select m).FirstOrDefault();
                    if (x != null)
                    {
                        EmployeeDB employee = new EmployeeDB
                        {
                            Id = (int)x.Id,
                            EmpName = x.EmpName,
                            Email = x.Email,
                            DateofBirth = x.DateofBirth,
                            Phone = x.Phone,
                            Gender = x.Gender,
                            Address = x.Address,
                            City = x.City,
                            Department = x.Department,
                            Salary = x.Salary,
                            JoiningDate = x.JoiningDate
                        };
                        return employee;
                    }

                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
           
            return new EmployeeDB();
        }
 
        public List<EmployeeDB> GetList()
        {
            try
            {
                using (Employee_RecoredEntities db = new Employee_RecoredEntities())
                {
                    List<EmployeeDB> EmployeeDB = (from x in db.Employees
                                                   select new EmployeeDB
                                                   {
                                                       Id = (int)x.Id,
                                                       EmpName = x.EmpName,
                                                       Email = x.Email,
                                                       DateofBirth = x.DateofBirth,
                                                       Phone = x.Phone,
                                                       Gender = x.Gender,
                                                       Address = x.Address,
                                                       City = x.City,
                                                       Department = x.Department,
                                                       Salary = x.Salary,
                                                       JoiningDate = x.JoiningDate
                                                   }).ToList();
                    if (EmployeeDB != null)
                    {
                        return EmployeeDB;
                    }

                }
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }
           
            return new List<EmployeeDB>();
        }

        public EmployeeDB Insert(EmployeeDB employee)
        {
            try
            {
                Employee emp = new Employee();
                emp.EmpName = employee.EmpName;
                emp.Email = employee.Email;
                emp.DateofBirth = employee.DateofBirth;
                emp.Phone = employee.Phone;
                emp.Gender = employee.Gender;
                emp.Address = employee.Address;
                emp.City = employee.City;
                emp.Department = employee.Department;
                emp.Salary = employee.Salary;
                emp.JoiningDate = employee.JoiningDate;
                using (Employee_RecoredEntities db = new Employee_RecoredEntities())
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();
                }
                employee.Id = emp.Id;
                return employee;
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                throw;
            }
           
        }

        public bool Update(EmployeeDB employee)
        {
            try
            {
                using (Employee_RecoredEntities db = new Employee_RecoredEntities())
                {
                    Employee item = (from x in db.Employees
                                     where x.Id == employee.Id
                                     select x).FirstOrDefault();
                    if (item == null)
                        return false;

                    item.EmpName = employee.EmpName;
                    item.Email = employee.Email;
                    item.DateofBirth = employee.DateofBirth;
                    item.Phone = employee.Phone;
                    item.Gender = employee.Gender;
                    item.Address = employee.Address;
                    item.City = employee.City;
                    item.Department = employee.Department;
                    item.Salary = employee.Salary;
                    item.JoiningDate = employee.JoiningDate;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
