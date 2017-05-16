using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP3_ORM.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.Services
{
    public  interface IRepository <T> where T : Entity
    {
        IEnumerable<T> GetAll();
        void Add(T myEntity);
        void Update(T myEntity);
        void Delete(T myEntity);
        void Cascade(T myEntity);


    }
}
