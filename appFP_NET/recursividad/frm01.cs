using System;
using System.Windows.Forms;

namespace ExponenteRecursivo
{
    public partial class frm01 : Form
    {
        public frm01()
        {
            InitializeComponent();
        }

        // Función recursiva para calcular la potencia
        public int CalcularPotencia(int baseNum, int exponente)
        {
            // Caso base: cualquier número elevado a 0 es 1
            if (exponente == 0)
            {
                return 1;
            }
            // Caso recursivo: baseNum^exponente = baseNum * baseNum^(exponente - 1)
            else
            {
                return baseNum * CalcularPotencia(baseNum, exponente - 1);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int baseNum = int.Parse(txtBase.Text);
                int exponente = int.Parse(txtExponente.Text);

                int resultado = CalcularPotencia(baseNum, exponente);
                lblResultado.Text = $"Resultado: {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese valores válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
