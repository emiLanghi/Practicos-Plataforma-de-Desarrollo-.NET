using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TP2;

namespace TP2
{
    public interface IRepo<T>
    {
        void Guardar(T entidad);
        void Actualizar(T entidad);
        T GetPorId(int id);
        IQueryable<T> GetTodos();
    }
}
