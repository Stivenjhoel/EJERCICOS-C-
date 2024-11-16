using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el número ingresado por el usuario
                int numero = Convert.ToInt32(txtNumero.Text);

                // Verificar si el número tiene exactamente 4 dígitos
                if (numero < 1000 || numero > 9999)
                {
                    MessageBox.Show("Por favor, ingrese un número de 4 cifras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convertir el número a string, invertirlo y convertirlo de nuevo a entero
                string numeroInvertido = new string(txtNumero.Text.ToCharArray().Reverse().ToArray());

                // Mostrar el número invertido
                lblResultado.Text = $"Número invertido: {numeroInvertido}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
