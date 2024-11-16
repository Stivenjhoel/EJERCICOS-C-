namespace SubcadenaSubsecuencia
{
    partial class frm10
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
            this.txtSubcadena = new System.Windows.Forms.TextBox();
            this.btnContar = new System.Windows.Forms.Button();
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
            // txtSubcadena
            // 
            this.txtSubcadena.Location = new System.Drawing.Point(12, 38);
            this.txtSubcadena.Name = "txtSubcadena";
            this.txtSubcadena.Size = new System.Drawing.Size(260, 20);
            this.txtSubcadena.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(12, 64);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(100, 23);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar Subsecuencias";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(12, 94);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado: ";
            // 
            // frm10
            // 
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.txtSubcadena);
            this.Controls.Add(this.txtCadena);
            this.Name = "frm10";
            this.Text = "Contar Subsecuencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtSubcadena;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Label lblResultado;
    }
}
