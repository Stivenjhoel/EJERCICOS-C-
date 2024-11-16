using System;
using System.Windows.Forms;

namespace FibonacciRecursivo
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        // Función recursiva para calcular el n-ésimo número de Fibonacci
        public int CalcularFibonacci(int n)
        {
            // Caso base: los dos primeros números de Fibonacci son 1
            if (n == 0 || n == 1)
            {
                return 1;
            }
            // Caso recursivo: F(n) = F(n-1) + F(n-2)
            else
            {
                return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtNumero.Text); // Leer el número de la serie Fibonacci
                if (n < 0)
                {
                    MessageBox.Show("Por favor ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int resultado = CalcularFibonacci(n);
                lblResultado.Text = $"El {n}-ésimo número de Fibonacci es: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
