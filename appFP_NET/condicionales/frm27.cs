using System;
using System.Windows.Forms;

namespace SueldoVendedores
{
    public partial class frm27 : Form
    {
        public frm27()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double montoVendido = Convert.ToDouble(txtMontoVendido.Text);

            double sueldoBasico = 600;
            double comision = montoVendido * 0.15;
            double sueldoBruto = sueldoBasico + comision;
            double descuento = 0;
            double sueldoNeto;
            int polosObsequiados;

            if (sueldoBruto > 1800)
            {
                descuento = sueldoBruto * 0.10;
            }
            else
            {
                descuento = sueldoBruto * 0.05;
            }

            sueldoNeto = sueldoBruto - descuento;

            if (montoVendido > 1000)
            {
                polosObsequiados = 3;
            }
            else
            {
                polosObsequiados = 1;
            }

            lblSueldoBruto.Text = "Sueldo Bruto: S/. " + sueldoBruto.ToString("F2");
            lblDescuento.Text = "Descuento: S/. " + descuento.ToString("F2");
            lblSueldoNeto.Text = "Sueldo Neto: S/. " + sueldoNeto.ToString("F2");
            lblPolos.Text = "Polos Obsequiados: " + polosObsequiados;
        }
    }
}
