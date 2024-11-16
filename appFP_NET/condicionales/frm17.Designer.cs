namespace Tienda
{
    partial class frm17
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCantidadDocenas;
        private System.Windows.Forms.TextBox txtCantidadDocenas;
        private System.Windows.Forms.Button btnCalcularCompra;
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
            this.lblCantidadDocenas = new System.Windows.Forms.Label();
            this.txtCantidadDocenas = new System.Windows.Forms.TextBox();
            this.btnCalcularCompra = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblCantidadDocenas
            // 
            this.lblCantidadDocenas.AutoSize = true;
            this.lblCantidadDocenas.Location = new System.Drawing.Point(12, 9);
            this.lblCantidadDocenas.Name = "lblCantidadDocenas";
            this.lblCantidadDocenas.Size = new System.Drawing.Size(124, 17);
            this.lblCantidadDocenas.TabIndex = 0;
            this.lblCantidadDocenas.Text = "Cantidad de Docenas:";

            // 
            // txtCantidadDocenas
            // 
            this.txtCantidadDocenas.Location = new System.Drawing.Point(142, 6);
            this.txtCantidadDocenas.Name = "txtCantidadDocenas";
            this.txtCantidadDocenas.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadDocenas.TabIndex = 1;

            // 
            // btnCalcularCompra
            // 
            this.btnCalcularCompra.Location = new System.Drawing.Point(15, 34);
            this.btnCalcularCompra.Name = "btnCalcularCompra";
            this.btnCalcularCompra.Size = new System.Drawing.Size(227, 30);
            this.btnCalcularCompra.TabIndex = 2;
            this.btnCalcularCompra.Text = "Calcular Compra";
            this.btnCalcularCompra.UseVisualStyleBackColor = true;
            this.btnCalcularCompra.Click += new System.EventHandler(this.btnCalcularCompra_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 67);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm17
            // 
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularCompra);
            this.Controls.Add(this.txtCantidadDocenas);
            this.Controls.Add(this.lblCantidadDocenas);
            this.Name = "frm17";
            this.Text = "Cálculo de Compra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
