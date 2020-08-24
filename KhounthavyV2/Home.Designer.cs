namespace KhounthavyV2
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuAddNewPawn = new System.Windows.Forms.Button();
            this.btnMenuCustomer = new System.Windows.Forms.Button();
            this.btnMenuPawnDetail = new System.Windows.Forms.Button();
            this.btnMenuSetting = new System.Windows.Forms.Button();
            this.panLogin = new System.Windows.Forms.Panel();
            this.lblServername = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnDatabaseSetting = new System.Windows.Forms.Button();
            this.btnSaveConnStr = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnMenuTurnBack = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 90);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.MenuPanel.Controls.Add(this.btnMenuTurnBack);
            this.MenuPanel.Controls.Add(this.btnMenuSetting);
            this.MenuPanel.Controls.Add(this.btnMenuPawnDetail);
            this.MenuPanel.Controls.Add(this.btnMenuCustomer);
            this.MenuPanel.Controls.Add(this.btnMenuAddNewPawn);
            this.MenuPanel.Controls.Add(this.label1);
            this.MenuPanel.Controls.Add(this.pictureBox1);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1352, 90);
            this.MenuPanel.TabIndex = 0;
            this.MenuPanel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KhounthavyV2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຮ້ານຄູນທະວີ";
            // 
            // btnMenuAddNewPawn
            // 
            this.btnMenuAddNewPawn.BackColor = System.Drawing.SystemColors.Control;
            this.btnMenuAddNewPawn.FlatAppearance.BorderSize = 0;
            this.btnMenuAddNewPawn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuAddNewPawn.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuAddNewPawn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMenuAddNewPawn.Location = new System.Drawing.Point(92, 54);
            this.btnMenuAddNewPawn.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuAddNewPawn.Name = "btnMenuAddNewPawn";
            this.btnMenuAddNewPawn.Size = new System.Drawing.Size(229, 36);
            this.btnMenuAddNewPawn.TabIndex = 2;
            this.btnMenuAddNewPawn.Text = "ເພີ່ມການຈຳນຳ";
            this.btnMenuAddNewPawn.UseVisualStyleBackColor = false;
            this.btnMenuAddNewPawn.Click += new System.EventHandler(this.btnMenuAddNewPawn_Click);
            // 
            // btnMenuCustomer
            // 
            this.btnMenuCustomer.BackColor = System.Drawing.Color.Black;
            this.btnMenuCustomer.FlatAppearance.BorderSize = 0;
            this.btnMenuCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCustomer.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuCustomer.Location = new System.Drawing.Point(325, 54);
            this.btnMenuCustomer.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuCustomer.Name = "btnMenuCustomer";
            this.btnMenuCustomer.Size = new System.Drawing.Size(229, 36);
            this.btnMenuCustomer.TabIndex = 2;
            this.btnMenuCustomer.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.btnMenuCustomer.UseVisualStyleBackColor = false;
            this.btnMenuCustomer.Click += new System.EventHandler(this.btnMenuCustomer_Click);
            // 
            // btnMenuPawnDetail
            // 
            this.btnMenuPawnDetail.BackColor = System.Drawing.Color.Black;
            this.btnMenuPawnDetail.FlatAppearance.BorderSize = 0;
            this.btnMenuPawnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPawnDetail.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPawnDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuPawnDetail.Location = new System.Drawing.Point(558, 54);
            this.btnMenuPawnDetail.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuPawnDetail.Name = "btnMenuPawnDetail";
            this.btnMenuPawnDetail.Size = new System.Drawing.Size(229, 36);
            this.btnMenuPawnDetail.TabIndex = 2;
            this.btnMenuPawnDetail.Text = "ຂໍ້ມູນການຈຳນຳ";
            this.btnMenuPawnDetail.UseVisualStyleBackColor = false;
            this.btnMenuPawnDetail.Click += new System.EventHandler(this.btnMenuPawnDetail_Click);
            // 
            // btnMenuSetting
            // 
            this.btnMenuSetting.BackColor = System.Drawing.Color.Black;
            this.btnMenuSetting.FlatAppearance.BorderSize = 0;
            this.btnMenuSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSetting.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuSetting.Location = new System.Drawing.Point(1024, 54);
            this.btnMenuSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuSetting.Name = "btnMenuSetting";
            this.btnMenuSetting.Size = new System.Drawing.Size(229, 36);
            this.btnMenuSetting.TabIndex = 2;
            this.btnMenuSetting.Text = "ຕັ້ງຄ່າ";
            this.btnMenuSetting.UseVisualStyleBackColor = false;
            this.btnMenuSetting.Click += new System.EventHandler(this.btnMenuSetting_Click);
            // 
            // panLogin
            // 
            this.panLogin.Controls.Add(this.lblServername);
            this.panLogin.Controls.Add(this.txtServerName);
            this.panLogin.Controls.Add(this.btnDatabaseSetting);
            this.panLogin.Controls.Add(this.btnSaveConnStr);
            this.panLogin.Controls.Add(this.btnLogin);
            this.panLogin.Controls.Add(this.label6);
            this.panLogin.Controls.Add(this.label2);
            this.panLogin.Controls.Add(this.label10);
            this.panLogin.Controls.Add(this.txtPass);
            this.panLogin.Controls.Add(this.txtUserName);
            this.panLogin.Location = new System.Drawing.Point(224, 161);
            this.panLogin.Name = "panLogin";
            this.panLogin.Size = new System.Drawing.Size(853, 458);
            this.panLogin.TabIndex = 3;
            // 
            // lblServername
            // 
            this.lblServername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblServername.BackColor = System.Drawing.Color.Transparent;
            this.lblServername.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServername.Location = new System.Drawing.Point(234, 339);
            this.lblServername.Name = "lblServername";
            this.lblServername.Size = new System.Drawing.Size(367, 26);
            this.lblServername.TabIndex = 65;
            this.lblServername.Text = "Server Name :";
            this.lblServername.Visible = false;
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtServerName.ForeColor = System.Drawing.Color.Green;
            this.txtServerName.Location = new System.Drawing.Point(236, 368);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(365, 31);
            this.txtServerName.TabIndex = 64;
            this.txtServerName.Visible = false;
            // 
            // btnDatabaseSetting
            // 
            this.btnDatabaseSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatabaseSetting.BackColor = System.Drawing.Color.Black;
            this.btnDatabaseSetting.FlatAppearance.BorderSize = 0;
            this.btnDatabaseSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaseSetting.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatabaseSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatabaseSetting.Location = new System.Drawing.Point(238, 285);
            this.btnDatabaseSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnDatabaseSetting.Name = "btnDatabaseSetting";
            this.btnDatabaseSetting.Size = new System.Drawing.Size(365, 33);
            this.btnDatabaseSetting.TabIndex = 61;
            this.btnDatabaseSetting.Text = "Database Connect Setting";
            this.btnDatabaseSetting.UseVisualStyleBackColor = false;
            // 
            // btnSaveConnStr
            // 
            this.btnSaveConnStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveConnStr.BackColor = System.Drawing.Color.Black;
            this.btnSaveConnStr.FlatAppearance.BorderSize = 0;
            this.btnSaveConnStr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConnStr.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConnStr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveConnStr.Location = new System.Drawing.Point(236, 415);
            this.btnSaveConnStr.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveConnStr.Name = "btnSaveConnStr";
            this.btnSaveConnStr.Size = new System.Drawing.Size(365, 33);
            this.btnSaveConnStr.TabIndex = 62;
            this.btnSaveConnStr.Text = "Save";
            this.btnSaveConnStr.UseVisualStyleBackColor = false;
            this.btnSaveConnStr.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(238, 236);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(365, 33);
            this.btnLogin.TabIndex = 63;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(236, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 26);
            this.label6.TabIndex = 58;
            this.label6.Text = "Password :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(232, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 55);
            this.label2.TabIndex = 59;
            this.label2.Text = "Login";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(236, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(367, 26);
            this.label10.TabIndex = 60;
            this.label10.Text = "User name :";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtPass.ForeColor = System.Drawing.Color.Green;
            this.txtPass.Location = new System.Drawing.Point(238, 187);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(365, 31);
            this.txtPass.TabIndex = 56;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtUserName.ForeColor = System.Drawing.Color.Green;
            this.txtUserName.Location = new System.Drawing.Point(238, 115);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(365, 31);
            this.txtUserName.TabIndex = 57;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // btnMenuTurnBack
            // 
            this.btnMenuTurnBack.BackColor = System.Drawing.Color.Black;
            this.btnMenuTurnBack.FlatAppearance.BorderSize = 0;
            this.btnMenuTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTurnBack.Font = new System.Drawing.Font("Phetsarath OT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTurnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuTurnBack.Location = new System.Drawing.Point(791, 54);
            this.btnMenuTurnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnMenuTurnBack.Name = "btnMenuTurnBack";
            this.btnMenuTurnBack.Size = new System.Drawing.Size(229, 36);
            this.btnMenuTurnBack.TabIndex = 3;
            this.btnMenuTurnBack.Text = "ສົ່ງເຄື່ອງຄືນ";
            this.btnMenuTurnBack.UseVisualStyleBackColor = false;
            this.btnMenuTurnBack.Click += new System.EventHandler(this.btnMenuTurnBack_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 717);
            this.Controls.Add(this.panLogin);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khounthavy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddNewPawn_Load);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panLogin.ResumeLayout(false);
            this.panLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.Panel MenuPanel;
        internal System.Windows.Forms.Button btnMenuSetting;
        internal System.Windows.Forms.Button btnMenuPawnDetail;
        internal System.Windows.Forms.Button btnMenuCustomer;
        internal System.Windows.Forms.Button btnMenuAddNewPawn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panLogin;
        internal System.Windows.Forms.Label lblServername;
        internal System.Windows.Forms.TextBox txtServerName;
        internal System.Windows.Forms.Button btnDatabaseSetting;
        internal System.Windows.Forms.Button btnSaveConnStr;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.TextBox txtUserName;
        internal System.Windows.Forms.Button btnMenuTurnBack;
    }
}

