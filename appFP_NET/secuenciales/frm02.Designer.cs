namespace Condicionales
{
    partial class Frm02
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCaramelos;
        private System.Windows.Forms.Button btnCalcular;

        /// <summary>
        /// Limpiar los recursos que esté utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados deben eliminarse; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            txtCantidad = new TextBox();
            lblImporte = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            lblCaramelos = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(117, 53);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(112, 23);
            txtCantidad.TabIndex = 0;
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(26, 103);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(93, 15);
            lblImporte.TabIndex = 1;
            lblImporte.Text = "Importe: S/. 0.00";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(26, 131);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(107, 15);
            lblDescuento.TabIndex = 2;
            lblDescuento.Text = "Descuento: S/. 0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(26, 159);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total a Pagar: S/. 0.00";
            // 
            // lblCaramelos
            // 
            lblCaramelos.AutoSize = true;
            lblCaramelos.Location = new Point(26, 188);
            lblCaramelos.Name = "lblCaramelos";
            lblCaramelos.Size = new Size(75, 15);
            lblCaramelos.TabIndex = 4;
            lblCaramelos.Text = "Caramelos: 0";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(86, 222);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(192, 28);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += BtnCalcular_Click;
            // 
            // Frm02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 281);
            Controls.Add(txtCantidad);
            Controls.Add(lblImporte);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotal);
            Controls.Add(lblCaramelos);
            Controls.Add(btnCalcular);
            Name = "Frm02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora de Ventas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
