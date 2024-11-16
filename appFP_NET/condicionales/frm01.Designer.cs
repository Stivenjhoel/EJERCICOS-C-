namespace Tienda
{
    partial class frm01
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCantidad;
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
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnCalcular = new Button();
            lblImporte = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(13, 13);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(126, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad de Unidades:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(145, 10);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(33, 39);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(212, 40);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Importe";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(13, 100);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(52, 15);
            lblImporte.TabIndex = 3;
            lblImporte.Text = "Importe:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(13, 130);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 4;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(13, 160);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // frm01
            // 
            ClientSize = new Size(284, 201);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblImporte);
            Controls.Add(btnCalcular);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Name = "frm01";
            Text = "Cálculo de Compra";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
