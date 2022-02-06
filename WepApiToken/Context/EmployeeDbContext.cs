using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WepApiToken.Entities;

namespace WepApiToken.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
        {
            Database.Connection.ConnectionString = "server=.;database=EmployeeDB;trusted_connection = true;";
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}