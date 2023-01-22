using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    [Table("MedicoIntegrador")]
    public class Medico : Persona
    {


        [Key]
        public int MedicoId { get; set; }
        public string Especialidad { get; set; }
        public string Matricula { get; set; }

      
        public List <Paciente> Pacientes { get; set; }
    }
}
