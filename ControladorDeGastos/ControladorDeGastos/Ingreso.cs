using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladorDeGastos
{
    public partial class Ingreso : Form
    {
        public Ingreso()
        {
            InitializeComponent();

        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoDetalles ingresoDetalles = new IngresoDetalles(textBox1.Text);
            ingresoDetalles.Visible = true;
            Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ControladorGastos controladorGastos1 = new ControladorGastos();
            //controladorGastos1.Visible = true;
            //Visible = false;
        }
    }
}
