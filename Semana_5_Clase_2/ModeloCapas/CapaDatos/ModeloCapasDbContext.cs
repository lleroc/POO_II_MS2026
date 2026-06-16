using Microsoft.EntityFrameworkCore;
using Presentacion.CapaDatos.Entidades;

namespace ModeloCapas.CapaDatos
{
    public class ModeloCapasDbContext : DbContext
    {
        public DbSet<VehiculoEntity> Vehiculos { get; set; }
        public DbSet<MatriculaEntity> Matriculas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opb) {
            opb.UseSqlServer(
                "server=.;uid=sa;pwd=123;database=ORMClientes;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }
    }
}
