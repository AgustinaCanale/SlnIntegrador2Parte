using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    [Table("EnfermeroIntegrador")]
    public class Enfermero:Persona
    {
        
        public int EnfermeroId { get; set; }
        public int Cuil { get; set; }

        

    }
}
