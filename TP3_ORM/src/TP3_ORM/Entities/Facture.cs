using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TP3_ORM.Entities
{
    public class Facture: Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NUMERO_FACTURE { get; set; }
        [Required]
        public DateTime DATE_FACTURATION { get; set; }
        [Required]
        public float MONTANT_FACTURE { get; set; }
        [ForeignKey("NUMERO_CONTRAT"), Required]
        public int NUMERO_CONTRAT { get; set; }

    }
}
