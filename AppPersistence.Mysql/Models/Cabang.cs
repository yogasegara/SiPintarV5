using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Cabang
    {
        [Key]
        public string KodeCabang { get; set; }

        [Column("cabang")]
        public string NamaCabang { get; set; }       
    }
}
