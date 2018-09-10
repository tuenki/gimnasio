namespace xtremgym
{
    partial class frmMantenimientoDB
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearReslpado = new System.Windows.Forms.Button();
            this.btnSubirRespaldo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento";
            // 
            // btnCrearReslpado
            // 
            this.btnCrearReslpado.Location = new System.Drawing.Point(62, 208);
            this.btnCrearReslpado.Name = "btnCrearReslpado";
            this.btnCrearReslpado.Size = new System.Drawing.Size(123, 64);
            this.btnCrearReslpado.TabIndex = 1;
            this.btnCrearReslpado.Text = "Crear respaldo";
            this.btnCrearReslpado.UseVisualStyleBackColor = true;
            this.btnCrearReslpado.Click += new System.EventHandler(this.btnCrearReslpado_Click);
            // 
            // btnSubirRespaldo
            // 
            this.btnSubirRespaldo.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSubirRespaldo.ForeColor = System.Drawing.Color.White;
            this.btnSubirRespaldo.Location = new System.Drawing.Point(359, 208);
            this.btnSubirRespaldo.Name = "btnSubirRespaldo";
            this.btnSubirRespaldo.Size = new System.Drawing.Size(123, 64);
            this.btnSubirRespaldo.TabIndex = 2;
            this.btnSubirRespaldo.Text = "Subir respaldo";
            this.btnSubirRespaldo.UseVisualStyleBackColor = false;
            this.btnSubirRespaldo.Click += new System.EventHandler(this.btnSubirRespaldo_Click);
            // 
            // frmMantenimientoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 425);
            this.Controls.Add(this.btnSubirRespaldo);
            this.Controls.Add(this.btnCrearReslpado);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantenimientoDB";
            this.Text = "frmMantenimientoDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearReslpado;
        private System.Windows.Forms.Button btnSubirRespaldo;
    }
}