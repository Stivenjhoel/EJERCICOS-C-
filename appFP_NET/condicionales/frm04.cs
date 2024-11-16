using System;
using System.Windows.Forms;

namespace PromedioFinal
{
    public partial class frm04 : Form
    {
        public frm04()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener las notas de las tres prácticas ingresadas
            double nota1 = Convert.ToDouble(txtNota1.Text);
            double nota2 = Convert.ToDouble(txtNota2.Text);
            double nota3 = Convert.ToDouble(txtNota3.Text);

            // Verificar si la tercera nota es mayor o igual a 10 y sumarle 2 puntos
            if (nota3 >= 10)
            {
                nota3 += 2;
            }

            // Calcular el promedio final
            double promedio = (nota1 + nota2 + nota3) / 3;

            // Mostrar el resultado
            lblPromedio.Text = "Promedio Final: " + promedio.ToString("F2");
        }
    }
}
