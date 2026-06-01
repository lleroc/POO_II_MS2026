using Semana_1_Clase_2.Controllers;
using Semana_1_Clase_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_1_Clase_2.Views
{
    public partial class Editar_Productos : Form
    {
        private readonly ProductosController _productosController;
        public Editar_Productos()
        {
            InitializeComponent();
            _productosController = new ProductosController();

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos
            {
                Nombre = txt_nombre.Text.Trim(),
                Fecha_Ingreso = DateOnly.FromDateTime(Convert.ToDateTime(dt_fecha.Text))
            };

            var respuesta = _productosController.AgregarProducto(productos);
            if (respuesta == "ok")
            {
                MessageBox.Show("El producto se agrego con exito", "Productos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Erro al guardar", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
