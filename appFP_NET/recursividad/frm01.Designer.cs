namespace ExponenteRecursivo
{
    partial class frm01
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">Si los recursos administrados deben ser eliminados; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            txtBase = new TextBox();
            txtExponente = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(12, 12);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 0;
            // 
            // txtExponente
            // 
            txtExponente.Location = new Point(12, 38);
            txtExponente.Name = "txtExponente";
            txtExponente.Size = new Size(100, 23);
            txtExponente.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 64);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 94);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado: ";
            // 
            // frm01
            // 
            ClientSize = new Size(229, 121);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtExponente);
            Controls.Add(txtBase);
            Name = "frm01";
            Text = "Potencia Recursiva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}
