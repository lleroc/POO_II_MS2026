using Microsoft.Data.SqlClient;

namespace Semana_1_Clase_2.Data
{
    public class Conexion
    {
        private string cadena = "server=.;database=cuarto;uid=sa;pwd=123;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion() {
            return new SqlConnection(cadena);
        }
    }
}
