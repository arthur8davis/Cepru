namespace LibFormularios
{
    partial class frmMostrarDatos
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
            this.cbBuscar = new System.Windows.Forms.ComboBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.dgvCorecciones = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCorreccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCorregir = new System.Windows.Forms.Button();
            this.BtnGuardarCorrecciones = new System.Windows.Forms.Button();
            this.pnBotones.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBotones
            // 
            this.pnBotones.Size = new System.Drawing.Size(78, 418);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnContenido
            // 
            this.pnContenido.Controls.Add(this.dgvDatos);
            this.pnContenido.Controls.Add(this.cbBuscar);
            this.pnContenido.Location = new System.Drawing.Point(82, 50);
            this.pnContenido.Controls.SetChildIndex(this.cbBuscar, 0);
            this.pnContenido.Controls.SetChildIndex(this.dgvDatos, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnGuardarCorrecciones);
            this.panel1.Controls.Add(this.BtnCorregir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtCorreccion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgvCorecciones);
            this.panel1.Controls.SetChildIndex(this.dgvCorecciones, 0);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.TxtCorreccion, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.BtnCorregir, 0);
            this.panel1.Controls.SetChildIndex(this.BtnGuardarCorrecciones, 0);
            // 
            // cbBuscar
            // 
            this.cbBuscar.FormattingEnabled = true;
            this.cbBuscar.Items.AddRange(new object[] {
            "Excel",
            "Texto"});
            this.cbBuscar.Location = new System.Drawing.Point(304, 30);
            this.cbBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.cbBuscar.Name = "cbBuscar";
            this.cbBuscar.Size = new System.Drawing.Size(92, 21);
            this.cbBuscar.TabIndex = 0;
            this.cbBuscar.SelectedIndexChanged += new System.EventHandler(this.cbBuscar_SelectedIndexChanged);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(16, 68);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(436, 318);
            this.dgvDatos.TabIndex = 1;
            // 
            // dgvCorecciones
            // 
            this.dgvCorecciones.AllowUserToDeleteRows = false;
            this.dgvCorecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorecciones.Location = new System.Drawing.Point(16, 141);
            this.dgvCorecciones.Name = "dgvCorecciones";
            this.dgvCorecciones.Size = new System.Drawing.Size(426, 150);
            this.dgvCorecciones.TabIndex = 0;
            this.dgvCorecciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCorecciones_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dato a corregir";
            // 
            // TxtCorreccion
            // 
            this.TxtCorreccion.Location = new System.Drawing.Point(115, 64);
            this.TxtCorreccion.Name = "TxtCorreccion";
            this.TxtCorreccion.Size = new System.Drawing.Size(280, 20);
            this.TxtCorreccion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Presione doble click derecho sobre la celda con herrores";
            // 
            // BtnCorregir
            // 
            this.BtnCorregir.Location = new System.Drawing.Point(190, 90);
            this.BtnCorregir.Name = "BtnCorregir";
            this.BtnCorregir.Size = new System.Drawing.Size(115, 23);
            this.BtnCorregir.TabIndex = 4;
            this.BtnCorregir.Text = "Corregir";
            this.BtnCorregir.UseVisualStyleBackColor = true;
            this.BtnCorregir.Click += new System.EventHandler(this.BtnCorregir_Click);
            // 
            // BtnGuardarCorrecciones
            // 
            this.BtnGuardarCorrecciones.Location = new System.Drawing.Point(190, 327);
            this.BtnGuardarCorrecciones.Name = "BtnGuardarCorrecciones";
            this.BtnGuardarCorrecciones.Size = new System.Drawing.Size(115, 23);
            this.BtnGuardarCorrecciones.TabIndex = 5;
            this.BtnGuardarCorrecciones.Text = "Guardar Corecciones";
            this.BtnGuardarCorrecciones.UseVisualStyleBackColor = true;
            this.BtnGuardarCorrecciones.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmMostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1012, 468);
            this.Name = "frmMostrarDatos";
            this.pnBotones.ResumeLayout(false);
            this.pnTitulo.ResumeLayout(false);
            this.pnContenido.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBuscar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox TxtCorreccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCorecciones;
        private System.Windows.Forms.Button BtnCorregir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGuardarCorrecciones;
    }
}
