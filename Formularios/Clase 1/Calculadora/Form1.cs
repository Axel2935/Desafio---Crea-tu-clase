namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txt1.Text);
            int valor2 = int.Parse(txt2.Text);
            int resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txt1.Text);
            int valor2 = int.Parse(txt2.Text);
            int resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txt1.Text);
            int valor2 = int.Parse(txt2.Text);
            int resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int valor1 = int.Parse(txt1.Text);
            int valor2 = int.Parse(txt2.Text);
            if (valor2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero");
                return;
            }
            else
            {
                int resultado = valor1 / valor2;
                lblResultado.Text = resultado.ToString();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
