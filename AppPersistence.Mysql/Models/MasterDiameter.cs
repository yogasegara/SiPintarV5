﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_diameter")]
    public class MasterDiameter
    {
        [Key]
        public string KodeDiameter { get; set; }
        public string KodeDiameterYangBerlaku { get; set; }
        public int? PeriodeMulaiBerlaku { get; set; }       
        public string NamaDiameter { get; set; }
        public decimal? Administrasi { get; set; } = 0;
        public decimal? Pemeliharaan { get; set; } = 0;
        public decimal? Pelayanan { get; set; } = 0;
        public decimal? Retribusi { get; set; } = 0;
        public decimal? DendaPakai0 { get; set; } = 0;
        public decimal? AirLimbah { get; set; } = 0;
        public string NomorBa { get; set; }
        public bool? Status { get; set; } = false;



        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
