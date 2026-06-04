using Sistemas_Animales.Controladores;
using Sistemas_Animales.Models;
using System.IO; //rutass y archivos
using System.Drawing; //trabajar con imagenes
using System.Windows.Forms;

namespace Sistemas_Animales
{
    public partial class Form1 : Form
    {
        private AnimalSqlController _animalController = new AnimalSqlController();

        bool editar = false;
        bool cancelar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

            btnEditar.Enabled = false;
            btnNuevo.Enabled = false;

            btnGuardar.Enabled = true;

            editar = false;
            cancelar = true;
            btnEliminar.Text = "Cancelar";

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
            else
            {  // aqui a a insertar
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

            if (pictureBox1.Image == null) {
                MessageBox.Show("La imagen no esta cargada");
                return;
            }

            using (SaveFileDialog guardar = new SaveFileDialog())
            {
                guardar.Title = "Elije donde guardar la imagen";
                guardar.Filter = "Imagen JPG (*.jpg)|*.jpg";
                guardar.FileName = "Imagen";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(guardar.FileName);
                    MessageBox.Show("Imagen Guardada con existo");
                }
            }
        }

        public void LimpiaCajas()
        {
            txtEdad.Value = 0;
            txtnombre.Text = "";
            txtraza.Text = "";
            cmbSexo.SelectedIndex = -1;

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
            cancelar = true;
            btnEliminar.Text = "Cancelar";


            btnEditar.Enabled = false;

            btnNuevo.Enabled = false;
            lstLista.Enabled = false;

            txtEdad.Enabled = true;
            txtnombre.Enabled = true;
            txtraza.Enabled = true;

            cmbSexo.Enabled = true;

            btnGuardar.Enabled = true;


        }

        private void lstLista_DoubleClick(object sender, EventArgs e)
        {
            AnimalModel animal = _animalController.uno(Convert.ToInt32(lstLista.SelectedValue));
            if (animal != null)
            {
                txtEdad.Value = animal.Edad;
                txtnombre.Text = animal.Nombre;
                txtraza.Text = animal.Raza;
                cmbSexo.Text = animal.Sexo;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cancelar == true)
            {
                txtEdad.Enabled = false;
                txtnombre.Enabled = false;
                txtraza.Enabled = false;
                cmbSexo.Enabled = false;
                lstLista.Enabled = true;
                btnEliminar.Enabled = true;
                btnEditar.Enabled = true;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnEliminar.Text = "Eliminar";
            }
            else
            {
                if (lstLista.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un item de la lista");
                    return;
                }
                DialogResult cajaDialogo = MessageBox.Show(
                    "Desea elimina el registro",
                    "Gestion de Aimales",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (cajaDialogo == DialogResult.Yes)
                {
                    var res = _animalController
                        .eliminar(Convert.ToInt32(lstLista.SelectedValue));
                    if (res == "ok")
                    {
                        MessageBox.Show("El registro se elimino con exito");
                        cargaLista();
                        txtEdad.Value = 0;
                        txtnombre.Text = "";
                        txtraza.Text = String.Empty;
                        cmbSexo.SelectedIndex = -1;
                    }
                }
                else
                {
                    MessageBox.Show("La eliminacion fue cancelada por el usuario");
                }
            }
            LimpiaCajas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargaLista();
            pictureBox1.AllowDrop = true;
            pictureBox1.DragEnter += pictureBox1_DragEnter;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (archivos.Length > 0 && EsImagen(archivos[0]))
            {
                pictureBox1.Image = Image.FromFile(archivos[0]);
            }
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (archivos.Length > 0 && EsImagen(archivos[0]))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else {
                    e.Effect = DragDropEffects.None;
                }
            }
        }

        private bool EsImagen(string ruta) { 
            string extesion = Path.GetExtension(ruta).ToLower();
            return extesion == ".jpg" ||
                extesion == ".jpeg" ||
                extesion == ".png" ||
                extesion == ".bmp" ||
                extesion == ".gif";
        }
    }
}
