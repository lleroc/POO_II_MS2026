using Mysql_ORM.Datos.Entidades;
using Mysql_ORM.Logica;


namespace Mysql_ORM.Presentacion
{
    public partial class Eliminar_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Eliminar_Cliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var existe = _clienteServicio.uno(Program.idCliente);
            if (existe == null)
            {
                MessageBox.Show("Cliente no encontrado");
                this.Close();
            }
            if (_clienteServicio.eliminar(Program.idCliente) == "ok")
            {
                MessageBox.Show("Cliente Eliminado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Existio un error al  guardar");
            }
        }
        private void Editar_Cliente_Load(object sender, EventArgs e)
        {
            CargaCliente();
        }
        public void CargaCliente()
        {
            var cliente = _clienteServicio.uno(Program.idCliente);
            if (cliente == null)
            {
                MessageBox.Show("Cliente no encontrado");
                this.Close();
            }
            else
            {
                txtApellido.Text = cliente.apellido;
                txtCorreo.Text = cliente.correo;
                txtDireccion.Text = cliente.direccion;
                txtNombre.Text = cliente.nombre;
                txtTelefono.Text = cliente.telefono;
            }
        }


    }
}
