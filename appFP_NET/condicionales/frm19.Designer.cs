namespace OficinaEmpleos
{
    partial class frm19
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Button btnDeterminarCategoria;
        private System.Windows.Forms.Label lblCategoria;

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
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.btnDeterminarCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 9);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 17);
            this.lblSexo.TabIndex = 0;
            this.lblSexo.Text = "Sexo:";

            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(58, 6);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 24);
            this.cmbSexo.TabIndex = 1;

            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 44);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(42, 17);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";

            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(58, 41);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 22);
            this.txtEdad.TabIndex = 3;

            // 
            // btnDeterminarCategoria
            // 
            this.btnDeterminarCategoria.Location = new System.Drawing.Point(15, 69);
            this.btnDeterminarCategoria.Name = "btnDeterminarCategoria";
            this.btnDeterminarCategoria.Size = new System.Drawing.Size(164, 30);
            this.btnDeterminarCategoria.TabIndex = 4;
            this.btnDeterminarCategoria.Text = "Determinar Categoría";
            this.btnDeterminarCategoria.UseVisualStyleBackColor = true;
            this.btnDeterminarCategoria.Click += new System.EventHandler(this.btnDeterminarCategoria_Click);

            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 110);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 17);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";

            // 
            // frm19
            // 
            this.ClientSize = new System.Drawing.Size(202, 139);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnDeterminarCategoria);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Name = "frm19";
            this.Text = "Categoría de Postulante";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
