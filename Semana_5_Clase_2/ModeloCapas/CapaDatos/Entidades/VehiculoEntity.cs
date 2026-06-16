using System;
using System.Collections.Generic;
using System.Text;

namespace Presentacion.CapaDatos.Entidades
{
    public class VehiculoEntity
    {
        public int id { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateOnly Fecha_Fabricacion { get; set; }
        public int Cilandraje { get; set; }
    }
}
