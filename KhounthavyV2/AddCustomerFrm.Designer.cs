namespace KhounthavyV2
{
    partial class AddCustomerFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panCustForm = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtImgNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVill = new System.Windows.Forms.TextBox();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            this.Pan_CustDgv = new System.Windows.Forms.Panel();
            this.CustDgvShow = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PicImg = new System.Windows.Forms.PictureBox();
            this.btnImgChoose = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtImgPath = new System.Windows.Forms.TextBox();
            this.btnReSaveImage = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.panCustForm.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.Pan_CustDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Sienna;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(179, 961);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 39);
            this.btnEdit.TabIndex = 38;
            this.btnEdit.Text = "ບັນທຶກການແກ້ໄຂ";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Sienna;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(30, 961);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 39);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "ບັນທຶກ";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.Controls.Add(this.panCustForm, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Pan_CustDgv, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(29, 32);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1283, 913);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // panCustForm
            // 
            this.panCustForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCustForm.BackColor = System.Drawing.Color.White;
            this.panCustForm.Controls.Add(this.PicImg);
            this.panCustForm.Controls.Add(this.btnReSaveImage);
            this.panCustForm.Controls.Add(this.btnImgChoose);
            this.panCustForm.Controls.Add(this.label11);
            this.panCustForm.Controls.Add(this.txtImgPath);
            this.panCustForm.Controls.Add(this.label21);
            this.panCustForm.Controls.Add(this.label20);
            this.panCustForm.Controls.Add(this.label3);
            this.panCustForm.Controls.Add(this.label12);
            this.panCustForm.Controls.Add(this.label4);
            this.panCustForm.Controls.Add(this.txtImgNo);
            this.panCustForm.Controls.Add(this.label8);
            this.panCustForm.Controls.Add(this.txtProv);
            this.panCustForm.Controls.Add(this.label5);
            this.panCustForm.Controls.Add(this.txtTel);
            this.panCustForm.Controls.Add(this.txtDist);
            this.panCustForm.Controls.Add(this.label7);
            this.panCustForm.Controls.Add(this.txtVill);
            this.panCustForm.Controls.Add(this.txtCustLastName);
            this.panCustForm.Controls.Add(this.txtCustName);
            this.panCustForm.Controls.Add(this.txtCustId);
            this.panCustForm.Location = new System.Drawing.Point(0, 61);
            this.panCustForm.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panCustForm.Name = "panCustForm";
            this.panCustForm.Size = new System.Drawing.Size(369, 852);
            this.panCustForm.TabIndex = 43;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(16, 584);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(336, 26);
            this.label21.TabIndex = 30;
            this.label21.Text = "ເລກທີ່ຮູູບ :";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(14, 509);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(336, 26);
            this.label20.TabIndex = 31;
            this.label20.Text = "ແຂວງ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 26);
            this.label3.TabIndex = 32;
            this.label3.Text = "ເບີໂທ :";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(14, 434);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(336, 26);
            this.label12.TabIndex = 33;
            this.label12.Text = "ເມືອງ :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 26);
            this.label4.TabIndex = 34;
            this.label4.Text = "ນາມສະກຸນ :";
            // 
            // txtImgNo
            // 
            this.txtImgNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgNo.BackColor = System.Drawing.Color.White;
            this.txtImgNo.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtImgNo.ForeColor = System.Drawing.Color.Green;
            this.txtImgNo.Location = new System.Drawing.Point(16, 613);
            this.txtImgNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtImgNo.Name = "txtImgNo";
            this.txtImgNo.Size = new System.Drawing.Size(334, 31);
            this.txtImgNo.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(14, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 26);
            this.label8.TabIndex = 35;
            this.label8.Text = "ບ້ານ :";
            // 
            // txtProv
            // 
            this.txtProv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProv.BackColor = System.Drawing.Color.White;
            this.txtProv.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtProv.ForeColor = System.Drawing.Color.Green;
            this.txtProv.Location = new System.Drawing.Point(16, 538);
            this.txtProv.Margin = new System.Windows.Forms.Padding(0);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(334, 31);
            this.txtProv.TabIndex = 23;
            this.txtProv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProv_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "ຊື່ລູກຄ້າ :";
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.BackColor = System.Drawing.Color.White;
            this.txtTel.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtTel.ForeColor = System.Drawing.Color.Green;
            this.txtTel.Location = new System.Drawing.Point(16, 313);
            this.txtTel.Margin = new System.Windows.Forms.Padding(0);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(334, 31);
            this.txtTel.TabIndex = 24;
            this.txtTel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTel_KeyDown);
            // 
            // txtDist
            // 
            this.txtDist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDist.BackColor = System.Drawing.Color.White;
            this.txtDist.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtDist.ForeColor = System.Drawing.Color.Green;
            this.txtDist.Location = new System.Drawing.Point(16, 463);
            this.txtDist.Margin = new System.Windows.Forms.Padding(0);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(334, 31);
            this.txtDist.TabIndex = 25;
            this.txtDist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDist_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(14, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(336, 26);
            this.label7.TabIndex = 37;
            this.label7.Text = "ລະຫັດລູກຄ້າ :";
            // 
            // txtVill
            // 
            this.txtVill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVill.BackColor = System.Drawing.Color.White;
            this.txtVill.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtVill.ForeColor = System.Drawing.Color.Green;
            this.txtVill.Location = new System.Drawing.Point(16, 388);
            this.txtVill.Margin = new System.Windows.Forms.Padding(0);
            this.txtVill.Name = "txtVill";
            this.txtVill.Size = new System.Drawing.Size(334, 31);
            this.txtVill.TabIndex = 27;
            this.txtVill.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVill_KeyDown);
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustLastName.BackColor = System.Drawing.Color.White;
            this.txtCustLastName.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtCustLastName.ForeColor = System.Drawing.Color.Green;
            this.txtCustLastName.Location = new System.Drawing.Point(16, 238);
            this.txtCustLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(334, 31);
            this.txtCustLastName.TabIndex = 26;
            this.txtCustLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustLastName_KeyDown);
            // 
            // txtCustName
            // 
            this.txtCustName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustName.BackColor = System.Drawing.Color.White;
            this.txtCustName.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtCustName.ForeColor = System.Drawing.Color.Green;
            this.txtCustName.Location = new System.Drawing.Point(16, 163);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(334, 31);
            this.txtCustName.TabIndex = 28;
            this.txtCustName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCustName_KeyDown);
            // 
            // txtCustId
            // 
            this.txtCustId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCustId.BackColor = System.Drawing.Color.White;
            this.txtCustId.Enabled = false;
            this.txtCustId.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtCustId.ForeColor = System.Drawing.Color.Green;
            this.txtCustId.Location = new System.Drawing.Point(16, 88);
            this.txtCustId.Margin = new System.Windows.Forms.Padding(0);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(334, 31);
            this.txtCustId.TabIndex = 29;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 61);
            this.panel5.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "ຂໍ້ມູນລູກຄ້າ :";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.btnCustSearch);
            this.panel7.Controls.Add(this.label19);
            this.panel7.Controls.Add(this.txtCustSearch);
            this.panel7.Location = new System.Drawing.Point(399, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(884, 61);
            this.panel7.TabIndex = 44;
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.BackColor = System.Drawing.Color.Black;
            this.btnCustSearch.FlatAppearance.BorderSize = 0;
            this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustSearch.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustSearch.Location = new System.Drawing.Point(479, 12);
            this.btnCustSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(122, 33);
            this.btnCustSearch.TabIndex = 4;
            this.btnCustSearch.Text = "ຄົ້ນຫາ";
            this.btnCustSearch.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(13, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(203, 23);
            this.label19.TabIndex = 2;
            this.label19.Text = "ຄົ້ນຫາຂໍ້ມູນລູກຄ້າ :";
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSearch.Location = new System.Drawing.Point(222, 13);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(254, 31);
            this.txtCustSearch.TabIndex = 3;
            // 
            // Pan_CustDgv
            // 
            this.Pan_CustDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pan_CustDgv.AutoScroll = true;
            this.Pan_CustDgv.BackColor = System.Drawing.Color.White;
            this.Pan_CustDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pan_CustDgv.Controls.Add(this.CustDgvShow);
            this.Pan_CustDgv.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Pan_CustDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.Pan_CustDgv.Location = new System.Drawing.Point(399, 61);
            this.Pan_CustDgv.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.Pan_CustDgv.Name = "Pan_CustDgv";
            this.Pan_CustDgv.Size = new System.Drawing.Size(884, 852);
            this.Pan_CustDgv.TabIndex = 45;
            // 
            // CustDgvShow
            // 
            this.CustDgvShow.AllowUserToAddRows = false;
            this.CustDgvShow.AllowUserToDeleteRows = false;
            this.CustDgvShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustDgvShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustDgvShow.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.CustDgvShow.BackgroundColor = System.Drawing.Color.White;
            this.CustDgvShow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustDgvShow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.CustDgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustDgvShow.Location = new System.Drawing.Point(3, 10);
            this.CustDgvShow.MultiSelect = false;
            this.CustDgvShow.Name = "CustDgvShow";
            this.CustDgvShow.ReadOnly = true;
            this.CustDgvShow.RowHeadersWidth = 40;
            this.CustDgvShow.RowTemplate.Height = 40;
            this.CustDgvShow.Size = new System.Drawing.Size(878, 839);
            this.CustDgvShow.TabIndex = 0;
            this.CustDgvShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustDgvShow_CellClick);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(369, 1009);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(72, 26);
            this.panel4.TabIndex = 40;
            // 
            // PicImg
            // 
            this.PicImg.Location = new System.Drawing.Point(15, 727);
            this.PicImg.Name = "PicImg";
            this.PicImg.Size = new System.Drawing.Size(130, 95);
            this.PicImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImg.TabIndex = 44;
            this.PicImg.TabStop = false;
            // 
            // btnImgChoose
            // 
            this.btnImgChoose.BackColor = System.Drawing.Color.Sienna;
            this.btnImgChoose.FlatAppearance.BorderSize = 0;
            this.btnImgChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImgChoose.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImgChoose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImgChoose.Location = new System.Drawing.Point(271, 691);
            this.btnImgChoose.Margin = new System.Windows.Forms.Padding(0);
            this.btnImgChoose.Name = "btnImgChoose";
            this.btnImgChoose.Size = new System.Drawing.Size(69, 31);
            this.btnImgChoose.TabIndex = 43;
            this.btnImgChoose.Text = "ເລືອກ";
            this.btnImgChoose.UseVisualStyleBackColor = false;
            this.btnImgChoose.Click += new System.EventHandler(this.btnImgChoose_Click);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(14, 662);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(327, 26);
            this.label11.TabIndex = 42;
            this.label11.Text = "ເລືອກຮູບ :";
            // 
            // txtImgPath
            // 
            this.txtImgPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgPath.BackColor = System.Drawing.Color.White;
            this.txtImgPath.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtImgPath.ForeColor = System.Drawing.Color.Green;
            this.txtImgPath.Location = new System.Drawing.Point(14, 691);
            this.txtImgPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(249, 31);
            this.txtImgPath.TabIndex = 41;
            // 
            // btnReSaveImage
            // 
            this.btnReSaveImage.BackColor = System.Drawing.Color.Sienna;
            this.btnReSaveImage.FlatAppearance.BorderSize = 0;
            this.btnReSaveImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReSaveImage.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReSaveImage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReSaveImage.Location = new System.Drawing.Point(163, 790);
            this.btnReSaveImage.Margin = new System.Windows.Forms.Padding(0);
            this.btnReSaveImage.Name = "btnReSaveImage";
            this.btnReSaveImage.Size = new System.Drawing.Size(187, 31);
            this.btnReSaveImage.TabIndex = 43;
            this.btnReSaveImage.Text = "ບັນທຶກຮູບຄືນ";
            this.btnReSaveImage.UseVisualStyleBackColor = false;
            this.btnReSaveImage.Visible = false;
            this.btnReSaveImage.Click += new System.EventHandler(this.btnReSaveImage_Click);
            // 
            // AddCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1367, 523);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Name = "AddCustomerFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ເພີ່ມລູກຄ້າ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddCustomerFrm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panCustForm.ResumeLayout(false);
            this.panCustForm.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.Pan_CustDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustDgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panCustForm;
        internal System.Windows.Forms.Label label21;
        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtImgNo;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtProv;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTel;
        internal System.Windows.Forms.TextBox txtDist;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtVill;
        internal System.Windows.Forms.TextBox txtCustLastName;
        internal System.Windows.Forms.TextBox txtCustName;
        internal System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.Panel panel5;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        internal System.Windows.Forms.Button btnCustSearch;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCustSearch;
        internal System.Windows.Forms.Panel Pan_CustDgv;
        internal System.Windows.Forms.DataGridView CustDgvShow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox PicImg;
        internal System.Windows.Forms.Button btnImgChoose;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtImgPath;
        internal System.Windows.Forms.Button btnReSaveImage;
    }
}