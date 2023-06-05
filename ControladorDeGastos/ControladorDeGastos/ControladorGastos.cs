using System.Drawing;

namespace ControladorDeGastos
{
    public partial class ControladorGastos : Form
    {
        public ControladorGastos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ingreso ingreso = new Ingreso();
            ingreso.Visible = true;
            Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gasto gasto = new Gasto();
            gasto.Visible = true;
            Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}