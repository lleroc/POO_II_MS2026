using ORM_sql_server.Controllers;
using ORM_sql_server.Views;

namespace ORM_sql_server
{
    public partial class Form1 : Form
    {
        private readonly ClienteControllers _clienteControllers;
        public Form1()
        {
            InitializeComponent();
            _clienteControllers = new ClienteControllers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        public void cargaLista()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _clienteControllers.todos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_NuevoCliente frm_Nuevo = new frm_NuevoCliente();
            frm_Nuevo.ShowDialog();
        }
    }
}
