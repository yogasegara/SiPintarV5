using System.ComponentModel.DataAnnotations;

namespace AppPersistence.Mysql.Models
{
    public class Pelanggan
    {
        #region Table Column
        [Key]
        public string NoSamb { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string KodeRayon { get; set; }
        public virtual MasterRayon MasterRayon { get; set; } //join
        public string KodeKelurahan { get; set; }
        public virtual Kelurahan Kelurahan { get; set; } //join
        public string KodeGol { get; set; }
        public string KodeDiameter { get; set; }
        public string KodeKolektif { get; set; }
        public string NoHp { get; set; }
        public string NoTelp { get; set; }
        public string NoRekening { get; set; }
        #endregion


    }
}
