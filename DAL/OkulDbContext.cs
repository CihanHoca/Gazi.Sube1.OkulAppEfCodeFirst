using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OkulDbContext:DbContext
    {
        public OkulDbContext():base("cstr")
        {

        }

        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Fluent Api
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgrenciler");

            modelBuilder.Entity<Ogrenci>().Property(o => o.Ad).HasMaxLength(50).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Soyad).HasMaxLength(75).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Ogrenci>().Property(o => o.Numara).HasMaxLength(10).IsRequired().HasColumnType("varchar");

        }

    }
}
