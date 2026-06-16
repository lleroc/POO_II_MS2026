using Microsoft.EntityFrameworkCore;
using ORM_sql_server.Data;
using ORM_sql_server.Migrations;
using ORM_sql_server.Models;
using System.Security.Permissions;

namespace ORM_sql_server.Controllers
{
    public class ClienteControllers
    {
        private readonly ClientesDbContext _clientesDbContext;
        public ClienteControllers()
        {
            _clientesDbContext = new ClientesDbContext();       
        }

        public List<ClienteModel> todos() {
            return _clientesDbContext.Clientes.ToList();
            //select * from cliente
        }
        public ClienteModel uno(int id) {
            return _clientesDbContext.
                Clientes.FirstOrDefault(cl => cl.id == id);
            //select * from clientes where id = id
        }
        //crear
        public string nuevo(ClienteModel cliente) {
            try
            {
                _clientesDbContext.Clientes.Add(cliente);
                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string actualizar(ClienteModel cliente) {
            try
            {
                var cl = _clientesDbContext.Clientes.Find(cliente.id);
                if (cl is null) throw new Exception("Cliente no encontrado");

                cl.Nombre = cliente.Nombre;
                cl.Telefono = cliente.Telefono;
                cl.Cedula = cliente.Cedula;
                cl.Correo = cliente.Correo;
                cl.Direccion = cliente.Direccion;

                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string eliminar(int id) {
            try
            {
                var cl = _clientesDbContext.Clientes.Find(id);
                if (cl is null) throw new Exception("Cliente no encontrado");

                _clientesDbContext.Remove(cl);
                _clientesDbContext.SaveChanges();
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
