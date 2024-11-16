using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los datos ingresados por el usuario
                int pies = Convert.ToInt32(txtPies.Text);
                int pulgadas = Convert.ToInt32(txtPulgadas.Text);

                // Conversión a metros
                // 1 pie = 0.3048 metros, 1 pulgada = 0.0254 metros
                double estaturaMetros = (pies * 0.3048) + (pulgadas * 0.0254);

                // Mostrar el resultado en metros
                lblResultado.Text = $"Estatura en metros: {estaturaMetros:F2} m";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
