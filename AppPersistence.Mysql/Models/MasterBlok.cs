using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_blok")]
    public class MasterBlok
    {
        [Key]
        public string KodeBlok { get; set; }       
        public string NamaBlok { get; set; }
        public string KodeRayon { get; set; }

        public virtual ICollection<MasterPelanggan> MasterPelanggan { get; set; }

    }
}
