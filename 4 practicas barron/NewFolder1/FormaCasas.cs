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
    public partial class FormaCasas : Form
    {
        public FormaCasas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputIngresos = txtIngresos.Text;
            string inputCostoCasa = txtCostoCasa.Text;

            if (string.IsNullOrWhiteSpace(inputIngresos) || string.IsNullOrWhiteSpace(inputCostoCasa) || !double.TryParse(inputIngresos, out double ingresos) || !double.TryParse(inputCostoCasa, out double costoCasa))
            {
                MessageBox.Show("Por favor, ingrese valores válidos para ingresos y costo de la casa.", "Error");
                return; // Salir del método si no se ingresaron valores válidos
            }

            double enganche = 0;
            double pagosMensuales = 0;
            int plazo = 0;

            if (ingresos < 8000)
            {
                enganche = costoCasa * 0.15;
                plazo = 10;
            }
            else
            {
                enganche = costoCasa * 0.30;
                plazo = 7;
            }

            pagosMensuales = (costoCasa - enganche) / (plazo * 12);

            MessageBox.Show("Enganche: $" + enganche.ToString("0.00") + "\nPagos Mensuales: $" + pagosMensuales.ToString("0.00"));
        }
    }
    }

