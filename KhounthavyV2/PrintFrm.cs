using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace KhounthavyV2
{
    public partial class PrintFrm : Form
    {
        public PrintFrm()
        {
            InitializeComponent();
        }

        private void PrintFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khounthavyDataSet.Pawn_view' table. You can move, or remove it, as needed.
            this.pawn_viewTableAdapter.Fill(this.khounthavyDataSet.Pawn_view);

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

            byte[] pdfContent = reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "<DeviceInfo><EmbedFonts>None</EmbedFonts></DeviceInfo>");
            String pdfPath = Directory.GetCurrentDirectory() + @"\report.PDF";
            FileStream pdfFile = new FileStream(pdfPath, FileMode.Create);
            pdfFile.Write(pdfContent, 0, pdfContent.Length);
            pdfFile.Close();

            axAcroPDF.src = pdfPath;


            this.reportViewer1.RefreshReport();
        }

    }
}
