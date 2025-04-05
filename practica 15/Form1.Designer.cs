namespace practica_15
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 45);
            label1.Name = "label1";
            label1.Size = new Size(344, 57);
            label1.TabIndex = 0;
            label1.Text = "Dado como dato el sueldo de un trabajador, \r\nel programa aplica un aumento del 15%\r\nsi el sueldo es inferior a 400000\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 156);
            label2.Name = "label2";
            label2.Size = new Size(128, 19);
            label2.TabIndex = 1;
            label2.Text = "Ingresar sueldo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 396);
            label3.Name = "label3";
            label3.Size = new Size(115, 19);
            label3.TabIndex = 2;
            label3.Text = "Nuevo sueldo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(344, 396);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(131, 235);
            button1.Name = "button1";
            button1.Size = new Size(128, 35);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(344, 235);
            button2.Name = "button2";
            button2.Size = new Size(85, 35);
            button2.TabIndex = 6;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1143, 503);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}
