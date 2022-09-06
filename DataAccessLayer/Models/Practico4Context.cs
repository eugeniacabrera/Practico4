using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Practico4Context : DbContext
    {
        public Practico4Context() { }
        public Practico4Context(DbContextOptions<Practico4Context> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-1ESC1UN,1433;Database=Practico4;User=sa;Password=sapass;");
            }
        }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<Contactos> Contactos { get; set; }

        public DbSet<DatosPersonales> DatosPersonales { get; set; }
    }
}
