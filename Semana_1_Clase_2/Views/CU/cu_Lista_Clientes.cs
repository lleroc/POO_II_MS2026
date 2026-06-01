using Semana_1_Clase_2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_1_Clase_2.Views.CU
{
    public partial class cu_Lista_Clientes : UserControl
    {
        private readonly ClientesController _clientesController = new ClientesController();
        public cu_Lista_Clientes()
        {
            InitializeComponent();
            carga_lista();
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carga_lista();

        }

        public void carga_lista() {

            listBox1.DataBindings.Clear();
            listBox1.DataSource = _clientesController.Todos();
            listBox1.DisplayMember = "Nombre";
            listBox1.ValueMember = "id";
        }
    }
}
