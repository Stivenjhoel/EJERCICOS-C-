namespace ConversionApp
{
    partial class frm10
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtNumero;
        private Button btnInvertir;
        private Label lblNumero;
        private Label lblResultado;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método para inicializar los componentes del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            txtNumero = new TextBox();
            btnInvertir = new Button();
            lblNumero = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(30, 65);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // btnInvertir
            // 
            btnInvertir.Location = new Point(150, 60);
            btnInvertir.Name = "btnInvertir";
            btnInvertir.Size = new Size(100, 30);
            btnInvertir.TabIndex = 1;
            btnInvertir.Text = "Invertir";
            btnInvertir.UseVisualStyleBackColor = true;
            btnInvertir.Click += btnInvertir_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(30, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(158, 15);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Ingrese un número (4 cifras):";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(30, 110);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(112, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Número invertido: -";
            // 
            // frm10
            // 
            ClientSize = new Size(284, 161);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero);
            Controls.Add(btnInvertir);
            Controls.Add(txtNumero);
            Name = "frm10";
            Text = "Invertir Número";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
