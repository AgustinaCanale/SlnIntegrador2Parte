using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    public class Paciente:Persona
    {
        
        public int PacienteId { get; set; }
        public int NroHistorialClinica { get; set; }


        public int MedicoId { get; set; }

        [ForeignKey("MedicoId")]
       public Medico Medico { get; set; }
    }

}
