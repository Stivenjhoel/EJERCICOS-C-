using System;
using System.Windows.Forms;

namespace CalculadoraSueldo
{
    public partial class frm29 : Form
    {
        public frm29()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                int horasTrabajadas = Convert.ToInt32(txtHoras.Text);
                decimal pagoPorHora = Convert.ToDecimal(txtPagoHora.Text);

                if (horasTrabajadas < 0 || pagoPorHora < 0)
                {
                    lblResultado.Text = "Ingrese valores válidos.";
                    return;
                }

                decimal sueldoBruto = 0;
                if (horasTrabajadas <= 48)
                {
                    sueldoBruto = horasTrabajadas * pagoPorHora;
                }
                else
                {

                    int horasExtras = horasTrabajadas - 48;
                    sueldoBruto = (48 * pagoPorHora) + (horasExtras * pagoPorHora * 1.2m);
                }

                decimal descuento = 0;
                if (sueldoBruto > 1500)
                {
                    descuento = sueldoBruto * 0.11m;
                }

                decimal sueldoNeto = sueldoBruto - descuento;

                // Mostrar resultados
                lblResultado.Text = $"Horas trabajadas: {horasTrabajadas}\n" +
                                    $"Pago por hora: S/. {pagoPorHora:F2}\n" +
                                    $"Sueldo bruto: S/. {sueldoBruto:F2}\n" +
                                    $"Descuento: S/. {descuento:F2}\n" +
                                    $"Sueldo neto: S/. {sueldoNeto:F2}";
            }
            catch (Exception)
            {
                lblResultado.Text = "Error al procesar los datos. Verifique la entrada.";
            }
        }
    }
}
