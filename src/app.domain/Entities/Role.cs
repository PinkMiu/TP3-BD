using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_ORM.Entities
{
    public class Role: Entity
    {
        [Key, ForeignKey("NUMERO_ARTISTE")]
        public int NUMERO_ARTISTE { get; set; }
        [Key, ForeignKey("NOM_GROUPE")]
        public string NOM_GROUPE { get; set; }
        public string ROLE { get; set; }

        public Artiste ARTISTE { get; set; }
        public Groupe GROUPE { get; set; }
    }
}
