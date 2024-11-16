using System;
using System.Windows.Forms;

namespace InstitucionBenefica
{
    public partial class frm18 : Form
    {
        public frm18()
        {
            InitializeComponent();
        }

        private void btnRepartirDonacion_Click(object sender, EventArgs e)
        {
            // Leer el monto de la donación
            double montoDonacion;

            if (double.TryParse(txtMontoDonacion.Text, out montoDonacion))
            {
                double centroSalud = 0, comedorNinos = 0, bolsa = 0;

                // Repartir la donación según el monto
                if (montoDonacion >= 10000)
                {
                    centroSalud = montoDonacion * 0.30; // 30% al centro de salud
                    comedorNinos = montoDonacion * 0.50; // 50% al comedor de niños
                    bolsa = montoDonacion - (centroSalud + comedorNinos); // Resto para la bolsa
                }
                else
                {
                    centroSalud = montoDonacion * 0.25; // 25% al centro de salud
                    comedorNinos = montoDonacion * 0.60; // 60% al comedor de niños
                    bolsa = montoDonacion - (centroSalud + comedorNinos); // Resto para la bolsa
                }

                // Mostrar los resultados
                lblResultado.Text = $"Monto de la Donación: S/. {montoDonacion:F2}\n" +
                                    $"Centro de Salud: S/. {centroSalud:F2}\n" +
                                    $"Comedor de Niños: S/. {comedorNinos:F2}\n" +
                                    $"Inversión en la Bolsa: S/. {bolsa:F2}";
            }
            else
            {
                lblResultado.Text = "Por favor ingrese un monto válido.";
            }
        }
    }
}
