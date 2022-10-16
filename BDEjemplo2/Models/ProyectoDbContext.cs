using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BDEjemplo2.Models
{
    public class ProyectoDbContext: DbContext
    {
        private const string ConnectionString = "DefaultConnection";
        public ProyectoDbContext() : base(ConnectionString)
        {

        }
        public DbSet<Personas> Persona { get; set; }
        public DbSet<Direcciones> Direccion { get; set; }
        public DbSet<SubDireccion> SubDireccion { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<int>().Where(p => p.Name.StartsWith("Codigo")).Configure(p => p.IsKey());
            modelBuilder.Entity<Direcciones>().HasRequired(x => x.Personas);
            modelBuilder.Entity<SubDireccion>().HasRequired(x => x.Direcciones);
            base.OnModelCreating(modelBuilder);
        }
    }
}