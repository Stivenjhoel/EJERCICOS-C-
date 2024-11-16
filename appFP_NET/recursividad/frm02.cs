using System;
using System.Windows.Forms;

namespace ExponenteIterativo
{
    public partial class frm02 : Form
    {
        public frm02()
        {
            InitializeComponent();
        }

        // Función iterativa para calcular la potencia
        public int CalcularPotenciaIterativa(int baseNum, int exponente)
        {
            int resultado = 1;  // Inicializamos el resultado en 1 (caso base)

            // Usamos un bucle 'for' para multiplicar la base por sí misma 'exponente' veces
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;  // Multiplicamos el resultado por la base
            }

            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);

                int resultado = CalcularPotenciaIterativa(baseNum, exponente);
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
