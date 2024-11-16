using System;
using System.Windows.Forms;

namespace TiendaDescuento
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer el código del producto y la cantidad de unidades
            int codigoProducto = Convert.ToInt32(txtCodigo.Text);
            int cantidadUnidades = Convert.ToInt32(txtCantidad.Text);

            // Variables para precio unitario, descuento y total
            decimal precioUnitario = 0;
            decimal descuento = 0;
            decimal totalCompra = 0;
            decimal montoDescuento = 0;

            // Asignar el precio unitario según el código del producto
            switch (codigoProducto)
            {
                case 101:
                    precioUnitario = 17;
                    break;
                case 102:
                    precioUnitario = 25;
                    break;
                case 103:
                    precioUnitario = 16;
                    break;
                case 104:
                    precioUnitario = 27;
                    break;
                default:
                    MessageBox.Show("Código de producto no válido.");
                    return;
            }

            // Calcular el descuento según la cantidad de unidades
            if (cantidadUnidades >= 31)
                descuento = 0.13m;
            else if (cantidadUnidades >= 21)
                descuento = 0.10m;
            else if (cantidadUnidades >= 11)
                descuento = 0.08m;
            else if (cantidadUnidades >= 1)
                descuento = 0.05m;

            // Calcular el importe total antes de descuento
            totalCompra = precioUnitario * cantidadUnidades;

            // Calcular el monto del descuento
            montoDescuento = totalCompra * descuento;

            // Calcular el total a pagar después del descuento
            decimal totalPagar = totalCompra - montoDescuento;

            // Mostrar los resultados
            lblImporte.Text = "Importe: S/. " + totalCompra.ToString("F2");
            lblDescuento.Text = "Descuento: S/. " + montoDescuento.ToString("F2");
            lblTotal.Text = "Total a pagar: S/. " + totalPagar.ToString("F2");
        }
    }
}
