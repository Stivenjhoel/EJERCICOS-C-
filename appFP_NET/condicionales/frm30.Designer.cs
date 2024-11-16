namespace CobroCuotas
{
    partial class frm30
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label lblDiaPago;
        private System.Windows.Forms.TextBox txtDiaPago;
        private System.Windows.Forms.Button btnCalcular;
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
            this.lblCuota = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.lblDiaPago = new System.Windows.Forms.Label();
            this.txtDiaPago = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Location = new System.Drawing.Point(12, 20);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(108, 17);
            this.lblCuota.TabIndex = 0;
            this.lblCuota.Text = "Cuota Mensual:";

            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(150, 17);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(100, 22);
            this.txtCuota.TabIndex = 1;

            // 
            // lblDiaPago
            // 
            this.lblDiaPago.AutoSize = true;
            this.lblDiaPago.Location = new System.Drawing.Point(12, 60);
            this.lblDiaPago.Name = "lblDiaPago";
            this.lblDiaPago.Size = new System.Drawing.Size(80, 17);
            this.lblDiaPago.TabIndex = 2;
            this.lblDiaPago.Text = "Día de Pago:";

            // 
            // txtDiaPago
            // 
            this.txtDiaPago.Location = new System.Drawing.Point(150, 57);
            this.txtDiaPago.Name = "txtDiaPago";
            this.txtDiaPago.Size = new System.Drawing.Size(100, 22);
            this.txtDiaPago.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(235, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Pago";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(74, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm30
            // 
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDiaPago);
            this.Controls.Add(this.lblDiaPago);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.lblCuota);
            this.Name = "frm30";
            this.Text = "Cobro de Cuotas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
