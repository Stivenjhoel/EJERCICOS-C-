namespace MultiplicacionSinAsterisco
{
    partial class frm02
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblNumero1
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(30, 30);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(62, 15);
            this.lblNumero1.Text = "Número 1:";

            // lblNumero2
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(30, 70);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(62, 15);
            this.lblNumero2.Text = "Número 2:";

            // txtNumero1
            this.txtNumero1.Location = new System.Drawing.Point(120, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 23);

            // txtNumero2
            this.txtNumero2.Location = new System.Drawing.Point(120, 70);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 23);

            // btnMultiplicar
            this.btnMultiplicar.Location = new System.Drawing.Point(30, 110);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(190, 30);
            this.btnMultiplicar.Text = "Multiplicar";
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);

            // lblResultado
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 160);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 15);
            this.lblResultado.Text = "Resultado:";

            // frm02
            this.ClientSize = new System.Drawing.Size(260, 200);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.lblResultado);
            this.Name = "frm02";
            this.Text = "Multiplicación sin *";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Label lblResultado;
    }
}
