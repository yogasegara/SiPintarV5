using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    public class Kelurahan
    {
        [Key]
        public string KodeKelurahan { get; set; }
        public string NamaKelurahan { get; set; }       
        public string KodeKecamatan { get; set; }       
        public int JumlahJiwa { get; set; }

              
        public virtual Kecamatan Kecamatan { get; set; }

        public virtual ICollection<Pelanggan> Pelanggan { get; set; }



    }
}
