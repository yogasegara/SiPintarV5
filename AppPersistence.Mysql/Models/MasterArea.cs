using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_area")]
    public class MasterArea
    {
        [Key]
        public string KodeArea { get; set; }
        public string NamaArea { get; set; }
        public string KodeWil { get; set; }


        public virtual MasterWilayah MasterWilayah { get; set; }

    }
}
