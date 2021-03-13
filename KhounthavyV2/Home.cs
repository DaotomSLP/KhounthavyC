using Microsoft.Reporting.WinForms;
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
            txtUserName.Focus();
        }

        public void ClearOldFrm()
        {
            foreach (Form form in this.MdiChildren)
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

        public void ShowNewFrm(Form newFrm)
        {
            newFrm.Anchor = AnchorStyles.Bottom;
            newFrm.MdiParent = this;
            newFrm.Show();
            newFrm.WindowState = FormWindowState.Normal;
            newFrm.WindowState = FormWindowState.Maximized;
        }

        public void ClearActiveMenu()
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

        public void ActiveMenu(Button menu)
        {
            menu.BackColor = Color.White;
            menu.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void Login()
        {
            try
            {
                API api = new API();
                if (api.Login(txtUserName.Text, txtPass.Text).Rows.Count > 0)
                {
                    AddPawnFrm addPawnFrm = new AddPawnFrm();
                    ShowNewFrm(addPawnFrm);
                    ClearActiveMenu();
                    ActiveMenu(btnMenuAddNewPawn);
                    MenuPanel.Visible = true;
                    panLogin.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username Or Password is Wrong");
                }
            }
            catch
            {
                MessageBox.Show("please setting server name");
            }
        }

        private void btnMenuAddNewPawn_Click(object sender, EventArgs e)
        {
            AddPawnFrm addPawnFrm = new AddPawnFrm();
            ClearOldFrm();
            ShowNewFrm(addPawnFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuAddNewPawn);
            print_panel.Visible = false;
            Program.Pawn_id = "";

        }

        private void btnMenuCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerFrm addCustomerFrm = new AddCustomerFrm();
            ClearOldFrm();
            ShowNewFrm(addCustomerFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuCustomer);
            print_panel.Visible = false;
            Program.Pawn_id = "";

        }

        private void btnMenuPawnDetail_Click(object sender, EventArgs e)
        {
            PawnDetailFrm pawnDetailFrm = new PawnDetailFrm();
            ClearOldFrm();
            ShowNewFrm(pawnDetailFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuPawnDetail);
            print_panel.Visible = true;
            Program.Pawn_id = "";

        }

        private void btnMenuTurnBack_Click(object sender, EventArgs e)
        {
            TurnBackFrm turnBackFrm = new TurnBackFrm();
            ClearOldFrm();
            ShowNewFrm(turnBackFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuTurnBack);
            print_panel.Visible = false;
            Program.Pawn_id = "";

        }

        private void btnMenuSetting_Click(object sender, EventArgs e)
        {
            SettingFrm settingFrm = new SettingFrm();
            ClearOldFrm();
            ShowNewFrm(settingFrm);
            ClearActiveMenu();
            ActiveMenu(btnMenuSetting);
            print_panel.Visible = false;
            Program.Pawn_id = "";

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void btnDatabaseSetting_Click(object sender, EventArgs e)
        {
            txtServerName.Visible = true;
            btnSaveConnStr.Visible = true;
            lblServername.Visible = true;
        }

        private void btnSaveConnStr_Click(object sender, EventArgs e)
        {
            try
            {
                AppSetting appSetting = new AppSetting();
                String NewConnStr = String.Format("Data Source={0};Initial Catalog=Khounthavy;Integrated Security=True", txtServerName.Text);
                appSetting.SaveConnStr("KhounthavyV2.Properties.Settings.KhounthavyConnectionString", NewConnStr);
                appSetting.SaveConnStr("KhounthavyV2.Properties.Settings.KhounthavyConnectionString1", NewConnStr);
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("Please Run in Administrator to setting Server Name and restart Program");
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.Pawn_id == "")
            {
                MessageBox.Show("ກະລຸນາເລືອກການຈຳກ່ອນ");
            }
            else
            {

                PrintFrm print = new PrintFrm();
                DataTable dtb = new DataTable();
                API api = new API();
                dtb = api.LoadPawn(Program.Pawn_id);
                ReportDataSource rptsrc = new ReportDataSource("DataSet1", dtb);

                print.reportViewer1.LocalReport.DataSources.Clear();
                print.reportViewer1.LocalReport.DataSources.Add(rptsrc);

                print.reportViewer1.LocalReport.Refresh();


                ClearOldFrm();
                ShowNewFrm(print);


                print.pawn_viewTableAdapter.Fill(print.khounthavyDataSet.Pawn_view);

                print.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);

                byte[] pdfContent = print.reportViewer1.LocalReport.Render(format: "PDF", deviceInfo: "<DeviceInfo><EmbedFonts>None</EmbedFonts></DeviceInfo>");
                String pdfPath = Directory.GetCurrentDirectory() + @"\report.PDF";
                FileStream pdfFile = new FileStream(pdfPath, FileMode.Create);
                pdfFile.Write(pdfContent, 0, pdfContent.Length);
                pdfFile.Close();

                print.axAcroPDF.src = pdfPath;
            }

        }
    }
}
