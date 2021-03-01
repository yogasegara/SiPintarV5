using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_kolektif")]
    public class MasterKolektif
    {
        [Key]
        public string KodeKolektif { get; set; }
        public string NamaKolektif { get; set; }         
        public string Ket { get; set; }
        public string Alamat { get; set; }      

        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
