using ORM_sql_server.Controllers;
using ORM_sql_server.Models;

namespace ORM_sql_server.Views
{
    public partial class frm_NuevoCliente : Form
    {
        private readonly ClienteControllers _clienteControllers;

        public frm_NuevoCliente()
        {
            InitializeComponent();
            _clienteControllers = new ClienteControllers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteModel clienteModel = new ClienteModel {
                Cedula = txt_cedula.Text.Trim(),
                Correo = txt_correo.Text.Trim(),
                Direccion = txt_direccion.Text.Trim(),
                Nombre = txt_nombre.Text.Trim(),
                Telefono = txt_telefono.Text.Trim(),
            };
            string res = _clienteControllers.nuevo(clienteModel);
            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                this.Close();
            }
            else {
                MessageBox.Show("Error al guardar. " + res);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
