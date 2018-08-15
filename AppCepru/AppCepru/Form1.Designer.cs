namespace AppCepru
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
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCargarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCargarDatos.Location = new System.Drawing.Point(51, 136);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(136, 52);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "CARGAR DATOS";
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGenerarReporte.Location = new System.Drawing.Point(264, 136);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(136, 52);
            this.btnGenerarReporte.TabIndex = 1;
            this.btnGenerarReporte.Text = "GENERAR REPORTES";
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalificar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalificar.Location = new System.Drawing.Point(481, 136);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(136, 52);
            this.btnCalificar.TabIndex = 2;
            this.btnCalificar.Text = "CALIFICAR";
            this.btnCalificar.UseVisualStyleBackColor = false;
            this.btnCalificar.Click += new System.EventHandler(this.btnCalificar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(670, 329);
            this.Controls.Add(this.btnCalificar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.btnCargarDatos);
            this.Name = "frmPrincipal";
            this.Text = "SISTEMA DE CALIFICACION";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnCalificar;
    }
}

