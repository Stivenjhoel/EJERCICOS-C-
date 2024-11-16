using System;
using System.Windows.Forms;

namespace InvertirCadenaRecursiva
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        // Función recursiva para invertir una cadena de caracteres
        public string Invertir(string cadena)
        {
            // Caso base: si la cadena tiene 0 o 1 caracteres, ya está invertida
            if (cadena.Length <= 1)
            {
                return cadena;
            }
            else
            {
                // Caso recursivo: invertir el resto de la cadena y concatenar el primer carácter al final
                return Invertir(cadena.Substring(1)) + cadena[0];
            }
        }

        private void btnInvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Leemos la cadena desde el cuadro de texto
                string cadena = txtCadena.Text;

                // Llamamos a la función recursiva para invertir la cadena
                string resultado = Invertir(cadena);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"Cadena invertida: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
