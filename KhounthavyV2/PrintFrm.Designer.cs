namespace KhounthavyV2
{
    partial class PrintFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintFrm));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.khounthavyDataSet = new KhounthavyV2.KhounthavyDataSet();
            this.pawnviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pawn_viewTableAdapter = new KhounthavyV2.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.khounthavyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pawnviewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KhounthavyV2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1335, 580);
            this.reportViewer1.TabIndex = 0;
            // 
            // khounthavyDataSet
            // 
            this.khounthavyDataSet.DataSetName = "KhounthavyDataSet";
            this.khounthavyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pawnviewBindingSource
            // 
            this.pawnviewBindingSource.DataMember = "Pawn_view";
            this.pawnviewBindingSource.DataSource = this.khounthavyDataSet;
            // 
            // pawn_viewTableAdapter
            // 
            this.pawn_viewTableAdapter.ClearBeforeFill = true;
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(1351, 595);
            this.axAcroPDF.TabIndex = 1;
            // 
            // PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 585);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintFrm";
            this.Text = "PrintFrm";
            this.Load += new System.EventHandler(this.PrintFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.khounthavyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private KhounthavyDataSet khounthavyDataSet;
        private System.Windows.Forms.BindingSource pawnviewBindingSource;
        private KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter pawn_viewTableAdapter;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
    }
}