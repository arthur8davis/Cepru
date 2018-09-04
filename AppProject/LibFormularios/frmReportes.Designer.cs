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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BtnCalificar = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbCepruDataSet = new LibFormularios.dbCepruDataSet();
            this.TErroresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TErroresTableAdapter = new LibFormularios.dbCepruDataSetTableAdapters.TErroresTableAdapter();
            this.Calificacion = new LibFormularios.Calificacion();
            this.TCalificadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TCalificadaTableAdapter = new LibFormularios.CalificacionTableAdapters.TCalificadaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbCepruDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TErroresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calificacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCalificadaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCalificar
            // 
            this.BtnCalificar.Location = new System.Drawing.Point(314, 12);
            this.BtnCalificar.Name = "BtnCalificar";
            this.BtnCalificar.Size = new System.Drawing.Size(96, 31);
            this.BtnCalificar.TabIndex = 0;
            this.BtnCalificar.Text = "Calificar";
            this.BtnCalificar.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Calificar";
            reportDataSource1.Value = this.TCalificadaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LibFormularios.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(612, 276);
            this.reportViewer1.TabIndex = 1;
            // 
            // dbCepruDataSet
            // 
            this.dbCepruDataSet.DataSetName = "dbCepruDataSet";
            this.dbCepruDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TErroresBindingSource
            // 
            this.TErroresBindingSource.DataMember = "TErrores";
            this.TErroresBindingSource.DataSource = this.dbCepruDataSet;
            // 
            // TErroresTableAdapter
            // 
            this.TErroresTableAdapter.ClearBeforeFill = true;
            // 
            // Calificacion
            // 
            this.Calificacion.DataSetName = "Calificacion";
            this.Calificacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TCalificadaBindingSource
            // 
            this.TCalificadaBindingSource.DataMember = "TCalificada";
            this.TCalificadaBindingSource.DataSource = this.Calificacion;
            // 
            // TCalificadaTableAdapter
            // 
            this.TCalificadaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 351);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.BtnCalificar);
            this.Name = "frmReportes";
            this.Text = "frmCalificar";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbCepruDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TErroresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calificacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TCalificadaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalificar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TErroresBindingSource;
        private dbCepruDataSet dbCepruDataSet;
        private dbCepruDataSetTableAdapters.TErroresTableAdapter TErroresTableAdapter;
        private System.Windows.Forms.BindingSource TCalificadaBindingSource;
        private Calificacion Calificacion;
        private CalificacionTableAdapters.TCalificadaTableAdapter TCalificadaTableAdapter;
    }
}