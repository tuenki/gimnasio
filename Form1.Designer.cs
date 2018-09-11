namespace xtremgym
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lavelDate = new System.Windows.Forms.Label();
            this.lavelTime = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnMembresia = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.iconMinimizar = new System.Windows.Forms.PictureBox();
            this.iconMaximizar = new System.Windows.Forms.PictureBox();
            this.iconRestaurar = new System.Windows.Forms.PictureBox();
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.HoraFEcha = new System.Windows.Forms.Timer(this.components);
            this.menuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            this.SuspendLayout();
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.menuVertical.Controls.Add(this.btnInicio);
            this.menuVertical.Controls.Add(this.button1);
            this.menuVertical.Controls.Add(this.lavelDate);
            this.menuVertical.Controls.Add(this.lavelTime);
            this.menuVertical.Controls.Add(this.btnReporte);
            this.menuVertical.Controls.Add(this.btnUsuario);
            this.menuVertical.Controls.Add(this.btnMembresia);
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Controls.Add(this.pictureBox1);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 0);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(250, 600);
            this.menuVertical.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(9, 188);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(235, 40);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Mantenimiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lavelDate
            // 
            this.lavelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lavelDate.AutoSize = true;
            this.lavelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavelDate.Location = new System.Drawing.Point(42, 555);
            this.lavelDate.Name = "lavelDate";
            this.lavelDate.Size = new System.Drawing.Size(51, 20);
            this.lavelDate.TabIndex = 6;
            this.lavelDate.Text = "label2";
            // 
            // lavelTime
            // 
            this.lavelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lavelTime.AutoSize = true;
            this.lavelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavelTime.Location = new System.Drawing.Point(41, 513);
            this.lavelTime.Name = "lavelTime";
            this.lavelTime.Size = new System.Drawing.Size(79, 29);
            this.lavelTime.TabIndex = 5;
            this.lavelTime.Text = "label1";
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporte.Location = new System.Drawing.Point(0, 328);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(235, 40);
            this.btnReporte.TabIndex = 4;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(2, 374);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(235, 40);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnMembresia
            // 
            this.btnMembresia.FlatAppearance.BorderSize = 0;
            this.btnMembresia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.btnMembresia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembresia.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembresia.ForeColor = System.Drawing.Color.White;
            this.btnMembresia.Image = ((System.Drawing.Image)(resources.GetObject("btnMembresia.Image")));
            this.btnMembresia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembresia.Location = new System.Drawing.Point(0, 280);
            this.btnMembresia.Name = "btnMembresia";
            this.btnMembresia.Size = new System.Drawing.Size(235, 40);
            this.btnMembresia.TabIndex = 2;
            this.btnMembresia.Text = "Membresias";
            this.btnMembresia.UseVisualStyleBackColor = true;
            this.btnMembresia.Click += new System.EventHandler(this.btnMembresia_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(10)))), ((int)(((byte)(43)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 234);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(235, 40);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, -66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.barraTitulo.Controls.Add(this.iconMinimizar);
            this.barraTitulo.Controls.Add(this.iconMaximizar);
            this.barraTitulo.Controls.Add(this.iconRestaurar);
            this.barraTitulo.Controls.Add(this.iconClose);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(250, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(650, 29);
            this.barraTitulo.TabIndex = 1;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // iconMinimizar
            // 
            this.iconMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.iconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMinimizar.Image")));
            this.iconMinimizar.Location = new System.Drawing.Point(570, 3);
            this.iconMinimizar.Name = "iconMinimizar";
            this.iconMinimizar.Size = new System.Drawing.Size(20, 20);
            this.iconMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMinimizar.TabIndex = 3;
            this.iconMinimizar.TabStop = false;
            this.iconMinimizar.Click += new System.EventHandler(this.iconMinimizar_Click);
            // 
            // iconMaximizar
            // 
            this.iconMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.iconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("iconMaximizar.Image")));
            this.iconMaximizar.Location = new System.Drawing.Point(596, 3);
            this.iconMaximizar.Name = "iconMaximizar";
            this.iconMaximizar.Size = new System.Drawing.Size(20, 20);
            this.iconMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconMaximizar.TabIndex = 2;
            this.iconMaximizar.TabStop = false;
            this.iconMaximizar.Click += new System.EventHandler(this.iconMaximizar_Click);
            // 
            // iconRestaurar
            // 
            this.iconRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconRestaurar.BackColor = System.Drawing.Color.SteelBlue;
            this.iconRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("iconRestaurar.Image")));
            this.iconRestaurar.Location = new System.Drawing.Point(596, 3);
            this.iconRestaurar.Name = "iconRestaurar";
            this.iconRestaurar.Size = new System.Drawing.Size(20, 20);
            this.iconRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRestaurar.TabIndex = 1;
            this.iconRestaurar.TabStop = false;
            this.iconRestaurar.Visible = false;
            this.iconRestaurar.Click += new System.EventHandler(this.iconRestaurar_Click);
            // 
            // iconClose
            // 
            this.iconClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(622, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(20, 20);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconClose.TabIndex = 0;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.iconClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(650, 600);
            this.panelContainer.TabIndex = 3;
            // 
            // HoraFEcha
            // 
            this.HoraFEcha.Enabled = true;
            this.HoraFEcha.Tick += new System.EventHandler(this.HoraFEcha_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.ControlBox = false;
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuVertical.ResumeLayout(false);
            this.menuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnMembresia;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox iconMinimizar;
        private System.Windows.Forms.PictureBox iconMaximizar;
        private System.Windows.Forms.PictureBox iconRestaurar;
        private System.Windows.Forms.PictureBox iconClose;
        private System.Windows.Forms.Label lavelDate;
        private System.Windows.Forms.Label lavelTime;
        private System.Windows.Forms.Timer HoraFEcha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInicio;
    }
}

