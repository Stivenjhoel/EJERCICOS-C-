using System;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class frm16 : Form
    {
        public frm16()
        {
            InitializeComponent();
        }

        private void btnCalcularCuota_Click(object sender, EventArgs e)
        {
            // Leer el costo de la casa y el ingreso mensual del comprador
            double costoCasa;
            double ingresoMensual;

            if (double.TryParse(txtCostoCasa.Text, out costoCasa) && double.TryParse(txtIngresoMensual.Text, out ingresoMensual))
            {
                double cuotaInicial = 0;
                double cuotaMensual = 0;
                int cuotas = 0;

                // Determinar el porcentaje de la cuota inicial y el número de cuotas mensuales
                if (ingresoMensual < 1250)
                {
                    cuotaInicial = costoCasa * 0.15; // 15% del costo de la casa
                    cuotas = 120; // 120 cuotas mensuales
                }
                else
                {
                    cuotaInicial = costoCasa * 0.30; // 30% del costo de la casa
                    cuotas = 75; // 75 cuotas mensuales
                }

                // Calcular la cuota mensual
                double montoRestante = costoCasa - cuotaInicial;
                cuotaMensual = montoRestante / cuotas;

                // Mostrar los resultados
                lblResultado.Text = $"Cuota Inicial: S/. {cuotaInicial:F2}\nCuota Mensual: S/. {cuotaMensual:F2}";
            }
            else
            {
                lblResultado.Text = "Por favor ingrese valores válidos para el costo de la casa y el ingreso mensual.";
            }
        }
    }
}
