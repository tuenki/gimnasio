namespace xtremgym
{
    partial class frmVeriTodasHuellas
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelVerificacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(280, 265);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(13, 13);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "0";
            // 
            // labelVerificacion
            // 
            this.labelVerificacion.AutoSize = true;
            this.labelVerificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerificacion.Location = new System.Drawing.Point(88, 116);
            this.labelVerificacion.Name = "labelVerificacion";
            this.labelVerificacion.Size = new System.Drawing.Size(171, 33);
            this.labelVerificacion.TabIndex = 2;
            this.labelVerificacion.Text = "En espera...";
            // 
            // frmVeriTodasHuellas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 287);
            this.Controls.Add(this.labelVerificacion);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label1);
            this.Name = "frmVeriTodasHuellas";
            this.Text = "frmVeriTodasHuellas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVeriTodasHuellas_FormClosed);
            this.Load += new System.EventHandler(this.frmVeriTodasHuellas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelVerificacion;
    }
}