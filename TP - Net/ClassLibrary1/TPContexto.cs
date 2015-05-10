using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using TPNet.Modelo;

namespace TPNet.DataAcces
{
    public class TPContexto: DbContext
    {
        public DbSet<Gerente> Gerentes { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Factor> Factores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GerenteConfiguracion());
            modelBuilder.Configurations.Add(new ProyectoConfiguracion());
            modelBuilder.Configurations.Add(new FactorConfiguracion());
            modelBuilder.Configurations.Add(new ValorizacionConfiguracion());

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
            Property(f => f.Calidad).IsRequired();
            Property(f => f.Duracion).IsRequired();
            Property(f => f.Recursos).IsRequired();
             

        }
    
    }


    public class ValorizacionConfiguracion : EntityTypeConfiguration<Valorizacion> { 
   
        public ValorizacionConfiguracion()
        {

            Property(v => v.Descripcion).IsRequired().HasMaxLength(500);
            Property(v => v.valor).IsRequired();
             
        
        }
    }
}
