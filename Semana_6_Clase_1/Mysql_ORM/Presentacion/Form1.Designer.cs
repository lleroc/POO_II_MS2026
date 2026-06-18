namespace Mysql_ORM
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
            listBox1 = new ListBox();
            btn_nuevo = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(33, 50);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 229);
            listBox1.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            btn_nuevo.Location = new Point(70, 285);
            btn_nuevo.Name = "btn_nuevo";
            btn_nuevo.Size = new Size(122, 23);
            btn_nuevo.TabIndex = 1;
            btn_nuevo.Text = "Nuevo Cliente";
            btn_nuevo.UseVisualStyleBackColor = true;
            btn_nuevo.Click += btn_nuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(70, 314);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 2;
            button1.Text = "Editar Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 343);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 3;
            button2.Text = "Eliminar Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 388);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btn_nuevo);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button btn_nuevo;
        private Button button1;
        private Button button2;
    }
}
