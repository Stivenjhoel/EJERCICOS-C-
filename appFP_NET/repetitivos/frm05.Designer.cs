namespace TablaDeMultiplicar
{
    partial class frm05
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            btnGenerarTabla = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(30, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(120, 30);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnGenerarTabla
            // 
            btnGenerarTabla.Location = new Point(30, 70);
            btnGenerarTabla.Name = "btnGenerarTabla";
            btnGenerarTabla.Size = new Size(190, 30);
            btnGenerarTabla.TabIndex = 2;
            btnGenerarTabla.Text = "Generar Tabla";
            btnGenerarTabla.Click += btnGenerarTabla_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 110);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado:";
            // 
            // frm05
            // 
            ClientSize = new Size(260, 139);
            Controls.Add(lblNumero);
            Controls.Add(txtNumero);
            Controls.Add(btnGenerarTabla);
            Controls.Add(lblResultado);
            Name = "frm05";
            Text = "Tabla de Multiplicar";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnGenerarTabla;
        private System.Windows.Forms.Label lblResultado;
    }
}
