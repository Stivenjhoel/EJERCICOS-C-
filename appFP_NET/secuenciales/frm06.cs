using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el radio y la altura ingresados por el usuario
                double radio = Convert.ToDouble(txtRadio.Text);
                double altura = Convert.ToDouble(txtAltura.Text);

                // Constante π
                double pi = Math.PI;

                // Calcular el área total y el volumen del cilindro
                double area = 2 * pi * radio * (radio + altura);
                double volumen = pi * Math.Pow(radio, 2) * altura;

                // Mostrar los resultados
                lblArea.Text = $"Área Total: {area:N2} unidades²";
                lblVolumen.Text = $"Volumen: {volumen:N2} unidades³";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
