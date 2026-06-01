namespace Semana_1_Clase_2.Views
{
    partial class Editar_Productos
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
            label1 = new Label();
            label2 = new Label();
            txt_nombre = new TextBox();
            dt_fecha = new DateTimePicker();
            label3 = new Label();
            btn_Guardar = new Button();
            btn_salir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Editar Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // txt_nombre
            // 
            txt_nombre.Location = new Point(12, 93);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.PlaceholderText = "Ingrrese el nombre del producto";
            txt_nombre.Size = new Size(295, 32);
            txt_nombre.TabIndex = 2;
            // 
            // dt_fecha
            // 
            dt_fecha.Location = new Point(12, 173);
            dt_fecha.Name = "dt_fecha";
            dt_fecha.Size = new Size(295, 32);
            dt_fecha.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "Fecha";
            // 
            // btn_Guardar
            // 
            btn_Guardar.Location = new Point(13, 239);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(99, 38);
            btn_Guardar.TabIndex = 5;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_salir
            // 
            btn_salir.Location = new Point(118, 239);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(99, 38);
            btn_salir.TabIndex = 6;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = true;
            btn_salir.Click += btn_salir_Click;
            // 
            // Editar_Productos
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 429);
            Controls.Add(btn_salir);
            Controls.Add(btn_Guardar);
            Controls.Add(label3);
            Controls.Add(dt_fecha);
            Controls.Add(txt_nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(5);
            Name = "Editar_Productos";
            Text = "Editar_Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_nombre;
        private DateTimePicker dt_fecha;
        private Label label3;
        private Button btn_Guardar;
        private Button btn_salir;
    }
}