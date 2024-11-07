namespace Practica2_1
{
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Hello, " + textBox1.Text + "!";

        }
    }
}
