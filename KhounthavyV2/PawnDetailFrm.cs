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
    public partial class PawnDetailFrm : Form
    {
        public PawnDetailFrm()
        {
            InitializeComponent();
        }

        private String cust_id="";
        private String khon_ma_ao="";

        public void LoadForm()
        {
            API api = new API();

            PawnDgvShow.DataSource = api.LoadData("Pawn");

            String[] headerText = { "ລະຫັດ", "ວັນທີ", "ມື້ຫຼຸດຈຳນຳ", "ເລກເຄື່ອງ", "ຊື່ເຄື່ອງ", "ສີ", "ຈຳນວນເງິນ(ກີບ)", "ຈຳນວນເງິນ(ບາດ)", "ສະຖານະ", "ມື້ສົ່ງເຄື່ອງ", "ລະຫັດລ໋ອກເຄື່ອງ", "ລະຫັດຜູ້ມາຈຳ", "ລະຫັດຜູ້ມາເອົາເຄື່ອງ", "ປະເພດເຄື່ອງ" };
            for (int i = 0; i <= headerText.Length - 1; i++)
            {
                PawnDgvShow.Columns[i].HeaderText = headerText[i];
            }

            this.ActiveControl = txtPawnSearch;
        }

        private void ShowCustomerByPawn(String id){
            API api = new API();
            DataTable dt;
            dt = api.LoadCustomerFromPawn(id);
            foreach (DataRow row in dt.Rows)
            {
                txtCustId.Text = row[0].ToString();
                txtCustName.Text = row[1].ToString();
                txtCustLastName.Text = row[2].ToString();
                txtTel.Text = row[3].ToString();
                txtVill.Text = row[4].ToString();
                txtDist.Text = row[5].ToString();
                txtProv.Text = row[6].ToString();

                PicImg.Image = null;

                try
                {
                    var imgByte = (Byte[])(row[7]);
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
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            API api = new API();
            
            PawnDgvShow.DataSource = api.SearchPawnByDate(txtPawnSearch.Text, dtpStart.Value.ToString(), dtpEnd.Value.ToString());
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            API api = new API();

            PawnDgvShow.DataSource = api.SearchPawnByDate(txtPawnSearch.Text, dtpStart.Value.ToString(), dtpEnd.Value.ToString());
        }

        private void btnPawnSearch_Click(object sender, EventArgs e)
        {
            API api = new API();
            PawnDgvShow.DataSource = api.PawnSearch(txtPawnSearch.Text);
        }

        private void PawnDgvShow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(PawnDgvShow.Rows[e.RowIndex].Cells[12].Value.ToString() != "")
            {
                radPhuJam.Visible = true;
                radPhuMaAo.Visible = true;
            }
            else
            {
                radPhuJam.Visible = false;
                radPhuMaAo.Visible = false;
            }

            cust_id = PawnDgvShow.Rows[e.RowIndex].Cells[11].Value.ToString();
            khon_ma_ao = PawnDgvShow.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtPawnId.Text = PawnDgvShow.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtColor.Text = PawnDgvShow.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtDevicePassword.Text = PawnDgvShow.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtKip.Text = PawnDgvShow.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtBath.Text = PawnDgvShow.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDeviceName.Text = PawnDgvShow.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtDeviceNo.Text = PawnDgvShow.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtpExp.Value = Convert.ToDateTime(PawnDgvShow.Rows[e.RowIndex].Cells[2].Value.ToString());
            dtpDate.Value = Convert.ToDateTime(PawnDgvShow.Rows[e.RowIndex].Cells[1].Value.ToString());
            cboDeviceType.SelectedItem = PawnDgvShow.Rows[e.RowIndex].Cells[13].Value.ToString() == ""? "ໂທລະສັບ" : PawnDgvShow.Rows[e.RowIndex].Cells[13].Value.ToString();

            Program.Pawn_id = PawnDgvShow.Rows[e.RowIndex].Cells[0].Value.ToString();

            ShowCustomerByPawn(cust_id);

        }

        private void PawnDetailFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void PawnDetailFrm_Resize(object sender, EventArgs e)
        {
            this.ActiveControl = txtPawnSearch;
        }

        private void btnReSaveImage_Click(object sender, EventArgs e)
        {
            API api = new API();
            api.ReSaveImage(PicImg);
        }

        private void radPhuJam_CheckedChanged(object sender, EventArgs e)
        {
            ShowCustomerByPawn(cust_id);
        }

        private void radPhuMaAo_CheckedChanged(object sender, EventArgs e)
        {
            ShowCustomerByPawn(khon_ma_ao);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            API api = new API();
            try
            {
                api.UpdatePawn(txtPawnId.Text, txtDeviceName.Text, txtColor.Text, txtDeviceNo.Text, txtDevicePassword.Text, txtKip.Text, txtBath.Text, dtpDate, dtpExp, cboDeviceType.SelectedItem.ToString());
                MessageBox.Show("Success");
            }
            catch
            {
                MessageBox.Show("error");
            }

            PawnDgvShow.DataSource = api.LoadData("Pawn");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            API api = new API();
            api.DeletePawn(txtPawnId.Text);
            MessageBox.Show("Success");
            PawnDgvShow.DataSource = api.LoadData("Pawn");

        }
    }
}
