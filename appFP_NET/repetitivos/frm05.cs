using System;
using System.Windows.Forms;

namespace TablaDeMultiplicar
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);

                if (numero <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un número positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblResultado.Text = $"Tabla de multiplicar de {numero}:";

                for (int i = 1; i <= 12; i++)
                {
                    lblResultado.Text += $"\n{numero} x {i} = {numero * i}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
