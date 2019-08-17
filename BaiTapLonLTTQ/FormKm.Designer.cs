namespace BaiTapLonLTTQ
{
    partial class FormKm
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbmakm = new System.Windows.Forms.ComboBox();
            this.tbgiamgia = new System.Windows.Forms.TextBox();
            this.tbtenkm = new System.Windows.Forms.TextBox();
            this.cbmadtkh = new System.Windows.Forms.ComboBox();
            this.cbmadtsp = new System.Windows.Forms.ComboBox();
            this.dtped = new System.Windows.Forms.DateTimePicker();
            this.dtpst = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgkm = new System.Windows.Forms.DataGridView();
            this.btsua = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthoat = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cktt = new System.Windows.Forms.CheckBox();
            this.btluu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgkm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Khuyến Mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Khuyến Mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Kết Thúc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên CT Khuyến Mãi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giảm Giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã DTSP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã DTKH";
            // 
            // cbmakm
            // 
            this.cbmakm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmakm.FormattingEnabled = true;
            this.cbmakm.Location = new System.Drawing.Point(129, 25);
            this.cbmakm.Name = "cbmakm";
            this.cbmakm.Size = new System.Drawing.Size(121, 21);
            this.cbmakm.TabIndex = 8;
            this.cbmakm.SelectedIndexChanged += new System.EventHandler(this.cbmakm_SelectedIndexChanged);
            // 
            // tbgiamgia
            // 
            this.tbgiamgia.Location = new System.Drawing.Point(530, 94);
            this.tbgiamgia.Name = "tbgiamgia";
            this.tbgiamgia.Size = new System.Drawing.Size(121, 20);
            this.tbgiamgia.TabIndex = 9;
            this.tbgiamgia.TextChanged += new System.EventHandler(this.tbgiamgia_TextChanged);
            // 
            // tbtenkm
            // 
            this.tbtenkm.Location = new System.Drawing.Point(129, 57);
            this.tbtenkm.Name = "tbtenkm";
            this.tbtenkm.Size = new System.Drawing.Size(121, 20);
            this.tbtenkm.TabIndex = 10;
            // 
            // cbmadtkh
            // 
            this.cbmadtkh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmadtkh.FormattingEnabled = true;
            this.cbmadtkh.Location = new System.Drawing.Point(530, 57);
            this.cbmadtkh.Name = "cbmadtkh";
            this.cbmadtkh.Size = new System.Drawing.Size(121, 21);
            this.cbmadtkh.TabIndex = 11;
            // 
            // cbmadtsp
            // 
            this.cbmadtsp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmadtsp.FormattingEnabled = true;
            this.cbmadtsp.Location = new System.Drawing.Point(530, 25);
            this.cbmadtsp.Name = "cbmadtsp";
            this.cbmadtsp.Size = new System.Drawing.Size(121, 21);
            this.cbmadtsp.TabIndex = 12;
            // 
            // dtped
            // 
            this.dtped.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtped.Location = new System.Drawing.Point(129, 126);
            this.dtped.Name = "dtped";
            this.dtped.Size = new System.Drawing.Size(121, 20);
            this.dtped.TabIndex = 13;
            // 
            // dtpst
            // 
            this.dtpst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpst.Location = new System.Drawing.Point(129, 90);
            this.dtpst.Name = "dtpst";
            this.dtpst.Size = new System.Drawing.Size(121, 20);
            this.dtpst.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgkm);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 209);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Chương Trình KM";
            // 
            // dtgkm
            // 
            this.dtgkm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgkm.Location = new System.Drawing.Point(3, 19);
            this.dtgkm.Name = "dtgkm";
            this.dtgkm.Size = new System.Drawing.Size(806, 184);
            this.dtgkm.TabIndex = 0;
            // 
            // btsua
            // 
            this.btsua.Image = global::BaiTapLonLTTQ.Properties.Resources.EditName_16x16;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(522, 435);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 2;
            this.btsua.Text = "  Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btxoa
            // 
            this.btxoa.Image = global::BaiTapLonLTTQ.Properties.Resources.DeleteList_16x16;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(357, 435);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "  Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthoat
            // 
            this.btthoat.Image = global::BaiTapLonLTTQ.Properties.Resources.Cancel_16x16;
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(681, 435);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 23);
            this.btthoat.TabIndex = 16;
            this.btthoat.Text = "  Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btthem
            // 
            this.btthem.Image = global::BaiTapLonLTTQ.Properties.Resources.Add_16x16;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(33, 435);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 1;
            this.btthem.Text = "     Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cktt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpst);
            this.groupBox2.Controls.Add(this.dtped);
            this.groupBox2.Controls.Add(this.tbgiamgia);
            this.groupBox2.Controls.Add(this.cbmadtkh);
            this.groupBox2.Controls.Add(this.cbmadtsp);
            this.groupBox2.Controls.Add(this.cbmakm);
            this.groupBox2.Controls.Add(this.tbtenkm);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(806, 162);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Chi Tiết";
            // 
            // cktt
            // 
            this.cktt.AutoSize = true;
            this.cktt.Location = new System.Drawing.Point(460, 128);
            this.cktt.Name = "cktt";
            this.cktt.Size = new System.Drawing.Size(188, 17);
            this.cktt.TabIndex = 15;
            this.cktt.Text = "Khuyến Mãi Trong Ngày Hôm Nay";
            this.cktt.UseVisualStyleBackColor = true;
            this.cktt.CheckedChanged += new System.EventHandler(this.cktt_CheckedChanged);
            // 
            // btluu
            // 
            this.btluu.Image = global::BaiTapLonLTTQ.Properties.Resources.Apply_16x16;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(190, 435);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(75, 23);
            this.btluu.TabIndex = 18;
            this.btluu.Text = " Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // FormKm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 504);
            this.Controls.Add(this.btluu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.label1);
            this.Name = "FormKm";
            this.Text = "FormKm";
            this.Load += new System.EventHandler(this.FormKm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgkm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmakm;
        private System.Windows.Forms.TextBox tbgiamgia;
        private System.Windows.Forms.TextBox tbtenkm;
        private System.Windows.Forms.ComboBox cbmadtkh;
        private System.Windows.Forms.ComboBox cbmadtsp;
        private System.Windows.Forms.DateTimePicker dtped;
        private System.Windows.Forms.DateTimePicker dtpst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgkm;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.CheckBox cktt;
    }
}