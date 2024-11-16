namespace CompraProductos
{
    partial class frm22
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUnidadesA;
        private System.Windows.Forms.Label lblUnidadesB;
        private System.Windows.Forms.TextBox txtUnidadesA;
        private System.Windows.Forms.TextBox txtUnidadesB;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblImporteBruto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblTotalPagar;

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
            this.lblUnidadesA = new System.Windows.Forms.Label();
            this.lblUnidadesB = new System.Windows.Forms.Label();
            this.txtUnidadesA = new System.Windows.Forms.TextBox();
            this.txtUnidadesB = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblImporteBruto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblUnidadesA
            // 
            this.lblUnidadesA.AutoSize = true;
            this.lblUnidadesA.Location = new System.Drawing.Point(12, 9);
            this.lblUnidadesA.Name = "lblUnidadesA";
            this.lblUnidadesA.Size = new System.Drawing.Size(159, 17);
            this.lblUnidadesA.TabIndex = 0;
            this.lblUnidadesA.Text = "Unidades del Producto A:";

            // 
            // lblUnidadesB
            // 
            this.lblUnidadesB.AutoSize = true;
            this.lblUnidadesB.Location = new System.Drawing.Point(12, 42);
            this.lblUnidadesB.Name = "lblUnidadesB";
            this.lblUnidadesB.Size = new System.Drawing.Size(159, 17);
            this.lblUnidadesB.TabIndex = 1;
            this.lblUnidadesB.Text = "Unidades del Producto B:";

            // 
            // txtUnidadesA
            // 
            this.txtUnidadesA.Location = new System.Drawing.Point(177, 6);
            this.txtUnidadesA.Name = "txtUnidadesA";
            this.txtUnidadesA.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadesA.TabIndex = 2;

            // 
            // txtUnidadesB
            // 
            this.txtUnidadesB.Location = new System.Drawing.Point(177, 39);
            this.txtUnidadesB.Name = "txtUnidadesB";
            this.txtUnidadesB.Size = new System.Drawing.Size(100, 22);
            this.txtUnidadesB.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(262, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Importe, Descuento y Total a Pagar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblImporteBruto
            // 
            this.lblImporteBruto.AutoSize = true;
            this.lblImporteBruto.Location = new System.Drawing.Point(12, 116);
            this.lblImporteBruto.Name = "lblImporteBruto";
            this.lblImporteBruto.Size = new System.Drawing.Size(113, 17);
            this.lblImporteBruto.TabIndex = 5;
            this.lblImporteBruto.Text = "Importe Bruto: S/.";

            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 146);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(84, 17);
            this.lblDescuento.TabIndex = 6;
            this.lblDescuento.Text = "Descuento: S/.";

            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(12, 176);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(111, 17);
            this.lblTotalPagar.TabIndex = 7;
            this.lblTotalPagar.Text = "Total a Pagar: S/.";

            // 
            // frm22
            // 
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblImporteBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtUnidadesB);
            this.Controls.Add(this.txtUnidadesA);
            this.Controls.Add(this.lblUnidadesB);
            this.Controls.Add(this.lblUnidadesA);
            this.Name = "frm22";
            this.Text = "Compra de Productos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
