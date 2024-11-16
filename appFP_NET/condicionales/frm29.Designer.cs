namespace CalculadoraSueldo
{
    partial class frm29
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lblPagoHora;
        private System.Windows.Forms.TextBox txtPagoHora;
        private System.Windows.Forms.Button btnCalcular;
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
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lblPagoHora = new System.Windows.Forms.Label();
            this.txtPagoHora = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(12, 20);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(115, 17);
            this.lblHoras.TabIndex = 0;
            this.lblHoras.Text = "Horas trabajadas:";

            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(150, 17);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 22);
            this.txtHoras.TabIndex = 1;

            // 
            // lblPagoHora
            // 
            this.lblPagoHora.AutoSize = true;
            this.lblPagoHora.Location = new System.Drawing.Point(12, 60);
            this.lblPagoHora.Name = "lblPagoHora";
            this.lblPagoHora.Size = new System.Drawing.Size(99, 17);
            this.lblPagoHora.TabIndex = 2;
            this.lblPagoHora.Text = "Pago por hora:";

            // 
            // txtPagoHora
            // 
            this.txtPagoHora.Location = new System.Drawing.Point(150, 57);
            this.txtPagoHora.Name = "txtPagoHora";
            this.txtPagoHora.Size = new System.Drawing.Size(100, 22);
            this.txtPagoHora.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(235, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(74, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm29
            // 
            this.ClientSize = new System.Drawing.Size(280, 230);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPagoHora);
            this.Controls.Add(this.lblPagoHora);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lblHoras);
            this.Name = "frm29";
            this.Text = "Cálculo de Sueldo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
