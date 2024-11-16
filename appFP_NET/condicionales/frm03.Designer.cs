namespace ClasificacionAngulos
{
    partial class frm03
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAngulo;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.Button btnClasificar;
        private System.Windows.Forms.Label lblClasificacion;

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
            this.lblAngulo = new System.Windows.Forms.Label();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.btnClasificar = new System.Windows.Forms.Button();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblAngulo
            // 
            this.lblAngulo.AutoSize = true;
            this.lblAngulo.Location = new System.Drawing.Point(13, 13);
            this.lblAngulo.Name = "lblAngulo";
            this.lblAngulo.Size = new System.Drawing.Size(133, 17);
            this.lblAngulo.TabIndex = 0;
            this.lblAngulo.Text = "Introduce el ángulo (°):";

            // 
            // txtAngulo
            // 
            this.txtAngulo.Location = new System.Drawing.Point(152, 10);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(100, 22);
            this.txtAngulo.TabIndex = 1;

            // 
            // btnClasificar
            // 
            this.btnClasificar.Location = new System.Drawing.Point(16, 50);
            this.btnClasificar.Name = "btnClasificar";
            this.btnClasificar.Size = new System.Drawing.Size(236, 40);
            this.btnClasificar.TabIndex = 2;
            this.btnClasificar.Text = "Clasificar Ángulo";
            this.btnClasificar.UseVisualStyleBackColor = true;
            this.btnClasificar.Click += new System.EventHandler(this.btnClasificar_Click);

            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Location = new System.Drawing.Point(13, 100);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(96, 17);
            this.lblClasificacion.TabIndex = 3;
            this.lblClasificacion.Text = "Clasificación:";

            // 
            // frm03
            // 
            this.ClientSize = new System.Drawing.Size(284, 130);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.btnClasificar);
            this.Controls.Add(this.txtAngulo);
            this.Controls.Add(this.lblAngulo);
            this.Name = "frm03";
            this.Text = "Clasificación de Ángulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
