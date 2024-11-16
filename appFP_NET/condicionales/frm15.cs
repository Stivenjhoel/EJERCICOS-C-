using System;
using System.Windows.Forms;

namespace SueldoVendedor
{
    public partial class frm15 : Form
    {
        public frm15()
        {
            InitializeComponent();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            // Leer los datos ingresados por el usuario
            double montoVendido;
            if (double.TryParse(txtMontoVendido.Text, out montoVendido))
            {
                double sueldoBase = 250;
                double comision = 0;
                double porcentajeComision = 0;

                // Determinar la comisión según el monto vendido
                if (montoVendido <= 5000)
                {
                    porcentajeComision = 0.05; // 5% para ventas menores o iguales a 5000
                }
                else if (montoVendido > 5000 && montoVendido <= 10000)
                {
                    porcentajeComision = 0.08; // 8% para ventas entre 5001 y 10000
                }
                else if (montoVendido > 10000 && montoVendido <= 20000)
                {
                    porcentajeComision = 0.10; // 10% para ventas entre 10001 y 20000
                }
                else
                {
                    porcentajeComision = 0.15; // 15% para ventas mayores a 20000
                }

                // Calcular la comisión
                comision = montoVendido * porcentajeComision;

                // Calcular el sueldo bruto
                double sueldoBruto = sueldoBase + comision;

                // Calcular el descuento según el sueldo bruto
                double descuento = 0;
                if (sueldoBruto > 3500)
                {
                    descuento = sueldoBruto * 0.15; // Descuento del 15%
                }
                else
                {
                    descuento = sueldoBruto * 0.08; // Descuento del 8%
                }

                // Calcular el sueldo neto
                double sueldoNeto = sueldoBruto - descuento;

                // Mostrar los resultados
                lblResultado.Text = $"Sueldo Bruto: S/. {sueldoBruto:F2}\nComisión: S/. {comision:F2}\nDescuento: S/. {descuento:F2}\nSueldo Neto: S/. {sueldoNeto:F2}";
            }
            else
            {
                lblResultado.Text = "Por favor ingrese un monto de venta válido.";
            }
        }
    }
}
