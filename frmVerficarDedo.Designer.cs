namespace xtremgym
{
    partial class frmVerficarDedo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelVerificador = new System.Windows.Forms.Label();
            this.labelEstatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verficar dedo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(92, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelVerificador
            // 
            this.labelVerificador.AutoSize = true;
            this.labelVerificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerificador.Location = new System.Drawing.Point(113, 233);
            this.labelVerificador.Name = "labelVerificador";
            this.labelVerificador.Size = new System.Drawing.Size(85, 24);
            this.labelVerificador.TabIndex = 2;
            this.labelVerificador.Text = "Espera...";
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(114, 203);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(35, 13);
            this.labelEstatus.TabIndex = 3;
            this.labelEstatus.Text = "label3";
            // 
            // frmVerficarDedo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 287);
            this.Controls.Add(this.labelEstatus);
            this.Controls.Add(this.labelVerificador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVerficarDedo";
            this.Text = "frmVerficarDedo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmVerficarDedo_FormClosed);
            this.Load += new System.EventHandler(this.frmVerficarDedo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelVerificador;
        private System.Windows.Forms.Label labelEstatus;
    }
}