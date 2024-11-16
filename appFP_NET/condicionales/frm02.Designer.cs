namespace Tienda
{
    partial class frm02
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCaramelos;

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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCaramelos = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(13, 13);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(126, 17);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de Unidades:";

            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(145, 10);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 50);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(229, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Compra";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(13, 100);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(52, 17);
            this.lblImporte.TabIndex = 3;
            this.lblImporte.Text = "Importe:";

            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(13, 130);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(79, 17);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento:";

            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 160);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 17);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";

            // 
            // lblCaramelos
            // 
            this.lblCaramelos.AutoSize = true;
            this.lblCaramelos.Location = new System.Drawing.Point(13, 190);
            this.lblCaramelos.Name = "lblCaramelos";
            this.lblCaramelos.Size = new System.Drawing.Size(76, 17);
            this.lblCaramelos.TabIndex = 6;
            this.lblCaramelos.Text = "Caramelos:";

            // 
            // frm02
            // 
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.lblCaramelos);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Name = "frm02";
            this.Text = "Cálculo de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
