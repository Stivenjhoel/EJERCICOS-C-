using System;
using System.Windows.Forms;

namespace Tienda
{
    public partial class frm17 : Form
    {
        public frm17()
        {
            InitializeComponent();
        }

        private void btnCalcularCompra_Click(object sender, EventArgs e)
        {
            // Leer la cantidad de docenas y el precio por docena
            int cantidadDocenas;
            double precioDocena = 10.0; // Precio por docena

            if (int.TryParse(txtCantidadDocenas.Text, out cantidadDocenas))
            {
                double montoCompra = cantidadDocenas * precioDocena;
                double descuento = 0;
                double totalPagar = montoCompra;
                int lapicerosObsequio = 0;

                // Calcular el descuento
                if (cantidadDocenas >= 6)
                {
                    descuento = montoCompra * 0.15; // 15% de descuento por 6 o más docenas
                }
                else
                {
                    descuento = montoCompra * 0.10; // 10% de descuento en caso contrario
                }

                // Calcular la cantidad de lapiceros de obsequio
                if (cantidadDocenas >= 30)
                {
                    lapicerosObsequio = (cantidadDocenas / 3) * 2; // 2 lapiceros por cada 3 docenas
                }

                // Calcular el total a pagar después del descuento
                totalPagar = montoCompra - descuento;

                // Mostrar los resultados
                lblResultado.Text = $"Monto de la Compra: S/. {montoCompra:F2}\n" +
                                    $"Descuento: S/. {descuento:F2}\n" +
                                    $"Total a Pagar: S/. {totalPagar:F2}\n" +
                                    $"Lapiceros de Obsequio: {lapicerosObsequio}";
            }
            else
            {
                lblResultado.Text = "Por favor ingrese una cantidad válida de docenas.";
            }
        }
    }
}
