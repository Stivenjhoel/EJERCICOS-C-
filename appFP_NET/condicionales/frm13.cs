using System;
using System.Windows.Forms;

namespace CifrasConsecutivas
{
    public partial class frm13 : Form
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Leer el número ingresado
            int numero;
            if (int.TryParse(txtNumero.Text, out numero) && numero >= 100 && numero <= 999)
            {
                // Extraer las cifras del número
                int unidad = numero % 10;
                int decena = (numero / 10) % 10;
                int centena = (numero / 100) % 10;

                // Verificar si las cifras son consecutivas en orden ascendente o descendente
                if ((centena == decena - 1 && decena == unidad - 1) || (centena == decena + 1 && decena == unidad + 1))
                {
                    lblResultado.Text = "Las cifras son consecutivas.";
                }
                else
                {
                    lblResultado.Text = "Las cifras no son consecutivas.";
                }
            }
            else
            {
                lblResultado.Text = "Por favor ingrese un número de tres cifras.";
            }
        }
    }
}
