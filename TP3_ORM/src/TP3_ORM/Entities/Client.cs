using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TP3_ORM.Entities
{
    public class Client
    {
        [Key]
        public string CODE_CLIENT { get; set; }
        [Required]
        public string NOM { get; set; }
        [Required]
        public string PRENOM { get; set; }
        [Required]
        public string NUM_TELEPHONE { get; set; }
        [Required]
        public bool BONNE_REFERENCE { get; set; }

        //[ForeignKey()]
        //public string REFERENCE { get; set; }
    }
}

