using System;
using System.Windows.Forms;

namespace CantidadDeDivisores
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int cantidadDivisores = 0;

                if (numero <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        cantidadDivisores++;
                    }
                }

                lblResultado.Text = $"Cantidad de divisores: {cantidadDivisores}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
