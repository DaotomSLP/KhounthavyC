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

                txtCustId.Text = api.GetNewId("Customer");

                btnEdit.Enabled = false;

                btnSave.Text = "ບັນທຶກ";

                String[] headerText = { "ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ຮູບ" };
                for (int i = 0; i <= headerText.Length - 1; i++)
                {
                    CustDgvShow.Columns[i].HeaderText = headerText[i];
                }

                this.ActiveControl = txtCustName;
            }
        }

        private void AddCustomerFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(btnEdit.Enabled == true)
            {
                btnSave.Text = "ບັນທຶກ";
                btnEdit.Enabled = false;
            }
            else
            {
                API api = new API();
                try
                {
                    api.InsertCustomer(
                        txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                        txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text
                    );

                    MessageBox.Show("SUCCESS");
                    LoadForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

            }
            catch
            {

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            API api = new API();

            try
            {
                api.UpdateCustomer(
                    txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                    txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text
                );
                MessageBox.Show("SUCCESS");
                LoadForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
