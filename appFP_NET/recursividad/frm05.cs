using System;
using System.Windows.Forms;

namespace MayorElementoRecursivo
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        // Función recursiva para encontrar el mayor número en el arreglo
        public int MayorElemento(int[] v, int desde)
        {
            // Caso base: si estamos en el último elemento, retornamos ese elemento
            if (desde == v.Length - 1)
            {
                return v[desde];
            }
            else
            {
                // Caso recursivo: compararemos el elemento actual con el mayor de los elementos restantes
                int mayorDelRestante = MayorElemento(v, desde + 1);
                return v[desde] > mayorDelRestante ? v[desde] : mayorDelRestante;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Definimos un vector de números enteros
                int[] v = { 1, 3, 5, 7, 2, 9, 4, 6, 8, 10 };

                // Llamamos a la función recursiva para encontrar el mayor número
                int resultado = MayorElemento(v, 0);

                // Mostramos el resultado en el Label
                lblResultado.Text = $"El mayor elemento del vector es: {resultado}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
