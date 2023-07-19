using Aereopuerto.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aereopuerto.Context
{
    public class ApplicationDbContext : DbContext //Hereda una libreria de EntityFramework  
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Cadena de conexion - Ocupas instalar PaqueteNuGet MySQL.MicrosoftEntities...
            optionsBuilder.UseMySQL("server=localhost; database=Aereopuerto23AM; user=root; password=");
        }
        //Mapeo de la BD
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Sale> Sale { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Purveyor> Purveyor { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
