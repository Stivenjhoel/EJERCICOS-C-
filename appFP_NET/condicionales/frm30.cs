using System;
using System.Windows.Forms;

namespace CobroCuotas
{
    public partial class frm30 : Form
    {
        public frm30()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                decimal cuotaMensual = Convert.ToDecimal(txtCuota.Text);
                int diaPago = Convert.ToInt32(txtDiaPago.Text);

                if (cuotaMensual < 0 || diaPago < 1 || diaPago > 31)
                {
                    lblResultado.Text = "Ingrese valores válidos.";
                    return;
                }

                decimal descuento = 0;
                decimal recargo = 0;
                decimal totalAPagar = cuotaMensual;

                if (diaPago <= 10)
                {
                    descuento = Math.Max(5, cuotaMensual * 0.02m);
                    totalAPagar -= descuento;
                }
                else if (diaPago <= 20)
                {
                    descuento = 0;
                }
                else
                {
                    recargo = Math.Max(10, cuotaMensual * 0.03m);
                    totalAPagar += recargo;
                }

                lblResultado.Text = $"Cuota Mensual: ${cuotaMensual:F2}\n" +
                                    $"Día de Pago: {diaPago}\n" +
                                    $"Descuento Aplicado: ${descuento:F2}\n" +
                                    $"Recargo Aplicado: ${recargo:F2}\n" +
                                    $"Total a Pagar: ${totalAPagar:F2}";
            }
            catch (Exception)
            {
                lblResultado.Text = "Error al procesar los datos. Verifique la entrada.";
            }
        }
    }
}
