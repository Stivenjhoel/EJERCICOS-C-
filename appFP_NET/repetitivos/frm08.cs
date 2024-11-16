using System;
using System.Windows.Forms;

namespace PotenciaCalculator
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcularPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int exponente = int.Parse(txtExponente.Text);

                if (exponente < 0)
                {
                    MessageBox.Show("Por favor, ingresa un exponente no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long resultado = 1;
                for (int i = 1; i <= exponente; i++)
                {
                    resultado *= numero;
                }

                lblResultado.Text = $"El resultado de {numero} elevado a {exponente} es: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
