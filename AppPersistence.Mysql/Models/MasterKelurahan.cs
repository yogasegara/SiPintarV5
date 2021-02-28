using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_kelurahan")]
    public class MasterKelurahan
    {
        [Key]
        public string KodeKelurahan { get; set; }
        public string NamaKelurahan { get; set; }       
        public string KodeKecamatan { get; set; }   
        public string NamaKecamatan { get; set; }
        public string KodeCabang { get; set; }
        public string NamaCabang { get; set; }
        public int? JumlahJiwa { get; set; }            
     

        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }



    }
}
