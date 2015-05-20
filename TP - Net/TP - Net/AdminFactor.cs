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
    internal class AdminFactor
    {
        internal void ActualizarFactor(TPContexto _ctx, Factor _factor, Valorizacion valor)
        {
            var _factores = from p in _ctx.Factores
                             where p.IdFactor == _factor.IdFactor
                             select p;
            Factor _unFactor= _factores.SingleOrDefault();
          // Valorizacion _unValor =

            if (_unFactor != null)
            {
                _unFactor.IdFactor = _factor.IdFactor;
                _unFactor.Nombre = _factor.Nombre;
               _ctx.SubmitChanges();
            }
        }

            

        internal void DeleteFactor(TPContexto _ctx, int _id)
        {
            var _factores = from p in _ctx.Factores
                             where p.IdFactor == _id
                             select p;
            Factor _unFactor = _factores.SingleOrDefault();

            if (_unFactor != null)
            {
                _ctx.Factores.DeleteOnSubmit(_unFactor);
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

