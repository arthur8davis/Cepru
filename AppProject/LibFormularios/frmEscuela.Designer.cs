namespace LibFormularios
{
    partial class frmEscuela
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
            this.pnBotones.SuspendLayout();
            this.pnTitulo.SuspendLayout();
            this.pnContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.Text = "ESCUELAS";
            // 
            // pnBotones
            // 
            this.pnBotones.Size = new System.Drawing.Size(78, 415);
            // 
            // pnTitulo
            // 
            this.pnTitulo.Size = new System.Drawing.Size(1013, 50);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmEscuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1013, 465);
            this.Name = "frmEscuela";
            this.pnBotones.ResumeLayout(false);
            this.pnTitulo.ResumeLayout(false);
            this.pnContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
