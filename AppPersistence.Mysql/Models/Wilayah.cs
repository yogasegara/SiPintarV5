using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Wilayah
    {
        [Key]
        public string KodeWil { get; set; }

        [Column("wilayah")]
        public string NamaWilayah { get; set; }  
       
    }
}
