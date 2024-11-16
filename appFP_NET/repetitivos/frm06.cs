using System;
using System.Windows.Forms;

namespace TablaDeMultiplicarRango
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero.Text);
                int inicio = int.Parse(txtInicio.Text);
                int fin = int.Parse(txtFin.Text);

                if (numero <= 0 || inicio <= 0 || fin <= 0 || inicio > fin)
                {
                    MessageBox.Show("Por favor, ingresa números válidos y asegúrate de que el rango sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lblResultado.Text = $"Tabla de multiplicar de {numero}, del {inicio} al {fin}:";

                for (int i = inicio; i <= fin; i++)
                {
                    lblResultado.Text += $"\n{numero} x {i} = {numero * i}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
