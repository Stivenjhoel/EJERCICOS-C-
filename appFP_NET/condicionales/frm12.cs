using System;
using System.Windows.Forms;

namespace DiaDeLaSemana
{
    public partial class frm12 : Form
    {
        public frm12()
        {
            InitializeComponent();
        }

        private void btnDeterminarDia_Click(object sender, EventArgs e)
        {
            // Leer el número del día ingresado
            int dia;
            if (int.TryParse(txtNumeroDia.Text, out dia))
            {
                string diaSemana;

                // Determinar el nombre del día según el número ingresado
                switch (dia)
                {
                    case 1:
                        diaSemana = "Lunes";
                        break;
                    case 2:
                        diaSemana = "Martes";
                        break;
                    case 3:
                        diaSemana = "Miércoles";
                        break;
                    case 4:
                        diaSemana = "Jueves";
                        break;
                    case 5:
                        diaSemana = "Viernes";
                        break;
                    case 6:
                        diaSemana = "Sábado";
                        break;
                    case 7:
                        diaSemana = "Domingo";
                        break;
                    default:
                        diaSemana = "Número no válido. Ingrese un número entre 1 y 7.";
                        break;
                }

                // Mostrar el resultado en la etiqueta
                lblResultado.Text = "Día: " + diaSemana;
            }
            else
            {
                // Si no es un número válido
                lblResultado.Text = "Por favor ingrese un número válido.";
            }
        }
    }
}
