using Mysql_ORM.Datos;
using Mysql_ORM.Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mysql_ORM.Logica
{
    public class TipoContactosServicio
    {
        private readonly ModeloCapasDbContext _dbContext;
        public TipoContactosServicio()
        {
            _dbContext = new ModeloCapasDbContext();
        }

        public List<TipoContacto> todos()
        {
            return _dbContext.TipoContactos.OrderBy(tp => tp.id).ToList();
        }
    }
}
