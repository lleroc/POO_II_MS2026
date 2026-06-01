namespace Semana_1_Clase_2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contrasenia = txt_contrasenia.Text.Trim();

            if (usuario == "admin" && contrasenia == "123")
            {
                var dashbpoard = new Form1();
                dashbpoard.Show();
                this.Hide();
            }
            else
            {
                lbl_mensaje.Text = "Usuario o contraseña incorrectos.";
                lbl_mensaje.Visible = true;

            }
        }
    }
}
