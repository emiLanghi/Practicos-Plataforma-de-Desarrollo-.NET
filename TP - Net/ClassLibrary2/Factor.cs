using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Linq;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP2.Modelo
{
    public class Factor
    {
        public int IdFactor { get; set; }
        public string Nombre{get; set;}
        public List<Proyecto> Proyectos { get; set; }

    }
}
