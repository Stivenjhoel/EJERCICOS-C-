namespace ConversorHora
{
    partial class frm28
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.Button btnConvertir;
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
            this.lblHora = new System.Windows.Forms.Label();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 20);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(102, 17);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Ingrese la Hora:";

            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(120, 17);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(50, 22);
            this.txtHora.TabIndex = 1;

            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(12, 60);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(124, 17);
            this.lblMinutos.TabIndex = 2;
            this.lblMinutos.Text = "Ingrese los Minutos:";

            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(140, 57);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(50, 22);
            this.txtMinutos.TabIndex = 3;

            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(15, 100);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(175, 30);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir a 12 horas";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 150);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(76, 17);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm28
            // 
            this.ClientSize = new System.Drawing.Size(250, 200);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.lblHora);
            this.Name = "frm28";
            this.Text = "Conversor de Horas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
