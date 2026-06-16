using System;
using System.Collections.Generic;
using System.Text;
using ModeloCapas.CapaDatos;
using Presentacion.CapaDatos.Entidades;

namespace Presentacion.CapaLogica
{
    public class VehiculosServicio //es lo mismo que el controlador
    {
        private readonly ModeloCapasDbContext _db;
        public VehiculosServicio()
        {
            _db = new ModeloCapasDbContext();
        }

        public List<VehiculoEntity> todosVehiculo() {
            return _db.Vehiculos.ToList();
        }
        public List<MatriculaEntity> todosVehiculosMatriculados() {
            var res = (from vh in _db.Vehiculos
                       join ma in _db.Matriculas on vh.id equals ma.VehiculoEntityId
                       select new MatriculaEntity
                       {
                           Anio_Matricula = ma.Anio_Matricula,//0
                           Estado = ma.Estado,//1
                           VehiculoEntityId = ma.VehiculoEntityId,//2
                           id = ma.id,//3
                           VehiculoEntity = ma.VehiculoEntity,//4
                       }).ToList();
            return res;
        }
    }
}
