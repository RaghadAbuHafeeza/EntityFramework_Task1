using EF_Task_1_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task_1_.Data
{
    internal class ApplicationDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\NEWSQLSERVER;Database=EF_Task1;Trusted_Connection=true;TrustServerCertificate=true;");
        }
    }
}
