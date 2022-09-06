using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Contactos
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_Contacto { get; set; }
        public string Nombre { get; set; }
        [ForeignKey("Personas")]
        public virtual int Id_Persona { get; set; }
        public virtual Personas Personas { get; set; }

        [ForeignKey("DatosPersonales")]

        public int Id_DatosPersonales { get; set; }
        public virtual DatosPersonales DatosPersonales { get; set; }
    }
}
