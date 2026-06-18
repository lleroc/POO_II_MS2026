using System;
using System.Collections.Generic;
using System.Text;

namespace Mysql_ORM.Datos.Entidades
{
    public class ContactoEntity
    {
        public int id { get; set; }
        public string Detalle { get; set; }

        //relaciones
        //relacion con clientes
        public int ClientesId { get; set; }
        public Clientes Clientes { get; set; }
        //tipo de contacto
        public int TipoContactoId { get; set; }
        public TipoContacto TipoContacto { get; set; }

    }
}
