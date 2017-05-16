using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_ORM.Entities
{
    public class Artiste : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NUMERO_ARTISTE { get; set; }
        [Required]
        public string NOM { get; set; }
        [Required]
        public string PRENOM { get; set; }
        public string NUM_TELEPHONE { get; set; }
        public string NOM_ARTISTE { get; set; }
        //TODO: contrainte U1
        [Required]
        public int NAS { get; set; }

        public ICollection<Role> ROLES { get; set; }

    }
}
