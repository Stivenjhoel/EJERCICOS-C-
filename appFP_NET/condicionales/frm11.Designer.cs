namespace DeterminarSigno
{
    partial class frm11
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnDeterminarSigno;
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
            this.btnDeterminarSigno = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(12, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(60, 17);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";

            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(78, 6);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;

            // 
            // btnDeterminarSigno
            // 
            this.btnDeterminarSigno.Location = new System.Drawing.Point(15, 34);
            this.btnDeterminarSigno.Name = "btnDeterminarSigno";
            this.btnDeterminarSigno.Size = new System.Drawing.Size(163, 35);
            this.btnDeterminarSigno.TabIndex = 2;
            this.btnDeterminarSigno.Text = "Determinar Signo";
            this.btnDeterminarSigno.UseVisualStyleBackColor = true;
            this.btnDeterminarSigno.Click += new System.EventHandler(this.btnDeterminarSigno_Click);

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
            // frm11
            // 
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnDeterminarSigno);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "frm11";
            this.Text = "Determinar Signo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
