using System;
using System.Windows.Forms;

namespace SumaVectorRecursiva
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        // Función recursiva para sumar los elementos del vector entre las posiciones 'desde' y 'hasta'
        public int SumaVector(int[] v, int desde, int hasta)
        {
            // Caso base: si 'desde' es mayor que 'hasta', no hay elementos para sumar
            if (desde > hasta)
            {
                return 0;
            }
            else
            {
                // Caso recursivo: sumamos el elemento actual y seguimos con el siguiente
                return v[desde] + SumaVector(v, desde + 1, hasta);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Definimos un vector de números enteros
                int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // Leemos las posiciones 'desde' y 'hasta' desde los cuadros de texto
                int desde = int.Parse(txtDesde.Text);
                int hasta = int.Parse(txtHasta.Text);

                // Verificamos que las posiciones sean válidas
                if (desde < 0 || hasta >= v.Length || desde > hasta)
                {
                    MessageBox.Show("Por favor ingrese un rango válido de posiciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Llamamos a la función recursiva para calcular la suma
                int resultado = SumaVector(v, desde, hasta);
                lblResultado.Text = $"Suma de los elementos entre {desde} y {hasta}: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
