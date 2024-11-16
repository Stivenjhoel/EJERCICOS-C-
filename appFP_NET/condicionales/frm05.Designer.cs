namespace MayorNumero
{
    partial class frm05
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGenerar;
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnGenerar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(13, 13);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(166, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingresa un número de 4 cifras:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(185, 10);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(64, 39);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(221, 40);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar Mayor Número";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(13, 100);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(171, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Mayor número de dos cifras: --";
            // 
            // frm05
            // 
            ClientSize = new Size(338, 130);
            Controls.Add(lblResultado);
            Controls.Add(btnGenerar);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "frm05";
            Text = "Generar Mayor Número";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
