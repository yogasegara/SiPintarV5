using AppBusiness.Data.Configurations;
using AppPersistence.Mysql.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPersistence.Mysql
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pelanggan> Pelanggan { get; set; }
        public DbSet<MasterRayon> MasterRayon { get; set; }
        public DbSet<MasterArea> MasterArea { get; set; }
        public DbSet<MasterWilayah> MasterWilayah { get; set; }
        public DbSet<Kelurahan> Kelurahan { get; set; }
        public DbSet<Kecamatan> Kecamatan { get; set; }
        public DbSet<Cabang> Cabang { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MasterArea>(entity =>
            {
                entity.ToTable("master_area");
                entity.HasOne(s => s.MasterWilayah).WithMany(s => s.MasterArea).HasForeignKey(s => s.KodeWil);
            });


            //modelBuilder.Entity<Pelanggan>(entity =>
            //{
            //    entity.ToTable("pelanggan");              
            //    entity.HasOne(s => s.MasterRayon).WithMany(s => s.Pelanggan).HasForeignKey(s => s.KodeRayon);
            //    entity.HasOne(s => s.Kelurahan).WithMany(s => s.Pelanggan).HasForeignKey(s => s.KodeKelurahan);
            //});

            //modelBuilder.Entity<Kelurahan>(entity =>
            //{
            //    entity.ToTable("kelurahan");
            //    entity.HasOne(s => s.Kecamatan).WithMany(s => s.Kelurahan).HasForeignKey(s => s.KodeKecamatan);               
            //});






            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(AppSetting.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
