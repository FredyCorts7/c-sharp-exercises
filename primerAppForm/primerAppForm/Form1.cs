using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerAppForm
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float n1, n2, resultado;
            n1 = float.Parse(txtNumero1.Text);
            n2 = float.Parse(txtNumero2.Text);
            resultado = n1 + n2;
            txtResultado.Text = resultado.ToString();
            txtNumero1.Text = null;
            txtNumero2.Text = null;
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            float n1, n2, resultado;
            n1 = float.Parse(txtNumero1.Text);
            n2 = float.Parse(txtNumero2.Text);
            resultado = n1 - n2;
            txtResultado.Text = resultado.ToString();
            txtNumero1.Text = null;
            txtNumero2.Text = null;
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            float n1, n2, resultado;
            n1 = float.Parse(txtNumero1.Text);
            n2 = float.Parse(txtNumero2.Text);
            resultado = n1 * n2;
            txtResultado.Text = resultado.ToString();
            txtNumero1.Text = null;
            txtNumero2.Text = null;
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float n1, n2, resultado;
            n1 = float.Parse(txtNumero1.Text);
            n2 = float.Parse(txtNumero2.Text);
            resultado = n1 / n2;
            txtResultado.Text = resultado.ToString();
            txtNumero1.Text = null;
            txtNumero2.Text = null;
        }
    }
}
