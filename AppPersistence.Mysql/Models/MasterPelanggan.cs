﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_pelanggan")]
    public class MasterPelanggan
    {
        [Key]
        public string NoSamb { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string KodeRayon { get; set; }    
        public string KodeKelurahan { get; set; }       
        public string KodeGol { get; set; }
        public string KodeDiameter { get; set; }
        public string KodeKolektif { get; set; }
        public string KodeKondisiMeter { get; set; }
        public string KodeSumberAir { get; set; }
        public string KodeBlok { get; set; }
        public string KodeMerekMeter { get; set; }
        public string KodeAdministrasiLain { get; set; }
        public string KodePemeliharaanLain { get; set; }
        public string KodeRetribusiLain { get; set; }
        public string NoHp { get; set; }
        public string NoTelp { get; set; }
        public string NoKtp { get; set; }
        public string NoSegelMeter { get; set; }
        public string NoRekening { get; set; }
        public string NoPendaftaran { get; set; }
        public string NoRab { get; set; }
        public string SeriMeter { get; set; }
        public int? Status { get; set; }
        public string KepemilikanBangunan { get; set; }
        public string NamaPemilik { get; set; }
        public string Pekerjaan { get; set; }        
        public int? Penghuni { get; set; }
        public int? Flag { get; set; }
        public string Keterangan { get; set; }
        public Boolean? AdaAngsuran { get; set; }
        public decimal? LuasRumah { get; set; }
        public string Email { get; set; }
        public DateTime? TglDaftar { get; set; }
        public DateTime? TglMeter { get; set; }
        public int? UrutanBaca { get; set; }
        public decimal? StanAwalPasang { get; set; }
        public Boolean? FlagHapus { get; set; }
        public string NosambBaru { get; set; }
        public string KeteranganHapus { get; set; }
        public DateTime? TglHapus { get; set; }
        public DateTime? TglPutus { get; set; }


        public virtual MasterRayon MasterRayon { get; set; } //join
        public virtual MasterKelurahan MasterKelurahan { get; set; } //join
        public virtual MasterDiameter MasterDiameter { get; set; } //join
        public virtual MasterGolongan MasterGolongan { get; set; } //join
        public virtual MasterKolektif MasterKolektif { get; set; } //join
        public virtual MasterKondisiMeter MasterKondisiMeter { get; set; } //join
        public virtual MasterSumberAir MasterSumberAir { get; set; } //join
        public virtual MasterBlok MasterBlok { get; set; } //join
        public virtual MasterMerekMeter MasterMerekMeter { get; set; } //join







    }
}
