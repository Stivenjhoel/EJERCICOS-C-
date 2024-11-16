using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);

                if (a == 0)
                {
                    MessageBox.Show("El coeficiente 'a' no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double discriminante = Math.Pow(b, 2) - 4 * a * c;

                if (discriminante > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    lblResultado.Text = $"x1 = {x1:F2}, x2 = {x2:F2}";
                }
                else if (discriminante == 0)
                {
                    double x = -b / (2 * a);
                    lblResultado.Text = $"Raíz única: x = {x:F2}";
                }
                else
                {
                    double realPart = -b / (2 * a);
                    double imaginaryPart = Math.Sqrt(-discriminante) / (2 * a);
                    lblResultado.Text = $"x1 = {realPart:F2} + {imaginaryPart:F2}i\nx2 = {realPart:F2} - {imaginaryPart:F2}i";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese coeficientes válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
