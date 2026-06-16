using Microsoft.EntityFrameworkCore;
using Mysql_ORM.Datos.Entidades;


namespace Mysql_ORM.Datos
{
    public class ModeloCapasDbContext : DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opb) {
            var cn = "server=localhost;uid=root;pwd=Lleroc_0188;database=Cuarto_Mysql";
            opb.UseMySql(
                cn,
                ServerVersion.AutoDetect(cn)
                );
        }
    }
}
