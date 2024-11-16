using System;
using System.Windows.Forms;

namespace OficinaEmpleos
{
    public partial class frm19 : Form
    {
        public frm19()
        {
            InitializeComponent();
        }

        private void btnDeterminarCategoria_Click(object sender, EventArgs e)
        {
            // Leer los datos ingresados
            string sexo = cmbSexo.SelectedItem.ToString();
            int edad;

            if (int.TryParse(txtEdad.Text, out edad))
            {
                string categoria = "";

                // Determinar la categoría en función del sexo y la edad
                if (sexo == "Femenino")
                {
                    if (edad < 23)
                    {
                        categoria = "FA";  // Femenino menor de 23 años
                    }
                    else
                    {
                        categoria = "FB";  // Femenino mayor o igual a 23 años
                    }
                }
                else if (sexo == "Masculino")
                {
                    if (edad < 25)
                    {
                        categoria = "MA";  // Masculino menor de 25 años
                    }
                    else
                    {
                        categoria = "MB";  // Masculino mayor o igual a 25 años
                    }
                }

                // Mostrar la categoría
                lblCategoria.Text = $"Categoría: {categoria}";
            }
            else
            {
                lblCategoria.Text = "Por favor ingrese una edad válida.";
            }
        }
    }
}
