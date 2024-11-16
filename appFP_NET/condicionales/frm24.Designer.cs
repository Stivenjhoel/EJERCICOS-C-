namespace SueldoVendedor
{
    partial class frm24
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMontoVendido;
        private System.Windows.Forms.TextBox txtMontoVendido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSueldoTotal;

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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSueldoTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblMontoVendido
            // 
            this.lblMontoVendido.AutoSize = true;
            this.lblMontoVendido.Location = new System.Drawing.Point(12, 9);
            this.lblMontoVendido.Name = "lblMontoVendido";
            this.lblMontoVendido.Size = new System.Drawing.Size(118, 17);
            this.lblMontoVendido.TabIndex = 0;
            this.lblMontoVendido.Text = "Monto Vendido (S/.):";

            // 
            // txtMontoVendido
            // 
            this.txtMontoVendido.Location = new System.Drawing.Point(136, 6);
            this.txtMontoVendido.Name = "txtMontoVendido";
            this.txtMontoVendido.Size = new System.Drawing.Size(100, 22);
            this.txtMontoVendido.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 45);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(221, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblSueldoTotal
            // 
            this.lblSueldoTotal.AutoSize = true;
            this.lblSueldoTotal.Location = new System.Drawing.Point(12, 90);
            this.lblSueldoTotal.Name = "lblSueldoTotal";
            this.lblSueldoTotal.Size = new System.Drawing.Size(103, 17);
            this.lblSueldoTotal.TabIndex = 3;
            this.lblSueldoTotal.Text = "Sueldo Total: S/.";

            // 
            // frm24
            // 
            this.ClientSize = new System.Drawing.Size(266, 126);
            this.Controls.Add(this.lblSueldoTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoVendido);
            this.Controls.Add(this.lblMontoVendido);
            this.Name = "frm24";
            this.Text = "Cálculo de Sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
