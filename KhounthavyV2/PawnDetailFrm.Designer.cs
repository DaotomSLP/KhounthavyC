namespace KhounthavyV2
{
    partial class PawnDetailFrm
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
            this.panCustSearchHeader = new System.Windows.Forms.Panel();
            this.btnCustSearch = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCustSearch = new System.Windows.Forms.TextBox();
            this.Pan_CustDgv = new System.Windows.Forms.Panel();
            this.CustDgvShow = new System.Windows.Forms.DataGridView();
            this.panCustSearchHeader.SuspendLayout();
            this.Pan_CustDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustDgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // panCustSearchHeader
            // 
            this.panCustSearchHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panCustSearchHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panCustSearchHeader.Controls.Add(this.btnCustSearch);
            this.panCustSearchHeader.Controls.Add(this.Label1);
            this.panCustSearchHeader.Controls.Add(this.txtCustSearch);
            this.panCustSearchHeader.Location = new System.Drawing.Point(48, 37);
            this.panCustSearchHeader.Name = "panCustSearchHeader";
            this.panCustSearchHeader.Size = new System.Drawing.Size(1268, 61);
            this.panCustSearchHeader.TabIndex = 31;
            // 
            // btnCustSearch
            // 
            this.btnCustSearch.BackColor = System.Drawing.Color.Black;
            this.btnCustSearch.FlatAppearance.BorderSize = 0;
            this.btnCustSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustSearch.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustSearch.Location = new System.Drawing.Point(423, 12);
            this.btnCustSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnCustSearch.Name = "btnCustSearch";
            this.btnCustSearch.Size = new System.Drawing.Size(122, 33);
            this.btnCustSearch.TabIndex = 4;
            this.btnCustSearch.Text = "ຄົ້ນຫາ";
            this.btnCustSearch.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(13, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(147, 23);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "ຄົ້ນຫາຂໍ້ມູນລູກຄ້າ :";
            // 
            // txtCustSearch
            // 
            this.txtCustSearch.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSearch.Location = new System.Drawing.Point(166, 14);
            this.txtCustSearch.Name = "txtCustSearch";
            this.txtCustSearch.Size = new System.Drawing.Size(254, 31);
            this.txtCustSearch.TabIndex = 3;
            // 
            // Pan_CustDgv
            // 
            this.Pan_CustDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pan_CustDgv.AutoScroll = true;
            this.Pan_CustDgv.BackColor = System.Drawing.Color.White;
            this.Pan_CustDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pan_CustDgv.Controls.Add(this.CustDgvShow);
            this.Pan_CustDgv.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Pan_CustDgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(23)))));
            this.Pan_CustDgv.Location = new System.Drawing.Point(48, 98);
            this.Pan_CustDgv.Name = "Pan_CustDgv";
            this.Pan_CustDgv.Size = new System.Drawing.Size(1268, 592);
            this.Pan_CustDgv.TabIndex = 30;
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
            this.CustDgvShow.Enabled = false;
            this.CustDgvShow.Location = new System.Drawing.Point(3, 10);
            this.CustDgvShow.MultiSelect = false;
            this.CustDgvShow.Name = "CustDgvShow";
            this.CustDgvShow.ReadOnly = true;
            this.CustDgvShow.RowHeadersWidth = 40;
            this.CustDgvShow.RowTemplate.Height = 40;
            this.CustDgvShow.Size = new System.Drawing.Size(1262, 579);
            this.CustDgvShow.TabIndex = 0;
            // 
            // PawnDetailFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1350, 717);
            this.Controls.Add(this.panCustSearchHeader);
            this.Controls.Add(this.Pan_CustDgv);
            this.Name = "PawnDetailFrm";
            this.Text = "PawnDetailFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panCustSearchHeader.ResumeLayout(false);
            this.panCustSearchHeader.PerformLayout();
            this.Pan_CustDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustDgvShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panCustSearchHeader;
        internal System.Windows.Forms.Button btnCustSearch;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtCustSearch;
        internal System.Windows.Forms.Panel Pan_CustDgv;
        internal System.Windows.Forms.DataGridView CustDgvShow;
    }
}