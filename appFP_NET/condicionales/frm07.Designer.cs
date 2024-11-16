namespace NumeroIntermedio
{
    partial class frm07
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblNumero2;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblNumero3;
        private System.Windows.Forms.TextBox txtNumero3;
        private System.Windows.Forms.Button btnCalcular;
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
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero3 = new System.Windows.Forms.Label();
            this.txtNumero3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(13, 13);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(68, 17);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Número 1:";

            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(87, 10);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 22);
            this.txtNumero1.TabIndex = 1;

            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(13, 45);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(68, 17);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Número 2:";

            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(87, 42);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 22);
            this.txtNumero2.TabIndex = 3;

            // 
            // lblNumero3
            // 
            this.lblNumero3.AutoSize = true;
            this.lblNumero3.Location = new System.Drawing.Point(13, 77);
            this.lblNumero3.Name = "lblNumero3";
            this.lblNumero3.Size = new System.Drawing.Size(68, 17);
            this.lblNumero3.TabIndex = 4;
            this.lblNumero3.Text = "Número 3:";

            // 
            // txtNumero3
            // 
            this.txtNumero3.Location = new System.Drawing.Point(87, 74);
            this.txtNumero3.Name = "txtNumero3";
            this.txtNumero3.Size = new System.Drawing.Size(100, 22);
            this.txtNumero3.TabIndex = 5;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(171, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Número Intermedio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(13, 155);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(133, 17);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Número intermedio: --";

            // 
            // frm07
            // 
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero3);
            this.Controls.Add(this.lblNumero3);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero1);
            this.Name = "frm07";
            this.Text = "Número Intermedio";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
