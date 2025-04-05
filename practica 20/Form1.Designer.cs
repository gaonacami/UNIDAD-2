namespace practica_20
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 44);
            label1.Name = "label1";
            label1.Size = new Size(419, 19);
            label1.TabIndex = 0;
            label1.Text = "Este programa categoriza a la persona segun su edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 116);
            label2.Name = "label2";
            label2.Size = new Size(143, 19);
            label2.TabIndex = 1;
            label2.Text = "Introduce tu edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 196);
            label3.Name = "label3";
            label3.Size = new Size(145, 19);
            label3.TabIndex = 2;
            label3.Text = "Segun tu edad tu:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(107, 286);
            button1.Name = "button1";
            button1.Size = new Size(98, 39);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(314, 286);
            button2.Name = "button2";
            button2.Size = new Size(104, 39);
            button2.TabIndex = 4;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(517, 286);
            button3.Name = "button3";
            button3.Size = new Size(103, 39);
            button3.TabIndex = 5;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(350, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(350, 196);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 26);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 503);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
