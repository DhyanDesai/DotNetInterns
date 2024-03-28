using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Practice
{
    public class RepoEmployee : DbContext{
        public DbSet<DepartmentModel>  Department { get;  set; }
          public DbSet<EmployeeModel> Employee { get;  set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          optionsBuilder.UseSqlServer("Data Source = CS69-PC ; Initial catalog =Entity_Framework ;Integrated Security = true ; TrustServerCertificate = True");


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}