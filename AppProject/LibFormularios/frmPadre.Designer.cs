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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnContenido = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvErrores = new System.Windows.Forms.DataGridView();
            this.pnBotones.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Location = new System.Drawing.Point(2, 1);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(544, 47);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "TITULO";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnBotones
            // 
            this.pnBotones.Controls.Add(this.btnSalir);
            this.pnBotones.Controls.Add(this.btnGuardar);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBotones.Location = new System.Drawing.Point(0, 50);
            this.pnBotones.Margin = new System.Windows.Forms.Padding(2);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(78, 416);
            this.pnBotones.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalir.Location = new System.Drawing.Point(2, 362);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 50);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Location = new System.Drawing.Point(2, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 50);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pnTitulo
            // 
            this.pnTitulo.Controls.Add(this.label1);
            this.pnTitulo.Controls.Add(this.lbTitulo);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1012, 50);
            this.pnTitulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(546, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "ERRORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.button1);
            this.pnContenido.Controls.Add(this.dgvDatos);
            this.pnContenido.Location = new System.Drawing.Point(78, 50);
            this.pnContenido.Margin = new System.Windows.Forms.Padding(2);
            this.pnContenido.Name = "pnContenido";
            this.pnContenido.Size = new System.Drawing.Size(468, 414);
            this.pnContenido.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvErrores);
            this.panel1.Location = new System.Drawing.Point(548, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 414);
            this.panel1.TabIndex = 6;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(16, 79);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(436, 318);
            this.dgvDatos.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cargar Archivo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvErrores
            // 
            this.dgvErrores.AllowUserToDeleteRows = false;
            this.dgvErrores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErrores.Location = new System.Drawing.Point(19, 132);
            this.dgvErrores.Name = "dgvErrores";
            this.dgvErrores.Size = new System.Drawing.Size(426, 150);
            this.dgvErrores.TabIndex = 1;
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnBotones);
            this.Controls.Add(this.pnTitulo);
            this.Controls.Add(this.pnContenido);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPadre";
            this.Text = "frmPadre";
            this.pnBotones.ResumeLayout(false);
            this.pnTitulo.ResumeLayout(false);
            this.pnContenido.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbTitulo;
        protected System.Windows.Forms.Panel pnBotones;
        protected System.Windows.Forms.Button btnSalir;
        protected System.Windows.Forms.Button btnGuardar;
        protected System.Windows.Forms.Panel pnTitulo;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Panel pnContenido;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridView dgvErrores;
    }
}