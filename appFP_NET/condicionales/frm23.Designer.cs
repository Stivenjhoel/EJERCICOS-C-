namespace PropinaNotas
{
    partial class frm23
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNotaMatematicas;
        private System.Windows.Forms.Label lblNotaFisica;
        private System.Windows.Forms.TextBox txtNotaMatematicas;
        private System.Windows.Forms.TextBox txtNotaFisica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPropinaTotal;
        private System.Windows.Forms.Label lblObsequio;

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
            this.lblNotaMatematicas = new System.Windows.Forms.Label();
            this.lblNotaFisica = new System.Windows.Forms.Label();
            this.txtNotaMatematicas = new System.Windows.Forms.TextBox();
            this.txtNotaFisica = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPropinaTotal = new System.Windows.Forms.Label();
            this.lblObsequio = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNotaMatematicas
            // 
            this.lblNotaMatematicas.AutoSize = true;
            this.lblNotaMatematicas.Location = new System.Drawing.Point(12, 9);
            this.lblNotaMatematicas.Name = "lblNotaMatematicas";
            this.lblNotaMatematicas.Size = new System.Drawing.Size(142, 17);
            this.lblNotaMatematicas.TabIndex = 0;
            this.lblNotaMatematicas.Text = "Nota de Matemáticas:";

            // 
            // lblNotaFisica
            // 
            this.lblNotaFisica.AutoSize = true;
            this.lblNotaFisica.Location = new System.Drawing.Point(12, 42);
            this.lblNotaFisica.Name = "lblNotaFisica";
            this.lblNotaFisica.Size = new System.Drawing.Size(106, 17);
            this.lblNotaFisica.TabIndex = 1;
            this.lblNotaFisica.Text = "Nota de Física:";

            // 
            // txtNotaMatematicas
            // 
            this.txtNotaMatematicas.Location = new System.Drawing.Point(160, 6);
            this.txtNotaMatematicas.Name = "txtNotaMatematicas";
            this.txtNotaMatematicas.Size = new System.Drawing.Size(100, 22);
            this.txtNotaMatematicas.TabIndex = 2;

            // 
            // txtNotaFisica
            // 
            this.txtNotaFisica.Location = new System.Drawing.Point(160, 39);
            this.txtNotaFisica.Name = "txtNotaFisica";
            this.txtNotaFisica.Size = new System.Drawing.Size(100, 22);
            this.txtNotaFisica.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 75);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(245, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Propina y Obsequio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblPropinaTotal
            // 
            this.lblPropinaTotal.AutoSize = true;
            this.lblPropinaTotal.Location = new System.Drawing.Point(12, 116);
            this.lblPropinaTotal.Name = "lblPropinaTotal";
            this.lblPropinaTotal.Size = new System.Drawing.Size(122, 17);
            this.lblPropinaTotal.TabIndex = 5;
            this.lblPropinaTotal.Text = "Total de la Propina:";

            // 
            // lblObsequio
            // 
            this.lblObsequio.AutoSize = true;
            this.lblObsequio.Location = new System.Drawing.Point(12, 146);
            this.lblObsequio.Name = "lblObsequio";
            this.lblObsequio.Size = new System.Drawing.Size(73, 17);
            this.lblObsequio.TabIndex = 6;
            this.lblObsequio.Text = "Obsequio: ";

            // 
            // frm23
            // 
            this.ClientSize = new System.Drawing.Size(294, 206);
            this.Controls.Add(this.lblObsequio);
            this.Controls.Add(this.lblPropinaTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNotaFisica);
            this.Controls.Add(this.txtNotaMatematicas);
            this.Controls.Add(this.lblNotaFisica);
            this.Controls.Add(this.lblNotaMatematicas);
            this.Name = "frm23";
            this.Text = "Propina por Notas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
