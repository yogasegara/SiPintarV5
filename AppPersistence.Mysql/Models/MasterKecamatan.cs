using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_kecamatan")]
    public class MasterKecamatan
    {
        [Key]
        public string KodeKecamatan { get; set; }       
        public string NamaKecamatan { get; set; }     
        public string KodeCabang { get; set; }


        public virtual MasterCabang MasterCabang { get; set; }
    }
}
