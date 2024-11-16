using System;
using System.Windows.Forms;

namespace OrdenNumeros
{
    public partial class frm20 : Form
    {
        public frm20()
        {
            InitializeComponent();
        }

        private void btnVerificarOrden_Click(object sender, EventArgs e)
        {
            // Leer los tres números ingresados
            int a, b, c;

            if (int.TryParse(txtA.Text, out a) && int.TryParse(txtB.Text, out b) && int.TryParse(txtC.Text, out c))
            {
                // Determinar el orden de los números
                string mensaje = "";

                if (a < b && b < c)
                {
                    mensaje = "Los números están en orden ascendente.";
                }
                else if (a > b && b > c)
                {
                    mensaje = "Los números están en orden descendente.";
                }
                else
                {
                    mensaje = "Los números están en desorden.";
                }

                // Mostrar el resultado
                lblResultado.Text = mensaje;
            }
            else
            {
                lblResultado.Text = "Por favor ingrese tres números válidos.";
            }
        }
    }
}
