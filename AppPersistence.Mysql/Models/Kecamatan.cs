using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Kecamatan
    {
        [Key]
        public string KodeKecamatan { get; set; }

        [Column("kecamatan")]
        public string NamaKecamatan { get; set; }     
        public string KodeCabang { get; set; }  
    }
}
