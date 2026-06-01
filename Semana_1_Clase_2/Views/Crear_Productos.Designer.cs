namespace Semana_1_Clase_2.Views
{
    partial class Crear_Productos
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            dt_fecha = new DateTimePicker();
            txt_nombre = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 25);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(236, 25);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE PRODUCTOS";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.205822F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.79418F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(dt_fecha, 1, 1);
            tableLayoutPanel1.Controls.Add(txt_nombre, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1282043F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 74.8717957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel1.Size = new Size(502, 240);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 42);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // dt_fecha
            // 
            dt_fecha.Dock = DockStyle.Fill;
            dt_fecha.Location = new Point(109, 45);
            dt_fecha.Name = "dt_fecha";
            dt_fecha.Size = new Size(390, 32);
            dt_fecha.TabIndex = 3;
            // 
            // txt_nombre
            // 
            txt_nombre.Dock = DockStyle.Fill;
            txt_nombre.Location = new Point(109, 3);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(390, 32);
            txt_nombre.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.82629F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.17371F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 132F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128F));
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 271);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(502, 100);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(376, 3);
            button4.Name = "button4";
            button4.Size = new Size(123, 94);
            button4.TabIndex = 3;
            button4.Text = "Cerrar Ventana";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(244, 3);
            button3.Name = "button3";
            button3.Size = new Size(126, 94);
            button3.TabIndex = 2;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(121, 3);
            button2.Name = "button2";
            button2.Size = new Size(117, 94);
            button2.TabIndex = 1;
            button2.Text = "Limpiar Cajas";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 94);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Crear_Productos
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 371);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel2);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Crear_Productos";
            Text = "Crear_Productos";
            Load += Crear_Productos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private DateTimePicker dt_fecha;
        private TextBox txt_nombre;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}