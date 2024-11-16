namespace TablaDeMultiplicarRango
{
    partial class frm06
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
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.btnGenerarTabla = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 15);
            this.lblNumero.Text = "Número:";

            // lblInicio
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(30, 70);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 15);
            this.lblInicio.Text = "Inicio:";

            // lblFin
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(30, 110);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(26, 15);
            this.lblFin.Text = "Fin:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(120, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);

            // txtInicio
            this.txtInicio.Location = new System.Drawing.Point(120, 70);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 23);

            // txtFin
            this.txtFin.Location = new System.Drawing.Point(120, 110);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 23);

            // btnGenerarTabla
            this.btnGenerarTabla.Location = new System.Drawing.Point(30, 150);
            this.btnGenerarTabla.Name = "btnGenerarTabla";
            this.btnGenerarTabla.Size = new System.Drawing.Size(190, 30);
            this.btnGenerarTabla.Text = "Generar Tabla";
            this.btnGenerarTabla.Click += new System.EventHandler(this.btnGenerarTabla_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 190);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 15);
            this.lblResultado.Text = "Resultado:";

            this.ClientSize = new System.Drawing.Size(260, 250);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtFin);
            this.Controls.Add(this.btnGenerarTabla);
            this.Controls.Add(this.lblResultado);
            this.Name = "frm06";
            this.Text = "Generar Tabla de Multiplicar";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.Button btnGenerarTabla;
        private System.Windows.Forms.Label lblResultado;
    }
}
