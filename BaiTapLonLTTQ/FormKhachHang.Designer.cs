namespace BaiTapLonLTTQ
{
    partial class FormKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbtenkh = new System.Windows.Forms.TextBox();
            this.tbdiachi = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbsdt = new System.Windows.Forms.TextBox();
            this.dtg1 = new System.Windows.Forms.DataGridView();
            this.cbmakh = new System.Windows.Forms.ComboBox();
            this.gbtk = new System.Windows.Forms.GroupBox();
            this.rbtinh = new System.Windows.Forms.RadioButton();
            this.btntim = new System.Windows.Forms.Button();
            this.tbtimkiem = new System.Windows.Forms.TextBox();
            this.lbtim = new System.Windows.Forms.Label();
            this.rbtenkh = new System.Windows.Forms.RadioButton();
            this.rbmakh = new System.Windows.Forms.RadioButton();
            this.btnquit = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.cbloaikh = new System.Windows.Forms.ComboBox();
            this.btnlichsu = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnTL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).BeginInit();
            this.gbtk.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Loại Khách Hàng";
            // 
            // tbtenkh
            // 
            this.tbtenkh.Enabled = false;
            this.tbtenkh.Location = new System.Drawing.Point(107, 101);
            this.tbtenkh.Name = "tbtenkh";
            this.tbtenkh.Size = new System.Drawing.Size(184, 20);
            this.tbtenkh.TabIndex = 7;
            // 
            // tbdiachi
            // 
            this.tbdiachi.Enabled = false;
            this.tbdiachi.Location = new System.Drawing.Point(107, 141);
            this.tbdiachi.Name = "tbdiachi";
            this.tbdiachi.Size = new System.Drawing.Size(184, 20);
            this.tbdiachi.TabIndex = 8;
            this.tbdiachi.TextChanged += new System.EventHandler(this.tbdiachi_TextChanged);
            // 
            // tbemail
            // 
            this.tbemail.Enabled = false;
            this.tbemail.Location = new System.Drawing.Point(530, 57);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(178, 20);
            this.tbemail.TabIndex = 9;
            // 
            // tbsdt
            // 
            this.tbsdt.Enabled = false;
            this.tbsdt.Location = new System.Drawing.Point(530, 101);
            this.tbsdt.Name = "tbsdt";
            this.tbsdt.Size = new System.Drawing.Size(178, 20);
            this.tbsdt.TabIndex = 10;
            this.tbsdt.TextChanged += new System.EventHandler(this.tbsdt_TextChanged);
            this.tbsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsdt_KeyPress);
            // 
            // dtg1
            // 
            this.dtg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg1.Location = new System.Drawing.Point(25, 341);
            this.dtg1.Name = "dtg1";
            this.dtg1.Size = new System.Drawing.Size(772, 168);
            this.dtg1.TabIndex = 12;
            this.dtg1.DoubleClick += new System.EventHandler(this.dtg1_DoubleClick);
            // 
            // cbmakh
            // 
            this.cbmakh.FormattingEnabled = true;
            this.cbmakh.Location = new System.Drawing.Point(107, 57);
            this.cbmakh.Name = "cbmakh";
            this.cbmakh.Size = new System.Drawing.Size(184, 21);
            this.cbmakh.TabIndex = 13;
            this.cbmakh.SelectedIndexChanged += new System.EventHandler(this.cbmakh_SelectedIndexChanged);
            // 
            // gbtk
            // 
            this.gbtk.Controls.Add(this.rbtinh);
            this.gbtk.Controls.Add(this.btntim);
            this.gbtk.Controls.Add(this.tbtimkiem);
            this.gbtk.Controls.Add(this.lbtim);
            this.gbtk.Controls.Add(this.rbtenkh);
            this.gbtk.Controls.Add(this.rbmakh);
            this.gbtk.Location = new System.Drawing.Point(25, 223);
            this.gbtk.Name = "gbtk";
            this.gbtk.Size = new System.Drawing.Size(772, 112);
            this.gbtk.TabIndex = 19;
            this.gbtk.TabStop = false;
            this.gbtk.Text = "Tìm Kiếm";
            this.gbtk.Enter += new System.EventHandler(this.gbtk_Enter);
            // 
            // rbtinh
            // 
            this.rbtinh.AutoSize = true;
            this.rbtinh.Location = new System.Drawing.Point(47, 72);
            this.rbtinh.Name = "rbtinh";
            this.rbtinh.Size = new System.Drawing.Size(94, 17);
            this.rbtinh.TabIndex = 5;
            this.rbtinh.TabStop = true;
            this.rbtinh.Text = "Tìm Theo Tỉnh";
            this.rbtinh.UseVisualStyleBackColor = true;
            this.rbtinh.CheckedChanged += new System.EventHandler(this.rbtinh_CheckedChanged);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(585, 44);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 4;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // tbtimkiem
            // 
            this.tbtimkiem.Enabled = false;
            this.tbtimkiem.Location = new System.Drawing.Point(304, 46);
            this.tbtimkiem.Name = "tbtimkiem";
            this.tbtimkiem.Size = new System.Drawing.Size(207, 20);
            this.tbtimkiem.TabIndex = 3;
            // 
            // lbtim
            // 
            this.lbtim.AutoSize = true;
            this.lbtim.Location = new System.Drawing.Point(160, 49);
            this.lbtim.Name = "lbtim";
            this.lbtim.Size = new System.Drawing.Size(0, 13);
            this.lbtim.TabIndex = 2;
            // 
            // rbtenkh
            // 
            this.rbtenkh.AutoSize = true;
            this.rbtenkh.Location = new System.Drawing.Point(47, 49);
            this.rbtenkh.Name = "rbtenkh";
            this.rbtenkh.Size = new System.Drawing.Size(92, 17);
            this.rbtenkh.TabIndex = 1;
            this.rbtenkh.TabStop = true;
            this.rbtenkh.Text = "Tìm Theo Tên";
            this.rbtenkh.UseVisualStyleBackColor = true;
            this.rbtenkh.CheckedChanged += new System.EventHandler(this.rbtenkh_CheckedChanged);
            // 
            // rbmakh
            // 
            this.rbmakh.AutoSize = true;
            this.rbmakh.Location = new System.Drawing.Point(47, 26);
            this.rbmakh.Name = "rbmakh";
            this.rbmakh.Size = new System.Drawing.Size(91, 17);
            this.rbmakh.TabIndex = 0;
            this.rbmakh.TabStop = true;
            this.rbmakh.Text = "Tìm Theo Mã ";
            this.rbmakh.UseVisualStyleBackColor = true;
            this.rbmakh.CheckedChanged += new System.EventHandler(this.rbmakh_CheckedChanged);
            // 
            // btnquit
            // 
            this.btnquit.Image = global::BaiTapLonLTTQ.Properties.Resources.Cancel_16x16;
            this.btnquit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnquit.Location = new System.Drawing.Point(670, 527);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(75, 23);
            this.btnquit.TabIndex = 20;
            this.btnquit.Text = "  Exit";
            this.btnquit.UseVisualStyleBackColor = true;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Image = global::BaiTapLonLTTQ.Properties.Resources.Add_16x16;
            this.btntaomoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaomoi.Location = new System.Drawing.Point(58, 527);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(149, 23);
            this.btntaomoi.TabIndex = 22;
            this.btntaomoi.Text = "  Tạo Mới Khách Hàng";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Location = new System.Drawing.Point(381, 527);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(75, 23);
            this.btrefresh.TabIndex = 23;
            this.btrefresh.Text = "Home";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // cbloaikh
            // 
            this.cbloaikh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloaikh.FormattingEnabled = true;
            this.cbloaikh.Location = new System.Drawing.Point(530, 140);
            this.cbloaikh.Name = "cbloaikh";
            this.cbloaikh.Size = new System.Drawing.Size(178, 21);
            this.cbloaikh.TabIndex = 24;
            // 
            // btnlichsu
            // 
            this.btnlichsu.Image = global::BaiTapLonLTTQ.Properties.Resources.Hide_16x16;
            this.btnlichsu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlichsu.Location = new System.Drawing.Point(530, 183);
            this.btnlichsu.Name = "btnlichsu";
            this.btnlichsu.Size = new System.Drawing.Size(117, 23);
            this.btnlichsu.TabIndex = 18;
            this.btnlichsu.Text = "    Lịch sử mua hàng";
            this.btnlichsu.UseVisualStyleBackColor = true;
            this.btnlichsu.Click += new System.EventHandler(this.btnlichsu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::BaiTapLonLTTQ.Properties.Resources.EditName_16x16;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(370, 183);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(89, 23);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::BaiTapLonLTTQ.Properties.Resources.DeleteList_16x16;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(197, 183);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(89, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Enabled = false;
            this.btnthem.Image = global::BaiTapLonLTTQ.Properties.Resources.Apply_16x16;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(34, 183);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(88, 23);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Lưu";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnTL
            // 
            this.btnTL.Image = global::BaiTapLonLTTQ.Properties.Resources.Show_16x16;
            this.btnTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTL.Location = new System.Drawing.Point(697, 183);
            this.btnTL.Name = "btnTL";
            this.btnTL.Size = new System.Drawing.Size(123, 23);
            this.btnTL.TabIndex = 14;
            this.btnTL.Text = "   Thông Tin Loại KH";
            this.btnTL.UseVisualStyleBackColor = true;
            this.btnTL.Click += new System.EventHandler(this.btnTL_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 562);
            this.Controls.Add(this.cbloaikh);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnquit);
            this.Controls.Add(this.gbtk);
            this.Controls.Add(this.btnlichsu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnTL);
            this.Controls.Add(this.cbmakh);
            this.Controls.Add(this.dtg1);
            this.Controls.Add(this.tbsdt);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbdiachi);
            this.Controls.Add(this.tbtenkh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg1)).EndInit();
            this.gbtk.ResumeLayout(false);
            this.gbtk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbtenkh;
        private System.Windows.Forms.TextBox tbdiachi;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbsdt;
        private System.Windows.Forms.DataGridView dtg1;
        private System.Windows.Forms.ComboBox cbmakh;
        private System.Windows.Forms.Button btnTL;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlichsu;
        private System.Windows.Forms.GroupBox gbtk;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox tbtimkiem;
        private System.Windows.Forms.Label lbtim;
        private System.Windows.Forms.RadioButton rbtenkh;
        private System.Windows.Forms.RadioButton rbmakh;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.RadioButton rbtinh;
        private System.Windows.Forms.ComboBox cbloaikh;
    }
}