using System;
using System.Windows.Forms;

namespace EdadMayorMenor
{
    public partial class frm06 : Form
    {
        public frm06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las edades ingresadas
            int edad1 = Convert.ToInt32(txtEdad1.Text);
            int edad2 = Convert.ToInt32(txtEdad2.Text);
            int edad3 = Convert.ToInt32(txtEdad3.Text);

            // Determinar la edad mayor y menor
            int edadMayor = Math.Max(edad1, Math.Max(edad2, edad3));
            int edadMenor = Math.Min(edad1, Math.Min(edad2, edad3));

            // Mostrar los resultados
            lblEdadMayor.Text = "Edad Mayor: " + edadMayor.ToString();
            lblEdadMenor.Text = "Edad Menor: " + edadMenor.ToString();
        }
    }
}
