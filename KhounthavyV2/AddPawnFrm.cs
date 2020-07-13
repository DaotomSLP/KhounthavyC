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
    public partial class AddPawnFrm : Form
    {
        public AddPawnFrm()
        {
            InitializeComponent();
        }

        private void ClearCustForm()
        {
            try
            {
                foreach (Control control in this.panCustForm.Controls)
                {
                    if(control is TextBox)
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
                foreach(Control control in this.panCustForm.Controls)
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

            }
            catch
            {

            }
       
        }

        private void LoadForm()
        {
            API api = new API();

            CustDgvShow.DataSource = api.LoadData("Customer");

            txtPawnId.Text = api.GetNewId("Pawn");
            txtCustId.Text = api.GetNewId("Customer");

            

            cboDeviceType.SelectedItem = "ໂທລະສັບ";

            String[] headerText = { "ລະຫັດລູກຄ້າ", "ຊື່", "ນາມສະກຸນ", "ເບີໂທ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ຮູບ" };
            for (int i = 0; i <= headerText.Length - 1; i++)
            {
                CustDgvShow.Columns[i].HeaderText = headerText[i];
            }
        }

        private void AddPawnFrm_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            API api = new API();
            try
            {
                if(radNewCust.Checked == true)
                {
                    api.InsertCustomer(
                        txtCustId.Text, txtCustName.Text, txtCustLastName.Text, txtTel.Text,
                        txtVill.Text, txtDist.Text, txtProv.Text, txtImgNo.Text
                    );
                }



                api.InsertPawn(
                    txtPawnId.Text, dtpDate, txtDeviceNo.Text, txtDeviceName.Text, txtColor.Text,
                    txtKip.Text, txtBath.Text, dtpExp, txtCustId.Text, API.Current_user, "", "",
                    txtDevicePassword.Text, "", cboDeviceType.SelectedItem.ToString()
                    );

                MessageBox.Show("SUCCESS");
                LoadForm();
            }
            catch (Exception ex)
            {
                //api.DeleteCustomer(txtCustId.Text);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
