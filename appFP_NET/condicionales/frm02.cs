using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad de unidades
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precioUnitario = 20;
            decimal importe = cantidad * precioUnitario;
            decimal descuento = 0;
            decimal total = 0;
            int caramelos = 0;

            // Calcular el descuento basado en el importe
            if (importe > 700)
            {
                descuento = importe * 0.16m; // 16% descuento
            }
            else if (importe >= 501 && importe <= 700)
            {
                descuento = importe * 0.14m; // 14% descuento
            }
            else
            {
                descuento = importe * 0.12m; // 12% descuento
            }

            // Calcular el total después del descuento
            total = importe - descuento;

            // Determinar el número de caramelos según la cantidad de unidades
            if (cantidad >= 1 && cantidad <= 50)
            {
                caramelos = 5;
            }
            else if (cantidad >= 51 && cantidad <= 100)
            {
                caramelos = 10;
            }
            else if (cantidad > 100)
            {
                caramelos = 15;
            }

            // Mostrar resultados
            lblImporte.Text = "Importe: S/. " + importe.ToString("F2");
            lblDescuento.Text = "Descuento: S/. " + descuento.ToString("F2");
            lblTotal.Text = "Total a Pagar: S/. " + total.ToString("F2");
            lblCaramelos.Text = "Caramelos: " + caramelos.ToString();
        }
    }
}
