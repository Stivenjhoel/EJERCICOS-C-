using System;
using System.Windows.Forms;

namespace RestaSucesiva
{
    public partial class frm01 : Form
    {
        public frm01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int dividendo = int.Parse(txtDividendo.Text);
                int divisor = int.Parse(txtDivisor.Text);

                if (divisor == 0)
                {
                    MessageBox.Show("El divisor no puede ser cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cálculo por restas sucesivas
                int cociente = 0;
                int resto = dividendo;

                while (resto >= divisor)
                {
                    resto -= divisor;
                    cociente++;
                }

                // Mostrar resultados
                lblCociente.Text = $"Cociente: {cociente}";
                lblResto.Text = $"Resto: {resto}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
