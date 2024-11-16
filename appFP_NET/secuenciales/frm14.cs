using System;
using System.Linq;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los 5 números ingresados
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double num3 = Convert.ToDouble(txtNum3.Text);
                double num4 = Convert.ToDouble(txtNum4.Text);
                double num5 = Convert.ToDouble(txtNum5.Text);

                // Almacenar los números en un array
                double[] numeros = { num1, num2, num3, num4, num5 };

                // Ordenar los números de mayor a menor
                var mayores = numeros.OrderByDescending(n => n).Take(3).ToArray();

                // Calcular el promedio de los 3 números mayores
                double promedio = mayores.Average();

                // Mostrar el resultado
                lblResultado.Text = $"Promedio de los 3 mayores: {promedio:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
