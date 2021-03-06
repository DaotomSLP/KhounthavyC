﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnBarcode.Barcode;
using OnBarcode.Barcode.RS2016;
using System.IO;

namespace KhounthavyV2
{
    public partial class AddPawnFrm : Form
    {
        public AddPawnFrm()
        {
            InitializeComponent();
        }

        private void ClearPawnForm()
        {
            try
            {
                foreach (Control control in this.panPawnFrm1.Controls)
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

            try
            {
                foreach (Control control in this.panPawnFrm2.Controls)
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

            try
            {
                foreach (Control control in this.panPawnFrm3.Controls)
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

        private void barcodeGenerate(String id)
        {
            LinearRS barcode = new LinearRS();
            barcode.Type = BarcodeType.CODE128;
            barcode.Data = id;
            barcode.drawBarcode(Directory.GetCurrentDirectory() + @"\barcode.jpg");
        }



        private void radOldCust_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radOldCust.Checked == true)
            {
                CustDgvShow.Enabled = true;
                LockCustForm();
            }
        }

        private void radNewCust_CheckedChanged_1(object sender, EventArgs e)
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


        private void LoadForm()
        {
            API api = new API();

            CustDgvShow.DataSource = api.LoadData("Customer");
            ((DataGridViewImageColumn)CustDgvShow.Columns[8]).ImageLayout = DataGridViewImageCellLayout.Zoom;

            txtPawnId.Text = api.GetNewId("Pawn");
            txtCustId.Text = api.GetNewId("Customer");
            cboDeviceType.SelectedItem = "ໂທລະສັບ";

            String[] headerText = { "ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເລກຮູບ","ເລກຮູບ" };
            for (int i = 0; i <= headerText.Length - 1; i++)
            {
                CustDgvShow.Columns[i].HeaderText = headerText[i];
            }

            this.ActiveControl = txtDeviceName;
        }

        private void EnterTextbox(KeyEventArgs e, TextBox textBox)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox.Focus();
            }
        }

        private void backUpDialog()
        {
            if (DateTime.Now.ToString("dd") == "28")
            {
                DialogResult dialogResult = MessageBox.Show("ຕ້ອງການ BackUp ຂໍ້ມູນຫຼືບໍ່ ??", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
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
                    catch
                    {
                        MessageBox.Show("Can't Backup");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
        }

        private void AddPawnFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
            backUpDialog();
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

                            api.InsertPawn(
                                txtPawnId.Text, dtpDate, txtDeviceNo.Text, txtDeviceName.Text, txtColor.Text,
                                txtKip.Text, txtBath.Text, dtpExp, txtCustId.Text, API.Current_user, "ຍັງບໍ່ມາເອົາ", "",
                                txtDevicePassword.Text, "", cboDeviceType.SelectedItem.ToString(), ""
                                );
                            barcodeGenerate(txtPawnId.Text);


                        try
                        {
                            api.InsertBarcodeImage();
                        }
                        catch
                        {
                            api.UpdateBarcodeImage();
                        }

                        PrintBill();

                        ClearCustForm();
                        ClearPawnForm();
                        radNewCust.Checked = true;
                        LoadForm();



                    }
                }
                else
                {
                    api.InsertPawn(
                        txtPawnId.Text, dtpDate, txtDeviceNo.Text, txtDeviceName.Text, txtColor.Text,
                        txtKip.Text, txtBath.Text, dtpExp, txtCustId.Text, API.Current_user, "ຍັງບໍ່ມາເອົາ", "",
                        txtDevicePassword.Text, "", cboDeviceType.SelectedItem.ToString(), ""
                        );
                    barcodeGenerate(txtPawnId.Text);


                    try
                    {
                        api.InsertBarcodeImage();
                    }
                    catch
                    {
                        api.UpdateBarcodeImage();
                    }
                    PrintBill();

                    ClearCustForm();
                    ClearPawnForm();
                    radNewCust.Checked = true;
                    LoadForm();



                }

            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }


        private void PrintBill()
        {
            PrintFrm print = new PrintFrm();

            DataTable dtb = new DataTable();
                API api = new API();
                dtb = api.LoadPawn(txtPawnId.Text);
                ReportDataSource rptsrc = new ReportDataSource("DataSet1", dtb);

                print.reportViewer1.LocalReport.DataSources.Clear();
                print.reportViewer1.LocalReport.DataSources.Add(rptsrc);

                print.reportViewer1.LocalReport.Refresh();
                print.Show();
            

        }

        private void CustDgvShow_CellClick(object sender, DataGridViewCellMouseEventArgs e)
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

                //if picture box is not empty:
                if (PicImg.Image == null || PicImg == null)
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

        private void txtDeviceName_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtDeviceNo);
        }

        private void txtDeviceNo_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtColor);
        }

        private void txtColor_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtKip);
        }

        private void txtKip_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtBath);
        }

        private void txtBath_KeyDown(object sender, KeyEventArgs e)
        {
            EnterTextbox(e, txtDevicePassword);
        }

        private void txtCustId_KeyDown(object sender, KeyEventArgs e)
        {

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

        private void btnImgChoose_Click(object sender, EventArgs e)
        {
           
                CameraFrm cameraFrm = new CameraFrm();
                cameraFrm.Show();
                cameraFrm.FormClosed += returnImageFrm;
    }

        private void returnImageFrm(object sender, EventArgs e)
        {
                CameraFrm cameraFrm = (CameraFrm)sender;
                if(cameraFrm.returnPictureBox != null)
                {
                    PicImg.Image = (Bitmap)cameraFrm.returnPictureBox.Image;
                }

        }

        private void btnReSaveImage_Click(object sender, EventArgs e)
        {
            API api = new API();
            api.ReSaveImage(PicImg);
        }

        private void panPawnFrm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panPawnFrmHerder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtKip_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double kip = Convert.ToDouble(txtKip.Text);
                txtKip.Text = String.Format("{0:0,0}", kip);
                txtKip.SelectionStart = txtKip.TextLength;
            }
            catch
            {

            }
        }

        private void txtBath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double bath = Convert.ToDouble(txtBath.Text);
                txtBath.Text = String.Format("{0:0,0}", bath);
                txtBath.SelectionStart = txtBath.TextLength;
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
