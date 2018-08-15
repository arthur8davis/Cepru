namespace LibFormularios
{
    partial class frmPostulante
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
            this.dgvPostulante = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcarrera = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCiclo = new System.Windows.Forms.TextBox();
            this.tbAula = new System.Windows.Forms.TextBox();
            this.tbCarpeta = new System.Windows.Forms.TextBox();
            this.tbGrupo = new System.Windows.Forms.TextBox();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.btImportar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostulante)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbSexo);
            this.panel2.Controls.Add(this.tbGrupo);
            this.panel2.Controls.Add(this.tbCarpeta);
            this.panel2.Controls.Add(this.tbAula);
            this.panel2.Controls.Add(this.tbCiclo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dgvPostulante);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbcarrera);
            this.panel2.Controls.Add(this.tbNombre);
            this.panel2.Controls.Add(this.tbCodigo);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btImportar);
            this.panel3.Controls.SetChildIndex(this.btImportar, 0);
            this.panel3.Controls.SetChildIndex(this.btnEliminar, 0);
            // 
            // dgvPostulante
            // 
            this.dgvPostulante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostulante.Location = new System.Drawing.Point(12, 143);
            this.dgvPostulante.Name = "dgvPostulante";
            this.dgvPostulante.ReadOnly = true;
            this.dgvPostulante.Size = new System.Drawing.Size(360, 113);
            this.dgvPostulante.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Carrera";
            // 
            // tbcarrera
            // 
            this.tbcarrera.Location = new System.Drawing.Point(59, 58);
            this.tbcarrera.Name = "tbcarrera";
            this.tbcarrera.Size = new System.Drawing.Size(281, 20);
            this.tbcarrera.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(59, 32);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(281, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(59, 6);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 7;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ciclo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Aula Examen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Carpeta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sexo";
            // 
            // tbCiclo
            // 
            this.tbCiclo.Location = new System.Drawing.Point(59, 87);
            this.tbCiclo.Name = "tbCiclo";
            this.tbCiclo.Size = new System.Drawing.Size(100, 20);
            this.tbCiclo.TabIndex = 19;
            // 
            // tbAula
            // 
            this.tbAula.Location = new System.Drawing.Point(260, 87);
            this.tbAula.Name = "tbAula";
            this.tbAula.Size = new System.Drawing.Size(78, 20);
            this.tbAula.TabIndex = 20;
            // 
            // tbCarpeta
            // 
            this.tbCarpeta.Location = new System.Drawing.Point(59, 113);
            this.tbCarpeta.Name = "tbCarpeta";
            this.tbCarpeta.Size = new System.Drawing.Size(60, 20);
            this.tbCarpeta.TabIndex = 21;
            // 
            // tbGrupo
            // 
            this.tbGrupo.Location = new System.Drawing.Point(298, 113);
            this.tbGrupo.Name = "tbGrupo";
            this.tbGrupo.Size = new System.Drawing.Size(42, 20);
            this.tbGrupo.TabIndex = 22;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(209, 113);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(45, 20);
            this.tbSexo.TabIndex = 23;
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(12, 12);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(75, 23);
            this.btImportar.TabIndex = 3;
            this.btImportar.Text = "Importar";
            this.btImportar.UseVisualStyleBackColor = true;
            this.btImportar.Click += new System.EventHandler(this.btImportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(154, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmPostulante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Name = "frmPostulante";
            this.Text = "frmPostulante";
            this.Load += new System.EventHandler(this.frmPostulante_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostulante)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostulante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbcarrera;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.TextBox tbGrupo;
        private System.Windows.Forms.TextBox tbCarpeta;
        private System.Windows.Forms.TextBox tbAula;
        private System.Windows.Forms.TextBox tbCiclo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btImportar;
    }
}