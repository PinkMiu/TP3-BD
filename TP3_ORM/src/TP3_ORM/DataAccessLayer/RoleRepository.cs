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
    public class RoleRepository<T> : IRepository<T> where T : Entity
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

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Cascade(T entity) { }
    }
}
