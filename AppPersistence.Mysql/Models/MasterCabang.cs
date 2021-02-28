using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_cabang")]
    public class MasterCabang
    {
        [Key]
        public string KodeCabang { get; set; }       
        public string NamaCabang { get; set; }

        public virtual ICollection<MasterKecamatan> MasterKecamatan { get; set; }
    }
}
