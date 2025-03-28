using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _10._2_BooksMVCProject.Models;

namespace _10._2_BooksMVCProject.Data
{
    public class _10_2_BooksMVCProjectContext : DbContext
    {
        public _10_2_BooksMVCProjectContext (DbContextOptions<_10_2_BooksMVCProjectContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=localhost;Initial Catalog=BooksMVCProject;Integrated Security=True;Trust Server Certificate=True");
        }


        public DbSet<_10._2_BooksMVCProject.Models.Book> Book { get; set; } = default!;
    }
}
