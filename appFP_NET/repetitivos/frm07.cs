using System;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcularFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);

                if (numero < 0)
                {
                    MessageBox.Show("Por favor, ingresa un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }

                lblResultado.Text = $"El factorial de {numero} es: {factorial}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
