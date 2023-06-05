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
    public partial class IngresoDetalles : Form
    {
        public IngresoDetalles(string valor)
        {
            InitializeComponent();
            label2.Text = valor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atrassss");
        }
    }
}
