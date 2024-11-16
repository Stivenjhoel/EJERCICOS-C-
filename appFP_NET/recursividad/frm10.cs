using System;
using System.Windows.Forms;

namespace SubcadenaSubsecuencia
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        // Función recursiva que cuenta las veces que la subcadena aparece como subsecuencia
        public int ContarSubsecuencias(string cadena, string subcadena, int i = 0, int j = 0)
        {
            // Caso base: si hemos recorrido toda la subcadena, hemos encontrado una subsecuencia
            if (j == subcadena.Length)
            {
                return 1;
            }

            // Caso base: si hemos recorrido toda la cadena sin encontrar la subcadena
            if (i == cadena.Length)
            {
                return 0;
            }

            // Si los caracteres coinciden, tenemos dos opciones:
            // 1. Contar la subsecuencia incluyendo este carácter
            // 2. Saltar este carácter y seguir buscando
            if (cadena[i] == subcadena[j])
            {
                return ContarSubsecuencias(cadena, subcadena, i + 1, j + 1) + ContarSubsecuencias(cadena, subcadena, i + 1, j);
            }
            else
            {
                // Si los caracteres no coinciden, solo podemos saltar este carácter de la cadena
                return ContarSubsecuencias(cadena, subcadena, i + 1, j);
            }
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leemos las cadenas ingresadas por el usuario
                string cadena = txtCadena.Text;
                string subcadena = txtSubcadena.Text;

                // Llamamos a la función recursiva para contar las subsecuencias
                int resultado = ContarSubsecuencias(cadena, subcadena);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"La subcadena '{subcadena}' aparece {resultado} veces como subsecuencia en la cadena '{cadena}'.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
