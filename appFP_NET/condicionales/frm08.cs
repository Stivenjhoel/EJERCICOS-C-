using System;
using System.Windows.Forms;

namespace PropinaEstudiante
{
    public partial class frm08 : Form
    {
        public frm08()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer las notas de los tres exámenes
            int examen1 = Convert.ToInt32(txtExamen1.Text);
            int examen2 = Convert.ToInt32(txtExamen2.Text);
            int examen3 = Convert.ToInt32(txtExamen3.Text);

            // Propina base
            decimal propinaBase = 20.00m;
            decimal propinaAdicional = 0.00m;

            // Verificar cuántos exámenes están aprobados (considerando que la nota aprobatoria es mayor o igual a 10)
            if (examen1 >= 10) propinaAdicional += 5;
            if (examen2 >= 10) propinaAdicional += 5;
            if (examen3 >= 10) propinaAdicional += 5;

            // Calcular monto total de la propina
            decimal propinaTotal = propinaBase + propinaAdicional;

            // Mostrar el resultado
            lblTotal.Text = "Monto total de la propina: S/. " + propinaTotal.ToString("F2");
        }
    }
}
