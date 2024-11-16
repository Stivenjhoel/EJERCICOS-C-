namespace DiaDeLaSemana
{
    partial class frm12
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumeroDia;
        private System.Windows.Forms.TextBox txtNumeroDia;
        private System.Windows.Forms.Button btnDeterminarDia;
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
            this.lblNumeroDia = new System.Windows.Forms.Label();
            this.txtNumeroDia = new System.Windows.Forms.TextBox();
            this.btnDeterminarDia = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumeroDia
            // 
            this.lblNumeroDia.AutoSize = true;
            this.lblNumeroDia.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroDia.Name = "lblNumeroDia";
            this.lblNumeroDia.Size = new System.Drawing.Size(141, 17);
            this.lblNumeroDia.TabIndex = 0;
            this.lblNumeroDia.Text = "Número del día (1-7):";

            // 
            // txtNumeroDia
            // 
            this.txtNumeroDia.Location = new System.Drawing.Point(159, 6);
            this.txtNumeroDia.Name = "txtNumeroDia";
            this.txtNumeroDia.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroDia.TabIndex = 1;

            // 
            // btnDeterminarDia
            // 
            this.btnDeterminarDia.Location = new System.Drawing.Point(15, 34);
            this.btnDeterminarDia.Name = "btnDeterminarDia";
            this.btnDeterminarDia.Size = new System.Drawing.Size(244, 35);
            this.btnDeterminarDia.TabIndex = 2;
            this.btnDeterminarDia.Text = "Determinar Día de la Semana";
            this.btnDeterminarDia.UseVisualStyleBackColor = true;
            this.btnDeterminarDia.Click += new System.EventHandler(this.btnDeterminarDia_Click);

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
            // frm12
            // 
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDeterminarDia);
            this.Controls.Add(this.txtNumeroDia);
            this.Controls.Add(this.lblNumeroDia);
            this.Name = "frm12";
            this.Text = "Determinar Día de la Semana";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
