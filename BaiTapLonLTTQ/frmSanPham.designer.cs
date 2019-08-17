namespace QuanLyBanHang
{
    partial class frmSanPham
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
            this.cboMaSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXuatxu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxtMoTa = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.dgvShowSanPham = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.cboMaKho = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnXX = new System.Windows.Forms.RadioButton();
            this.rbtnTen = new System.Windows.Forms.RadioButton();
            this.rbtnMa = new System.Windows.Forms.RadioButton();
            this.lbTitleFind = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboMaSanPham
            // 
            this.cboMaSanPham.FormattingEnabled = true;
            this.cboMaSanPham.Location = new System.Drawing.Point(134, 54);
            this.cboMaSanPham.Name = "cboMaSanPham";
            this.cboMaSanPham.Size = new System.Drawing.Size(121, 21);
            this.cboMaSanPham.TabIndex = 1;
            this.cboMaSanPham.SelectedIndexChanged += new System.EventHandler(this.cboMaSanPham_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(134, 83);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(121, 20);
            this.txtTenSanPham.TabIndex = 4;
            this.txtTenSanPham.TextChanged += new System.EventHandler(this.txtTenSanPham_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại Sản phẩm";
            // 
            // txtXuatxu
            // 
            this.txtXuatxu.Location = new System.Drawing.Point(470, 83);
            this.txtXuatxu.Name = "txtXuatxu";
            this.txtXuatxu.Size = new System.Drawing.Size(121, 20);
            this.txtXuatxu.TabIndex = 8;
            this.txtXuatxu.TextChanged += new System.EventHandler(this.txtXuatxu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xuất xứ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kho chứa";
            // 
            // rtxtMoTa
            // 
            this.rtxtMoTa.Location = new System.Drawing.Point(470, 111);
            this.rtxtMoTa.Name = "rtxtMoTa";
            this.rtxtMoTa.Size = new System.Drawing.Size(206, 62);
            this.rtxtMoTa.TabIndex = 11;
            this.rtxtMoTa.Text = "";
            this.rtxtMoTa.TextChanged += new System.EventHandler(this.rtxtMoTa_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mô tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ghi chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(134, 146);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(210, 55);
            this.rtxtGhiChu.TabIndex = 15;
            this.rtxtGhiChu.Text = "";
            this.rtxtGhiChu.TextChanged += new System.EventHandler(this.rtxtGhiChu_TextChanged);
            // 
            // dgvShowSanPham
            // 
            this.dgvShowSanPham.AllowUserToAddRows = false;
            this.dgvShowSanPham.AllowUserToDeleteRows = false;
            this.dgvShowSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvShowSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowSanPham.Location = new System.Drawing.Point(20, 334);
            this.dgvShowSanPham.Name = "dgvShowSanPham";
            this.dgvShowSanPham.ReadOnly = true;
            this.dgvShowSanPham.Size = new System.Drawing.Size(740, 202);
            this.dgvShowSanPham.TabIndex = 16;
            this.dgvShowSanPham.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvShowSanPham_MouseDoubleClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quản lý sản phẩm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(667, 293);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(93, 35);
            this.btnTimKiem.TabIndex = 28;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(462, 224);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(93, 35);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(342, 224);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 35);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(217, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(93, 35);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(97, 224);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(93, 35);
            this.btnTao.TabIndex = 24;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(584, 224);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 35);
            this.btnHuy.TabIndex = 29;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(470, 51);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiSP.TabIndex = 30;
            this.cboLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_SelectedIndexChanged);
            // 
            // cboMaKho
            // 
            this.cboMaKho.FormattingEnabled = true;
            this.cboMaKho.Location = new System.Drawing.Point(134, 111);
            this.cboMaKho.Name = "cboMaKho";
            this.cboMaKho.Size = new System.Drawing.Size(121, 21);
            this.cboMaKho.TabIndex = 31;
            this.cboMaKho.SelectedIndexChanged += new System.EventHandler(this.cboMaKho_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnXX);
            this.groupBox1.Controls.Add(this.rbtnTen);
            this.groupBox1.Controls.Add(this.rbtnMa);
            this.groupBox1.Location = new System.Drawing.Point(314, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 42);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // rbtnXX
            // 
            this.rbtnXX.AutoSize = true;
            this.rbtnXX.Location = new System.Drawing.Point(225, 16);
            this.rbtnXX.Name = "rbtnXX";
            this.rbtnXX.Size = new System.Drawing.Size(89, 17);
            this.rbtnXX.TabIndex = 2;
            this.rbtnXX.TabStop = true;
            this.rbtnXX.Text = "Theo Xuất xứ";
            this.rbtnXX.UseVisualStyleBackColor = true;
            // 
            // rbtnTen
            // 
            this.rbtnTen.AutoSize = true;
            this.rbtnTen.Location = new System.Drawing.Point(115, 16);
            this.rbtnTen.Name = "rbtnTen";
            this.rbtnTen.Size = new System.Drawing.Size(89, 17);
            this.rbtnTen.TabIndex = 1;
            this.rbtnTen.TabStop = true;
            this.rbtnTen.Text = "Theo Tên SP";
            this.rbtnTen.UseVisualStyleBackColor = true;
            // 
            // rbtnMa
            // 
            this.rbtnMa.AutoSize = true;
            this.rbtnMa.Location = new System.Drawing.Point(7, 15);
            this.rbtnMa.Name = "rbtnMa";
            this.rbtnMa.Size = new System.Drawing.Size(85, 17);
            this.rbtnMa.TabIndex = 0;
            this.rbtnMa.TabStop = true;
            this.rbtnMa.Text = "Theo Mã SP";
            this.rbtnMa.UseVisualStyleBackColor = true;
            // 
            // lbTitleFind
            // 
            this.lbTitleFind.AutoSize = true;
            this.lbTitleFind.Location = new System.Drawing.Point(24, 278);
            this.lbTitleFind.Name = "lbTitleFind";
            this.lbTitleFind.Size = new System.Drawing.Size(117, 13);
            this.lbTitleFind.TabIndex = 34;
            this.lbTitleFind.Text = "Nhập thông tin cần tìm:";
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 559);
            this.Controls.Add(this.lbTitleFind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboMaKho);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvShowSanPham);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtxtMoTa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtXuatxu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaSanPham);
            this.Name = "frmSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản Phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboMaSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXuatxu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtMoTa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.DataGridView dgvShowSanPham;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.ComboBox cboMaKho;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnXX;
        private System.Windows.Forms.RadioButton rbtnTen;
        private System.Windows.Forms.RadioButton rbtnMa;
        private System.Windows.Forms.Label lbTitleFind;
    }
}