using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los números ingresados por el usuario
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);

                // Verificar si ambos números tienen exactamente 3 dígitos
                if ((numero1 < 100 || numero1 > 999) || (numero2 < 100 || numero2 > 999))
                {
                    MessageBox.Show("Por favor, ingrese dos números de 3 cifras cada uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Extraer dígitos de ambos números
                int centenas1 = numero1 / 100;         // Primera cifra del primer número
                int decenas1 = (numero1 / 10) % 10;    // Segunda cifra del primer número
                int unidades1 = numero1 % 10;          // Tercera cifra del primer número

                int centenas2 = numero2 / 100;         // Primera cifra del segundo número
                int decenas2 = (numero2 / 10) % 10;    // Segunda cifra del segundo número
                int unidades2 = numero2 % 10;          // Tercera cifra del segundo número

                // Intercambiar la primera y tercera cifras
                int nuevoNumero1 = (centenas2 * 100) + (decenas1 * 10) + unidades2;
                int nuevoNumero2 = (centenas1 * 100) + (decenas2 * 10) + unidades1;

                // Mostrar los números resultantes
                lblResultado.Text = $"Nuevos números: {nuevoNumero1} y {nuevoNumero2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
