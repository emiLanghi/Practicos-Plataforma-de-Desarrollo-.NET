using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TP2;

namespace TP2
{
    public class Repositorio<T> : IRepo<T> where T : class
    {
        protected DbSet<T> DbSet;

        public Repositorio(DbContext TPContexto)
        {
            DbSet = TPContexto.Set<T>();
        }


        public void Guardar(T entidad)
        {
            DbSet.Add(entidad);
        }

        public void Actualizar(T entidad)
        {
            DbSet.Attach(entidad);
        }

        public T GetPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetTodos()
        {
            return DbSet;
        }

        
    }
}
