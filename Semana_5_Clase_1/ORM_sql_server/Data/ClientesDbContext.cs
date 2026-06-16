using Microsoft.EntityFrameworkCore;
using ORM_sql_server.Models;

namespace ORM_sql_server.Data
{
    public class ClientesDbContext : DbContext
    {
        public DbSet<ClienteModel> Clientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opb) {
            opb.UseSqlServer(
                "server=.;uid=sa;pwd=123;database=Clientes;Trusted_Connection=True;TrustServerCertificate=True"
                );
        }
    }
}
