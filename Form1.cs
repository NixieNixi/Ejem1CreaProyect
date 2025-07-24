using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejem1CreaProyect
{
    //Creado por NixieNixi
    //Motivo: Pratica de ESD115, CICLO II - 2025
    //Fecha de creacion y finalizacion: 23/07/2025


    //prueba
    //Ejecutar el formulario. Probar con datos válidos, como por ejemplo: 1,-10 y 9.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Debe asignar un valor numerico en a", "Error");
                txta.Focus();
                return;

            }
            double a;
            a = Convert.ToDouble(txta.Text);


            if (txtb.Text == "")
            {
                MessageBox.Show("Debe asignar un valor numerico en a", "Error");
                txta.Focus();
                return;

            }
            double b;
            b = Convert.ToDouble(txtb.Text);

            if (txtc.Text == "")
            {
                MessageBox.Show("Debe ingresar un valor numerico en c", "Error");
                txtc.Focus();
                return;
            }
            double c;
            c = Convert.ToDouble(txtc.Text);
            //Hacer la formula de ecuacion cuadratica
            double x1, x2;
            //Mandamos a llamar a la funcion que calcula la cuadratica
            EcuacionCuadratica(a, b, c, out x1, out x2);
            //mostrar resultados
            txtx1.Text = x1.ToString();
            txtx2.Text = x2.ToString();

        }

        private void EcuacionCuadratica(double a, double b, double c, out double x1, out double x2)
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
