using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1___Controles_Programado_por_Gabriel_Jimenez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HashSet<string> meses = new HashSet<string> {"enero", "febrero", "marzo", "abril",
                                    "mayo", "junio", "julio", "agosto",
                                    "septiembre", "octubre", "noviembre", "diciembre"};

            if (txtDia.Text == "" || txtAño.Text == "" || txtMes.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            else if (!meses.Contains(txtMes.Text.ToLower()))
            {
                MessageBox.Show("Introduzca un mes valido (Enero, febrero, etc)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtDia.Text, out int result) || !int.TryParse(txtAño.Text, out int resul))
            {
                MessageBox.Show("El dia y el año solo pueden tener numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblOutput.Text += txtDia.Text + " de " + txtMes.Text + " de " + txtAño.Text;
            }
            
        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cerrando...", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }
    }
}
