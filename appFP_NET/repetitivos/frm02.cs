using System;
using System.Windows.Forms;

namespace MultiplicacionSinAsterisco
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = int.Parse(txtNumero1.Text);
                int numero2 = int.Parse(txtNumero2.Text);

                bool esNegativo = false;
                if (numero2 < 0)
                {
                    esNegativo = true;
                    numero2 = -numero2; 
                }

                int resultado = 0;
                for (int i = 0; i < numero2; i++)
                {
                    resultado += numero1;
                }

                if (esNegativo)
                {
                    resultado = -resultado;
                }

                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
