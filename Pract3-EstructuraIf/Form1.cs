using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValorA.Text == "" || !decimal.TryParse(txtValorA.Text, out decimal valorA))
            {
                MessageBox.Show("Formato no valido en el primer valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValorB.Text == "" || !decimal.TryParse(txtValorB.Text, out decimal valorB))
            {
                MessageBox.Show("Formato no valido en el segundo valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal resp;
                resp = valorA + valorB;
                lblOperador.Text = "+";
                txtRespuesta.Text = resp.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValorA.Text == "" || !decimal.TryParse(txtValorA.Text, out decimal valorA))
            {
                MessageBox.Show("Formato no valido en el primer valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValorB.Text == "" || !decimal.TryParse(txtValorB.Text, out decimal valorB))
            {
                MessageBox.Show("Formato no valido en el segundo valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (valorB == 0)
                    MessageBox.Show("El segundo valor no puede ser cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    decimal resp;
                    resp = valorA / valorB;
                    lblOperador.Text = "/";
                    txtRespuesta.Text = resp.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbRestar_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValorA.Text == "" || !decimal.TryParse(txtValorA.Text, out decimal valorA))
            {
                MessageBox.Show("Formato no valido en el primer valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValorB.Text == "" || !decimal.TryParse(txtValorB.Text, out decimal valorB))
            {
                MessageBox.Show("Formato no valido en el segundo valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal resp;
                resp = valorA - valorB;
                lblOperador.Text = "-";
                txtRespuesta.Text = resp.ToString();
            }
        }

        private void rbMultiplicar_CheckedChanged(object sender, EventArgs e)
        {
            if (txtValorA.Text == "" || !decimal.TryParse(txtValorA.Text, out decimal valorA))
            {
                MessageBox.Show("Formato no valido en el primer valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtValorB.Text == "" || !decimal.TryParse(txtValorB.Text, out decimal valorB))
            {
                MessageBox.Show("Formato no valido en el segundo valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal resp;
                resp = valorA * valorB;
                lblOperador.Text = "*";
                txtRespuesta.Text = resp.ToString();
            }
        }
    }
}
