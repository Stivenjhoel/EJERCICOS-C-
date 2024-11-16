namespace ConversionApp
{
    partial class frm04
    {
        private System.ComponentModel.IContainer components = null;

        // Controles de la interfaz
        private TextBox txtPies;
        private TextBox txtPulgadas;
        private Button btnConvertir;
        private Label lblResultado;
        private Label lblPies;
        private Label lblPulgadas;

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
        /// Inicializar los componentes del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            txtPies = new TextBox();
            txtPulgadas = new TextBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            lblPies = new Label();
            lblPulgadas = new Label();
            SuspendLayout();
            // 
            // txtPies
            // 
            txtPies.Location = new Point(196, 30);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 0;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(196, 61);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(100, 23);
            txtPulgadas.TabIndex = 1;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(196, 90);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(100, 30);
            btnConvertir.TabIndex = 2;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(177, 138);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(146, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Estatura en metros: 0.00 m";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(30, 30);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(125, 15);
            lblPies.TabIndex = 4;
            lblPies.Text = "Ingrese estatura (pies):";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(30, 60);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(152, 15);
            lblPulgadas.TabIndex = 5;
            lblPulgadas.Text = "Ingrese estatura (pulgadas):";
            // 
            // frm04
            // 
            ClientSize = new Size(357, 181);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(txtPulgadas);
            Controls.Add(txtPies);
            Name = "frm04";
            Text = "Conversor de Estatura";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
