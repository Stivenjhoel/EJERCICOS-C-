using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm15 : Form
    {
        public frm15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los aportes en dólares de Juan y Rosa
                double aporteJuan = Convert.ToDouble(txtJuan.Text);
                double aporteRosa = Convert.ToDouble(txtRosa.Text);

                // Leer el aporte en soles de Daniel y convertir a dólares
                double aporteDanielSoles = Convert.ToDouble(txtDaniel.Text);
                double aporteDaniel = aporteDanielSoles / 3.00; // Conversión a dólares

                // Calcular el capital total en dólares
                double capitalTotal = aporteJuan + aporteRosa + aporteDaniel;

                // Calcular el porcentaje de cada aporte respecto al capital total
                double porcentajeJuan = (aporteJuan / capitalTotal) * 100;
                double porcentajeRosa = (aporteRosa / capitalTotal) * 100;
                double porcentajeDaniel = (aporteDaniel / capitalTotal) * 100;

                // Mostrar resultados
                lblResultado.Text = $"Capital Total: ${capitalTotal:F2}\n" +
                                    $"Juan: {porcentajeJuan:F2}%\n" +
                                    $"Rosa: {porcentajeRosa:F2}%\n" +
                                    $"Daniel: {porcentajeDaniel:F2}%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
