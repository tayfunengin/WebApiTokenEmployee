using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WepApiToken.Context;
using WepApiToken.Entities;

namespace WepApiToken.Controllers
{
    public class EmployeesController : ApiController
    {
        EmployeeDbContext db = new EmployeeDbContext();

        [Authorize]
        public IEnumerable<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public IHttpActionResult Post(Employee employee)
        {         
            db.Employees.Add(employee);
            db.SaveChanges();

            return Ok(Get());
        }

        public IHttpActionResult Put(Employee employee)
        {
            Employee updated = db.Employees.FirstOrDefault(x => x.ID == employee.ID);
            db.Entry(updated).CurrentValues.SetValues(employee);
            db.SaveChanges();
            return Ok(Get());
        }

        public IHttpActionResult Delete(int id)
        {
            Employee deleted = db.Employees.FirstOrDefault(x => x.ID == id);
            db.Employees.Remove(deleted);
            db.SaveChanges();
            return Ok(Get());
        }

    }
}
