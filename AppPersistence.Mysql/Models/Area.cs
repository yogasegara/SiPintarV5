using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Area
    {
        [Key]
        public string KodeArea { get; set; }

        [Column("area")]
        public string NamaArea { get; set; }
        public string KodeWil { get; set; }

    }
}
