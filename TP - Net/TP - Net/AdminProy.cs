using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Data.Entity;

using System.Text;
using System.Threading.Tasks;
using TP2.Modelo;
using TP2.DataAcces;

namespace TP2
{
    internal class AdminProyect
    {
        internal void ActualizarProyecto(TPContexto _ctx, Proyecto _proy)
        {
            var _proyectos = from p in _ctx.Proyectos
                             where p.IdProyecto == _proy.IdProyecto
                             select p;
            Proyecto _unProyecto = _proyectos.SingleOrDefault();

            if (_unProyecto != null)
            {
                _unProyecto.IdProyecto = _proy.IdProyecto;
                _unProyecto.Nombre = _proy.Nombre;
                _unProyecto.Fecha = _proy.Fecha;
                _unProyecto.Descripcion = _proy.Descripcion;
                _ctx.SubmitChanges();
            }

        }

        internal void DeleteProyecto(TPContexto _ctx, int _id)
        {
            var _proyectos = from p in _ctx.Proyectos
                             where p.IdProyecto == _id
                             select p;
            Proyecto _unProyecto = _proyectos.SingleOrDefault();

            if (_unProyecto != null)
            {
                _ctx.Proyectos.DeleteOnSubmit(_unProyecto);
                _ctx.SubmitChanges();
            }
        }

        internal List<Proyecto> ObtenerLista(TPContexto _ctx)
        {
            return (from p in _ctx.Proyectos
                    select p).ToList();
        }

    }
}
