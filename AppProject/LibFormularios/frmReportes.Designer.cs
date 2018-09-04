namespace LibFormularios
{
    partial class frmReportes
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
            this.SuspendLayout();
            // 
            // BtnCalificar
            // 
            this.BtnCalificar.Location = new System.Drawing.Point(108, 12);
            this.BtnCalificar.Name = "BtnCalificar";
            this.BtnCalificar.Size = new System.Drawing.Size(96, 31);
            this.BtnCalificar.TabIndex = 0;
            this.BtnCalificar.Text = "Calificar";
            this.BtnCalificar.UseVisualStyleBackColor = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.BtnCalificar);
            this.Name = "frmReportes";
            this.Text = "frmCalificar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalificar;
    }
}