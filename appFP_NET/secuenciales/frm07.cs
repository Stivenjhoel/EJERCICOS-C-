using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la base y la altura ingresadas por el usuario
                double baseRectangulo = Convert.ToDouble(txtBase.Text);
                double alturaRectangulo = Convert.ToDouble(txtAltura.Text);

                // Calcular el área y el perímetro
                double area = baseRectangulo * alturaRectangulo;
                double perimetro = 2 * (baseRectangulo + alturaRectangulo);

                // Mostrar los resultados
                lblArea.Text = $"Área: {area:N2} unidades²";
                lblPerimetro.Text = $"Perímetro: {perimetro:N2} unidades";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
