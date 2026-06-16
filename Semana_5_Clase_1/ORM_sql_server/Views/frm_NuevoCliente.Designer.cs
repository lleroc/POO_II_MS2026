namespace ORM_sql_server.Views
{
    partial class frm_NuevoCliente
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
            btn_guardar = new Button();
            label1 = new Label();
            txt_cedula = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_nombre = new TextBox();
            label4 = new Label();
            txt_direccion = new TextBox();
            label5 = new Label();
            txt_telefono = new TextBox();
            label6 = new Label();
            txt_correo = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(22, 385);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(92, 41);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 2;
            label1.Text = "Nuevo Cliente";
            // 
            // txt_cedula
            // 
            txt_cedula.Location = new Point(22, 86);
            txt_cedula.Name = "txt_cedula";
            txt_cedula.Size = new Size(190, 32);
            txt_cedula.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 58);
            label2.Name = "label2";
            label2.Size = new Size(71, 25);
            label2.TabIndex = 4;
            label2.Text = "Cedula";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 118);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(22, 146);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(190, 32);
            txt_nombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 179);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 8;
            label4.Text = "Direccion";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(22, 207);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(190, 32);
            txt_direccion.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 241);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 10;
            label5.Text = "Telefono";
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(22, 269);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(190, 32);
            txt_telefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 304);
            label6.Name = "label6";
            label6.Size = new Size(70, 25);
            label6.TabIndex = 12;
            label6.Text = "Correo";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(22, 332);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(190, 32);
            txt_correo.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(120, 385);
            button1.Name = "button1";
            button1.Size = new Size(99, 41);
            button1.TabIndex = 13;
            button1.Text = "CancelAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // frm_NuevoCliente
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 438);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(txt_correo);
            Controls.Add(label5);
            Controls.Add(txt_telefono);
            Controls.Add(label4);
            Controls.Add(txt_direccion);
            Controls.Add(label3);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(txt_cedula);
            Controls.Add(label1);
            Controls.Add(btn_guardar);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_NuevoCliente";
            Text = "Nuevo Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_guardar;
        private Label label1;
        private TextBox txt_cedula;
        private Label label2;
        private Label label3;
        private TextBox txt_nombre;
        private Label label4;
        private TextBox txt_direccion;
        private Label label5;
        private TextBox txt_telefono;
        private Label label6;
        private TextBox txt_correo;
        private Button button1;
    }
}