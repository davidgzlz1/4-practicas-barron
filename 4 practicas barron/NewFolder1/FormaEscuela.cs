using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_practicas_barron.NewFolder1
{
    public partial class FormaEscuela : Form
    {
        public FormaEscuela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputPromedio = txtPromedio.Text;

            if (string.IsNullOrWhiteSpace(inputPromedio) || !double.TryParse(inputPromedio, out double promedio))
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el promedio.", "Error");
                return; // Salir del método si no se ingresó un valor válido
            }

            double colegiatura = double.Parse(txtColegiatura.Text);
            double descuento = 0;
            double iva = 0;

            if (promedio >= 9.0)
            {
                descuento = 0.30 * colegiatura;
            }
            else
            {
                iva = 0.10 * colegiatura;
            }

            double total = colegiatura - descuento + iva;

            MessageBox.Show("Monto a pagar: $" + total.ToString("0.00"));
        }
    }
}
