using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlnIntegrador.Entidades
{
    [NotMapped]
    public class Director:Medico
    {
      
        public string Postgrado { get; set; }

    }
}
