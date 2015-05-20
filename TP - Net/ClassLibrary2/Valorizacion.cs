using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP2.Modelo
{
   public class Valorizacion
    {
       public int Valor { get; set; }
       public string Descripcion { get; set; }
    }
}
