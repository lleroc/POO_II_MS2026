using Semana_1_Clase_2.Models;
using Microsoft.Data.SqlClient;
using Semana_1_Clase_2.Data;

namespace Semana_1_Clase_2.Controllers
{
    public class ClientesController
    {
        private readonly Conexion _conexion = new Conexion();
        
        public ClientesController()
        {
            
        }

        public List<ClienteModel> Todos()
        {
            List<ClienteModel> listaclientes = new List<ClienteModel>();
            using (SqlConnection cn = _conexion.ObtenerConexion())
            {
                string cadena = "select * from clientes";
                SqlCommand cmd = new SqlCommand(cadena, cn);
                cn.Open();
                SqlDataReader lector = cmd.ExecuteReader();
                
                while (lector.Read()) {
                    ClienteModel cliente = new ClienteModel()
                    {
                        Id = Convert.ToInt32(lector["id"]),
                        Nombre = lector["Nombre"].ToString(),
                        Direccion = lector["Direccion"].ToString(),
                        Telefono = lector["Telefono"].ToString(),
                        Correo = lector["Correo"].ToString(),
                    };

                    listaclientes.Add(cliente);
                }
            }
            return listaclientes;
        }
    }
}
