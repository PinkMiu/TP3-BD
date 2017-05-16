using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.persistence;
using TP3_ORM.DataAccessLayer;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.Services
{
    public class EntityExists 
    {
        private readonly OurDbContext _context;

        public bool ClientExists(string codeClient)
        {
            var client = _context.Clients.FirstOrDefault(x => x.CODE_CLIENT == codeClient);
            if (client != null)
            {
                return true;
            }

            return false;
        }

        public bool ArtisteExists(int numeroArtiste)
        {
            var artiste = _context.Artistes.FirstOrDefault(x => x.NUMERO_ARTISTE == numeroArtiste);
            if (artiste != null)
            {
                return true;
            }

            return false;
        }

        public bool GroupeExists(string nomGroupe)
        {
            var groupe = _context.Groupes.FirstOrDefault(x => x.NOM_GROUPE== nomGroupe);
            if (groupe != null)
            {
                return true;
            }

            return false;
        }

        public bool RoleExists(int numeroArtiste, string nomGroupe)
        {
            var role1 = _context.Roles.FirstOrDefault(x => x.NUMERO_ARTISTE == numeroArtiste);
            var role2 = _context.Roles.FirstOrDefault(x => x.NOM_GROUPE == nomGroupe);
            if (role1 != null && role2 != null)
            {
                return true;
            }

            return false;
        }

        public bool ContratExists(int numeroContrat)
        {
            var contrat = _context.Contrats.FirstOrDefault(x => x.NUMERO_CONTRAT == numeroContrat);
            if (contrat != null)
            {
                return true;
            }

            return false;
        }

        public bool FactureExists(int numeroFacture)
        {
            var facture = _context.Factures.FirstOrDefault(x => x.NUMERO_FACTURE == numeroFacture);
            if (facture != null)
            {
                return true;
            }

            return false;
        }
    }
}
