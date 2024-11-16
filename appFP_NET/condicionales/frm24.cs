using System;
using System.Windows.Forms;

namespace SueldoVendedor
{
    public partial class frm24 : Form
    {
        public frm24()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double montoVendido = Convert.ToDouble(txtMontoVendido.Text);

            double sueldoBase = montoVendido * 0.10;

            double bonoExceso = 0;
            if (montoVendido > 5000)
            {
                bonoExceso = ((montoVendido - 5000) / 500) * 25;
            }

            double sueldoTotal = sueldoBase + bonoExceso;

            lblSueldoTotal.Text = "Sueldo Total: S/. " + sueldoTotal.ToString("F2");
        }
    }
}
