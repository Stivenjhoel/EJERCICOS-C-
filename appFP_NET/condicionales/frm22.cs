using System;
using System.Windows.Forms;

namespace CompraProductos
{
    public partial class frm22 : Form
    {
        public frm22()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer la cantidad de unidades de cada producto
            int unidadesProductoA = Convert.ToInt32(txtUnidadesA.Text);
            int unidadesProductoB = Convert.ToInt32(txtUnidadesB.Text);

            // Precios unitarios
            double precioA = 25.0;
            double precioB = 30.0;

            // Descuentos
            double descuentoA = (unidadesProductoA > 50) ? 0.15 : 0.0;
            double descuentoB = (unidadesProductoB > 60) ? 0.10 : 0.0;

            // Calcular el importe bruto
            double importeBrutoA = unidadesProductoA * precioA;
            double importeBrutoB = unidadesProductoB * precioB;
            double importeBrutoTotal = importeBrutoA + importeBrutoB;

            // Calcular los descuentos
            double descuentoTotalA = importeBrutoA * descuentoA;
            double descuentoTotalB = importeBrutoB * descuentoB;
            double descuentoTotal = descuentoTotalA + descuentoTotalB;

            // Calcular el total a pagar
            double totalPagar = importeBrutoTotal - descuentoTotal;

            // Mostrar los resultados
            lblImporteBruto.Text = "Importe Bruto: S/. " + importeBrutoTotal.ToString("F2");
            lblDescuento.Text = "Descuento: S/. " + descuentoTotal.ToString("F2");
            lblTotalPagar.Text = "Total a Pagar: S/. " + totalPagar.ToString("F2");
        }
    }
}
