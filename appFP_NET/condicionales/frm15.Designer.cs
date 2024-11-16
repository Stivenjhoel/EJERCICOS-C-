namespace SueldoVendedor
{
    partial class frm15
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMontoVendido;
        private System.Windows.Forms.TextBox txtMontoVendido;
        private System.Windows.Forms.Button btnCalcularSueldo;
        private System.Windows.Forms.Label lblResultado;

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
            this.lblMontoVendido = new System.Windows.Forms.Label();
            this.txtMontoVendido = new System.Windows.Forms.TextBox();
            this.btnCalcularSueldo = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblMontoVendido
            // 
            this.lblMontoVendido.AutoSize = true;
            this.lblMontoVendido.Location = new System.Drawing.Point(12, 9);
            this.lblMontoVendido.Name = "lblMontoVendido";
            this.lblMontoVendido.Size = new System.Drawing.Size(100, 17);
            this.lblMontoVendido.TabIndex = 0;
            this.lblMontoVendido.Text = "Monto Vendido:";

            // 
            // txtMontoVendido
            // 
            this.txtMontoVendido.Location = new System.Drawing.Point(118, 6);
            this.txtMontoVendido.Name = "txtMontoVendido";
            this.txtMontoVendido.Size = new System.Drawing.Size(100, 22);
            this.txtMontoVendido.TabIndex = 1;

            // 
            // btnCalcularSueldo
            // 
            this.btnCalcularSueldo.Location = new System.Drawing.Point(15, 34);
            this.btnCalcularSueldo.Name = "btnCalcularSueldo";
            this.btnCalcularSueldo.Size = new System.Drawing.Size(203, 35);
            this.btnCalcularSueldo.TabIndex = 2;
            this.btnCalcularSueldo.Text = "Calcular Sueldo";
            this.btnCalcularSueldo.UseVisualStyleBackColor = true;
            this.btnCalcularSueldo.Click += new System.EventHandler(this.btnCalcularSueldo_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 72);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm15
            // 
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularSueldo);
            this.Controls.Add(this.txtMontoVendido);
            this.Controls.Add(this.lblMontoVendido);
            this.Name = "frm15";
            this.Text = "Cálculo Sueldo Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
