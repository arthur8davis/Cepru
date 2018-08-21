namespace AppProject
{
    partial class frmPrincipal
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCorreciones = new System.Windows.Forms.Button();
            this.BtnCalificar = new System.Windows.Forms.Button();
            this.BtnRespuestasAlumn = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.CkbClaves = new System.Windows.Forms.CheckBox();
            this.BtnClaveRespuestas = new System.Windows.Forms.Button();
            this.CkbRespAlumnosD = new System.Windows.Forms.CheckBox();
            this.CkbRespAlumnosC = new System.Windows.Forms.CheckBox();
            this.CkbRespAlumnosB = new System.Windows.Forms.CheckBox();
            this.CkbRespAlumnosA = new System.Windows.Forms.CheckBox();
            this.CkbIdentidadD = new System.Windows.Forms.CheckBox();
            this.CkbIdentidadC = new System.Windows.Forms.CheckBox();
            this.CkbIdentidadB = new System.Windows.Forms.CheckBox();
            this.BtnIdentidad = new System.Windows.Forms.Button();
            this.CkbIdentidadA = new System.Windows.Forms.CheckBox();
            this.CkbFaltantes = new System.Windows.Forms.CheckBox();
            this.BtnFaltantes = new System.Windows.Forms.Button();
            this.CkbPostulantes = new System.Windows.Forms.CheckBox();
            this.BtnPostulantes = new System.Windows.Forms.Button();
            this.CkbEscuelas = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnEscuelas = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCorreciones);
            this.panel2.Controls.Add(this.BtnCalificar);
            this.panel2.Location = new System.Drawing.Point(307, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 266);
            this.panel2.TabIndex = 14;
            // 
            // BtnCorreciones
            // 
            this.BtnCorreciones.Enabled = false;
            this.BtnCorreciones.Location = new System.Drawing.Point(70, 55);
            this.BtnCorreciones.Name = "BtnCorreciones";
            this.BtnCorreciones.Size = new System.Drawing.Size(127, 39);
            this.BtnCorreciones.TabIndex = 8;
            this.BtnCorreciones.Text = "Realizar Correcciones";
            this.BtnCorreciones.UseVisualStyleBackColor = true;
            this.BtnCorreciones.Click += new System.EventHandler(this.BtnCorreciones_Click);
            // 
            // BtnCalificar
            // 
            this.BtnCalificar.Enabled = false;
            this.BtnCalificar.Location = new System.Drawing.Point(70, 126);
            this.BtnCalificar.Name = "BtnCalificar";
            this.BtnCalificar.Size = new System.Drawing.Size(127, 39);
            this.BtnCalificar.TabIndex = 9;
            this.BtnCalificar.Text = "Calificar";
            this.BtnCalificar.UseVisualStyleBackColor = true;
            // 
            // BtnRespuestasAlumn
            // 
            this.BtnRespuestasAlumn.Enabled = false;
            this.BtnRespuestasAlumn.Location = new System.Drawing.Point(10, 150);
            this.BtnRespuestasAlumn.Name = "BtnRespuestasAlumn";
            this.BtnRespuestasAlumn.Size = new System.Drawing.Size(120, 23);
            this.BtnRespuestasAlumn.TabIndex = 6;
            this.BtnRespuestasAlumn.Text = "Respuestas Alumnos";
            this.BtnRespuestasAlumn.UseVisualStyleBackColor = true;
            this.BtnRespuestasAlumn.Click += new System.EventHandler(this.BtnRespuestasAlumn_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTitulo.Location = new System.Drawing.Point(0, 1);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(557, 47);
            this.lbTitulo.TabIndex = 11;
            this.lbTitulo.Text = "SISTEMA DE CALIFICACIONES CEPRU";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CkbClaves
            // 
            this.CkbClaves.AutoSize = true;
            this.CkbClaves.Enabled = false;
            this.CkbClaves.Location = new System.Drawing.Point(148, 184);
            this.CkbClaves.Name = "CkbClaves";
            this.CkbClaves.Size = new System.Drawing.Size(15, 14);
            this.CkbClaves.TabIndex = 18;
            this.CkbClaves.UseVisualStyleBackColor = true;
            // 
            // BtnClaveRespuestas
            // 
            this.BtnClaveRespuestas.Enabled = false;
            this.BtnClaveRespuestas.Location = new System.Drawing.Point(10, 179);
            this.BtnClaveRespuestas.Name = "BtnClaveRespuestas";
            this.BtnClaveRespuestas.Size = new System.Drawing.Size(120, 23);
            this.BtnClaveRespuestas.TabIndex = 17;
            this.BtnClaveRespuestas.Text = "Clave de respuestas";
            this.BtnClaveRespuestas.UseVisualStyleBackColor = true;
            this.BtnClaveRespuestas.Click += new System.EventHandler(this.BtnClaveRespuestas_Click);
            // 
            // CkbRespAlumnosD
            // 
            this.CkbRespAlumnosD.AutoSize = true;
            this.CkbRespAlumnosD.Enabled = false;
            this.CkbRespAlumnosD.Location = new System.Drawing.Point(265, 156);
            this.CkbRespAlumnosD.Name = "CkbRespAlumnosD";
            this.CkbRespAlumnosD.Size = new System.Drawing.Size(34, 17);
            this.CkbRespAlumnosD.TabIndex = 16;
            this.CkbRespAlumnosD.Text = "D";
            this.CkbRespAlumnosD.UseVisualStyleBackColor = true;
            // 
            // CkbRespAlumnosC
            // 
            this.CkbRespAlumnosC.AutoSize = true;
            this.CkbRespAlumnosC.Enabled = false;
            this.CkbRespAlumnosC.Location = new System.Drawing.Point(226, 155);
            this.CkbRespAlumnosC.Name = "CkbRespAlumnosC";
            this.CkbRespAlumnosC.Size = new System.Drawing.Size(33, 17);
            this.CkbRespAlumnosC.TabIndex = 15;
            this.CkbRespAlumnosC.Text = "C";
            this.CkbRespAlumnosC.UseVisualStyleBackColor = true;
            // 
            // CkbRespAlumnosB
            // 
            this.CkbRespAlumnosB.AutoSize = true;
            this.CkbRespAlumnosB.Enabled = false;
            this.CkbRespAlumnosB.Location = new System.Drawing.Point(187, 156);
            this.CkbRespAlumnosB.Name = "CkbRespAlumnosB";
            this.CkbRespAlumnosB.Size = new System.Drawing.Size(33, 17);
            this.CkbRespAlumnosB.TabIndex = 14;
            this.CkbRespAlumnosB.Text = "B";
            this.CkbRespAlumnosB.UseVisualStyleBackColor = true;
            // 
            // CkbRespAlumnosA
            // 
            this.CkbRespAlumnosA.AutoSize = true;
            this.CkbRespAlumnosA.Enabled = false;
            this.CkbRespAlumnosA.Location = new System.Drawing.Point(148, 156);
            this.CkbRespAlumnosA.Name = "CkbRespAlumnosA";
            this.CkbRespAlumnosA.Size = new System.Drawing.Size(33, 17);
            this.CkbRespAlumnosA.TabIndex = 13;
            this.CkbRespAlumnosA.Text = "A";
            this.CkbRespAlumnosA.UseVisualStyleBackColor = true;
            // 
            // CkbIdentidadD
            // 
            this.CkbIdentidadD.AutoSize = true;
            this.CkbIdentidadD.Enabled = false;
            this.CkbIdentidadD.Location = new System.Drawing.Point(265, 126);
            this.CkbIdentidadD.Name = "CkbIdentidadD";
            this.CkbIdentidadD.Size = new System.Drawing.Size(34, 17);
            this.CkbIdentidadD.TabIndex = 12;
            this.CkbIdentidadD.Text = "D";
            this.CkbIdentidadD.UseVisualStyleBackColor = true;
            // 
            // CkbIdentidadC
            // 
            this.CkbIdentidadC.AutoSize = true;
            this.CkbIdentidadC.Enabled = false;
            this.CkbIdentidadC.Location = new System.Drawing.Point(226, 125);
            this.CkbIdentidadC.Name = "CkbIdentidadC";
            this.CkbIdentidadC.Size = new System.Drawing.Size(33, 17);
            this.CkbIdentidadC.TabIndex = 11;
            this.CkbIdentidadC.Text = "C";
            this.CkbIdentidadC.UseVisualStyleBackColor = true;
            // 
            // CkbIdentidadB
            // 
            this.CkbIdentidadB.AutoSize = true;
            this.CkbIdentidadB.Enabled = false;
            this.CkbIdentidadB.Location = new System.Drawing.Point(187, 126);
            this.CkbIdentidadB.Name = "CkbIdentidadB";
            this.CkbIdentidadB.Size = new System.Drawing.Size(33, 17);
            this.CkbIdentidadB.TabIndex = 10;
            this.CkbIdentidadB.Text = "B";
            this.CkbIdentidadB.UseVisualStyleBackColor = true;
            // 
            // BtnIdentidad
            // 
            this.BtnIdentidad.Enabled = false;
            this.BtnIdentidad.Location = new System.Drawing.Point(10, 121);
            this.BtnIdentidad.Name = "BtnIdentidad";
            this.BtnIdentidad.Size = new System.Drawing.Size(120, 23);
            this.BtnIdentidad.TabIndex = 8;
            this.BtnIdentidad.Text = "Identidad";
            this.BtnIdentidad.UseVisualStyleBackColor = true;
            this.BtnIdentidad.Click += new System.EventHandler(this.BtnIdentidad_Click);
            // 
            // CkbIdentidadA
            // 
            this.CkbIdentidadA.AutoSize = true;
            this.CkbIdentidadA.Enabled = false;
            this.CkbIdentidadA.Location = new System.Drawing.Point(148, 126);
            this.CkbIdentidadA.Name = "CkbIdentidadA";
            this.CkbIdentidadA.Size = new System.Drawing.Size(33, 17);
            this.CkbIdentidadA.TabIndex = 7;
            this.CkbIdentidadA.Text = "A";
            this.CkbIdentidadA.UseVisualStyleBackColor = true;
            // 
            // CkbFaltantes
            // 
            this.CkbFaltantes.AutoSize = true;
            this.CkbFaltantes.Enabled = false;
            this.CkbFaltantes.Location = new System.Drawing.Point(148, 97);
            this.CkbFaltantes.Name = "CkbFaltantes";
            this.CkbFaltantes.Size = new System.Drawing.Size(15, 14);
            this.CkbFaltantes.TabIndex = 5;
            this.CkbFaltantes.UseVisualStyleBackColor = true;
            // 
            // BtnFaltantes
            // 
            this.BtnFaltantes.Enabled = false;
            this.BtnFaltantes.Location = new System.Drawing.Point(10, 92);
            this.BtnFaltantes.Name = "BtnFaltantes";
            this.BtnFaltantes.Size = new System.Drawing.Size(120, 23);
            this.BtnFaltantes.TabIndex = 4;
            this.BtnFaltantes.Text = "Faltantes";
            this.BtnFaltantes.UseVisualStyleBackColor = true;
            this.BtnFaltantes.Click += new System.EventHandler(this.BtnFaltantes_Click);
            // 
            // CkbPostulantes
            // 
            this.CkbPostulantes.AutoSize = true;
            this.CkbPostulantes.Enabled = false;
            this.CkbPostulantes.Location = new System.Drawing.Point(148, 68);
            this.CkbPostulantes.Name = "CkbPostulantes";
            this.CkbPostulantes.Size = new System.Drawing.Size(15, 14);
            this.CkbPostulantes.TabIndex = 3;
            this.CkbPostulantes.UseVisualStyleBackColor = true;
            // 
            // BtnPostulantes
            // 
            this.BtnPostulantes.Enabled = false;
            this.BtnPostulantes.Location = new System.Drawing.Point(10, 63);
            this.BtnPostulantes.Name = "BtnPostulantes";
            this.BtnPostulantes.Size = new System.Drawing.Size(120, 23);
            this.BtnPostulantes.TabIndex = 2;
            this.BtnPostulantes.Text = "Postulantes";
            this.BtnPostulantes.UseVisualStyleBackColor = true;
            this.BtnPostulantes.Click += new System.EventHandler(this.BtnPostulantes_Click);
            // 
            // CkbEscuelas
            // 
            this.CkbEscuelas.AutoSize = true;
            this.CkbEscuelas.Enabled = false;
            this.CkbEscuelas.Location = new System.Drawing.Point(148, 39);
            this.CkbEscuelas.Name = "CkbEscuelas";
            this.CkbEscuelas.Size = new System.Drawing.Size(15, 14);
            this.CkbEscuelas.TabIndex = 1;
            this.CkbEscuelas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CkbClaves);
            this.panel1.Controls.Add(this.BtnClaveRespuestas);
            this.panel1.Controls.Add(this.CkbRespAlumnosD);
            this.panel1.Controls.Add(this.CkbRespAlumnosC);
            this.panel1.Controls.Add(this.CkbRespAlumnosB);
            this.panel1.Controls.Add(this.CkbRespAlumnosA);
            this.panel1.Controls.Add(this.CkbIdentidadD);
            this.panel1.Controls.Add(this.CkbIdentidadC);
            this.panel1.Controls.Add(this.CkbIdentidadB);
            this.panel1.Controls.Add(this.BtnIdentidad);
            this.panel1.Controls.Add(this.CkbIdentidadA);
            this.panel1.Controls.Add(this.BtnRespuestasAlumn);
            this.panel1.Controls.Add(this.CkbFaltantes);
            this.panel1.Controls.Add(this.BtnFaltantes);
            this.panel1.Controls.Add(this.CkbPostulantes);
            this.panel1.Controls.Add(this.BtnPostulantes);
            this.panel1.Controls.Add(this.CkbEscuelas);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnEscuelas);
            this.panel1.Location = new System.Drawing.Point(2, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 266);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGA DE DATOS";
            // 
            // BtnEscuelas
            // 
            this.BtnEscuelas.Location = new System.Drawing.Point(10, 34);
            this.BtnEscuelas.Name = "BtnEscuelas";
            this.BtnEscuelas.Size = new System.Drawing.Size(120, 23);
            this.BtnEscuelas.TabIndex = 0;
            this.BtnEscuelas.Text = "Escuelas";
            this.BtnEscuelas.UseVisualStyleBackColor = true;
            this.BtnEscuelas.Click += new System.EventHandler(this.BtnEscuelas_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 318);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnCorreciones;
        private System.Windows.Forms.Button BtnCalificar;
        private System.Windows.Forms.Button BtnRespuestasAlumn;
        protected System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.CheckBox CkbClaves;
        private System.Windows.Forms.Button BtnClaveRespuestas;
        private System.Windows.Forms.CheckBox CkbRespAlumnosD;
        private System.Windows.Forms.CheckBox CkbRespAlumnosC;
        private System.Windows.Forms.CheckBox CkbRespAlumnosB;
        private System.Windows.Forms.CheckBox CkbRespAlumnosA;
        private System.Windows.Forms.CheckBox CkbIdentidadD;
        private System.Windows.Forms.CheckBox CkbIdentidadC;
        private System.Windows.Forms.CheckBox CkbIdentidadB;
        private System.Windows.Forms.Button BtnIdentidad;
        private System.Windows.Forms.CheckBox CkbIdentidadA;
        private System.Windows.Forms.CheckBox CkbFaltantes;
        private System.Windows.Forms.Button BtnFaltantes;
        private System.Windows.Forms.CheckBox CkbPostulantes;
        private System.Windows.Forms.Button BtnPostulantes;
        private System.Windows.Forms.CheckBox CkbEscuelas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEscuelas;
    }
}