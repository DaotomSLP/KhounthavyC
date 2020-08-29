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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void btnImgChoose_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    String filePath = openFileDialog.FileName;
                    txtImgPath.Text = filePath;

                    try
                    {
                        PicImg.Image = Image.FromFile(filePath);
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
