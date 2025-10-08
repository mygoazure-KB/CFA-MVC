using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CFACrud.Models
{
    public class EmpDbContext:DbContext
    {
        public EmpDbContext():base("constr")
        {
            
        }
        public DbSet<Models.Employee> Employees { get; set; }   
    }
}

