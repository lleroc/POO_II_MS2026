using Semana_1_Clase_2.Views.CU;

namespace Semana_1_Clase_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productos = new Views.Lista_productos();
            productos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cu_clientes = new cu_Lista_Clientes();
            cu_clientes.AutoSize = true;
            cu_clientes.Dock = DockStyle.Fill;
            panel_clientes.Controls.Add(cu_clientes);

        }
    }
}
