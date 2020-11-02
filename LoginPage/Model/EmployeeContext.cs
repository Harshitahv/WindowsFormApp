using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace LoginPage.Model
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext()
        {

        }
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public DbSet<Login> Login { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>().HasData(
                new Login
                {
                    Id = 1,
                    UserName="admin",
                    Password="admin@123"
                }
                );
        }
    }
}
