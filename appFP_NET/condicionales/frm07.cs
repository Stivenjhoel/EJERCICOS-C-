using System;
using System.Windows.Forms;

namespace NumeroIntermedio
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer los tres números enteros ingresados por el usuario
            int num1 = Convert.ToInt32(txtNumero1.Text);
            int num2 = Convert.ToInt32(txtNumero2.Text);
            int num3 = Convert.ToInt32(txtNumero3.Text);

            // Determinar el número intermedio
            int intermedio;

            if ((num1 > num2 && num1 < num3) || (num1 < num2 && num1 > num3))
            {
                intermedio = num1;
            }
            else if ((num2 > num1 && num2 < num3) || (num2 < num1 && num2 > num3))
            {
                intermedio = num2;
            }
            else
            {
                intermedio = num3;
            }

            // Mostrar el número intermedio
            lblResultado.Text = "Número intermedio: " + intermedio.ToString();
        }
    }
}
