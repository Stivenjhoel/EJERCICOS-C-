namespace CompraPiezas
{
    partial class frm26
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMontoCompra;
        private System.Windows.Forms.TextBox txtMontoCompra;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblIntereses;
        private System.Windows.Forms.Label lblPagoPropio;

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
            this.lblMontoCompra = new System.Windows.Forms.Label();
            this.txtMontoCompra = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblIntereses = new System.Windows.Forms.Label();
            this.lblPagoPropio = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblMontoCompra
            // 
            this.lblMontoCompra.AutoSize = true;
            this.lblMontoCompra.Location = new System.Drawing.Point(12, 15);
            this.lblMontoCompra.Name = "lblMontoCompra";
            this.lblMontoCompra.Size = new System.Drawing.Size(143, 17);
            this.lblMontoCompra.TabIndex = 0;
            this.lblMontoCompra.Text = "Monto Total de Compra:";

            // 
            // txtMontoCompra
            // 
            this.txtMontoCompra.Location = new System.Drawing.Point(170, 12);
            this.txtMontoCompra.Name = "txtMontoCompra";
            this.txtMontoCompra.Size = new System.Drawing.Size(100, 22);
            this.txtMontoCompra.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 50);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(255, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Préstamo y Pago Propio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(12, 95);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(75, 17);
            this.lblPrestamo.TabIndex = 3;
            this.lblPrestamo.Text = "Préstamo: $";

            // 
            // lblIntereses
            // 
            this.lblIntereses.AutoSize = true;
            this.lblIntereses.Location = new System.Drawing.Point(12, 125);
            this.lblIntereses.Name = "lblIntereses";
            this.lblIntereses.Size = new System.Drawing.Size(77, 17);
            this.lblIntereses.TabIndex = 4;
            this.lblIntereses.Text = "Intereses: $";

            // 
            // lblPagoPropio
            // 
            this.lblPagoPropio.AutoSize = true;
            this.lblPagoPropio.Location = new System.Drawing.Point(12, 155);
            this.lblPagoPropio.Name = "lblPagoPropio";
            this.lblPagoPropio.Size = new System.Drawing.Size(90, 17);
            this.lblPagoPropio.TabIndex = 5;
            this.lblPagoPropio.Text = "Pago Propio: $";

            // 
            // frm26
            // 
            this.ClientSize = new System.Drawing.Size(290, 200);
            this.Controls.Add(this.lblPagoPropio);
            this.Controls.Add(this.lblIntereses);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoCompra);
            this.Controls.Add(this.lblMontoCompra);
            this.Name = "frm26";
            this.Text = "Préstamo y Pago Propio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
