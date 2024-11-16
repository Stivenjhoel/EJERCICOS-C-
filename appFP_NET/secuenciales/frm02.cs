using System;
using System.Windows.Forms;

namespace Condicionales
{
    public partial class Frm02 : Form
    {
        public Frm02()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                double precioUnitario = 20.0;
                double importe = cantidad * precioUnitario;
                double descuento;

                if (cantidad >= 1 && cantidad <= 5)
                {
                    descuento = importe * 0.05;
                }
                else if (cantidad >= 6 && cantidad <= 10)
                {
                    descuento = importe * 0.10;
                }
                else if (cantidad > 10)
                {
                    descuento = importe * 0.15;
                }
                else
                {
                    descuento = 0;
                }

                double total = importe - descuento;
                int caramelos;

                if (cantidad >= 1 && cantidad <= 5)
                {
                    caramelos = 1;
                }
                else if (cantidad >= 6 && cantidad <= 10)
                {
                    caramelos = 2;
                }
                else
                {
                    caramelos = 3;
                }

                lblImporte.Text = $"Importe: S/. {importe:F2}";
                lblDescuento.Text = $"Descuento: S/. {descuento:F2}";
                lblTotal.Text = $"Total a Pagar: S/. {total:F2}";
                lblCaramelos.Text = $"Caramelos: {caramelos}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}