namespace EdadMayorMenor
{
    partial class frm06
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblEdad1;
        private System.Windows.Forms.TextBox txtEdad1;
        private System.Windows.Forms.Label lblEdad2;
        private System.Windows.Forms.TextBox txtEdad2;
        private System.Windows.Forms.Label lblEdad3;
        private System.Windows.Forms.TextBox txtEdad3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblEdadMayor;
        private System.Windows.Forms.Label lblEdadMenor;

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
            this.lblEdad1 = new System.Windows.Forms.Label();
            this.txtEdad1 = new System.Windows.Forms.TextBox();
            this.lblEdad2 = new System.Windows.Forms.Label();
            this.txtEdad2 = new System.Windows.Forms.TextBox();
            this.lblEdad3 = new System.Windows.Forms.Label();
            this.txtEdad3 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblEdadMayor = new System.Windows.Forms.Label();
            this.lblEdadMenor = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblEdad1
            // 
            this.lblEdad1.AutoSize = true;
            this.lblEdad1.Location = new System.Drawing.Point(13, 13);
            this.lblEdad1.Name = "lblEdad1";
            this.lblEdad1.Size = new System.Drawing.Size(54, 17);
            this.lblEdad1.TabIndex = 0;
            this.lblEdad1.Text = "Edad 1:";

            // 
            // txtEdad1
            // 
            this.txtEdad1.Location = new System.Drawing.Point(75, 10);
            this.txtEdad1.Name = "txtEdad1";
            this.txtEdad1.Size = new System.Drawing.Size(100, 22);
            this.txtEdad1.TabIndex = 1;

            // 
            // lblEdad2
            // 
            this.lblEdad2.AutoSize = true;
            this.lblEdad2.Location = new System.Drawing.Point(13, 45);
            this.lblEdad2.Name = "lblEdad2";
            this.lblEdad2.Size = new System.Drawing.Size(54, 17);
            this.lblEdad2.TabIndex = 2;
            this.lblEdad2.Text = "Edad 2:";

            // 
            // txtEdad2
            // 
            this.txtEdad2.Location = new System.Drawing.Point(75, 42);
            this.txtEdad2.Name = "txtEdad2";
            this.txtEdad2.Size = new System.Drawing.Size(100, 22);
            this.txtEdad2.TabIndex = 3;

            // 
            // lblEdad3
            // 
            this.lblEdad3.AutoSize = true;
            this.lblEdad3.Location = new System.Drawing.Point(13, 77);
            this.lblEdad3.Name = "lblEdad3";
            this.lblEdad3.Size = new System.Drawing.Size(54, 17);
            this.lblEdad3.TabIndex = 4;
            this.lblEdad3.Text = "Edad 3:";

            // 
            // txtEdad3
            // 
            this.txtEdad3.Location = new System.Drawing.Point(75, 74);
            this.txtEdad3.Name = "txtEdad3";
            this.txtEdad3.Size = new System.Drawing.Size(100, 22);
            this.txtEdad3.TabIndex = 5;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(16, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(159, 40);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular Edad Mayor y Menor";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblEdadMayor
            // 
            this.lblEdadMayor.AutoSize = true;
            this.lblEdadMayor.Location = new System.Drawing.Point(13, 155);
            this.lblEdadMayor.Name = "lblEdadMayor";
            this.lblEdadMayor.Size = new System.Drawing.Size(103, 17);
            this.lblEdadMayor.TabIndex = 7;
            this.lblEdadMayor.Text = "Edad Mayor: --";

            // 
            // lblEdadMenor
            // 
            this.lblEdadMenor.AutoSize = true;
            this.lblEdadMenor.Location = new System.Drawing.Point(13, 180);
            this.lblEdadMenor.Name = "lblEdadMenor";
            this.lblEdadMenor.Size = new System.Drawing.Size(103, 17);
            this.lblEdadMenor.TabIndex = 8;
            this.lblEdadMenor.Text = "Edad Menor: --";

            // 
            // frm06
            // 
            this.ClientSize = new System.Drawing.Size(284, 210);
            this.Controls.Add(this.lblEdadMenor);
            this.Controls.Add(this.lblEdadMayor);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtEdad3);
            this.Controls.Add(this.lblEdad3);
            this.Controls.Add(this.txtEdad2);
            this.Controls.Add(this.lblEdad2);
            this.Controls.Add(this.txtEdad1);
            this.Controls.Add(this.lblEdad1);
            this.Name = "frm06";
            this.Text = "Determinar Edad Mayor y Menor";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
