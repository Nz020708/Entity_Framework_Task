using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EntityFrameWork.Models;

namespace EntityFrameWork.DataAccess
{
    public class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4L8DU14;Database=CompanyDb;Integrated Security=true");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
