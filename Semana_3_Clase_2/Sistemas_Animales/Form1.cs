using Sistemas_Animales.Controladores;
using Sistemas_Animales.Models;

namespace Sistemas_Animales
{
    public partial class Form1 : Form
    {
        private AnimalController _animalController = new AnimalController();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
        }
        private void cargaLista()
        {
            lstLista.DataSource = null;
            lstLista.Items.Clear();
            lstLista.DataSource = _animalController.todos();
            lstLista.ValueMember = "id";
            lstLista.DisplayMember = "Nombre";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEdad.Enabled = true;
            txtnombre.Enabled = true;
            txtraza.Enabled = true;
            cmbSexo.Enabled = true;

            lstLista.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var res = _animalController.Nuevo(txtnombre.Text.Trim(),
                txtraza.Text.Trim(), cmbSexo.Text, Convert.ToInt32(txtEdad.Value));

            if (res == "ok")
            {
                MessageBox.Show("Se guardo con exito");
                cargaLista();
                LimpiaCajas();

                txtEdad.Enabled = false;
                txtnombre.Enabled = false;
                txtraza.Enabled = false;
                cmbSexo.Enabled = false;

                lstLista.Enabled = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnNuevo.Enabled = true;


                btnGuardar.Enabled = false;


            }
            else
            {
                MessageBox.Show(res);
            }
        }

        public void LimpiaCajas()
        {
            txtEdad.Value = 0;
            txtnombre.Text = "";
            txtraza.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstLista.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione al uno animal de la lista");
                return;
            }
            AnimalModel animal = _animalController.uno(Convert.ToInt32(lstLista.SelectedValue));
            txtraza.Text = animal.Raza;
            txtEdad.Value = animal.Edad;
            txtnombre.Text =animal.Nombre;
            cmbSexo.SelectedValue = animal.Sexo;

        }
    }
}
