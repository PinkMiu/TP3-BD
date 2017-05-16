using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP3_ORM.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration.Configuration;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TP3_ORM.DataAccessLayer
{
    public class OurDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<Groupe> Groupes { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Contrat> Contrats { get; set; }

        public OurDbContext(DbContextOptions<OurDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // NAS Unique constraint
            modelBuilder.Entity<Artiste>().Property(p => p.NAS).HasAnnotation("Index", new IndexAnnotation(new[] {
                                                                                                new IndexAttribute("Index") { IsUnique = true }}));
            // Relations
            // Artiste - Role 
            modelBuilder.Entity<Artiste>()
                        .HasMany(c => c.ROLES)
                        .WithOne(e => e.ARTISTE)
                        .IsRequired();
                        

            // Groupe - Role
            modelBuilder.Entity<Groupe>()
                        .HasMany(c => c.ROLES)
                        .WithOne(e => e.GROUPE)
                        .IsRequired();

            // Groupe - Contrat
            modelBuilder.Entity<Groupe>()
                        .HasMany(c => c.CONTRATS)
                        .WithOne(e => e.GROUPE);

            // Client - Contrat

            modelBuilder.Entity<Client>()
                        .HasMany(c => c.CONTRATS)
                        .WithOne(e => e.CLIENT);

            // Contrat - Facture
            modelBuilder.Entity<Contrat>()
                        .HasOne(c => c.FACTURE)
                        .WithOne(e => e.CONTRAT);

        }
    }
}
