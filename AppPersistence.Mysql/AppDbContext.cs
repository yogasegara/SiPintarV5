using AppBusiness.Data.Configurations;
using AppPersistence.Mysql.Models;
using Microsoft.EntityFrameworkCore;

namespace AppPersistence.Mysql
{
    public class AppDbContext : DbContext
    {
        #region Wilayah Administratif
        public DbSet<MasterRayon> MasterRayon { get; set; }
        public DbSet<MasterArea> MasterArea { get; set; }
        public DbSet<MasterWilayah> MasterWilayah { get; set; }
        

        public DbSet<MasterKelurahan> MasterKelurahan { get; set; }
        public DbSet<MasterKecamatan> MasterKecamatan { get; set; }
        public DbSet<MasterCabang> MasterCabang { get; set; }
        #endregion

        #region Tarif & Golongan
        public DbSet<MasterDiameter> MasterDiameter { get; set; }
        public DbSet<MasterGolongan> MasterGolongan { get; set; }

        #endregion

        #region data atribute

        public DbSet<MasterKolektif> MasterKolektif { get; set; }
        public DbSet<MasterKondisiMeter> MasterKondisiMeter { get; set; }
        public DbSet<MasterSumberAir> MasterSumberAir { get; set; }
        public DbSet<MasterBlok> MasterBlok { get; set; }
        public DbSet<MasterMerekMeter> MasterMerekMeter { get; set; }

        #endregion

        #region Langganan
        public DbSet<MasterPelanggan> MasterPelanggan { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region MasterArea
            modelBuilder.Entity<MasterArea>(entity =>
            {
                entity.ToTable("master_area");
                entity.HasOne(s => s.MasterWilayah).WithMany(s => s.MasterArea).HasForeignKey(s => s.KodeWil);
            });
            #endregion

            #region MasterKecamatan
            modelBuilder.Entity<MasterKecamatan>(entity =>
            {
                entity.ToTable("master_kecamatan");
                entity.HasOne(s => s.MasterCabang).WithMany(s => s.MasterKecamatan).HasForeignKey(s => s.KodeCabang);
            });
            #endregion

            #region MasterPelanggan
            modelBuilder.Entity<MasterPelanggan>(entity =>
            {
                entity.ToTable("master_pelanggan");
                entity.HasOne(s => s.MasterRayon).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeRayon);
                entity.HasOne(s => s.MasterKelurahan).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeKelurahan);
                entity.HasOne(s => s.MasterDiameter).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeDiameter);
                entity.HasOne(s => s.MasterGolongan).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeGol);
                entity.HasOne(s => s.MasterKolektif).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeKolektif);
                entity.HasOne(s => s.MasterKondisiMeter).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeKondisiMeter);
                entity.HasOne(s => s.MasterSumberAir).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeSumberAir);
                entity.HasOne(s => s.MasterBlok).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeBlok);
                entity.HasOne(s => s.MasterMerekMeter).WithMany(s => s.MasterPelanggan).HasForeignKey(s => s.KodeMerekMeter);

            });
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(AppSetting.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
