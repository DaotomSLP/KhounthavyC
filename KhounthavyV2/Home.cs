using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhounthavyV2
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AddNewPawn_Load(object sender, EventArgs e)
        {
            AddPawnFrm addCustomerFrm = new AddPawnFrm();
            ShowNewFrm(addCustomerFrm);

            if( DateTime.Now.ToString("dd") == "28")
            {
                API api = new API();
                api.BackUp();
            }
        }

        private void ClearOldFrm()
        {
            foreach(Form form in this.MdiChildren)
            {
                try
                {
                        form.Close();
                }
                catch
                {

                }
            }  
        }

        private void ShowNewFrm(Form newFrm)
        {
            newFrm.Anchor = AnchorStyles.Bottom;
            newFrm.MdiParent = this;
            newFrm.Show();
            newFrm.WindowState = FormWindowState.Normal;
            newFrm.WindowState = FormWindowState.Maximized;
        }

        private void ClearActiveMenu()
        {
            try  //try for it not error if it not see button in menu panel.
            {
                foreach (Button menu in MenuPanel.Controls)
                {
                    menu.BackColor = Color.Black;
                    menu.ForeColor = SystemColors.ButtonHighlight;
                }
            }
            catch
            {

            }
        }

        private void ActiveMenu(Button menu)
        {
            menu.BackColor = Color.White;
            menu.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void btnMenuAddNewPawn_Click(object sender, EventArgs e)
        {
            AddPawnFrm addPawnFrm = new AddPawnFrm();
            ClearOldFrm();
            ShowNewFrm(addPawnFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuAddNewPawn);
        }

        private void btnMenuCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerFrm addCustomerFrm = new AddCustomerFrm();
            ClearOldFrm();
            ShowNewFrm(addCustomerFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuCustomer);
        }

        private void btnMenuPawnDetail_Click(object sender, EventArgs e)
        {
            PawnDetailFrm pawnDetailFrm = new PawnDetailFrm();
            ClearOldFrm();
            ShowNewFrm(pawnDetailFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuPawnDetail);
        }

        private void btnMenuSetting_Click(object sender, EventArgs e)
        {
            PrintFrm pawnDetailFrm = new PrintFrm();
            ClearOldFrm();

            DataTable dtb = new DataTable();
            API api = new API();
            dtb = api.LoadPawn("PN000002");
            ReportDataSource rptsrc = new ReportDataSource("DataSet1", dtb);
            pawnDetailFrm.reportViewer1.LocalReport.DataSources.Clear();
            pawnDetailFrm.reportViewer1.LocalReport.DataSources.Add(rptsrc);
            pawnDetailFrm.reportViewer1.LocalReport.Refresh();


            ShowNewFrm(pawnDetailFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuSetting);
        }

    }
}
