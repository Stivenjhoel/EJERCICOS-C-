using System;
using System.Windows.Forms;

namespace NumerosConSumaIgual
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnBuscarNumeros_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string resultado = "";

            for (int num = 1000; num <= 9999; num++)
            {
                int[] cifras = new int[4];
                cifras[0] = num / 1000;
                cifras[1] = (num / 100) % 10;
                cifras[2] = (num / 10) % 10;
                cifras[3] = num % 10;

                int sumaPares = cifras[1] + cifras[3]; 
                int sumaImpares = cifras[0] + cifras[2]; 

                if (sumaPares == sumaImpares)
                {
                    resultado += num.ToString() + "\n";
                    contador++;
                }
            }

            if (contador > 0)
            {
                txtNumeros.Text = resultado;
                lblCantidad.Text = $"Cantidad de números encontrados: {contador}";
            }
            else
            {
                MessageBox.Show("No se encontraron números que cumplan la condición.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
