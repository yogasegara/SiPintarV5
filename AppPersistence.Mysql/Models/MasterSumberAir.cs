using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_sumberair")]
    public class MasterSumberAir
    {
        [Key]
        public string KodeSumberAir { get; set; }
        public string NamaSumberAir { get; set; }      


        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
