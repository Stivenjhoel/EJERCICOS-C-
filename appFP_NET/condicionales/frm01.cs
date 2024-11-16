using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class frm01 : Form
    {
        public frm01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad de unidades
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precioUnitario = 0;
            decimal descuento = 0;
            decimal total = 0;

            // Determinar el precio unitario según la cantidad
            if (cantidad >= 1 && cantidad <= 25)
            {
                precioUnitario = 27;
            }
            else if (cantidad >= 26 && cantidad <= 50)
            {
                precioUnitario = 25;
            }
            else if (cantidad >= 51)
            {
                precioUnitario = 23;
            }

            // Calcular el importe de la compra
            decimal importe = cantidad * precioUnitario;

            // Aplicar descuento
            if (cantidad > 50)
            {
                descuento = importe * 0.15m; // 15% de descuento
            }
            else
            {
                descuento = importe * 0.05m; // 5% de descuento
            }

            // Calcular total a pagar
            total = importe - descuento;

            // Mostrar resultados
            lblImporte.Text = "Importe: S/. " + importe.ToString("F2");
            lblDescuento.Text = "Descuento: S/. " + descuento.ToString("F2");
            lblTotal.Text = "Total a Pagar: S/. " + total.ToString("F2");
        }
    }
}
