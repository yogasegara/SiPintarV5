using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_merekmeter")]
    public class MasterMerekMeter
    {
        [Key]
        public string KodeMerekMeter { get; set; }       
        public string NamaMerekMeter { get; set; }

        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
