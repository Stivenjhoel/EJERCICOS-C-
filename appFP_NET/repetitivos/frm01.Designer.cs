namespace RestaSucesiva
{
    partial class frm01
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCociente = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblDividendo
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Location = new System.Drawing.Point(30, 30);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(70, 15);
            this.lblDividendo.Text = "Dividendo:";

            // lblDivisor
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Location = new System.Drawing.Point(30, 70);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(50, 15);
            this.lblDivisor.Text = "Divisor:";

            // txtDividendo
            this.txtDividendo.Location = new System.Drawing.Point(120, 30);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(100, 23);

            // txtDivisor
            this.txtDivisor.Location = new System.Drawing.Point(120, 70);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(100, 23);

            // btnCalcular
            this.btnCalcular.Location = new System.Drawing.Point(30, 110);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(190, 30);
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // lblCociente
            this.lblCociente.AutoSize = true;
            this.lblCociente.Location = new System.Drawing.Point(30, 160);
            this.lblCociente.Name = "lblCociente";
            this.lblCociente.Size = new System.Drawing.Size(58, 15);
            this.lblCociente.Text = "Cociente:";

            // lblResto
            this.lblResto.AutoSize = true;
            this.lblResto.Location = new System.Drawing.Point(30, 190);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(44, 15);
            this.lblResto.Text = "Resto:";

            // frm01
            this.ClientSize = new System.Drawing.Size(260, 240);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCociente);
            this.Controls.Add(this.lblResto);
            this.Name = "frm01";
            this.Text = "División por Restas Sucesivas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCociente;
        private System.Windows.Forms.Label lblResto;
    }
}
