using System;
using System.Windows.Forms;

namespace PropinaNotas
{
    public partial class frm23 : Form
    {
        public frm23()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double notaMatematicas = Convert.ToDouble(txtNotaMatematicas.Text);
            double notaFisica = Convert.ToDouble(txtNotaFisica.Text);

            double propinaMatematicas = (notaMatematicas > 17) ? 3 : notaMatematicas * 1;

            double propinaFisica = (notaFisica > 15) ? 2 : notaFisica * 0.5;

            double promedio = (notaMatematicas + notaFisica) / 2;

            string obsequio = (promedio > 16) ? "¡Te obsequiaré un reloj!" : "No hay obsequio.";

            double propinaTotal = propinaMatematicas + propinaFisica;

            lblPropinaTotal.Text = "Total de la Propina: S/. " + propinaTotal.ToString("F2");
            lblObsequio.Text = obsequio;
        }
    }
}
