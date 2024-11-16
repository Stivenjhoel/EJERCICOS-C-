using System;
using System.Windows.Forms;

namespace SupermercadoPromocion
{
    public partial class frm14 : Form
    {
        public frm14()
        {
            InitializeComponent();
        }

        private void btnAplicarDescuento_Click(object sender, EventArgs e)
        {
            // Leer el número de la tarjeta
            int numeroTarjeta;
            double montoCompra;

            if (int.TryParse(txtNumeroTarjeta.Text, out numeroTarjeta) && double.TryParse(txtMontoCompra.Text, out montoCompra))
            {
                double descuento = 0;

                // Verificar si el número de la tarjeta es par y no menor de 100
                if (numeroTarjeta % 2 == 0 && numeroTarjeta >= 100)
                {
                    descuento = montoCompra * 0.15; // 15% de descuento
                }
                else
                {
                    descuento = montoCompra * 0.05; // 5% de descuento
                }

                double totalPagar = montoCompra - descuento;

                // Mostrar los resultados
                lblResultado.Text = $"Número de Tarjeta: {numeroTarjeta}\nMonto de Compra: S/. {montoCompra:F2}\nDescuento: S/. {descuento:F2}\nTotal a Pagar: S/. {totalPagar:F2}";
            }
            else
            {
                lblResultado.Text = "Por favor ingrese un número de tarjeta y un monto de compra válidos.";
            }
        }
    }
}
