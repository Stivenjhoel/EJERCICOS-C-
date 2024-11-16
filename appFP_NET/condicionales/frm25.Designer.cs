namespace BonificacionEmpleados
{
    partial class frm25
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSueldoBruto;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Label lblCantidadHijos;
        private System.Windows.Forms.TextBox txtCantidadHijos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblBonificacion;
        private System.Windows.Forms.Label lblSueldoNeto;

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
            this.lblSueldoBruto = new System.Windows.Forms.Label();
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.lblCantidadHijos = new System.Windows.Forms.Label();
            this.txtCantidadHijos = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblBonificacion = new System.Windows.Forms.Label();
            this.lblSueldoNeto = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblSueldoBruto
            // 
            this.lblSueldoBruto.AutoSize = true;
            this.lblSueldoBruto.Location = new System.Drawing.Point(12, 15);
            this.lblSueldoBruto.Name = "lblSueldoBruto";
            this.lblSueldoBruto.Size = new System.Drawing.Size(98, 17);
            this.lblSueldoBruto.TabIndex = 0;
            this.lblSueldoBruto.Text = "Sueldo Bruto (S/.):";

            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(140, 12);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(100, 22);
            this.txtSueldoBruto.TabIndex = 1;

            // 
            // lblCantidadHijos
            // 
            this.lblCantidadHijos.AutoSize = true;
            this.lblCantidadHijos.Location = new System.Drawing.Point(12, 50);
            this.lblCantidadHijos.Name = "lblCantidadHijos";
            this.lblCantidadHijos.Size = new System.Drawing.Size(117, 17);
            this.lblCantidadHijos.TabIndex = 2;
            this.lblCantidadHijos.Text = "Cantidad de Hijos:";

            // 
            // txtCantidadHijos
            // 
            this.txtCantidadHijos.Location = new System.Drawing.Point(140, 47);
            this.txtCantidadHijos.Name = "txtCantidadHijos";
            this.txtCantidadHijos.Size = new System.Drawing.Size(100, 22);
            this.txtCantidadHijos.TabIndex = 3;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 85);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(225, 30);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular Bonificación y Sueldo";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblBonificacion
            // 
            this.lblBonificacion.AutoSize = true;
            this.lblBonificacion.Location = new System.Drawing.Point(12, 130);
            this.lblBonificacion.Name = "lblBonificacion";
            this.lblBonificacion.Size = new System.Drawing.Size(96, 17);
            this.lblBonificacion.TabIndex = 5;
            this.lblBonificacion.Text = "Bonificación: S/.";

            // 
            // lblSueldoNeto
            // 
            this.lblSueldoNeto.AutoSize = true;
            this.lblSueldoNeto.Location = new System.Drawing.Point(12, 160);
            this.lblSueldoNeto.Name = "lblSueldoNeto";
            this.lblSueldoNeto.Size = new System.Drawing.Size(101, 17);
            this.lblSueldoNeto.TabIndex = 6;
            this.lblSueldoNeto.Text = "Sueldo Neto: S/.";

            // 
            // frm25
            // 
            this.ClientSize = new System.Drawing.Size(266, 200);
            this.Controls.Add(this.lblSueldoNeto);
            this.Controls.Add(this.lblBonificacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCantidadHijos);
            this.Controls.Add(this.lblCantidadHijos);
            this.Controls.Add(this.txtSueldoBruto);
            this.Controls.Add(this.lblSueldoBruto);
            this.Name = "frm25";
            this.Text = "Bonificación por Fiestas Patrias";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
