using System;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los catetos ingresados por el usuario
                double catetoA = Convert.ToDouble(txtCatetoA.Text);
                double catetoB = Convert.ToDouble(txtCatetoB.Text);

                // Calcular la hipotenusa usando el teorema de Pitágoras
                double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

                // Mostrar el resultado
                lblResultado.Text = $"Hipotenusa = {hipotenusa:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
