namespace CifrasConsecutivas
{
    partial class frm13
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVerificar;
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(151, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número de tres cifras:";

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(169, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;

            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(15, 34);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(254, 35);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar si las cifras son consecutivas";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 72);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(78, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado:";

            // 
            // frm13
            // 
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "frm13";
            this.Text = "Cifras Consecutivas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
