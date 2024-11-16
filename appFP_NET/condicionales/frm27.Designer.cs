namespace SueldoVendedores
{
    partial class frm27
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMontoVendido;
        private System.Windows.Forms.TextBox txtMontoVendido;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSueldoNeto;
        private System.Windows.Forms.Label lblPolos;

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
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.lblPolos = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblMontoVendido
            // 
            this.lblMontoVendido.AutoSize = true;
            this.lblMontoVendido.Location = new System.Drawing.Point(12, 20);
            this.lblMontoVendido.Name = "lblMontoVendido";
            this.lblMontoVendido.Size = new System.Drawing.Size(134, 17);
            this.lblMontoVendido.TabIndex = 0;
            this.lblMontoVendido.Text = "Monto Total Vendido:";

            // 
            // txtMontoVendido
            // 
            this.txtMontoVendido.Location = new System.Drawing.Point(160, 17);
            this.txtMontoVendido.Name = "txtMontoVendido";
            this.txtMontoVendido.Size = new System.Drawing.Size(100, 22);
            this.txtMontoVendido.TabIndex = 1;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 60);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(245, 30);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Sueldo y Polos";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(12, 110);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(98, 17);
            this.lblSueldoBruto.TabIndex = 3;
            this.lblSueldoBruto.Text = "Sueldo Bruto: ";

            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(12, 140);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(85, 17);
            this.lblDescuento.TabIndex = 4;
            this.lblDescuento.Text = "Descuento: ";

            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(12, 170);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(93, 17);
            this.lblSueldoNeto.TabIndex = 5;
            this.lblSueldoNeto.Text = "Sueldo Neto: ";

            // 
            // lblPolos
            // 
            this.lblPolos.AutoSize = true;
            this.lblPolos.Location = new System.Drawing.Point(12, 200);
            this.lblPolos.Name = "lblPolos";
            this.lblPolos.Size = new System.Drawing.Size(126, 17);
            this.lblPolos.TabIndex = 6;
            this.lblPolos.Text = "Polos Obsequiados:";

            // 
            // frm27
            // 
            this.ClientSize = new System.Drawing.Size(280, 250);
            this.Controls.Add(this.lblPolos);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSueldoBruto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMontoVendido);
            this.Controls.Add(this.lblMontoVendido);
            this.Name = "frm27";
            this.Text = "Cálculo de Sueldo y Polos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
