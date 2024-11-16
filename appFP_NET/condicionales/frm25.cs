using System;
using System.Windows.Forms;

namespace BonificacionEmpleados
{
    public partial class frm25 : Form
    {
        public frm25()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sueldoBruto = Convert.ToDouble(txtSueldoBruto.Text);
            int cantidadHijos = Convert.ToInt32(txtCantidadHijos.Text);

            double bonificacion;
            if (cantidadHijos > 1)
            {
                bonificacion = sueldoBruto * 0.125 + (cantidadHijos * 40);
            }
            else
            {
                bonificacion = sueldoBruto * 0.10;
            }

            double sueldoNeto = sueldoBruto + bonificacion;

            lblBonificacion.Text = "Bonificación: S/. " + bonificacion.ToString("F2");
            lblSueldoNeto.Text = "Sueldo Neto: S/. " + sueldoNeto.ToString("F2");
        }
    }
}
