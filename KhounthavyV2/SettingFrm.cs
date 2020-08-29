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
    public partial class SettingFrm : Form
    {
        public SettingFrm()
        {
            InitializeComponent();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Back up files (*.bak)|*.bak|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                   String filePath = openFileDialog.FileName;

                    try
                    {
                        API api = new API();
                        api.Restore(filePath);
                        MessageBox.Show("Restore Success..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }

        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            using (var fbd = new SaveFileDialog())
            {
                fbd.Filter = "BAK|*.bak|All files (*.*)|*.*";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        API api = new API();
                        api.BackUp(fbd.FileName);
                        MessageBox.Show("Back up Success...");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }
    }
}
