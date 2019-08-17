namespace BTL_BacVu
{
    partial class frm_nhaphang
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
            this.components = new System.ComponentModel.Container();
            this.grbox_TTchung = new System.Windows.Forms.GroupBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.richtxt_TeNCC = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richtext_ghichu = new System.Windows.Forms.RichTextBox();
            this.DTpicker_ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.cbb_MaNCC = new System.Windows.Forms.ComboBox();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.cbb_MaHDN = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_TenNCC = new System.Windows.Forms.Label();
            this.lbl_MaNCC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_manv = new System.Windows.Forms.Label();
            this.lbl_hdn = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.cbb_MaSP = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.grbox_mathangnhap = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_gianhap = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Gridview_HDN = new System.Windows.Forms.DataGridView();
            this.cl_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btt_them = new System.Windows.Forms.Button();
            this.btt_sua = new System.Windows.Forms.Button();
            this.btt_xoa = new System.Windows.Forms.Button();
            this.btt_ok = new System.Windows.Forms.Button();
            this.btt_huy = new System.Windows.Forms.Button();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltip_soluong = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btt_lammoi = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpicker_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.grbox_TTchung.SuspendLayout();
            this.grbox_mathangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_HDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbox_TTchung
            // 
            this.grbox_TTchung.BackColor = System.Drawing.SystemColors.Control;
            this.grbox_TTchung.Controls.Add(this.btn_luu);
            this.grbox_TTchung.Controls.Add(this.richtxt_TeNCC);
            this.grbox_TTchung.Controls.Add(this.label2);
            this.grbox_TTchung.Controls.Add(this.richtext_ghichu);
            this.grbox_TTchung.Controls.Add(this.DTpicker_ngaynhap);
            this.grbox_TTchung.Controls.Add(this.txt_TenNV);
            this.grbox_TTchung.Controls.Add(this.cbb_MaNCC);
            this.grbox_TTchung.Controls.Add(this.cbb_MaNV);
            this.grbox_TTchung.Controls.Add(this.cbb_MaHDN);
            this.grbox_TTchung.Controls.Add(this.label9);
            this.grbox_TTchung.Controls.Add(this.lbl_TenNCC);
            this.grbox_TTchung.Controls.Add(this.lbl_MaNCC);
            this.grbox_TTchung.Controls.Add(this.label3);
            this.grbox_TTchung.Controls.Add(this.lbl_manv);
            this.grbox_TTchung.Controls.Add(this.lbl_hdn);
            this.grbox_TTchung.Controls.Add(this.groupBox2);
            this.grbox_TTchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_TTchung.Location = new System.Drawing.Point(28, 35);
            this.grbox_TTchung.Name = "grbox_TTchung";
            this.grbox_TTchung.Size = new System.Drawing.Size(668, 188);
            this.grbox_TTchung.TabIndex = 0;
            this.grbox_TTchung.TabStop = false;
            this.grbox_TTchung.Text = "Thông Tin Chung";
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(572, 157);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(57, 31);
            this.btn_luu.TabIndex = 24;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Visible = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // richtxt_TeNCC
            // 
            this.richtxt_TeNCC.Enabled = false;
            this.richtxt_TeNCC.Location = new System.Drawing.Point(87, 121);
            this.richtxt_TeNCC.Name = "richtxt_TeNCC";
            this.richtxt_TeNCC.Size = new System.Drawing.Size(156, 50);
            this.richtxt_TeNCC.TabIndex = 23;
            this.richtxt_TeNCC.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ghi Chú";
            // 
            // richtext_ghichu
            // 
            this.richtext_ghichu.Location = new System.Drawing.Point(473, 94);
            this.richtext_ghichu.Name = "richtext_ghichu";
            this.richtext_ghichu.Size = new System.Drawing.Size(156, 57);
            this.richtext_ghichu.TabIndex = 21;
            this.richtext_ghichu.Text = "";
            // 
            // DTpicker_ngaynhap
            // 
            this.DTpicker_ngaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.DTpicker_ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTpicker_ngaynhap.ImeMode = System.Windows.Forms.ImeMode.On;
            this.DTpicker_ngaynhap.Location = new System.Drawing.Point(87, 56);
            this.DTpicker_ngaynhap.Name = "DTpicker_ngaynhap";
            this.DTpicker_ngaynhap.Size = new System.Drawing.Size(156, 22);
            this.DTpicker_ngaynhap.TabIndex = 20;
            this.DTpicker_ngaynhap.Value = new System.DateTime(2017, 11, 8, 21, 37, 0, 0);
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Enabled = false;
            this.txt_TenNV.Location = new System.Drawing.Point(473, 58);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(156, 20);
            this.txt_TenNV.TabIndex = 15;
            // 
            // cbb_MaNCC
            // 
            this.cbb_MaNCC.FormattingEnabled = true;
            this.cbb_MaNCC.Location = new System.Drawing.Point(87, 94);
            this.cbb_MaNCC.Name = "cbb_MaNCC";
            this.cbb_MaNCC.Size = new System.Drawing.Size(156, 21);
            this.cbb_MaNCC.TabIndex = 13;
            this.cbb_MaNCC.SelectedIndexChanged += new System.EventHandler(this.cbb_MaNCC_SelectedIndexChanged);
            this.cbb_MaNCC.TextChanged += new System.EventHandler(this.cbb_MaNCC_TextChanged);
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(473, 23);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(156, 21);
            this.cbb_MaNV.TabIndex = 12;
            this.cbb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cbb_MaNV_SelectedIndexChanged);
            this.cbb_MaNV.TextChanged += new System.EventHandler(this.cbb_MaNCC_TextChanged);
            // 
            // cbb_MaHDN
            // 
            this.cbb_MaHDN.DropDownWidth = 100;
            this.cbb_MaHDN.FormattingEnabled = true;
            this.cbb_MaHDN.ItemHeight = 13;
            this.cbb_MaHDN.Location = new System.Drawing.Point(87, 26);
            this.cbb_MaHDN.Name = "cbb_MaHDN";
            this.cbb_MaHDN.Size = new System.Drawing.Size(156, 21);
            this.cbb_MaHDN.TabIndex = 11;
            this.cbb_MaHDN.SelectedIndexChanged += new System.EventHandler(this.cbb_MaHDN_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Ngày Nhập";
            // 
            // lbl_TenNCC
            // 
            this.lbl_TenNCC.AutoSize = true;
            this.lbl_TenNCC.Location = new System.Drawing.Point(13, 124);
            this.lbl_TenNCC.Name = "lbl_TenNCC";
            this.lbl_TenNCC.Size = new System.Drawing.Size(56, 15);
            this.lbl_TenNCC.TabIndex = 5;
            this.lbl_TenNCC.Text = "Tên NCC";
            // 
            // lbl_MaNCC
            // 
            this.lbl_MaNCC.AutoSize = true;
            this.lbl_MaNCC.Location = new System.Drawing.Point(19, 94);
            this.lbl_MaNCC.Name = "lbl_MaNCC";
            this.lbl_MaNCC.Size = new System.Drawing.Size(53, 15);
            this.lbl_MaNCC.TabIndex = 4;
            this.lbl_MaNCC.Text = "Mã NCC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên NV";
            // 
            // lbl_manv
            // 
            this.lbl_manv.AutoSize = true;
            this.lbl_manv.Location = new System.Drawing.Point(399, 29);
            this.lbl_manv.Name = "lbl_manv";
            this.lbl_manv.Size = new System.Drawing.Size(44, 15);
            this.lbl_manv.TabIndex = 2;
            this.lbl_manv.Text = "Mã NV";
            // 
            // lbl_hdn
            // 
            this.lbl_hdn.AutoSize = true;
            this.lbl_hdn.Location = new System.Drawing.Point(17, 26);
            this.lbl_hdn.Name = "lbl_hdn";
            this.lbl_hdn.Size = new System.Drawing.Size(55, 15);
            this.lbl_hdn.TabIndex = 1;
            this.lbl_hdn.Text = "Mã HDN";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(275, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(6, 7);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Enabled = false;
            this.txt_TenSP.Location = new System.Drawing.Point(73, 77);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(146, 21);
            this.txt_TenSP.TabIndex = 19;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(584, 28);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(66, 21);
            this.txt_soluong.TabIndex = 18;
            this.tooltip_soluong.SetToolTip(this.txt_soluong, "Nhập số nguyên");
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong1_TextChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong1_KeyPress);
            // 
            // cbb_MaSP
            // 
            this.cbb_MaSP.FormattingEnabled = true;
            this.cbb_MaSP.Location = new System.Drawing.Point(75, 31);
            this.cbb_MaSP.Name = "cbb_MaSP";
            this.cbb_MaSP.Size = new System.Drawing.Size(102, 23);
            this.cbb_MaSP.TabIndex = 14;
            this.cbb_MaSP.SelectedIndexChanged += new System.EventHandler(this.cbb_MaSP_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(507, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên SP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã SP";
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(288, 8);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(205, 24);
            this.lbl_tieude.TabIndex = 1;
            this.lbl_tieude.Text = "Thông tin nhập hàng";
            // 
            // grbox_mathangnhap
            // 
            this.grbox_mathangnhap.BackColor = System.Drawing.SystemColors.Control;
            this.grbox_mathangnhap.Controls.Add(this.label8);
            this.grbox_mathangnhap.Controls.Add(this.label4);
            this.grbox_mathangnhap.Controls.Add(this.txt_TenSP);
            this.grbox_mathangnhap.Controls.Add(this.txt_thanhtien);
            this.grbox_mathangnhap.Controls.Add(this.txt_soluong);
            this.grbox_mathangnhap.Controls.Add(this.txt_gianhap);
            this.grbox_mathangnhap.Controls.Add(this.label16);
            this.grbox_mathangnhap.Controls.Add(this.cbb_MaSP);
            this.grbox_mathangnhap.Controls.Add(this.label14);
            this.grbox_mathangnhap.Controls.Add(this.label10);
            this.grbox_mathangnhap.Controls.Add(this.label6);
            this.grbox_mathangnhap.Controls.Add(this.label7);
            this.grbox_mathangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_mathangnhap.Location = new System.Drawing.Point(28, 229);
            this.grbox_mathangnhap.Name = "grbox_mathangnhap";
            this.grbox_mathangnhap.Size = new System.Drawing.Size(668, 108);
            this.grbox_mathangnhap.TabIndex = 2;
            this.grbox_mathangnhap.TabStop = false;
            this.grbox_mathangnhap.Text = "Thông tin các mặt hàng nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(431, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "đ";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(328, 74);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(102, 21);
            this.txt_thanhtien.TabIndex = 10;
            // 
            // txt_gianhap
            // 
            this.txt_gianhap.Location = new System.Drawing.Point(328, 31);
            this.txt_gianhap.Name = "txt_gianhap";
            this.txt_gianhap.Size = new System.Drawing.Size(97, 21);
            this.txt_gianhap.TabIndex = 9;
            this.txt_gianhap.TextChanged += new System.EventHandler(this.txt_soluong1_TextChanged);
            this.txt_gianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong1_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(241, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 5;
            this.label16.Text = "Thành Tiền";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(241, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "Gía nhập";
            // 
            // Gridview_HDN
            // 
            this.Gridview_HDN.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Gridview_HDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview_HDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_MaSP,
            this.cl_tenSP,
            this.cl_soluong,
            this.cl_gia});
            this.Gridview_HDN.Location = new System.Drawing.Point(28, 354);
            this.Gridview_HDN.Name = "Gridview_HDN";
            this.Gridview_HDN.Size = new System.Drawing.Size(668, 115);
            this.Gridview_HDN.TabIndex = 3;
            this.Gridview_HDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview_HDN_CellClick);
            this.Gridview_HDN.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridview_HDN_CellContentDoubleClick);
            // 
            // cl_MaSP
            // 
            this.cl_MaSP.DataPropertyName = "MaSP";
            this.cl_MaSP.HeaderText = "Mã Sản Phẩm";
            this.cl_MaSP.Name = "cl_MaSP";
            // 
            // cl_tenSP
            // 
            this.cl_tenSP.DataPropertyName = "TenSP";
            this.cl_tenSP.HeaderText = "Tên Sản Phẩm";
            this.cl_tenSP.Name = "cl_tenSP";
            // 
            // cl_soluong
            // 
            this.cl_soluong.DataPropertyName = "SoLuong";
            this.cl_soluong.HeaderText = "Số Lượng";
            this.cl_soluong.Name = "cl_soluong";
            // 
            // cl_gia
            // 
            this.cl_gia.DataPropertyName = "GiaNhap";
            this.cl_gia.HeaderText = "Gía Nhập";
            this.cl_gia.Name = "cl_gia";
            // 
            // btt_them
            // 
            this.btt_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_them.Location = new System.Drawing.Point(28, 530);
            this.btt_them.Name = "btt_them";
            this.btt_them.Size = new System.Drawing.Size(59, 26);
            this.btt_them.TabIndex = 4;
            this.btt_them.Text = "Thêm";
            this.btt_them.UseVisualStyleBackColor = false;
            this.btt_them.Click += new System.EventHandler(this.btt_them_Click);
            // 
            // btt_sua
            // 
            this.btt_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_sua.Location = new System.Drawing.Point(112, 530);
            this.btt_sua.Name = "btt_sua";
            this.btt_sua.Size = new System.Drawing.Size(67, 26);
            this.btt_sua.TabIndex = 5;
            this.btt_sua.Text = "Sửa";
            this.btt_sua.UseVisualStyleBackColor = false;
            this.btt_sua.Click += new System.EventHandler(this.btt_sua_Click);
            // 
            // btt_xoa
            // 
            this.btt_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_xoa.Location = new System.Drawing.Point(222, 530);
            this.btt_xoa.Name = "btt_xoa";
            this.btt_xoa.Size = new System.Drawing.Size(67, 26);
            this.btt_xoa.TabIndex = 6;
            this.btt_xoa.Text = "Xóa";
            this.btt_xoa.UseVisualStyleBackColor = false;
            this.btt_xoa.Click += new System.EventHandler(this.btt_xoa_Click);
            // 
            // btt_ok
            // 
            this.btt_ok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_ok.Location = new System.Drawing.Point(326, 530);
            this.btt_ok.Name = "btt_ok";
            this.btt_ok.Size = new System.Drawing.Size(67, 26);
            this.btt_ok.TabIndex = 7;
            this.btt_ok.Text = "OK";
            this.btt_ok.UseVisualStyleBackColor = false;
            this.btt_ok.Click += new System.EventHandler(this.btt_ok_Click);
            // 
            // btt_huy
            // 
            this.btt_huy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_huy.Location = new System.Drawing.Point(426, 530);
            this.btt_huy.Name = "btt_huy";
            this.btt_huy.Size = new System.Drawing.Size(67, 26);
            this.btt_huy.TabIndex = 8;
            this.btt_huy.Text = "Hủy";
            this.btt_huy.UseVisualStyleBackColor = false;
            this.btt_huy.Click += new System.EventHandler(this.btt_huy_Click);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(543, 486);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(135, 22);
            this.txt_tongtien.TabIndex = 9;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tổng Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(680, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "đ";
            // 
            // btt_lammoi
            // 
            this.btt_lammoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btt_lammoi.Location = new System.Drawing.Point(621, 530);
            this.btt_lammoi.Name = "btt_lammoi";
            this.btt_lammoi.Size = new System.Drawing.Size(75, 26);
            this.btt_lammoi.TabIndex = 22;
            this.btt_lammoi.Text = "Làm mới";
            this.btt_lammoi.UseVisualStyleBackColor = false;
            this.btt_lammoi.Click += new System.EventHandler(this.btt_lammoi_Click);
            // 
            // btn_in
            // 
            this.btn_in.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_in.Location = new System.Drawing.Point(519, 530);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(64, 26);
            this.btn_in.TabIndex = 23;
            this.btn_in.Text = "In";
            this.btn_in.UseVisualStyleBackColor = false;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 24;
            this.label11.Text = "Chọn Ngày";
            // 
            // dtpicker_ChonNgay
            // 
            this.dtpicker_ChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker_ChonNgay.Location = new System.Drawing.Point(109, 486);
            this.dtpicker_ChonNgay.Name = "dtpicker_ChonNgay";
            this.dtpicker_ChonNgay.Size = new System.Drawing.Size(124, 22);
            this.dtpicker_ChonNgay.TabIndex = 25;
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Timkiem.Location = new System.Drawing.Point(239, 486);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(75, 25);
            this.btn_Timkiem.TabIndex = 26;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = false;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // frm_nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 585);
            this.Controls.Add(this.btn_Timkiem);
            this.Controls.Add(this.dtpicker_ChonNgay);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btt_lammoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.btt_huy);
            this.Controls.Add(this.btt_ok);
            this.Controls.Add(this.btt_xoa);
            this.Controls.Add(this.btt_sua);
            this.Controls.Add(this.btt_them);
            this.Controls.Add(this.Gridview_HDN);
            this.Controls.Add(this.grbox_mathangnhap);
            this.Controls.Add(this.lbl_tieude);
            this.Controls.Add(this.grbox_TTchung);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_nhaphang";
            this.Text = "Nhập Hàng";
            this.grbox_TTchung.ResumeLayout(false);
            this.grbox_TTchung.PerformLayout();
            this.grbox_mathangnhap.ResumeLayout(false);
            this.grbox_mathangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview_HDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbox_TTchung;
        private System.Windows.Forms.DateTimePicker DTpicker_ngaynhap;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.ComboBox cbb_MaSP;
        private System.Windows.Forms.ComboBox cbb_MaNCC;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.ComboBox cbb_MaHDN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_TenNCC;
        private System.Windows.Forms.Label lbl_MaNCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_manv;
        private System.Windows.Forms.Label lbl_hdn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.GroupBox grbox_mathangnhap;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_gianhap;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView Gridview_HDN;
        private System.Windows.Forms.Button btt_them;
        private System.Windows.Forms.Button btt_sua;
        private System.Windows.Forms.Button btt_xoa;
        private System.Windows.Forms.Button btt_ok;
        private System.Windows.Forms.Button btt_huy;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip tooltip_soluong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richtext_ghichu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btt_lammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_gia;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.RichTextBox richtxt_TeNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpicker_ChonNgay;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.Button btn_luu;
    }
}

