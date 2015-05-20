using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP2.Modelo
{
    public class Gerente
    {
        public int GerenteID { get; set; }
        public string User { get; set; }
        public string Nombre { get; set; }
        public int Pass { get; set; }
        public List<Proyecto> Proyectos { get; set; }
        
        

     }
}
