using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Presentacion.CapaDatos.Entidades
{
    public class MatriculaEntity
    {
        public int id { get; set; }
        public DateOnly Anio_Matricula { get; set; }
        //estado => Matriculado = true || Matriculado = false
        //Un vehiculo cuando cummple todos los requisitos esta matriculado
        public bool Estado { get; set; }

        //relaciones entre tablas

        public int VehiculoEntityId { get; set; }
        public VehiculoEntity VehiculoEntity { get; set; }

    }
}
