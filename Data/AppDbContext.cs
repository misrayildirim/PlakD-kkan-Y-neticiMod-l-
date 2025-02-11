using Microsoft.EntityFrameworkCore;
using PlakDükkanıYöneticiModülü.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiModülü.Data
{
    public  class AppDbContext:DbContext
    {
        public DbSet<Yönetici> Yöneticiler { get; set; }
        public DbSet<Album> Albums { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-50CG7EG\\SQLEXPRESS;Database=PlakDükkanıYönetimDb;trustservercertificate=true;Trusted_Connection=true");
        }

    }
}
