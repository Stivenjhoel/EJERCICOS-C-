namespace InstitucionBenefica
{
    partial class frm18
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblMontoDonacion;
        private System.Windows.Forms.TextBox txtMontoDonacion;
        private System.Windows.Forms.Button btnRepartirDonacion;
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
            this.lblMontoDonacion = new System.Windows.Forms.Label();
            this.txtMontoDonacion = new System.Windows.Forms.TextBox();
            this.btnRepartirDonacion = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblMontoDonacion
            // 
            this.lblMontoDonacion.AutoSize = true;
            this.lblMontoDonacion.Location = new System.Drawing.Point(12, 9);
            this.lblMontoDonacion.Name = "lblMontoDonacion";
            this.lblMontoDonacion.Size = new System.Drawing.Size(129, 17);
            this.lblMontoDonacion.TabIndex = 0;
            this.lblMontoDonacion.Text = "Monto de la Donación:";

            // 
            // txtMontoDonacion
            // 
            this.txtMontoDonacion.Location = new System.Drawing.Point(147, 6);
            this.txtMontoDonacion.Name = "txtMontoDonacion";
            this.txtMontoDonacion.Size = new System.Drawing.Size(100, 22);
            this.txtMontoDonacion.TabIndex = 1;

            // 
            // btnRepartirDonacion
            // 
            this.btnRepartirDonacion.Location = new System.Drawing.Point(15, 34);
            this.btnRepartirDonacion.Name = "btnRepartirDonacion";
            this.btnRepartirDonacion.Size = new System.Drawing.Size(232, 30);
            this.btnRepartirDonacion.TabIndex = 2;
            this.btnRepartirDonacion.Text = "Repartir Donación";
            this.btnRepartirDonacion.UseVisualStyleBackColor = true;
            this.btnRepartirDonacion.Click += new System.EventHandler(this.btnRepartirDonacion_Click);

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
            // frm18
            // 
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnRepartirDonacion);
            this.Controls.Add(this.txtMontoDonacion);
            this.Controls.Add(this.lblMontoDonacion);
            this.Name = "frm18";
            this.Text = "Reparto de Donación";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
