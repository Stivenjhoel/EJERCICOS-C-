namespace TiendaDescuento
{
    partial class frm09
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;

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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";

            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(12, 45);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(71, 17);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";

            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(93, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 2;

            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(93, 42);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 76);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 40);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Importe y Descuento";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(12, 130);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(57, 17);
            this.lblImporte.TabIndex = 5;
            this.lblImporte.Text = "Importe:";

            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 160);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(78, 17);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento:";

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 190);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total:";

            // 
            // frm09
            // 
            this.ClientSize = new System.Drawing.Size(211, 220);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frm09";
            this.Text = "Cálculo de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
