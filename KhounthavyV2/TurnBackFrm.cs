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

        private void LoadForm()
        {
            API api = new API();

            CustDgvShow.DataSource = api.LoadData("Customer");
            ((DataGridViewImageColumn)CustDgvShow.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Zoom;
            txtCustId.Text = api.GetNewId("Customer");

            String[] headerText = { "ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເລກຮູບ", "ເລກຮູບ" };
            for (int i = 0; i <= headerText.Length - 1; i++)
            {
                CustDgvShow.Columns[i].HeaderText = headerText[i];
            }
        }

        private void ClearCustForm()
        {
            try
            {
                foreach (Control control in this.panCustForm.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Text = "";
                    }
                }
            }
            catch
            {

            }
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
            LoadForm();
        }

        private void txtPawnId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPawnId.Focus();
            }
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
            API api = new API();

            try
            {
                if (radNewCust.Checked == true)
                {
                    if (PicImg.Image == null || PicImg == null)
                    {
                        MessageBox.Show("ກະລຸນາເລືອກຮູບກ່ອນບັນທຶກ !!!");
                    }
                    else
                    {
                        api.InsertCustomer(
                           txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                           txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text,
                           api.ConvertImageToByte(PicImg)
                        );
                    }
                }

                api.TurnBack(txtPawnId.Text,  txtCustId.Text);

                MessageBox.Show("SUCCESS");
                ClearCustForm();
                radNewCust.Checked = true;
                LoadForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
