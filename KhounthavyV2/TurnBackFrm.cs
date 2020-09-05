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
    public partial class TurnBackFrm : Form
    {
        public TurnBackFrm()
        {
            InitializeComponent();
        }

        private void btnTurnBack_Click(object sender, EventArgs e)
        {
            try
            {
                API api = new API();
                //api.TurnBack(txtPawnId.Text, txtImgNo.Text);
                MessageBox.Show("Success...");
                //txtImgNo.Clear();
                txtPawnId.Clear();
            }
            catch
            {
                MessageBox.Show("Can not Turnback");
            }
        }

        private void TurnBackFrm_Load(object sender, EventArgs e)
        {
            txtPawnId.Focus();
        }

        private void txtPawnId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPawnId.Focus();
            }
        }

        private void txtImgNo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnImgChoose_Click(object sender, EventArgs e)
        {
            CameraFrm cameraFrm = new CameraFrm();
            cameraFrm.Show();
            cameraFrm.FormClosed += returnImageFrm;
        }
        private void returnImageFrm(object sender, EventArgs e)
        {
            CameraFrm cameraFrm = (CameraFrm)sender;
            PicImg.Image = (Bitmap)cameraFrm.returnPictureBox.Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
