using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número ingresado por el usuario
                int numero = Convert.ToInt32(txtNumero.Text);

                // Verificar si el número tiene 4 dígitos
                if (numero < 1000 || numero > 9999)
                {
                    MessageBox.Show("Por favor, ingrese un número de 4 cifras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular la suma de las cifras
                int suma = 0;
                int temp = numero;

                while (temp > 0)
                {
                    suma += temp % 10; // Obtener el último dígito y sumarlo
                    temp /= 10;        // Eliminar el último dígito
                }

                // Mostrar el resultado
                lblResultado.Text = $"Suma de las cifras: {suma}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
