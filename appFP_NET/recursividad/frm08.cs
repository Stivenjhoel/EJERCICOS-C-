using System;
using System.Windows.Forms;

namespace MCD_Euclides
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        // Función para calcular el MCD usando el algoritmo de Euclides
        public int MCD(int m, int n)
        {
            // Si n es 0, el MCD es m
            if (n == 0)
            {
                return m;
            }
            else
            {
                // Recursivamente llamar a MCD con (n, m % n)
                return MCD(n, m % n);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leemos los números ingresados por el usuario
                int m = int.Parse(txtNumero1.Text);
                int n = int.Parse(txtNumero2.Text);

                // Asegurarnos de que m sea mayor que n
                if (m <= n)
                {
                    MessageBox.Show("El primer número debe ser mayor que el segundo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamamos a la función MCD para obtener el resultado
                int resultado = MCD(m, n);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"El MCD de {m} y {n} es: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números enteros.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
