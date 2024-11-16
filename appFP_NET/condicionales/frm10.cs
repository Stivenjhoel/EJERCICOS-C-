using System;
using System.Windows.Forms;

namespace EvaluacionCurso
{
    public partial class frm10 : Form
    {
        public frm10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer las 5 notas del curso
            decimal nota1 = Convert.ToDecimal(txtNota1.Text);
            decimal nota2 = Convert.ToDecimal(txtNota2.Text);
            decimal nota3 = Convert.ToDecimal(txtNota3.Text);
            decimal nota4 = Convert.ToDecimal(txtNota4.Text);
            decimal nota5 = Convert.ToDecimal(txtNota5.Text);

            // Crear un array con las 5 notas
            decimal[] notas = { nota1, nota2, nota3, nota4, nota5 };

            // Obtener la nota mayor y la menor
            decimal notaMayor = Math.Max(Math.Max(Math.Max(nota1, nota2), Math.Max(nota3, nota4)), nota5);
            decimal notaMenor = Math.Min(Math.Min(Math.Min(nota1, nota2), Math.Min(nota3, nota4)), nota5);

            // Eliminar la nota mayor y menor
            decimal sumaNotas = 0;
            int countNotas = 0;

            foreach (var nota in notas)
            {
                if (nota != notaMayor && nota != notaMenor)
                {
                    sumaNotas += nota;
                    countNotas++;
                }
            }

            // Calcular el promedio de las 3 notas restantes
            decimal promedio = sumaNotas / countNotas;

            // Mostrar las notas eliminadas
            lblNotasEliminadas.Text = $"Notas eliminadas: {notaMayor}, {notaMenor}";

            // Mostrar el promedio aprobatorio
            lblPromedio.Text = $"Promedio Aprobatorio: {promedio:F2}";
        }
    }
}
