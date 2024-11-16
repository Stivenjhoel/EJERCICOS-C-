using System;
using System.Windows.Forms;

namespace Multiplos
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnMostrarMultiples_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int cantidad = int.Parse(txtCantidad.Text);

                if (numero <= 0 || cantidad <= 0)
                {
                    MessageBox.Show("Por favor, ingresa números positivos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblResultado.Text = "Múltiplos:";

                for (int i = 1; i <= cantidad; i++)
                {
                    lblResultado.Text += $"\n{numero * i}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
