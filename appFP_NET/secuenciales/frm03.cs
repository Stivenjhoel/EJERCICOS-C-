using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos ingresados por el usuario
                double tramo1Kilometros = Convert.ToDouble(txtTramo1Km.Text);
                double tramo2Pies = Convert.ToDouble(txtTramo2Pies.Text);
                double tramo3Millas = Convert.ToDouble(txtTramo3Millas.Text);

                // Conversión de unidades
                double tramo1Metros = tramo1Kilometros * 1000;
                double tramo2Metros = tramo2Pies * 0.3048;
                double tramo3Metros = tramo3Millas * 1609;

                // Longitud total en metros
                double totalMetros = tramo1Metros + tramo2Metros + tramo3Metros;

                // Conversión de metros a yardas
                double totalYardas = totalMetros / 0.9144;

                // Mostrar los resultados
                lblResultadoMetros.Text = $"Total en metros: {totalMetros:F2} m";
                lblResultadoYardas.Text = $"Total en yardas: {totalYardas:F2} yd";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
