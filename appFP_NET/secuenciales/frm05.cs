using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace ConversionApp
{
    public partial class frm05 : Form
    {
        public frm05()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer la capacidad en GB ingresada por el usuario
                double capacidadGB = Convert.ToDouble(txtGigabytes.Text);

                // Realizar las conversiones
                double capacidadMB = capacidadGB * 1024;
                double capacidadKB = capacidadMB * 1024;
                double capacidadBytes = capacidadKB * 1024;

                // Mostrar los resultados en las etiquetas correspondientes
                lblMegabytes.Text = $"Capacidad en MB: {capacidadMB:N2} MB";
                lblKilobytes.Text = $"Capacidad en KB: {capacidadKB:N2} KB";
                lblBytes.Text = $"Capacidad en Bytes: {capacidadBytes:N2} Bytes";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
