using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPersistence.Mysql.Models
{
    [Table("master_rayon")]
    public class MasterRayon
    {
        [Key]
        public string KodeRayon { get; set; }
        public string NamaRayon { get; set; }   
        public string KodeArea { get; set; }   
        public string NamaArea { get; set; }
        public string KodeWil { get; set; }
        public string NamaWilayah { get; set; }
        public string KodeLoket { get; set; }


     


        //public virtual ICollection<Pelanggan> Pelanggan { get; set; }

    }
}
