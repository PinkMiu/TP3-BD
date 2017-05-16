using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP3_ORM.Entities;
using TP3_ORM.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.DataAccessLayer
{
    public class ClientRepository<T> : IRepository<T> where T: Entity
    {
        private readonly DbContext _context;

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity) //Nos entités ne peuvent pas avoir le comportement de suppression avec et sans Cascade, car cela dépend du paramètre 
                                     //que l'on établie dans la méthode OnModelCreating de notre DBContext. Alors, certaines entités auront le comportement cascade,
                                     //et d'autre ne l'auront pas. Nous pourrons alors testé les deux comportements. 
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
        public void DeleteCascade(T entity)
        {
            this.Delete(entity);
        }
    }
}
