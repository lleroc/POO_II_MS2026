using Sistemas_Animales.Controladores;
using Sistemas_Animales.Models;

namespace Sistemas_Animales
{
    public partial class Form1 : Form
    {
        private AnimalSqlController _animalController = new AnimalSqlController();
        bool editar = false;
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

            editar = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar) //voy a editar si es verdadero
            {
                var res = _animalController.editar(Convert.ToInt32(lstLista.SelectedValue), 
                    txtnombre.Text.Trim(),
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
            else {  // aqui a a insertar
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
            txtnombre.Text = animal.Nombre;
            cmbSexo.Text = animal.Sexo;

            editar = true;


        }

        private void lstLista_DoubleClick(object sender, EventArgs e)
        {
            AnimalModel animal = _animalController.uno(Convert.ToInt32(lstLista.SelectedValue));
            if (animal !=null)
            {
                txtEdad.Value = animal.Edad;
                txtnombre.Text = animal.Nombre;
                txtraza.Text = animal.Raza;
                cmbSexo.Text = animal.Sexo;
            }
        }
    }
}
