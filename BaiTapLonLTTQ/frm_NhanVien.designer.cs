namespace BTL_BacVu
{
    partial class frm_NhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rdbtn_nu = new System.Windows.Forms.RadioButton();
            this.rdbtn_nam = new System.Windows.Forms.RadioButton();
            this.richtxt_diachi = new System.Windows.Forms.RichTextBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_SĐT = new System.Windows.Forms.TextBox();
            this.txt_Hoten = new System.Windows.Forms.TextBox();
            this.cbb_MaNV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DTGridview_TTnhanvien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_timkiemNV = new System.Windows.Forms.TextBox();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGridview_TTnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rdbtn_nu);
            this.groupBox1.Controls.Add(this.rdbtn_nam);
            this.groupBox1.Controls.Add(this.richtxt_diachi);
            this.groupBox1.Controls.Add(this.txt_luong);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.txt_SĐT);
            this.groupBox1.Controls.Add(this.txt_Hoten);
            this.groupBox1.Controls.Add(this.cbb_MaNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(672, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Đồng";
            // 
            // rdbtn_nu
            // 
            this.rdbtn_nu.AutoSize = true;
            this.rdbtn_nu.Location = new System.Drawing.Point(189, 100);
            this.rdbtn_nu.Name = "rdbtn_nu";
            this.rdbtn_nu.Size = new System.Drawing.Size(39, 17);
            this.rdbtn_nu.TabIndex = 14;
            this.rdbtn_nu.TabStop = true;
            this.rdbtn_nu.Text = "Nữ";
            this.rdbtn_nu.UseVisualStyleBackColor = true;
            // 
            // rdbtn_nam
            // 
            this.rdbtn_nam.AutoSize = true;
            this.rdbtn_nam.Location = new System.Drawing.Point(107, 100);
            this.rdbtn_nam.Name = "rdbtn_nam";
            this.rdbtn_nam.Size = new System.Drawing.Size(47, 17);
            this.rdbtn_nam.TabIndex = 13;
            this.rdbtn_nam.TabStop = true;
            this.rdbtn_nam.Text = "Nam";
            this.rdbtn_nam.UseVisualStyleBackColor = true;
            // 
            // richtxt_diachi
            // 
            this.richtxt_diachi.Location = new System.Drawing.Point(520, 100);
            this.richtxt_diachi.Name = "richtxt_diachi";
            this.richtxt_diachi.Size = new System.Drawing.Size(146, 58);
            this.richtxt_diachi.TabIndex = 12;
            this.richtxt_diachi.Text = "";
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(520, 67);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(146, 20);
            this.txt_luong.TabIndex = 11;
            this.txt_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SĐT_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(520, 36);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(146, 20);
            this.txt_email.TabIndex = 10;
            // 
            // txt_SĐT
            // 
            this.txt_SĐT.Location = new System.Drawing.Point(107, 138);
            this.txt_SĐT.Name = "txt_SĐT";
            this.txt_SĐT.Size = new System.Drawing.Size(122, 20);
            this.txt_SĐT.TabIndex = 9;
            this.txt_SĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SĐT_KeyPress);
            // 
            // txt_Hoten
            // 
            this.txt_Hoten.Location = new System.Drawing.Point(107, 63);
            this.txt_Hoten.Name = "txt_Hoten";
            this.txt_Hoten.Size = new System.Drawing.Size(121, 20);
            this.txt_Hoten.TabIndex = 8;
            // 
            // cbb_MaNV
            // 
            this.cbb_MaNV.FormattingEnabled = true;
            this.cbb_MaNV.Location = new System.Drawing.Point(107, 33);
            this.cbb_MaNV.Name = "cbb_MaNV";
            this.cbb_MaNV.Size = new System.Drawing.Size(121, 21);
            this.cbb_MaNV.TabIndex = 7;
            this.cbb_MaNV.SelectedIndexChanged += new System.EventHandler(this.cbb_MaNV_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(449, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.DTGridview_TTnhanvien);
            this.groupBox3.Location = new System.Drawing.Point(12, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(763, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // DTGridview_TTnhanvien
            // 
            this.DTGridview_TTnhanvien.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DTGridview_TTnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGridview_TTnhanvien.Location = new System.Drawing.Point(0, 19);
            this.DTGridview_TTnhanvien.Name = "DTGridview_TTnhanvien";
            this.DTGridview_TTnhanvien.Size = new System.Drawing.Size(763, 136);
            this.DTGridview_TTnhanvien.TabIndex = 0;
            this.DTGridview_TTnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGridview_TTnhanvien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông Tin Nhân Viên";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_them.Location = new System.Drawing.Point(353, 249);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 32);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_sua.Location = new System.Drawing.Point(448, 249);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 32);
            this.btn_sua.TabIndex = 5;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xoa.Location = new System.Drawing.Point(532, 249);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_xoa.TabIndex = 6;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_luu.Location = new System.Drawing.Point(621, 249);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 32);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_thoat.Location = new System.Drawing.Point(702, 249);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(73, 32);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tên Nhân Viên";
            // 
            // txt_timkiemNV
            // 
            this.txt_timkiemNV.Location = new System.Drawing.Point(97, 259);
            this.txt_timkiemNV.Name = "txt_timkiemNV";
            this.txt_timkiemNV.Size = new System.Drawing.Size(100, 20);
            this.txt_timkiemNV.TabIndex = 10;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_timkiem.Location = new System.Drawing.Point(203, 256);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(75, 25);
            this.btn_timkiem.TabIndex = 11;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(798, 478);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiemNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_NhanVien";
            this.Text = "Nhân Viên";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGridview_TTnhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtn_nu;
        private System.Windows.Forms.RadioButton rdbtn_nam;
        private System.Windows.Forms.RichTextBox richtxt_diachi;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_SĐT;
        private System.Windows.Forms.TextBox txt_Hoten;
        private System.Windows.Forms.ComboBox cbb_MaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DTGridview_TTnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_timkiemNV;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Label label10;
    }
}