using System;
using System.Windows.Forms;

namespace RectanguloDeAsteriscos
{
    public partial class frm09 : Form
    {
        public frm09()
        {
            InitializeComponent();
        }

        private void btnGenerarRectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(txtAltura.Text);

                if (n < 4)
                {
                    MessageBox.Show("Por favor, ingresa un valor de n mayor o igual a 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string rectangulo = "";
                for (int i = 0; i < n; i++)
                {
                    rectangulo += new string('*', 2 * n) + "\n";
                }

                txtRectangulo.Text = rectangulo;
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
