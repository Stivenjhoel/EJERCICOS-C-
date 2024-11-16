using System;
using System.Windows.Forms;

namespace CompraPiezas
{
    public partial class frm26 : Form
    {
        public frm26()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montoCompra = Convert.ToDouble(txtMontoCompra.Text);

            double porcentajePrestamo, prestamo, intereses, pagoPropio;

            if (montoCompra > 5000)
            {
                porcentajePrestamo = 0.30;
            }
            else
            {
                porcentajePrestamo = 0.20;
            }

            prestamo = montoCompra * porcentajePrestamo;
            intereses = prestamo * 0.10;

            pagoPropio = montoCompra - prestamo;

            lblPrestamo.Text = "Préstamo: $" + prestamo.ToString("F2");
            lblIntereses.Text = "Intereses: $" + intereses.ToString("F2");
            lblPagoPropio.Text = "Pago Propio: $" + pagoPropio.ToString("F2");
        }
    }
}
