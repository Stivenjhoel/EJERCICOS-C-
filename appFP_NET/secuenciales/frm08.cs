using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm08 : Form
    {
        public frm08()
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

                // Calcular el área base, el área lateral y el área total
                double areaBase = pi * Math.Pow(radio, 2);
                double areaLateral = 2 * pi * radio * altura;
                double areaTotal = 2 * areaBase + areaLateral;

                // Mostrar los resultados
                lblAreaBase.Text = $"Área Base: {areaBase:N2} unidades²";
                lblAreaLateral.Text = $"Área Lateral: {areaLateral:N2} unidades²";
                lblAreaTotal.Text = $"Área Total: {areaTotal:N2} unidades²";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
