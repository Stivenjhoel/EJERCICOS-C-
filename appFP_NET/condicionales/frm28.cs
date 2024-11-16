using System;
using System.Windows.Forms;

namespace ConversorHora
{
    public partial class frm28 : Form
    {
        public frm28()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                int hora = Convert.ToInt32(txtHora.Text);
                int minutos = Convert.ToInt32(txtMinutos.Text);

                if (hora < 0 || hora > 23 || minutos < 0 || minutos > 59)
                {
                    lblResultado.Text = "Hora inválida. Por favor, ingrese una hora válida.";
                    return;
                }

                string periodo = (hora >= 12) ? "PM" : "AM";
                int hora12 = (hora == 0 || hora == 12) ? 12 : hora % 12;

                lblResultado.Text = $"Hora en formato 12 horas: {hora12:D2}:{minutos:D2} {periodo}";
            }
            catch (Exception)
            {
                lblResultado.Text = "Entrada inválida. Por favor, ingrese solo números.";
            }
        }
    }
}
