namespace InvertirCadenaRecursiva
{
    partial class frm06
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.btnInvertir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(12, 12);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(260, 20);
            this.txtCadena.TabIndex = 0;
            // 
            // btnInvertir
            // 
            this.btnInvertir.Location = new System.Drawing.Point(12, 38);
            this.btnInvertir.Name = "btnInvertir";
            this.btnInvertir.Size = new System.Drawing.Size(100, 23);
            this.btnInvertir.TabIndex = 1;
            this.btnInvertir.Text = "Invertir Cadena";
            this.btnInvertir.UseVisualStyleBackColor = true;
            this.btnInvertir.Click += new System.EventHandler(this.btnInvertir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 74);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado: ";
            // 
            // frm06
            // 
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnInvertir);
            this.Controls.Add(this.txtCadena);
            this.Name = "frm06";
            this.Text = "Invertir Cadena Recursiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Button btnInvertir;
        private System.Windows.Forms.Label lblResultado;
    }
}
