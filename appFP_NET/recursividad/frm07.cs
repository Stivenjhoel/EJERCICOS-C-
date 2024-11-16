using System;
using System.Windows.Forms;

namespace PalindromoRecursivoIterativo
{
    public partial class frm07 : Form
    {
        public frm07()
        {
            InitializeComponent();
        }

        // Función recursiva para verificar si una cadena es palíndromo
        public bool EsPalindromoRecursivo(string cadena)
        {
            // Caso base: si la cadena tiene 0 o 1 caracteres, es un palíndromo
            if (cadena.Length <= 1)
            {
                return true;
            }

            // Comparamos el primer y el último carácter
            if (cadena[0] == cadena[cadena.Length - 1])
            {
                // Llamada recursiva con la subcadena eliminando el primer y último carácter
                return EsPalindromoRecursivo(cadena.Substring(1, cadena.Length - 2));
            }
            else
            {
                return false;
            }
        }

        // Función iterativa para verificar si una cadena es palíndromo
        public bool EsPalindromoIterativo(string cadena)
        {
            int izquierda = 0;
            int derecha = cadena.Length - 1;

            while (izquierda < derecha)
            {
                if (cadena[izquierda] != cadena[derecha])
                {
                    return false;
                }

                izquierda++;
                derecha--;
            }

            return true;
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leemos la cadena desde el cuadro de texto
                string cadena = txtCadena.Text;

                // Llamamos a las funciones para verificar si es palíndromo
                bool esPalindromoRecursivo = EsPalindromoRecursivo(cadena);
                bool esPalindromoIterativo = EsPalindromoIterativo(cadena);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"Recursivo: {(esPalindromoRecursivo ? "Es un palíndromo" : "No es un palíndromo")}\n" +
                                    $"Iterativo: {(esPalindromoIterativo ? "Es un palíndromo" : "No es un palíndromo")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
