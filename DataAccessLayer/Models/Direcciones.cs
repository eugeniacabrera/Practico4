using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Direcciones
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id_Direccion { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }

        [ForeignKey("Personas")]
        public virtual int Id_Persona { get; set; }
        public virtual Personas Personas { get; set; }

    }
}
