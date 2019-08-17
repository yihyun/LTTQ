namespace BaiTapLonLTTQ
{
    partial class FormLoaiKH
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
            this.lbQuanLy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaLoaiKH = new System.Windows.Forms.ComboBox();
            this.tbTenLoaiKH = new System.Windows.Forms.TextBox();
            this.tbghichu = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.dtg2 = new System.Windows.Forms.DataGridView();
            this.btnexit = new System.Windows.Forms.Button();
            this.btntaomoi = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.btnre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanLy
            // 
            this.lbQuanLy.AutoSize = true;
            this.lbQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanLy.Location = new System.Drawing.Point(233, 9);
            this.lbQuanLy.Name = "lbQuanLy";
            this.lbQuanLy.Size = new System.Drawing.Size(287, 25);
            this.lbQuanLy.TabIndex = 0;
            this.lbQuanLy.Text = "Quản Lý Loại Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Loại Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Loại Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghi Chú";
            // 
            // cbMaLoaiKH
            // 
            this.cbMaLoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLoaiKH.FormattingEnabled = true;
            this.cbMaLoaiKH.Location = new System.Drawing.Point(155, 62);
            this.cbMaLoaiKH.Name = "cbMaLoaiKH";
            this.cbMaLoaiKH.Size = new System.Drawing.Size(146, 21);
            this.cbMaLoaiKH.TabIndex = 4;
            this.cbMaLoaiKH.SelectedIndexChanged += new System.EventHandler(this.cbMaLoaiKH_SelectedIndexChanged);
            // 
            // tbTenLoaiKH
            // 
            this.tbTenLoaiKH.Location = new System.Drawing.Point(155, 105);
            this.tbTenLoaiKH.Name = "tbTenLoaiKH";
            this.tbTenLoaiKH.Size = new System.Drawing.Size(146, 20);
            this.tbTenLoaiKH.TabIndex = 5;
            // 
            // tbghichu
            // 
            this.tbghichu.Location = new System.Drawing.Point(479, 59);
            this.tbghichu.Multiline = true;
            this.tbghichu.Name = "tbghichu";
            this.tbghichu.Size = new System.Drawing.Size(237, 66);
            this.tbghichu.TabIndex = 6;
            // 
            // btnthem
            // 
            this.btnthem.Enabled = false;
            this.btnthem.Image = global::BaiTapLonLTTQ.Properties.Resources.Apply_16x16;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(238, 154);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 7;
            this.btnthem.Text = "  Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = global::BaiTapLonLTTQ.Properties.Resources.DeleteList_16x16;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(408, 154);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 8;
            this.btnxoa.Text = "  Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Image = global::BaiTapLonLTTQ.Properties.Resources.EditName_16x16;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(608, 154);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dtg2
            // 
            this.dtg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg2.Location = new System.Drawing.Point(30, 224);
            this.dtg2.Name = "dtg2";
            this.dtg2.Size = new System.Drawing.Size(676, 150);
            this.dtg2.TabIndex = 10;
            // 
            // btnexit
            // 
            this.btnexit.Image = global::BaiTapLonLTTQ.Properties.Resources.Cancel_16x16;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(608, 415);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "  Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btntaomoi
            // 
            this.btntaomoi.Image = global::BaiTapLonLTTQ.Properties.Resources.Add_16x16;
            this.btntaomoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntaomoi.Location = new System.Drawing.Point(30, 154);
            this.btntaomoi.Name = "btntaomoi";
            this.btntaomoi.Size = new System.Drawing.Size(143, 23);
            this.btntaomoi.TabIndex = 12;
            this.btntaomoi.Text = "  Tạo Mới Loại Khách Hàng";
            this.btntaomoi.UseVisualStyleBackColor = true;
            this.btntaomoi.Click += new System.EventHandler(this.btntaomoi_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Image = global::BaiTapLonLTTQ.Properties.Resources.NewTableStyle_16x16;
            this.btnchitiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnchitiet.Location = new System.Drawing.Point(307, 415);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(107, 23);
            this.btnchitiet.TabIndex = 13;
            this.btnchitiet.Text = "   Khách Hàng";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // btnre
            // 
            this.btnre.Location = new System.Drawing.Point(30, 415);
            this.btnre.Name = "btnre";
            this.btnre.Size = new System.Drawing.Size(95, 23);
            this.btnre.TabIndex = 14;
            this.btnre.Text = "Home";
            this.btnre.UseVisualStyleBackColor = true;
            this.btnre.Click += new System.EventHandler(this.btnre_Click);
            // 
            // FormLoaiKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 500);
            this.Controls.Add(this.btnre);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btntaomoi);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dtg2);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.tbghichu);
            this.Controls.Add(this.tbTenLoaiKH);
            this.Controls.Add(this.cbMaLoaiKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQuanLy);
            this.Name = "FormLoaiKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoaiKH";
            this.Load += new System.EventHandler(this.FormLoaiKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuanLy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaLoaiKH;
        private System.Windows.Forms.TextBox tbTenLoaiKH;
        private System.Windows.Forms.TextBox tbghichu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dtg2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btntaomoi;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Button btnre;
    }
}