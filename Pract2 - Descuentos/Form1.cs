using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2___Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (txtValorVenta.Text == "" || !decimal.TryParse(txtValorVenta.Text, out decimal valorVentas))
            {
                MessageBox.Show("Formato no valido en Valor Venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                decimal descPorcen, descDinero, ventaFinal;
                if (valorVentas >= 500)
                    descPorcen = 0.30m;
                else if (valorVentas > 300 && valorVentas < 500)
                    descPorcen = 0.20m;
                else if (valorVentas > 100 && valorVentas <= 300)
                    descPorcen = 0.10m;
                else descPorcen = 0;

                descDinero = valorVentas * descPorcen;
                ventaFinal = valorVentas - descDinero;
                txtDescPorcen.Text = descPorcen.ToString();
                txtDescDin.Text = descDinero.ToString("F2");
                txtVentaFinal.Text = ventaFinal.ToString("F2");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescDin.Text = "";
            txtDescPorcen.Text = "";
            txtValorVenta.Text = "";
            txtVentaFinal.Text = "";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cerrara la ventana", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Cerrando...", "Salir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }
    }
}
