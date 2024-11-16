namespace RegistroEmpleado
{
    partial class frm21
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNumeroEmpleado;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Button btnMostrarInformacion;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;

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
            this.lblNumeroEmpleado = new System.Windows.Forms.Label();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.btnMostrarInformacion = new System.Windows.Forms.Button();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNumeroEmpleado
            // 
            this.lblNumeroEmpleado.AutoSize = true;
            this.lblNumeroEmpleado.Location = new System.Drawing.Point(12, 9);
            this.lblNumeroEmpleado.Name = "lblNumeroEmpleado";
            this.lblNumeroEmpleado.Size = new System.Drawing.Size(160, 17);
            this.lblNumeroEmpleado.TabIndex = 0;
            this.lblNumeroEmpleado.Text = "Ingrese el número empleado:";

            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(178, 6);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(100, 22);
            this.txtNumeroEmpleado.TabIndex = 1;

            // 
            // btnMostrarInformacion
            // 
            this.btnMostrarInformacion.Location = new System.Drawing.Point(15, 34);
            this.btnMostrarInformacion.Name = "btnMostrarInformacion";
            this.btnMostrarInformacion.Size = new System.Drawing.Size(263, 30);
            this.btnMostrarInformacion.TabIndex = 2;
            this.btnMostrarInformacion.Text = "Mostrar Información del Empleado";
            this.btnMostrarInformacion.UseVisualStyleBackColor = true;
            this.btnMostrarInformacion.Click += new System.EventHandler(this.btnMostrarInformacion_Click);

            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(12, 72);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(96, 17);
            this.lblEstadoCivil.TabIndex = 3;
            this.lblEstadoCivil.Text = "Estado Civil: ";

            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 102);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(49, 17);
            this.lblEdad.TabIndex = 4;
            this.lblEdad.Text = "Edad: ";

            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 132);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(47, 17);
            this.lblSexo.TabIndex = 5;
            this.lblSexo.Text = "Sexo: ";

            // 
            // frm21
            // 
            this.ClientSize = new System.Drawing.Size(294, 158);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblEstadoCivil);
            this.Controls.Add(this.btnMostrarInformacion);
            this.Controls.Add(this.txtNumeroEmpleado);
            this.Controls.Add(this.lblNumeroEmpleado);
            this.Name = "frm21";
            this.Text = "Registro Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
