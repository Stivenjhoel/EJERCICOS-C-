namespace ConversionApp
{
    partial class frm09
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtNumero;
        private Button btnCalcular;
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
            btnCalcular = new Button();
            lblNumero = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(43, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(162, 55);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 30);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
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
            lblResultado.Size = new Size(113, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Suma de las cifras: 0";
            // 
            // frm09
            // 
            ClientSize = new Size(284, 161);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Name = "frm09";
            Text = "Suma de Cifras";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
