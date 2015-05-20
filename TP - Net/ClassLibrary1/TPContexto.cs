using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using TP2.Modelo;

namespace TP2.DataAcces
{
    public class TPContexto: DbContext
    {
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Factor> Factores { get; set; }
        public DbSet<Valorizacion> Valores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GerenteConfiguracion());
            modelBuilder.Configurations.Add(new ProyectoConfiguracion());
            modelBuilder.Configurations.Add(new FactorConfiguracion());
            modelBuilder.Configurations.Add(new ValorizacionConfiguracion());

        }

        public void SubmitChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class GerenteConfiguracion : EntityTypeConfiguration<Gerente>
    {
        public GerenteConfiguracion()
        {
            Property(g => g.Nombre).IsRequired().HasMaxLength(100);
            Property(g => g.User).IsRequired();
            Property(g => g.Pass).IsRequired();
            Property(g => g.GerenteID).IsRequired();

        }
    }

    public class ProyectoConfiguracion : EntityTypeConfiguration<Proyecto> { 
    
    public ProyectoConfiguracion(){

        Property(p => p.Descripcion).IsRequired().HasMaxLength(500);
        Property(p => p.Fecha).IsRequired();
        Property(p => p.IdProyecto).IsRequired();
       
     }
    }

    public class FactorConfiguracion : EntityTypeConfiguration<Factor> {

        public FactorConfiguracion() {

            Property(f => f.IdFactor).IsRequired();
            Property(f => f.Nombre).IsRequired().HasMaxLength(100);

        }
    
    }


    public class ValorizacionConfiguracion : EntityTypeConfiguration<Valorizacion> { 
   
        public ValorizacionConfiguracion()
        {

            Property(v => v.Descripcion).IsRequired().HasMaxLength(500);
            Property(v => v.Valor).IsRequired();
             
        
        }
    }
     //public  GetPorId(int id)
     //   {
     //       return DbSet.Find(id);
     //   }
}
