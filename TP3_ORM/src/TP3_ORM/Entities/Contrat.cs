using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_ORM.Entities
{
    public class Contrat
    {
        [Key]
        public int NUMERO_CONTRAT { get; set; }
        [Required]
        public DateTime DATE { get; set; }
        [Required]
        public DateTime HEURE_DEBUT { get; set; }
        [Required]
        public DateTime HEURE_FIN { get; set; }
        public string NOM_EVENEMENT { get; set; }
        [Required]
        public float CACHET_REEL { get; set; }
        [ForeignKey(), Required]
        public string NOM_GROUPE { get; set;  }
        [ForeignKey(), Required]
        public string CODE_CLIENT { get; set; }
    }

}
