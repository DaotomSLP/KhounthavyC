﻿using System;
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
    public partial class AddCustomerFrm : Form
    {
        public AddCustomerFrm()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            {
                API api = new API();

                CustDgvShow.DataSource = api.LoadData("Customer");
                ((DataGridViewImageColumn)CustDgvShow.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Zoom;

                txtCustId.Text = api.GetNewId("Customer");

                btnEdit.Enabled = false;

                btnSave.Text = "ບັນທຶກ";

                String[] headerText = { "ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເລກຮູບ","ຮູບ" };
                for (int i = 0; i <= headerText.Length - 1; i++)
                {
                    CustDgvShow.Columns[i].HeaderText = headerText[i];
                }

                this.ActiveControl = txtCustName;
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

        private void EnterTextbox(KeyEventArgs e, TextBox textBox)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox.Focus();
            }
        }

        private void AddCustomerFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            API api = new API();
            if (PicImg.Image == null || PicImg == null)
            {
                MessageBox.Show("ກະລຸນາເລືອກຮູບກ່ອນບັນທຶກ !!!");
            }
            else
            {
                if (btnEdit.Enabled == true)
                {
                    btnSave.Text = "ບັນທຶກ";
                    btnEdit.Enabled = false;
                }
                else
                {
                    try
                    {
                        api.InsertCustomer(
                            txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                            txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text,
                            api.ConvertImageToByte(PicImg)
                        );

                        MessageBox.Show("SUCCESS");
                        ClearCustForm();
                        LoadForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void CustDgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEdit.Enabled = true;
            btnSave.Text = "ເພິ່ມລູກຄ້າໃໝ່";

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

                PanPawnDgv.Visible = true;
                panPawnFrmHerder.Visible = true;
                API api = new API();

                PawnDgvShow.DataSource = api.PawnSearchByCustomer(txtCustId.Text);

                String[] headerText = { "ລະຫັດ", "ວັນທີ", "ມື້ຫຼຸດຈຳນຳ", "ເລກເຄື່ອງ", "ຊື່ເຄື່ອງ", "ສີ", "ຈຳນວນເງິນ(ກີບ)", "ຈຳນວນເງິນ(ບາດ)", "ສະຖານະ", "ມື້ສົ່ງເຄື່ອງ", "ລະຫັດລ໋ອກເຄື່ອງ", "ລະຫັດຜູ້ມາຈຳ", "ລະຫັດຜູ້ມາເອົາເຄື່ອງ" };
                for (int i = 0; i <= headerText.Length - 1; i++)
                {
                    PawnDgvShow.Columns[i].HeaderText = headerText[i];
                }

                try
                {
                    var imgByte = (Byte[])(CustDgvShow.Rows[e.RowIndex].Cells[8].Value);
                    MemoryStream memoryStream = new MemoryStream(imgByte);
                    PicImg.Image = Image.FromStream(memoryStream);
                }
                
                catch
                {

                }

                //if picture box is not empty:
                if(PicImg.Image == null || PicImg==null)
                {
                    btnReSaveImage.Visible = false;
                }
                else
                {
                    btnReSaveImage.Visible = true;
                }
            }
            catch
            {

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            API api = new API();
            if (PicImg.Image == null || PicImg == null)
            {
                MessageBox.Show("ກະລຸນາເລືອກຮູບກ່ອນບັນທຶກ !!!");
            }
            else
            {
                try
                {
                    api.UpdateCustomer(
                        txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                        txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text,
                        api.ConvertImageToByte(PicImg)
                    );
                    MessageBox.Show("SUCCESS");
                    ClearCustForm();
                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtCustName_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtCustLastName);
        }

        private void txtCustLastName_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtTel);
        }

        private void txtTel_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtVill);
        }

        private void txtVill_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtDist);
        }

        private void txtDist_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtProv);
        }

        private void txtProv_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtImgNo);
        }

        private void btnImgChoose_Click_1(object sender, EventArgs e)
        {
            CameraFrm cameraFrm = new CameraFrm();
            cameraFrm.Show();
            cameraFrm.FormClosed += returnImageFrm;
        }
        private void returnImageFrm(object sender, EventArgs e)
        {
            CameraFrm cameraFrm = (CameraFrm)sender;
            if (cameraFrm.returnPictureBox != null)
            {
                PicImg.Image = (Bitmap)cameraFrm.returnPictureBox.Image;
            }
        }

        private void btnCustSearch_Click(object sender, EventArgs e)
        {
            API api = new API();

            CustDgvShow.DataSource = api.CustomerSearch(txtCustSearch.Text);
            ((DataGridViewImageColumn)CustDgvShow.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnReSaveImage_Click_1(object sender, EventArgs e)
        {
            using (var fbd = new SaveFileDialog())
            {
                fbd.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|All files (*.*)|*.*";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        PicImg.Image.Save(fbd.FileName);
                        MessageBox.Show("Success...");
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
