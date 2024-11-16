namespace RectanguloDeAsteriscos
{
    partial class frm09
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
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnGenerarRectangulo = new System.Windows.Forms.Button();
            this.txtRectangulo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // lblAltura
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(30, 30);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(44, 15);
            this.lblAltura.Text = "Altura:";

            // txtAltura
            this.txtAltura.Location = new System.Drawing.Point(80, 30);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 23);

            // btnGenerarRectangulo
            this.btnGenerarRectangulo.Location = new System.Drawing.Point(30, 70);
            this.btnGenerarRectangulo.Name = "btnGenerarRectangulo";
            this.btnGenerarRectangulo.Size = new System.Drawing.Size(150, 30);
            this.btnGenerarRectangulo.Text = "Generar Rectángulo";
            this.btnGenerarRectangulo.Click += new System.EventHandler(this.btnGenerarRectangulo_Click);

            // txtRectangulo
            this.txtRectangulo.Location = new System.Drawing.Point(30, 110);
            this.txtRectangulo.Multiline = true;
            this.txtRectangulo.Name = "txtRectangulo";
            this.txtRectangulo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRectangulo.Size = new System.Drawing.Size(200, 150);

            this.ClientSize = new System.Drawing.Size(260, 280);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnGenerarRectangulo);
            this.Controls.Add(this.txtRectangulo);
            this.Name = "frm09";
            this.Text = "Generador de Rectángulo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnGenerarRectangulo;
        private System.Windows.Forms.TextBox txtRectangulo;
    }
}
