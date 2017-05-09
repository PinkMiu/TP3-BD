using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP3_ORM.Entities
{
    public class Role
    {
        [Key, ForeignKey()]
        public int NUMERO_ARTISTE { get; set; }
        [Key, ForeignKey()]
        public string NOM_GROUPE { get; set; }
        public string ROLE { get; set; }
    }
}
