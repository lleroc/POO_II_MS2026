namespace Semana_1_Clase_2.Views.CU
{
    partial class cu_Lista_Clientes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            listBox1 = new ListBox();
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
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de Clientes";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8418083F));
            tableLayoutPanel1.Size = new Size(373, 354);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(367, 348);
            listBox1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 96F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 81F));
            tableLayoutPanel2.Controls.Add(button4, 3, 0);
            tableLayoutPanel2.Controls.Add(button3, 2, 0);
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Bottom;
            tableLayoutPanel2.Location = new Point(0, 290);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(373, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(295, 3);
            button4.Name = "button4";
            button4.Size = new Size(75, 94);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(199, 3);
            button3.Name = "button3";
            button3.Size = new Size(90, 94);
            button3.TabIndex = 2;
            button3.Text = "Actualizar Lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(101, 3);
            button2.Name = "button2";
            button2.Size = new Size(92, 94);
            button2.TabIndex = 1;
            button2.Text = "Editar Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(92, 94);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cu_Lista_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Name = "cu_Lista_Clientes";
            Size = new Size(373, 390);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
