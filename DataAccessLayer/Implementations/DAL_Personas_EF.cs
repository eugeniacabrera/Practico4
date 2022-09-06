using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Shared;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementations
{
    public class DAL_Personas_EF : IDAL_Personas
    {
        private string sqlConnection = "Server=DESKTOP-1ESC1UN,1433;Database=Practico4;User=sa;Password=sapass;";

        public Persona AddPersona(Persona x)
        {
            using (Practico4Context db = new Practico4Context())
            {
                Personas toSave = Personas.ToSave(x);
                db.Personas.Add(toSave);
                db.SaveChanges();
                return Get(x.Documento);
            }

            
        }

        public Persona? Get(string documento)
        {
            using (Practico4Context db = new Practico4Context())
                return db.Personas.Where(x => x.Documento == documento).FirstOrDefault()?.ToEntity();
        }

        public List<Persona> GetPersonas()
        {
            using (Practico4Context db = new Practico4Context())

                return db.Personas.Select(x => x.ToEntity()).ToList();
        }
    }
}
