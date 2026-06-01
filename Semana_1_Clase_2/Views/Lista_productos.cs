using Semana_1_Clase_2.Models;
using Semana_1_Clase_2.Controllers;

namespace Semana_1_Clase_2.Views
{
    public partial class Lista_productos : Form
    {
        private readonly ProductosController _productosController;
        public Lista_productos()
        {
            InitializeComponent();
            _productosController = new ProductosController();
        }

        private void Lista_productos_Load(object sender, EventArgs e)
        {
            listBox1.DataBindings.Clear();
            listBox1.DataSource = _productosController.ObtenerProductos();
            listBox1.DisplayMember = "Nombre";
            listBox1.ValueMember = "ProductosId";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var crear_productos = new Crear_Productos();
            crear_productos.ShowDialog();


            listBox1.DataBindings.Clear();
            listBox1.DataSource = _productosController.ObtenerProductos();
            listBox1.DisplayMember = "Nombre";
            listBox1.ValueMember = "ProductosId";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccion un item de la lista para editar");
                return;
            }
            // var editar_producto = new Editar_Productos();
            // editar_producto.ShowDialog();
        }
    }
}



