namespace Semana_1_Clase_2
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_inicio = new Button();
            btn_cancelar = new Button();
            label1 = new Label();
            txt_usuario = new TextBox();
            txt_contrasenia = new TextBox();
            label2 = new Label();
            lbl_mensaje = new Label();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_inicio
            // 
            btn_inicio.Location = new Point(27, 178);
            btn_inicio.Margin = new Padding(6, 5, 6, 5);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(114, 62);
            btn_inicio.TabIndex = 0;
            btn_inicio.Text = "Iniciar Sesion";
            btn_inicio.UseVisualStyleBackColor = true;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(153, 178);
            btn_cancelar.Margin = new Padding(6, 5, 6, 5);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(114, 62);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Salir";
            btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 55);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(27, 81);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.PlaceholderText = "Ingrese su usuario";
            txt_usuario.Size = new Size(240, 30);
            txt_usuario.TabIndex = 3;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.Location = new Point(27, 140);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.PasswordChar = '-';
            txt_contrasenia.PlaceholderText = "Ingrese su contraseña";
            txt_contrasenia.Size = new Size(240, 30);
            txt_contrasenia.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 114);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // lbl_mensaje
            // 
            lbl_mensaje.AutoSize = true;
            lbl_mensaje.ForeColor = Color.Red;
            lbl_mensaje.Location = new Point(27, 245);
            lbl_mensaje.Name = "lbl_mensaje";
            lbl_mensaje.Size = new Size(62, 23);
            lbl_mensaje.TabIndex = 6;
            lbl_mensaje.Text = "label3";
            lbl_mensaje.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 173);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 9);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 8;
            label3.Text = "SANA SANA";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 300);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(lbl_mensaje);
            Controls.Add(txt_contrasenia);
            Controls.Add(label2);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(btn_cancelar);
            Controls.Add(btn_inicio);
            Font = new Font("Bahnschrift SemiBold", 14F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(6, 5, 6, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "login";
            Text = "Sistema de Inventario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_inicio;
        private Button btn_cancelar;
        private Label label1;
        private TextBox txt_usuario;
        private TextBox txt_contrasenia;
        private Label label2;
        private Label lbl_mensaje;
        private Label label4;
        private Label label3;
    }
}