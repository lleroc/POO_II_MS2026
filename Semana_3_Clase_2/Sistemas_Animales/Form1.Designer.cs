namespace Sistemas_Animales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            panel2 = new Panel();
            lstLista = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            txtEdad = new NumericUpDown();
            cmbSexo = new ComboBox();
            label5 = new Label();
            txtraza = new TextBox();
            label4 = new Label();
            txtnombre = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEdad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 59);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(52, 23);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Animales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnEliminar, 0, 3);
            tableLayoutPanel1.Controls.Add(btnEditar, 0, 2);
            tableLayoutPanel1.Controls.Add(btnGuardar, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNuevo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 59);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(104, 378);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.ForeColor = Color.Red;
            btnEliminar.Location = new Point(3, 213);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 162);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Dock = DockStyle.Fill;
            btnEditar.ForeColor = Color.Red;
            btnEditar.Location = new Point(3, 143);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(98, 64);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.Enabled = false;
            btnGuardar.ForeColor = Color.Red;
            btnGuardar.Location = new Point(3, 73);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 64);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNuevo.Dock = DockStyle.Fill;
            btnNuevo.ForeColor = Color.Red;
            btnNuevo.Location = new Point(3, 3);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(98, 64);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lstLista);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(265, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 378);
            panel2.TabIndex = 2;
            // 
            // lstLista
            // 
            lstLista.Dock = DockStyle.Fill;
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(0, 21);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(200, 357);
            lstLista.TabIndex = 1;
            lstLista.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            lstLista.DoubleClick += lstLista_DoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 21);
            label2.TabIndex = 0;
            label2.Text = "Lista de Animales";
            // 
            // panel3
            // 
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtEdad);
            panel3.Controls.Add(cmbSexo);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtraza);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtnombre);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(104, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(161, 378);
            panel3.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(19, 248);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 9;
            label7.Text = "Arrastre y Suelte";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 272);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 94);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.DragDrop += pictureBox1_DragDrop;
            pictureBox1.DragEnter += pictureBox1_DragEnter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(9, 189);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 7;
            label6.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Enabled = false;
            txtEdad.Location = new Point(24, 213);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(120, 23);
            txtEdad.TabIndex = 6;
            // 
            // cmbSexo
            // 
            cmbSexo.Enabled = false;
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            cmbSexo.Location = new Point(24, 158);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(121, 23);
            cmbSexo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(9, 134);
            label5.Name = "label5";
            label5.Size = new Size(43, 21);
            label5.TabIndex = 4;
            label5.Text = "Sexo";
            // 
            // txtraza
            // 
            txtraza.Enabled = false;
            txtraza.Font = new Font("Segoe UI", 12F);
            txtraza.Location = new Point(23, 102);
            txtraza.Name = "txtraza";
            txtraza.Size = new Size(121, 29);
            txtraza.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(9, 75);
            label4.Name = "label4";
            label4.Size = new Size(43, 21);
            label4.TabIndex = 2;
            label4.Text = "Raza";
            // 
            // txtnombre
            // 
            txtnombre.Enabled = false;
            txtnombre.Font = new Font("Segoe UI", 12F);
            txtnombre.Location = new Point(23, 38);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(121, 29);
            txtnombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(9, 14);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 437);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Lista de Animales";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEdad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private Panel panel2;
        private Panel panel3;
        private ListBox lstLista;
        private Label label2;
        private ComboBox cmbSexo;
        private Label label5;
        private TextBox txtraza;
        private Label label4;
        private TextBox txtnombre;
        private Label label3;
        private Label label6;
        private NumericUpDown txtEdad;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
