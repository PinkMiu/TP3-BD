using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP3_ORM.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.DataAccessLayer
{
    public class OurDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Role> Roles { get; set; }

        public OurDbContext(DbContextOptions<OurDbContext> options)
            : base(options)
        {
            
        }
    }
}
