namespace practica_18
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.texto;
            pictureBox1.Location = new Point(103, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(710, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.triangulos;
            pictureBox2.Location = new Point(200, 61);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(286, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.diagrama;
            pictureBox3.Location = new Point(595, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(305, 323);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 184);
            label1.Name = "label1";
            label1.Size = new Size(108, 16);
            label1.TabIndex = 3;
            label1.Text = "Longitud lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 227);
            label2.Name = "label2";
            label2.Size = new Size(108, 16);
            label2.TabIndex = 4;
            label2.Text = "Longitud lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 269);
            label3.Name = "label3";
            label3.Size = new Size(108, 16);
            label3.TabIndex = 5;
            label3.Text = "Longitud lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 362);
            label4.Name = "label4";
            label4.Size = new Size(116, 16);
            label4.TabIndex = 6;
            label4.Text = "Tipo de triangulo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(237, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 22);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 22);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(237, 269);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 22);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(237, 356);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 22);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Location = new Point(80, 313);
            button1.Name = "button1";
            button1.Size = new Size(86, 22);
            button1.TabIndex = 11;
            button1.Text = "Decision";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Location = new Point(237, 313);
            button2.Name = "button2";
            button2.Size = new Size(86, 22);
            button2.TabIndex = 12;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Location = new Point(400, 313);
            button3.Name = "button3";
            button3.Size = new Size(86, 22);
            button3.TabIndex = 13;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(914, 424);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
