namespace KhounthavyV2
{
    partial class printFrm2
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(printFrm2));
            this.Pawn_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khounthavyDataSet = new KhounthavyV2.KhounthavyDataSet();
            this.pawnviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pawn_viewTableAdapter = new KhounthavyV2.KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.Pawn_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khounthavyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // Pawn_viewBindingSource
            // 
            this.Pawn_viewBindingSource.DataMember = "Pawn_view";
            this.Pawn_viewBindingSource.DataSource = this.khounthavyDataSet;
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
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Pawn_viewBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KhounthavyV2.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(89, 28);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1350, 585);
            this.reportViewer1.TabIndex = 2;
            // 
            // pawn_viewTableAdapter
            // 
            this.pawn_viewTableAdapter.ClearBeforeFill = true;
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(89, 28);
            this.axAcroPDF.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(1351, 595);
            this.axAcroPDF.TabIndex = 3;
            // 
            // printFrm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 651);
            this.Controls.Add(this.axAcroPDF);
            this.Controls.Add(this.reportViewer1);
            this.Name = "printFrm2";
            this.Text = "printFrm2";
            this.Load += new System.EventHandler(this.printFrm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pawn_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khounthavyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource Pawn_viewBindingSource;
        public KhounthavyDataSet khounthavyDataSet;
        private System.Windows.Forms.BindingSource pawnviewBindingSource;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public KhounthavyDataSetTableAdapters.Pawn_viewTableAdapter pawn_viewTableAdapter;
        public AxAcroPDFLib.AxAcroPDF axAcroPDF;
    }
}