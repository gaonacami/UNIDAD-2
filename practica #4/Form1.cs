namespace practica__4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radius, height;
            double basearea, lateralarea, totalarea;
            double volume;

            radius = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);

            basearea = radius * radius * Math.PI;
            lateralarea = 2 * Math.PI * radius * height;
            totalarea = 2 * Math.PI * radius * (height + radius);
            volume = Math.PI * radius * radius * height;

            textBox3.Text = basearea.ToString("0.##");
            textBox4.Text = lateralarea.ToString("0.##");
            textBox5.Text = totalarea.ToString("0.##");
            textBox6.Text = volume.ToString("0.##"); 
        }
    }
}
