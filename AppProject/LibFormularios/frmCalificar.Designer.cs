namespace LibFormularios
{
    partial class frmCalificar
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
            this.BtnCalificar = new System.Windows.Forms.Button();
            this.dgvCalificados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificados)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalificar
            // 
            this.BtnCalificar.Location = new System.Drawing.Point(275, 26);
            this.BtnCalificar.Name = "BtnCalificar";
            this.BtnCalificar.Size = new System.Drawing.Size(96, 31);
            this.BtnCalificar.TabIndex = 0;
            this.BtnCalificar.Text = "Calificar";
            this.BtnCalificar.UseVisualStyleBackColor = true;
            // 
            // dgvCalificados
            // 
            this.dgvCalificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificados.Location = new System.Drawing.Point(35, 101);
            this.dgvCalificados.Name = "dgvCalificados";
            this.dgvCalificados.Size = new System.Drawing.Size(566, 212);
            this.dgvCalificados.TabIndex = 1;
            // 
            // frmCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.dgvCalificados);
            this.Controls.Add(this.BtnCalificar);
            this.Name = "frmCalificar";
            this.Text = "frmCalificar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalificar;
        private System.Windows.Forms.DataGridView dgvCalificados;
    }
}