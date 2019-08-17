namespace QuanLyBanHang
{
    partial class frmLoaiSP
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
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.cboMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.lbLoaiSP = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvShowLoaiSP = new System.Windows.Forms.DataGridView();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Location = new System.Drawing.Point(65, 172);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(90, 13);
            this.lbMaLoaiSP.TabIndex = 0;
            this.lbMaLoaiSP.Text = "Mã loại sản phẩm";
            // 
            // cboMaLoaiSP
            // 
            this.cboMaLoaiSP.FormattingEnabled = true;
            this.cboMaLoaiSP.Location = new System.Drawing.Point(186, 169);
            this.cboMaLoaiSP.Name = "cboMaLoaiSP";
            this.cboMaLoaiSP.Size = new System.Drawing.Size(121, 21);
            this.cboMaLoaiSP.TabIndex = 1;
            this.cboMaLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboMaLoaiSP_SelectedIndexChanged);
            // 
            // lbLoaiSP
            // 
            this.lbLoaiSP.AutoSize = true;
            this.lbLoaiSP.Location = new System.Drawing.Point(65, 204);
            this.lbLoaiSP.Name = "lbLoaiSP";
            this.lbLoaiSP.Size = new System.Drawing.Size(78, 13);
            this.lbLoaiSP.TabIndex = 2;
            this.lbLoaiSP.Text = "Loại Sản phẩm";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(186, 201);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(121, 20);
            this.txtLoaiSP.TabIndex = 3;
            this.txtLoaiSP.TextChanged += new System.EventHandler(this.txtLoaiSP_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(452, 169);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(261, 70);
            this.txtGhiChu.TabIndex = 5;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(372, 172);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 4;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Danh sách loại sản phẩm";
            // 
            // dgvShowLoaiSP
            // 
            this.dgvShowLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowLoaiSP.Location = new System.Drawing.Point(118, 314);
            this.dgvShowLoaiSP.Name = "dgvShowLoaiSP";
            this.dgvShowLoaiSP.Size = new System.Drawing.Size(573, 149);
            this.dgvShowLoaiSP.TabIndex = 8;
            this.dgvShowLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowLoaiSP_CellClick);
            this.dgvShowLoaiSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowLoaiSP_CellContentClick);
            this.dgvShowLoaiSP.Click += new System.EventHandler(this.dgvShowLoaiSP_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Far;
            this.separatorControl1.Location = new System.Drawing.Point(211, 97);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(385, 23);
            this.separatorControl1.TabIndex = 13;
            this.separatorControl1.Click += new System.EventHandler(this.separatorControl1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(336, 12);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(255, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(174, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(93, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(12, 12);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 16;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // frmLoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 506);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.dgvShowLoaiSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.lbGhiChu);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.lbLoaiSP);
            this.Controls.Add(this.cboMaLoaiSP);
            this.Controls.Add(this.lbMaLoaiSP);
            this.Name = "frmLoaiSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.ComboBox cboMaLoaiSP;
        private System.Windows.Forms.Label lbLoaiSP;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvShowLoaiSP;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTao;
    }
}