namespace EvaluacionCurso
{
    partial class frm10
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Label lblNota5;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota5;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblNotasEliminadas;
        private System.Windows.Forms.Label lblPromedio;

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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.lblNota5 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota5 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblNotasEliminadas = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(12, 9);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(50, 17);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Nota 1:";

            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(12, 40);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(50, 17);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Nota 2:";

            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(12, 71);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(50, 17);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Nota 3:";

            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(12, 102);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(50, 17);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Nota 4:";

            // 
            // lblNota5
            // 
            this.lblNota5.AutoSize = true;
            this.lblNota5.Location = new System.Drawing.Point(12, 133);
            this.lblNota5.Name = "lblNota5";
            this.lblNota5.Size = new System.Drawing.Size(50, 17);
            this.lblNota5.TabIndex = 4;
            this.lblNota5.Text = "Nota 5:";

            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(68, 6);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 5;

            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(68, 37);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 6;

            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(68, 68);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 7;

            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(68, 99);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 22);
            this.txtNota4.TabIndex = 8;

            // 
            // txtNota5
            // 
            this.txtNota5.Location = new System.Drawing.Point(68, 130);
            this.txtNota5.Name = "txtNota5";
            this.txtNota5.Size = new System.Drawing.Size(100, 22);
            this.txtNota5.TabIndex = 9;

            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 160);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(153, 40);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Promedio";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);

            // 
            // lblNotasEliminadas
            // 
            this.lblNotasEliminadas.AutoSize = true;
            this.lblNotasEliminadas.Location = new System.Drawing.Point(12, 200);
            this.lblNotasEliminadas.Name = "lblNotasEliminadas";
            this.lblNotasEliminadas.Size = new System.Drawing.Size(122, 17);
            this.lblNotasEliminadas.TabIndex = 11;
            this.lblNotasEliminadas.Text = "Notas Eliminadas:";

            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(12, 230);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(119, 17);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio Aprobado:";

            // 
            // frm10
            // 
            this.ClientSize = new System.Drawing.Size(200, 260);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblNotasEliminadas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNota5);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota5);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "frm10";
            this.Text = "Evaluación del Curso";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
