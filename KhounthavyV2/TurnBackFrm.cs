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

        private void LockCustForm()
        {
            try
            {
                foreach (Control control in this.panCustForm.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void UnLockCustForm()
        {
            try
            {
                foreach (Control control in this.panCustForm.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = true;
                    }
                }
            }
            catch
            {

            }
            txtCustId.Enabled = false;
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
                if (txtPawnId.Text != "")
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


                            api.TurnBack(txtPawnId.Text, txtCustId.Text);

                            MessageBox.Show("SUCCESS");
                            ClearCustForm();
                            radNewCust.Checked = true;
                            LoadForm();
                        }
                    }
                    else
                    {

                        api.TurnBack(txtPawnId.Text, txtCustId.Text);

                        MessageBox.Show("SUCCESS");
                        ClearCustForm();
                        radNewCust.Checked = true;
                        LoadForm();
                    }

                }
                else
                {
                    MessageBox.Show("ກະລຸນາປ້ອນລະຫັດການຈຳ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnImgChoose_Click_1(object sender, EventArgs e)
        {
            CameraFrm cameraFrm = new CameraFrm();
            cameraFrm.Show();
            cameraFrm.FormClosed += returnImageFrm;
        }

        private void radNewCust_CheckedChanged(object sender, EventArgs e)
        {
            if (radNewCust.Checked == true)
            {
                CustDgvShow.Enabled = false;
                ClearCustForm();
                UnLockCustForm();
                API api = new API();
                txtCustId.Text = api.GetNewId("Customer");
            }
        }

        private void radOldCust_CheckedChanged(object sender, EventArgs e)
        {
            if (radOldCust.Checked == true)
            {
                CustDgvShow.Enabled = true;
                LockCustForm();
            }
        }

        private void CustDgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtCustId.Text = CustDgvShow.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCustName.Text = CustDgvShow.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCustLastName.Text = CustDgvShow.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTel.Text = CustDgvShow.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtVill.Text = CustDgvShow.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDist.Text = CustDgvShow.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtProv.Text = CustDgvShow.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtImgNo.Text = CustDgvShow.Rows[e.RowIndex].Cells[7].Value.ToString();

                PicImg.Image = null;

                try
                {
                    var imgByte = (Byte[])(CustDgvShow.Rows[e.RowIndex].Cells[8].Value);
                    MemoryStream memoryStream = new MemoryStream(imgByte);
                    PicImg.Image = Image.FromStream(memoryStream);
                }
                catch
                {

                }

            }
            catch
            {

            }
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            API api = new API();

            CustDgvShow.DataSource = api.CustomerSearch(txtCustSearch.Text);
            ((DataGridViewImageColumn)CustDgvShow.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
