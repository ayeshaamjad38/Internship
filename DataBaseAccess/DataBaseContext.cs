using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Task5.Model;

namespace Task5.DataBaseAccess
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EmployeeModel> Employee { get; set; }


    }
}
