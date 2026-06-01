

namespace Semana_1_Clase_2.Models
{
    //Quiero haceer un crud con los datos del cliente
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }

        public ClienteModel()
        {
        }
        public ClienteModel(int id, string nombre, string direccion, 
            string telefono, string correo)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
