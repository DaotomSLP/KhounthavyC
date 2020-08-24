namespace KhounthavyV2
{
    partial class TurnBackFrm
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
            this.lbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImgNo = new System.Windows.Forms.TextBox();
            this.txtPawnId = new System.Windows.Forms.TextBox();
            this.btnTurnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(187, 178);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(576, 26);
            this.lbl.TabIndex = 30;
            this.lbl.Text = "ເລກຮູບຜູ້ມາເອົາ :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(187, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(576, 26);
            this.label9.TabIndex = 31;
            this.label9.Text = "ລະຫັດ :";
            // 
            // txtImgNo
            // 
            this.txtImgNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImgNo.BackColor = System.Drawing.Color.White;
            this.txtImgNo.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtImgNo.ForeColor = System.Drawing.Color.Green;
            this.txtImgNo.Location = new System.Drawing.Point(189, 207);
            this.txtImgNo.Margin = new System.Windows.Forms.Padding(0);
            this.txtImgNo.Name = "txtImgNo";
            this.txtImgNo.Size = new System.Drawing.Size(574, 31);
            this.txtImgNo.TabIndex = 29;
            this.txtImgNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtImgNo_KeyDown);
            // 
            // txtPawnId
            // 
            this.txtPawnId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPawnId.BackColor = System.Drawing.Color.White;
            this.txtPawnId.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold);
            this.txtPawnId.ForeColor = System.Drawing.Color.Green;
            this.txtPawnId.Location = new System.Drawing.Point(189, 129);
            this.txtPawnId.Margin = new System.Windows.Forms.Padding(0);
            this.txtPawnId.Name = "txtPawnId";
            this.txtPawnId.Size = new System.Drawing.Size(574, 31);
            this.txtPawnId.TabIndex = 28;
            this.txtPawnId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPawnId_KeyDown);
            // 
            // btnTurnBack
            // 
            this.btnTurnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTurnBack.BackColor = System.Drawing.Color.Black;
            this.btnTurnBack.FlatAppearance.BorderSize = 0;
            this.btnTurnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnBack.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTurnBack.Location = new System.Drawing.Point(189, 268);
            this.btnTurnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurnBack.Name = "btnTurnBack";
            this.btnTurnBack.Size = new System.Drawing.Size(574, 39);
            this.btnTurnBack.TabIndex = 64;
            this.btnTurnBack.Text = "ສົ່ງເຄື່ອງ";
            this.btnTurnBack.UseVisualStyleBackColor = false;
            this.btnTurnBack.Click += new System.EventHandler(this.btnTurnBack_Click);
            // 
            // TurnBackFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.btnTurnBack);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtImgNo);
            this.Controls.Add(this.txtPawnId);
            this.Name = "TurnBackFrm";
            this.Text = "TurnBackFrm";
            this.Load += new System.EventHandler(this.TurnBackFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtImgNo;
        internal System.Windows.Forms.TextBox txtPawnId;
        internal System.Windows.Forms.Button btnTurnBack;
    }
}