using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_kondisimeter")]
    public class MasterKondisiMeter
    {
        [Key]
        public string KodeKondisiMeter { get; set; }
        public string NamaKondisiMeter { get; set; }      


        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
