using System;
using System.Windows.Forms;

namespace DeterminarSigno
{
    public partial class frm11 : Form
    {
        public frm11()
        {
            InitializeComponent();
        }

        private void btnDeterminarSigno_Click(object sender, EventArgs e)
        {
            // Leer el número ingresado
            double numero;
            if (double.TryParse(txtNumero.Text, out numero))
            {
                // Determinar el signo del número
                string resultado = "";

                if (numero > 0)
                {
                    resultado = "El número es positivo.";
                }
                else if (numero < 0)
                {
                    resultado = "El número es negativo.";
                }
                else
                {
                    resultado = "El número es cero.";
                }

                // Mostrar el resultado en la etiqueta
                lblResultado.Text = resultado;
            }
            else
            {
                // Si no es un número válido
                lblResultado.Text = "Por favor ingrese un número válido.";
            }
        }
    }
}
