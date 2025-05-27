using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BE.Data
{
    public class MyAppDBContext : DbContext
    {
        public MyAppDBContext(DbContextOptions<MyAppDBContext> options) : base(options)
        { }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     base.OnConfiguring(optionsBuilder);

        //     if (optionsBuilder.IsConfigured == false)
        //     {
        //         optionsBuilder.UseSqlServer(ConnStr);
        //     }
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}