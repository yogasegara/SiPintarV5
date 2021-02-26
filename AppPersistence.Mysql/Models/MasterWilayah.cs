using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_wilayah")]
    public class MasterWilayah
    {
        [Key]
        public string KodeWil { get; set; }   
        public string NamaWilayah { get; set; }

        public virtual ICollection<MasterArea> MasterArea { get; set; }

    }
}
