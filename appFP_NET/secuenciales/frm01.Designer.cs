using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace appFP_NET.secuenciales
{
    partial class _01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblVarones = new Label();
            lblPvarones = new Label();
            lblPmujeres = new Label();
            lblMujeres = new Label();
            buttonCalcular = new Button();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            SuspendLayout();
            // 
            // lblVarones
            // 
            lblVarones.AutoSize = true;
            lblVarones.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            lblVarones.Location = new Point(50, 50);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(60, 15);
            lblVarones.TabIndex = 0;
            lblVarones.Text = "Varones:";
            // 
            // lblPvarones
            // 
            lblPvarones.AutoSize = true;
            lblPvarones.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            lblPvarones.Location = new Point(209, 50);
            lblPvarones.Name = "lblPvarones";
            lblPvarones.Size = new Size(18, 15);
            lblPvarones.TabIndex = 0;
            lblPvarones.Text = "%";
            // 
            // lblPmujeres
            // 
            lblPmujeres.AutoSize = true;
            lblPmujeres.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            lblPmujeres.Location = new Point(209, 98);
            lblPmujeres.Name = "lblPmujeres";
            lblPmujeres.Size = new Size(18, 15);
            lblPmujeres.TabIndex = 0;
            lblPmujeres.Text = "%";
            // 
            // lblMujeres
            // 
            lblMujeres.AutoSize = true;
            lblMujeres.Font = new System.Drawing.Font("Segoe UI Black", 9F);
            lblMujeres.Location = new Point(50, 98);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(60, 15);
            lblMujeres.TabIndex = 6;
            lblMujeres.Text = "Mujeres:";
            // 
            // buttonCalcular
            // 
            buttonCalcular.Location = new Point(113, 148);
            buttonCalcular.Name = "buttonCalcular";
            buttonCalcular.Size = new Size(75, 23);
            buttonCalcular.TabIndex = 3;
            buttonCalcular.Text = "C&alcular";
            buttonCalcular.UseVisualStyleBackColor = true;
            buttonCalcular.Click += button1_Click;
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(113, 47);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(90, 23);
            txtVarones.TabIndex = 1;
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(113, 95);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(90, 23);
            txtMujeres.TabIndex = 2;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 211);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(buttonCalcular);
            Controls.Add(lblPmujeres);
            Controls.Add(lblMujeres);
            Controls.Add(lblPvarones);
            Controls.Add(lblVarones);
            Name = "_01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "_01";
            Load += _01_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private new void Font(string v1, float v2)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblVarones;
        private Label lblPvarones;
        private Label lblPmujeres;
        private Label lblMujeres;
        private Button buttonCalcular;
        private TextBox txtVarones;
        private TextBox txtMujeres;
    }
}