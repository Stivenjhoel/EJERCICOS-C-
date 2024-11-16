using System;
using System.Windows.Forms;

namespace ClasificacionAngulos
{
    public partial class frm03 : Form
    {
        public frm03()
        {
            InitializeComponent();
        }

        private void btnClasificar_Click(object sender, EventArgs e)
        {
            // Obtener el valor del ángulo ingresado
            double angulo = Convert.ToDouble(txtAngulo.Text);
            string clasificacion = "";

            // Clasificar el ángulo según su valor
            if (angulo == 0)
            {
                clasificacion = "Ángulo Nulo (0°)";
            }
            else if (angulo > 0 && angulo < 90)
            {
                clasificacion = "Ángulo Agudo (0° < x < 90°)";
            }
            else if (angulo == 90)
            {
                clasificacion = "Ángulo Recto (90°)";
            }
            else if (angulo > 90 && angulo < 180)
            {
                clasificacion = "Ángulo Obtuso (90° < x < 180°)";
            }
            else if (angulo == 180)
            {
                clasificacion = "Ángulo Llano (180°)";
            }
            else if (angulo > 180 && angulo < 360)
            {
                clasificacion = "Ángulo Cóncavo (180° < x < 360°)";
            }
            else if (angulo == 360)
            {
                clasificacion = "Ángulo Completo (360°)";
            }
            else
            {
                clasificacion = "Ángulo inválido (debe estar entre 0° y 360°)";
            }

            // Mostrar la clasificación
            lblClasificacion.Text = "Clasificación: " + clasificacion;
        }
    }
}
