using ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using ACARProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ACARProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public class ToDoContext:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //  optionsBuilder.UseSqlServer("server=.; database=ToDo; integrated security=true;"); user id siz

            optionsBuilder.UseSqlServer("server=.; database=ToDo; user id=sa; password=123;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.ApplyConfiguration(new GorevMap());
            modelBuilder.ApplyConfiguration(new AciliyetMap());
            modelBuilder.ApplyConfiguration(new RaporMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());

            base.OnModelCreating(modelBuilder);

        }
     
        public DbSet<Gorev> Gorevler { get; set; }
        public DbSet<Aciliyet> Aciliyetler { get; set; }
        public DbSet<Rapor> Raporlar { get; set; }



    }
}
