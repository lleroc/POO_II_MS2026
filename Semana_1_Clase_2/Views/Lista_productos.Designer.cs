namespace Semana_1_Clase_2.Views
{
    partial class Lista_productos
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(158, 259);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "Lista de Productos";
            // 
            // button1
            // 
            button1.Location = new Point(12, 319);
            button1.Name = "button1";
            button1.Size = new Size(158, 23);
            button1.TabIndex = 2;
            button1.Text = "Nuevo Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 348);
            button2.Name = "button2";
            button2.Size = new Size(158, 23);
            button2.TabIndex = 3;
            button2.Text = "Editar Producto";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Lista_productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 398);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Lista_productos";
            Text = "Lista de Productos";
            Load += Lista_productos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}