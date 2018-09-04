namespace LibFormularios
{
    partial class frmCorrecciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboSelccionCorreccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarCorrecciones = new System.Windows.Forms.Button();
            this.BtnCorregir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCorreccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCorecciones = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CbCoincidencias = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoincidencia = new System.Windows.Forms.TextBox();
            this.dgvCoincidencias = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoincidencias)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(557, 47);
            this.lbTitulo.TabIndex = 12;
            this.lbTitulo.Text = "FORMULARIO DE CORRECIONES";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboSelccionCorreccion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnGuardarCorrecciones);
            this.panel1.Controls.Add(this.BtnCorregir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtCorreccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvCorecciones);
            this.panel1.Location = new System.Drawing.Point(3, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 357);
            this.panel1.TabIndex = 13;
            // 
            // cboSelccionCorreccion
            // 
            this.cboSelccionCorreccion.FormattingEnabled = true;
            this.cboSelccionCorreccion.Items.AddRange(new object[] {
            "Escuelas",
            "Postulantes",
            "Indetidades",
            "Respuestas de alumnos"});
            this.cboSelccionCorreccion.Location = new System.Drawing.Point(219, 13);
            this.cboSelccionCorreccion.Name = "cboSelccionCorreccion";
            this.cboSelccionCorreccion.Size = new System.Drawing.Size(218, 21);
            this.cboSelccionCorreccion.TabIndex = 13;
            this.cboSelccionCorreccion.SelectedValueChanged += new System.EventHandler(this.cboSelccionCorreccion_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Realizar correcciones de:";
            // 
            // BtnGuardarCorrecciones
            // 
            this.BtnGuardarCorrecciones.Location = new System.Drawing.Point(219, 310);
            this.BtnGuardarCorrecciones.Name = "BtnGuardarCorrecciones";
            this.BtnGuardarCorrecciones.Size = new System.Drawing.Size(115, 23);
            this.BtnGuardarCorrecciones.TabIndex = 11;
            this.BtnGuardarCorrecciones.Text = "Guardar Corecciones";
            this.BtnGuardarCorrecciones.UseVisualStyleBackColor = true;
            this.BtnGuardarCorrecciones.Click += new System.EventHandler(this.BtnGuardarCorrecciones_Click);
            // 
            // BtnCorregir
            // 
            this.BtnCorregir.Location = new System.Drawing.Point(219, 88);
            this.BtnCorregir.Name = "BtnCorregir";
            this.BtnCorregir.Size = new System.Drawing.Size(115, 23);
            this.BtnCorregir.TabIndex = 10;
            this.BtnCorregir.Text = "Corregir";
            this.BtnCorregir.UseVisualStyleBackColor = true;
            this.BtnCorregir.Click += new System.EventHandler(this.BtnCorregir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Presione doble click derecho sobre la celda con herrores";
            // 
            // TxtCorreccion
            // 
            this.TxtCorreccion.Location = new System.Drawing.Point(157, 62);
            this.TxtCorreccion.Name = "TxtCorreccion";
            this.TxtCorreccion.Size = new System.Drawing.Size(280, 20);
            this.TxtCorreccion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dato a corregir";
            // 
            // dgvCorecciones
            // 
            this.dgvCorecciones.AllowUserToAddRows = false;
            this.dgvCorecciones.AllowUserToDeleteRows = false;
            this.dgvCorecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorecciones.Location = new System.Drawing.Point(67, 139);
            this.dgvCorecciones.Name = "dgvCorecciones";
            this.dgvCorecciones.ReadOnly = true;
            this.dgvCorecciones.Size = new System.Drawing.Size(426, 150);
            this.dgvCorecciones.TabIndex = 6;
            this.dgvCorecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorecciones_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(560, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 47);
            this.label4.TabIndex = 14;
            this.label4.Text = "COINCIDENCIAS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CbCoincidencias);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbCoincidencia);
            this.panel2.Controls.Add(this.dgvCoincidencias);
            this.panel2.Location = new System.Drawing.Point(561, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 355);
            this.panel2.TabIndex = 15;
            // 
            // CbCoincidencias
            // 
            this.CbCoincidencias.FormattingEnabled = true;
            this.CbCoincidencias.Items.AddRange(new object[] {
            "Escuelas",
            "Postulantes",
            "Identidad",
            "Respuestas Alumnos"});
            this.CbCoincidencias.Location = new System.Drawing.Point(203, 11);
            this.CbCoincidencias.Name = "CbCoincidencias";
            this.CbCoincidencias.Size = new System.Drawing.Size(121, 21);
            this.CbCoincidencias.TabIndex = 21;
            this.CbCoincidencias.SelectedIndexChanged += new System.EventHandler(this.CbCoincidencias_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Buscar Coincidencia en:";
            // 
            // tbCoincidencia
            // 
            this.tbCoincidencia.Location = new System.Drawing.Point(33, 81);
            this.tbCoincidencia.Name = "tbCoincidencia";
            this.tbCoincidencia.Size = new System.Drawing.Size(291, 20);
            this.tbCoincidencia.TabIndex = 19;
            this.tbCoincidencia.TextChanged += new System.EventHandler(this.tbCoincidencia_TextChanged);
            // 
            // dgvCoincidencias
            // 
            this.dgvCoincidencias.AllowUserToAddRows = false;
            this.dgvCoincidencias.AllowUserToDeleteRows = false;
            this.dgvCoincidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoincidencias.Location = new System.Drawing.Point(4, 137);
            this.dgvCoincidencias.Name = "dgvCoincidencias";
            this.dgvCoincidencias.ReadOnly = true;
            this.dgvCoincidencias.Size = new System.Drawing.Size(347, 150);
            this.dgvCoincidencias.TabIndex = 18;
            // 
            // frmCorrecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 408);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmCorrecciones";
            this.Text = "frmCorrecciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoincidencias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGuardarCorrecciones;
        private System.Windows.Forms.Button BtnCorregir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCorreccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCorecciones;
        private System.Windows.Forms.ComboBox cboSelccionCorreccion;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoincidencia;
        private System.Windows.Forms.DataGridView dgvCoincidencias;
        private System.Windows.Forms.ComboBox CbCoincidencias;
    }
}