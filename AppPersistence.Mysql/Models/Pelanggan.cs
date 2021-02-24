using System.ComponentModel.DataAnnotations;

namespace AppPersistence.Mysql.Models
{
    public class Pelanggan
    {
        [Key]
        public string NoSamb { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string KodeRayon { get; set; }
        public string KodeGol { get; set; }
        public string KodeDiameter { get; set; }
    }
}
