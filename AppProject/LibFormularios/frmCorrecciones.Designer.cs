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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGuardarCorrecciones = new System.Windows.Forms.Button();
            this.BtnCorregir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCorreccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCorecciones = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).BeginInit();
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
            this.panel1.Controls.Add(this.comboBox1);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Escuelas",
            "Postulantes",
            "Indetidades grupo A",
            "Indetidades grupo B",
            "Indetidades grupo C",
            "Indetidades grupo D",
            "Respuestas de alumnos grupo A",
            "Respuestas de alumnos grupo B",
            "Respuestas de alumnos grupo C",
            "Respuestas de alumnos grupo D"});
            this.comboBox1.Location = new System.Drawing.Point(219, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 13;
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
            // 
            // BtnCorregir
            // 
            this.BtnCorregir.Location = new System.Drawing.Point(219, 88);
            this.BtnCorregir.Name = "BtnCorregir";
            this.BtnCorregir.Size = new System.Drawing.Size(115, 23);
            this.BtnCorregir.TabIndex = 10;
            this.BtnCorregir.Text = "Corregir";
            this.BtnCorregir.UseVisualStyleBackColor = true;
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
            // 
            // frmCorrecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 408);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Name = "frmCorrecciones";
            this.Text = "frmCorrecciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}