using _4_practicas_barron.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_practicas_barron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputHorasTrabajadas = txtHorasTrabajadas.Text;

            if (string.IsNullOrWhiteSpace(inputHorasTrabajadas) || !int.TryParse(inputHorasTrabajadas, out int horasTrabajadas))
            {
                MessageBox.Show("Por favor, ingrese un número válido de horas trabajadas.", "Error");
                return; // Salir del método si no se ingresó un número válido
            }

            double salarioSemanal = 0;

            if (horasTrabajadas <= 40)
            {
                salarioSemanal = horasTrabajadas * 16.0;
            }
            else
            {
                salarioSemanal = 40 * 16.0 + (horasTrabajadas - 40) * 20.0;
            }

            MessageBox.Show("Salario semanal: $" + salarioSemanal.ToString("0.00"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaEscuela forma = new FormaEscuela();
            forma.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaCasas forma = new FormaCasas();
            forma.Show();
        }
    }
    }

