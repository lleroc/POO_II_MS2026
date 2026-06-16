using Mysql_ORM.Datos.Entidades;
using Mysql_ORM.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mysql_ORM.Presentacion
{
    public partial class Nuevo_Cliente : Form
    {
        private readonly ClienteServicio _clienteServicio;
        public Nuevo_Cliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var cliente = new Clientes {
                apellido = txtApellido.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                direccion = txtDireccion.Text.Trim(),
                nombre = txtNombre.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
            };
            if (_clienteServicio.insertar(cliente) == "ok")
            {
                MessageBox.Show("Cliente Guardado");
                this.Close();
            }
            else {
                MessageBox.Show("Existio un error al  guardar");
            }
        }
    }
}
