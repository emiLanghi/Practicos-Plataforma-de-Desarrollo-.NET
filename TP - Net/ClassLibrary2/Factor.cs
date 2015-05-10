using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPNet.Modelo
{
    public class Factor
    {
        public int IdFactor { get; set; }
        public int Calidad { get; set; }
        public int Recursos { get; set; }
        public int Duracion { get; set; }
        public List<Proyecto> Proyectos { get; set; }

    }
}
