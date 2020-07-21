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
    public partial class SettingFrm : Form
    {
        public SettingFrm()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                API api = new API();
                api.Restore();
            }
            catch
            {
                MessageBox.Show("Can't Restore");
            }
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                API api = new API();
                api.BackUp();
            }
            catch
            {
                MessageBox.Show("Can't Backup");
            }
        }
    }
}
