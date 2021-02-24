using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Rayon
    {
        [Key]
        public string KodeRayon { get; set; }
        public string NamaRayon { get; set; }   
        public string KodeArea { get; set; }

        [Column("area")]
        public string NamaArea { get; set; }
        public string KodeWil { get; set; }

        [Column("wilayah")]
        public string NamaWilayah { get; set; }
    }
}
