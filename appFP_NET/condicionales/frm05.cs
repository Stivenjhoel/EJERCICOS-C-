using System;
using System.Windows.Forms;

namespace MayorNumero
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Obtener el número ingresado como cadena
            string numero = txtNumero.Text;

            // Verificar que el número tenga 4 cifras
            if (numero.Length == 4 && int.TryParse(numero, out _))
            {
                // Convertir la cadena en un arreglo de caracteres
                char[] cifras = numero.ToCharArray();

                // Ordenar las cifras de menor a mayor
                Array.Sort(cifras);

                // La menor cifra es la primera y la mayor la última en el arreglo ordenado
                int menor = int.Parse(cifras[0].ToString());
                int mayor = int.Parse(cifras[3].ToString());

                // Formar el mayor número de dos cifras posible
                int mayorNumero = (mayor * 10) + menor;

                // Mostrar el resultado
                lblResultado.Text = "Mayor número de dos cifras: " + mayorNumero;
            }
            else
            {
                // Mostrar mensaje de error si el número no tiene 4 cifras
                MessageBox.Show("Por favor ingrese un número de 4 cifras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
