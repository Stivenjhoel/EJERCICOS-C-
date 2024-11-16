namespace Inmobiliaria
{
    partial class frm16
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCostoCasa;
        private System.Windows.Forms.Label lblIngresoMensual;
        private System.Windows.Forms.TextBox txtCostoCasa;
        private System.Windows.Forms.TextBox txtIngresoMensual;
        private System.Windows.Forms.Button btnCalcularCuota;
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
            this.lblCostoCasa = new System.Windows.Forms.Label();
            this.lblIngresoMensual = new System.Windows.Forms.Label();
            this.txtCostoCasa = new System.Windows.Forms.TextBox();
            this.txtIngresoMensual = new System.Windows.Forms.TextBox();
            this.btnCalcularCuota = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblCostoCasa
            // 
            this.lblCostoCasa.AutoSize = true;
            this.lblCostoCasa.Location = new System.Drawing.Point(12, 9);
            this.lblCostoCasa.Name = "lblCostoCasa";
            this.lblCostoCasa.Size = new System.Drawing.Size(97, 17);
            this.lblCostoCasa.TabIndex = 0;
            this.lblCostoCasa.Text = "Costo de la Casa:";

            // 
            // lblIngresoMensual
            // 
            this.lblIngresoMensual.AutoSize = true;
            this.lblIngresoMensual.Location = new System.Drawing.Point(12, 41);
            this.lblIngresoMensual.Name = "lblIngresoMensual";
            this.lblIngresoMensual.Size = new System.Drawing.Size(113, 17);
            this.lblIngresoMensual.TabIndex = 1;
            this.lblIngresoMensual.Text = "Ingreso Mensual:";

            // 
            // txtCostoCasa
            // 
            this.txtCostoCasa.Location = new System.Drawing.Point(131, 6);
            this.txtCostoCasa.Name = "txtCostoCasa";
            this.txtCostoCasa.Size = new System.Drawing.Size(100, 22);
            this.txtCostoCasa.TabIndex = 2;

            // 
            // txtIngresoMensual
            // 
            this.txtIngresoMensual.Location = new System.Drawing.Point(131, 38);
            this.txtIngresoMensual.Name = "txtIngresoMensual";
            this.txtIngresoMensual.Size = new System.Drawing.Size(100, 22);
            this.txtIngresoMensual.TabIndex = 3;

            // 
            // btnCalcularCuota
            // 
            this.btnCalcularCuota.Location = new System.Drawing.Point(15, 66);
            this.btnCalcularCuota.Name = "btnCalcularCuota";
            this.btnCalcularCuota.Size = new System.Drawing.Size(216, 35);
            this.btnCalcularCuota.TabIndex = 4;
            this.btnCalcularCuota.Text = "Calcular Cuota Inicial y Mensual";
            this.btnCalcularCuota.UseVisualStyleBackColor = true;
            this.btnCalcularCuota.Click += new System.EventHandler(this.btnCalcularCuota_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 104);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm16
            // 
            this.ClientSize = new System.Drawing.Size(250, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcularCuota);
            this.Controls.Add(this.txtIngresoMensual);
            this.Controls.Add(this.txtCostoCasa);
            this.Controls.Add(this.lblIngresoMensual);
            this.Controls.Add(this.lblCostoCasa);
            this.Name = "frm16";
            this.Text = "Cálculo Cuotas Casa";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
