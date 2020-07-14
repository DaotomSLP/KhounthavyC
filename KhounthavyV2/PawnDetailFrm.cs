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
    public partial class PawnDetailFrm : Form
    {
        public PawnDetailFrm()
        {
            InitializeComponent();
        }

        public void LoadForm()
        {
            API api = new API();

            PawnDgvShow.DataSource = api.LoadData("Pawn");

            String[] headerText = { "ລະຫັດ", "ວັນທີ", "ມື້ຫຼຸດຈຳນຳ", "ເລກເຄື່ອງ", "ຊື່ເຄື່ອງ", "ສີ", "ຈຳນວນເງິນ(ກີບ)", "ຈຳນວນເງິນ(ບາດ)", "ສະຖານະ", "ມື້ສົ່ງເຄື່ອງ", "ລະຫັດລ໋ອກເຄື່ອງ", "ລະຫັດຮູບຜູ້ມາເອົາເຄື່ອງ" };
            for (int i = 0; i <= headerText.Length - 1; i++)
            {
                PawnDgvShow.Columns[i].HeaderText = headerText[i];
            }

            this.ActiveControl = txtPawnSearch;
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
            //API api = new API();
            //DataTable dt;
            //dt = api.LoadCustomerFromPawn(PawnDgvShow.Rows[e.RowIndex].Cells[0].Value.ToString());
            //foreach (DataRow row in dt.Rows)
            //{
            //    txtCustId.Text = row[0].ToString();
            //    txtCustName.Text = row[1].ToString();
            //    txtCustLastName.Text = row[2].ToString();
            //    txtTel.Text = row[3].ToString();
            //    txtVill.Text = row[4].ToString();
            //    txtDist.Text = row[5].ToString();
            //    txtProv.Text = row[6].ToString();
            //    txtImgNo.Text = row[7].ToString();
            //}
        }

        private void PawnDetailFrm_Load(object sender, EventArgs e)
        {
            //LoadForm();
        }

        private void PawnDetailFrm_Resize(object sender, EventArgs e)
        {
            this.ActiveControl = txtPawnSearch;
        }
    }
}
