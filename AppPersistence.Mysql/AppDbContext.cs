using AppBusiness.Data.Configurations;
using AppPersistence.Mysql.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPersistence.Mysql
{
    public class AppDbContext : DbContext
    {
        public DbSet<MasterRayon> MasterRayon { get; set; }
        public DbSet<MasterArea> MasterArea { get; set; }
        public DbSet<MasterWilayah> MasterWilayah { get; set; }
        

        public DbSet<MasterKelurahan> MasterKelurahan { get; set; }
        public DbSet<MasterKecamatan> MasterKecamatan { get; set; }
        public DbSet<MasterCabang> MasterCabang { get; set; }


        public DbSet<MasterDiameter> MasterDiameter { get; set; }    




        public DbSet<MasterPelanggan> MasterPelanggan { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<MasterArea>(entity =>
            {
                entity.ToTable("master_area");
                entity.HasOne(s => s.MasterWilayah).WithMany(s => s.MasterArea).HasForeignKey(s => s.KodeWil);
            });

            modelBuilder.Entity<MasterKecamatan>(entity =>
            {
                entity.ToTable("master_kecamatan");
                entity.HasOne(s => s.MasterCabang).WithMany(s => s.MasterKecamatan).HasForeignKey(s => s.KodeCabang);
            });
                      

            modelBuilder.Entity<MasterPelanggan>(entity =>
            {
                entity.ToTable("master_pelanggan");
                entity.HasOne(s => s.MasterRayon).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeRayon);
                entity.HasOne(s => s.MasterKelurahan).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeKelurahan);
                entity.HasOne(s => s.MasterDiameter).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeDiameter);
            });


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(AppSetting.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
