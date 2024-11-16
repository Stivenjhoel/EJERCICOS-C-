namespace ConversionApp
{
    partial class frm11
    {
        private System.ComponentModel.IContainer components = null;

        // Declaración de controles
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnIntercambiar;
        private Label lblNumero1;
        private Label lblNumero2;
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
            this.txtNumero1 = new TextBox();
            this.txtNumero2 = new TextBox();
            this.btnIntercambiar = new Button();
            this.lblNumero1 = new Label();
            this.lblNumero2 = new Label();
            this.lblResultado = new Label();
            this.SuspendLayout();

            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(150, 30);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;

            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(150, 60);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;

            // 
            // btnIntercambiar
            // 
            this.btnIntercambiar.Location = new System.Drawing.Point(150, 90);
            this.btnIntercambiar.Name = "btnIntercambiar";
            this.btnIntercambiar.Size = new System.Drawing.Size(100, 30);
            this.btnIntercambiar.TabIndex = 2;
            this.btnIntercambiar.Text = "Intercambiar";
            this.btnIntercambiar.UseVisualStyleBackColor = true;
            this.btnIntercambiar.Click += new EventHandler(this.btnIntercambiar_Click);

            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(30, 30);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(91, 13);
            this.lblNumero1.TabIndex = 3;
            this.lblNumero1.Text = "Ingrese número 1:";

            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(30, 60);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(91, 13);
            this.lblNumero2.TabIndex = 4;
            this.lblNumero2.Text = "Ingrese número 2:";

            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(30, 140);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(106, 13);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Nuevos números: -";

            // 
            // frm11
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.btnIntercambiar);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "frm11";
            this.Text = "Intercambiar Cifras";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
