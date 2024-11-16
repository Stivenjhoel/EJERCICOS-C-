namespace SupermercadoPromocion
{
    partial class frm14
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.Label lblMontoCompra;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.TextBox txtMontoCompra;
        private System.Windows.Forms.Button btnAplicarDescuento;
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
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.lblMontoCompra = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.txtMontoCompra = new System.Windows.Forms.TextBox();
            this.btnAplicarDescuento = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(119, 17);
            this.lblNumeroTarjeta.TabIndex = 0;
            this.lblNumeroTarjeta.Text = "Número de Tarjeta:";

            // 
            // lblMontoCompra
            // 
            this.lblMontoCompra.AutoSize = true;
            this.lblMontoCompra.Location = new System.Drawing.Point(12, 40);
            this.lblMontoCompra.Name = "lblMontoCompra";
            this.lblMontoCompra.Size = new System.Drawing.Size(121, 17);
            this.lblMontoCompra.TabIndex = 1;
            this.lblMontoCompra.Text = "Monto de Compra:";

            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(137, 6);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroTarjeta.TabIndex = 2;

            // 
            // txtMontoCompra
            // 
            this.txtMontoCompra.Location = new System.Drawing.Point(137, 37);
            this.txtMontoCompra.Name = "txtMontoCompra";
            this.txtMontoCompra.Size = new System.Drawing.Size(100, 22);
            this.txtMontoCompra.TabIndex = 3;

            // 
            // btnAplicarDescuento
            // 
            this.btnAplicarDescuento.Location = new System.Drawing.Point(15, 65);
            this.btnAplicarDescuento.Name = "btnAplicarDescuento";
            this.btnAplicarDescuento.Size = new System.Drawing.Size(222, 35);
            this.btnAplicarDescuento.TabIndex = 4;
            this.btnAplicarDescuento.Text = "Aplicar Descuento";
            this.btnAplicarDescuento.UseVisualStyleBackColor = true;
            this.btnAplicarDescuento.Click += new System.EventHandler(this.btnAplicarDescuento_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 103);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm14
            // 
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnAplicarDescuento);
            this.Controls.Add(this.txtMontoCompra);
            this.Controls.Add(this.txtNumeroTarjeta);
            this.Controls.Add(this.lblMontoCompra);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Name = "frm14";
            this.Text = "Promoción Supermercado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
