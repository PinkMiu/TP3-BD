using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TP3_ORM.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.Services
{
    public  interface IRepository 
    {
        void Add(Entity myEntity);
        void Update(Entity myEntity);
        void Delete(Entity myEntity);
        void Cascade();


    }
}
