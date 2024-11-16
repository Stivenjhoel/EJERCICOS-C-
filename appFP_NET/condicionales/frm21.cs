using System;
using System.Windows.Forms;

namespace RegistroEmpleado
{
    public partial class frm21 : Form
    {
        public frm21()
        {
            InitializeComponent();
        }

        private void btnMostrarInformacion_Click(object sender, EventArgs e)
        {
            // Leer el número asignado al empleado
            int numeroEmpleado;

            if (int.TryParse(txtNumeroEmpleado.Text, out numeroEmpleado) && numeroEmpleado >= 1000 && numeroEmpleado <= 9999)
            {
                // Extraer las cifras del número
                int estadoCivil = numeroEmpleado / 1000;
                int edad = (numeroEmpleado / 10) % 100; // Obtener las dos cifras del medio
                int sexo = numeroEmpleado % 10;

                // Determinar el estado civil
                string estadoCivilStr = "";
                switch (estadoCivil)
                {
                    case 1: estadoCivilStr = "Soltero"; break;
                    case 2: estadoCivilStr = "Casado"; break;
                    case 3: estadoCivilStr = "Divorciado"; break;
                    case 4: estadoCivilStr = "Viudo"; break;
                    default: estadoCivilStr = "Desconocido"; break;
                }

                // Determinar el sexo
                string sexoStr = (sexo == 1) ? "Masculino" : (sexo == 2) ? "Femenino" : "Desconocido";

                // Mostrar la información
                lblEstadoCivil.Text = "Estado Civil: " + estadoCivilStr;
                lblEdad.Text = "Edad: " + edad.ToString();
                lblSexo.Text = "Sexo: " + sexoStr;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido de cuatro cifras.");
            }
        }
    }
}
