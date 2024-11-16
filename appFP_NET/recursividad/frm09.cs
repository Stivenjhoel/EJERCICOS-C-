using System;
using System.Windows.Forms;

namespace Subcadena
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        // Función iterativa para verificar si 'subcadena' es parte de 'cadena'
        public bool EsSubcadenaIterativa(string cadena, string subcadena)
        {
            // Si la subcadena es más larga que la cadena, no puede ser subcadena
            if (subcadena.Length > cadena.Length)
            {
                return false;
            }

            // Recorremos la cadena
            for (int i = 0; i <= cadena.Length - subcadena.Length; i++)
            {
                bool encontrado = true;
                // Comparamos cada letra de la subcadena con las letras correspondientes de la cadena
                for (int j = 0; j < subcadena.Length; j++)
                {
                    if (cadena[i + j] != subcadena[j])
                    {
                        encontrado = false;
                        break;
                    }
                }

                // Si encontramos la subcadena, retornamos true
                if (encontrado)
                {
                    return true;
                }
            }

            return false; // No se encontró la subcadena
        }

        // Función recursiva para verificar si 'subcadena' es parte de 'cadena'
        public bool EsSubcadenaRecursiva(string cadena, string subcadena, int i = 0, int j = 0)
        {
            // Caso base: si hemos llegado al final de la subcadena, significa que es una subcadena
            if (j == subcadena.Length)
            {
                return true;
            }

            // Si llegamos al final de la cadena sin encontrar la subcadena
            if (i == cadena.Length)
            {
                return false;
            }

            // Si los caracteres coinciden, avanzamos en la subcadena
            if (cadena[i] == subcadena[j])
            {
                return EsSubcadenaRecursiva(cadena, subcadena, i + 1, j + 1);
            }
            else
            {
                // Si no coinciden, reiniciamos la subcadena (avanzamos solo en la cadena)
                return EsSubcadenaRecursiva(cadena, subcadena, i + 1, 0);
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leemos los textos ingresados por el usuario
                string cadena = txtCadena.Text;
                string subcadena = txtSubcadena.Text;

                // Verificamos si la subcadena está presente en la cadena usando ambas funciones
                bool esSubcadenaIterativa = EsSubcadenaIterativa(cadena, subcadena);
                bool esSubcadenaRecursiva = EsSubcadenaRecursiva(cadena, subcadena);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"Iterativo: {(esSubcadenaIterativa ? "Es subcadena" : "No es subcadena")}\n" +
                                    $"Recursivo: {(esSubcadenaRecursiva ? "Es subcadena" : "No es subcadena")}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
