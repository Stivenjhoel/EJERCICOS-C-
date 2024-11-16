namespace Multiplos
{
    partial class frm04
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnMostrarMultiples = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 15);
            this.lblNumero.Text = "Número:";

            // lblCantidad
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 70);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(68, 15);
            this.lblCantidad.Text = "Cantidad:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(120, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);

            // txtCantidad
            this.txtCantidad.Location = new System.Drawing.Point(120, 70);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);

            // btnMostrarMultiples
            this.btnMostrarMultiples.Location = new System.Drawing.Point(30, 110);
            this.btnMostrarMultiples.Name = "btnMostrarMultiples";
            this.btnMostrarMultiples.Size = new System.Drawing.Size(190, 30);
            this.btnMostrarMultiples.Text = "Mostrar Múltiplos";
            this.btnMostrarMultiples.Click += new System.EventHandler(this.btnMostrarMultiples_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 15);
            this.lblResultado.Text = "Múltiplos:";

            // frm04
            this.ClientSize = new System.Drawing.Size(260, 230);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnMostrarMultiples);
            this.Controls.Add(this.lblResultado);
            this.Name = "frm04";
            this.Text = "Mostrar Múltiplos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnMostrarMultiples;
        private System.Windows.Forms.Label lblResultado;
    }
}
