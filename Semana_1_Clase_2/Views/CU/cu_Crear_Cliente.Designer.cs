namespace Semana_1_Clase_2.Views.CU
{
    partial class cu_Crear_Cliente
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button2, 1, 4);
            tableLayoutPanel1.Controls.Add(textBox4, 1, 3);
            tableLayoutPanel1.Controls.Add(textBox3, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(button1, 0, 4);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 73F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.Size = new Size(313, 334);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(52, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(49, 97);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(52, 153);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(56, 216);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Correo";
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 263);
            button1.Name = "button1";
            button1.Size = new Size(150, 68);
            button1.TabIndex = 4;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(159, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(159, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(159, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(151, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(159, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(151, 23);
            textBox4.TabIndex = 8;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(159, 263);
            button2.Name = "button2";
            button2.Size = new Size(151, 68);
            button2.TabIndex = 9;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            // 
            // cu_Crear_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "cu_Crear_Cliente";
            Size = new Size(313, 334);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}
