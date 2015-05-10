using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPNet.Modelo
{
   public class Valorizacion
    {
       public int valor { get; set; }
       public string Descripcion { get; set; }
    }
}
