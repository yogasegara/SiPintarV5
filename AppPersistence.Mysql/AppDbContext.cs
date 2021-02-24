using AppBusiness.Data.Configurations;
using AppPersistence.Mysql.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPersistence.Mysql
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pelanggan> Pelanggan { get; set; }
        public DbSet<Rayon> Rayon { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Wilayah> Wilayah { get; set; }
        public DbSet<Kelurahan> Kelurahan { get; set; }
        public DbSet<Kecamatan> Kecamatan { get; set; }
        public DbSet<Cabang> Cabang { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(AppSetting.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
