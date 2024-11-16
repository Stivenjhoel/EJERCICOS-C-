namespace PotenciaCalculator
{
    partial class frm08
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
            this.lblExponente = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.btnCalcularPotencia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 15);
            this.lblNumero.Text = "Número:";

            // lblExponente
            this.lblExponente.AutoSize = true;
            this.lblExponente.Location = new System.Drawing.Point(30, 70);
            this.lblExponente.Name = "lblExponente";
            this.lblExponente.Size = new System.Drawing.Size(68, 15);
            this.lblExponente.Text = "Exponente:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(120, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);

            // txtExponente
            this.txtExponente.Location = new System.Drawing.Point(120, 70);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(100, 23);

            // btnCalcularPotencia
            this.btnCalcularPotencia.Location = new System.Drawing.Point(30, 110);
            this.btnCalcularPotencia.Name = "btnCalcularPotencia";
            this.btnCalcularPotencia.Size = new System.Drawing.Size(190, 30);
            this.btnCalcularPotencia.Text = "Calcular Potencia";
            this.btnCalcularPotencia.Click += new System.EventHandler(this.btnCalcularPotencia_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 15);
            this.lblResultado.Text = "Resultado:";

            this.ClientSize = new System.Drawing.Size(260, 180);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblExponente);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.btnCalcularPotencia);
            this.Controls.Add(this.lblResultado);
            this.Name = "frm08";
            this.Text = "Calculadora de Potencia";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblExponente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.Button btnCalcularPotencia;
        private System.Windows.Forms.Label lblResultado;
    }
}
