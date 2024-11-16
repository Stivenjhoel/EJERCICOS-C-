namespace FactorialCalculator
{
    partial class frm07
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcularFactorial = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumero
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(30, 30);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 15);
            this.lblNumero.Text = "Número:";

            // txtNumero
            this.txtNumero.Location = new System.Drawing.Point(120, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 23);

            // btnCalcularFactorial
            this.btnCalcularFactorial.Location = new System.Drawing.Point(30, 70);
            this.btnCalcularFactorial.Name = "btnCalcularFactorial";
            this.btnCalcularFactorial.Size = new System.Drawing.Size(190, 30);
            this.btnCalcularFactorial.Text = "Calcular Factorial";
            this.btnCalcularFactorial.Click += new System.EventHandler(this.btnCalcularFactorial_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 110);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 15);
            this.lblResultado.Text = "Resultado:";

            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnCalcularFactorial);
            this.Controls.Add(this.lblResultado);
            this.Name = "frm07";
            this.Text = "Calculadora de Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcularFactorial;
        private System.Windows.Forms.Label lblResultado;
    }
}
