namespace NumerosConSumaIgual
{
    partial class frm10
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBuscarNumeros = new System.Windows.Forms.Button();
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnBuscarNumeros
            this.btnBuscarNumeros.Location = new System.Drawing.Point(30, 30);
            this.btnBuscarNumeros.Name = "btnBuscarNumeros";
            this.btnBuscarNumeros.Size = new System.Drawing.Size(200, 30);
            this.btnBuscarNumeros.Text = "Buscar Números";
            this.btnBuscarNumeros.Click += new System.EventHandler(this.btnBuscarNumeros_Click);

            // txtNumeros
            this.txtNumeros.Location = new System.Drawing.Point(30, 70);
            this.txtNumeros.Multiline = true;
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNumeros.Size = new System.Drawing.Size(200, 200);

            // lblCantidad
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 280);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(200, 15);
            this.lblCantidad.Text = "Cantidad de números encontrados: 0";

            this.ClientSize = new System.Drawing.Size(260, 320);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNumeros);
            this.Controls.Add(this.btnBuscarNumeros);
            this.Name = "frm10";
            this.Text = "Números con Suma Igual";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnBuscarNumeros;
        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Label lblCantidad;
    }
}
