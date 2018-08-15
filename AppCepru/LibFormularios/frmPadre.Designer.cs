namespace LibFormularios
{
    partial class frmPadre
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
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnTitulo.SuspendLayout();
            this.pnBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitulo
            // 
            this.pnTitulo.Controls.Add(this.lbTitulo);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(728, 61);
            this.pnTitulo.TabIndex = 0;
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnSalir);
            this.pnBotones.Controls.Add(this.btnGuardar);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBotones.Location = new System.Drawing.Point(0, 61);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(104, 510);
            this.pnBotones.TabIndex = 1;
            // 
            // pnContenido
            // 
            this.pnContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenido.Location = new System.Drawing.Point(104, 61);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(624, 510);
            this.pnContenido.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Location = new System.Drawing.Point(-3, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(731, 58);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "TITULO";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(3, 0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 61);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(3, 446);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 61);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 571);
            this.Controls.Add(this.pnContenido);
            this.Controls.Add(this.pnBotones);
            this.Controls.Add(this.pnTitulo);
            this.Name = "frmPadre";
            this.Text = "frmPadre";
            this.pnTitulo.ResumeLayout(false);
            this.pnBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnTitulo;
        protected System.Windows.Forms.Label lbTitulo;
        protected System.Windows.Forms.Panel pnBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Panel pnContenido;
    }
}