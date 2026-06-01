using Semana_1_Clase_2.Models;

namespace Semana_1_Clase_2.Controllers
{
    public class ProductosController
    {
        public static List<Productos> lista_productos = new List<Productos>() {
            new Productos
                {
                    Nombre = "producto 1" ,
                    ProductosId = 1,
                    Fecha_Ingreso = DateOnly.FromDateTime(DateTime.Now)
                },
             new Productos
                {
                    Nombre = "producto 2" ,
                    ProductosId = 2,
                    Fecha_Ingreso = DateOnly.FromDateTime(DateTime.Now)
                }
        };

        public string AgregarProducto(Productos producto)
        {
            if (producto == null) return "error";

            //producto.ProductosId = lista_productos.Count + 1;
            producto.ProductosId = lista_productos.Max(p => p.ProductosId);
            lista_productos.Add(producto);
            return "ok";
        }
        //SOLID - Principio de Responsabilidad Única
        public List<Productos> ObtenerProductos()
        {
            //productos_lista();
            return lista_productos;
        }
        public string EliminarProducto(int id)
         {
                var producto = lista_productos.FirstOrDefault(p => p.ProductosId == id);
                if (producto != null)
                {
                    lista_productos.Remove(producto);
                    return "Producto eliminado correctamente.";
                }
                return "Producto no encontrado.";
         }
        public string ActualizarProducto(Productos productoActualizado)
            {
                    var producto = lista_productos.FirstOrDefault(p => 
                    p.ProductosId == productoActualizado.ProductosId);
                    if (producto != null)
                    {
                        producto.Nombre = productoActualizado.Nombre;
                        producto.Fecha_Ingreso = productoActualizado.Fecha_Ingreso;

                        return "Producto actualizado correctamente.";
                    }
                    return "Producto no encontrado.";
            }

        public void productos_lista() {
            for (int i = 0; i < 10; i++)
            {
                var prod = new Productos
                {
                    Nombre = "Producto " + i,
                    ProductosId = i,
                    Fecha_Ingreso = DateOnly.FromDateTime(DateTime.Now)
                };
                lista_productos.Add(prod);
            }
        }
    }
}
