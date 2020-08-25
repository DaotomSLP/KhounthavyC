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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private String EncodePassword()
        {
            String EncodedPassword = "";
            
            return EncodedPassword;
        }

        private void btnDatabaseSetting_Click(object sender, EventArgs e)
        {
            lblServername.Visible = true;
            txtServerName.Visible = true;
            btnSaveConnStr.Visible = true;
        }

        private void btnSaveConnStr_Click(object sender, EventArgs e)
        {
            AppSetting appSetting = new AppSetting();
            String NewConnStr = String.Format("Data Source={0};Initial Catalog=Khounthavy;Integrated Security=True",txtServerName.Text);
            appSetting.SaveConnStr("KhounthavyV2.Properties.Settings.KhounthavyConnectionString", NewConnStr);
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            try
            {
                API api = new API();
                if (api.Login(txtUserName.Text, txtPass.Text).Rows.Count >0)
                {
                    Home home = new Home();
                    AddPawnFrm addPawnFrm = new AddPawnFrm();
                    home.ClearOldFrm();
                    home.ShowNewFrm(addPawnFrm);
                    home.ClearActiveMenu();
                    home.ActiveMenu(home.btnMenuAddNewPawn);
                    home.MenuPanel.Visible = true;
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
    }
}
