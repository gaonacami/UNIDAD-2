namespace practica__6
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            valor = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 95);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 1;
            label2.Text = "Ingresa el valor:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(341, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 171);
            label3.Name = "label3";
            label3.Size = new Size(195, 19);
            label3.TabIndex = 3;
            label3.Text = "Opciones de conversion\r\n";
            // 
            // valor
            // 
            valor.BackColor = SystemColors.ButtonShadow;
            valor.Location = new Point(110, 218);
            valor.Name = "valor";
            valor.Size = new Size(121, 32);
            valor.TabIndex = 4;
            valor.Text = "FAHRENHEIT";
            valor.UseVisualStyleBackColor = false;
            valor.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Location = new Point(253, 218);
            button2.Name = "button2";
            button2.Size = new Size(142, 32);
            button2.TabIndex = 5;
            button2.Text = "CENTIGRADOS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonShadow;
            button3.Location = new Point(437, 218);
            button3.Name = "button3";
            button3.Size = new Size(123, 32);
            button3.TabIndex = 6;
            button3.Text = "BORRAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 307);
            label4.Name = "label4";
            label4.Size = new Size(168, 19);
            label4.TabIndex = 7;
            label4.Text = "Resultado en grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(205, 349);
            label5.Name = "label5";
            label5.Size = new Size(186, 19);
            label5.TabIndex = 8;
            label5.Text = "Equivalente en grados:";
            // 
            // Resultado
            // 
            Resultado.Location = new Point(341, 381);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(100, 26);
            Resultado.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 503);
            Controls.Add(Resultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(valor);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button valor;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private TextBox Resultado;
    }
}
