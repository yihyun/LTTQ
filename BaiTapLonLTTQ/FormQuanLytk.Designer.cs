namespace BaiTapLonLTTQ
{
    partial class FormQuanLytk
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
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.cbmanv1 = new System.Windows.Forms.ComboBox();
            this.tbtennv1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtglogin = new System.Windows.Forms.DataGridView();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.bttim = new System.Windows.Forms.Button();
            this.tbtim = new System.Windows.Forms.TextBox();
            this.lbtimk = new System.Windows.Forms.Label();
            this.rbuser = new System.Windows.Forms.RadioButton();
            this.rbten = new System.Windows.Forms.RadioButton();
            this.rbma = new System.Windows.Forms.RadioButton();
            this.bttao = new System.Windows.Forms.Button();
            this.lnan = new System.Windows.Forms.Label();
            this.btnot = new System.Windows.Forms.Button();
            this.bthome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtglogin)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Tài Khoản Đăng Nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(580, 57);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(134, 20);
            this.tbuser.TabIndex = 4;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(580, 99);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(134, 20);
            this.tbpass.TabIndex = 5;
            // 
            // cbmanv1
            // 
            this.cbmanv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmanv1.FormattingEnabled = true;
            this.cbmanv1.Location = new System.Drawing.Point(190, 61);
            this.cbmanv1.Name = "cbmanv1";
            this.cbmanv1.Size = new System.Drawing.Size(134, 21);
            this.cbmanv1.TabIndex = 6;
            this.cbmanv1.SelectedIndexChanged += new System.EventHandler(this.cbmanv1_SelectedIndexChanged);
            // 
            // tbtennv1
            // 
            this.tbtennv1.Enabled = false;
            this.tbtennv1.Location = new System.Drawing.Point(190, 102);
            this.tbtennv1.Name = "tbtennv1";
            this.tbtennv1.Size = new System.Drawing.Size(134, 20);
            this.tbtennv1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên Nhân Viên";
            // 
            // dtglogin
            // 
            this.dtglogin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtglogin.Location = new System.Drawing.Point(78, 373);
            this.dtglogin.Name = "dtglogin";
            this.dtglogin.Size = new System.Drawing.Size(679, 176);
            this.dtglogin.TabIndex = 9;
            this.dtglogin.DoubleClick += new System.EventHandler(this.dtglogin_DoubleClick);
            // 
            // btthem
            // 
            this.btthem.Enabled = false;
            this.btthem.Location = new System.Drawing.Point(217, 155);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 10;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(368, 155);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 11;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(526, 155);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 12;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // bthuy
            // 
            this.bthuy.Location = new System.Drawing.Point(669, 155);
            this.bthuy.Name = "bthuy";
            this.bthuy.Size = new System.Drawing.Size(75, 23);
            this.bthuy.TabIndex = 13;
            this.bthuy.Text = "Exit";
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.bttim);
            this.grbTimKiem.Controls.Add(this.tbtim);
            this.grbTimKiem.Controls.Add(this.lbtimk);
            this.grbTimKiem.Controls.Add(this.rbuser);
            this.grbTimKiem.Controls.Add(this.rbten);
            this.grbTimKiem.Controls.Add(this.rbma);
            this.grbTimKiem.Location = new System.Drawing.Point(78, 240);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(679, 115);
            this.grbTimKiem.TabIndex = 14;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm Kiếm";
            this.grbTimKiem.Enter += new System.EventHandler(this.grbTimKiem_Enter);
            // 
            // bttim
            // 
            this.bttim.Enabled = false;
            this.bttim.Location = new System.Drawing.Point(540, 48);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(75, 23);
            this.bttim.TabIndex = 5;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // tbtim
            // 
            this.tbtim.Enabled = false;
            this.tbtim.Location = new System.Drawing.Point(316, 51);
            this.tbtim.Name = "tbtim";
            this.tbtim.Size = new System.Drawing.Size(177, 20);
            this.tbtim.TabIndex = 4;
            // 
            // lbtimk
            // 
            this.lbtimk.AutoSize = true;
            this.lbtimk.Location = new System.Drawing.Point(163, 53);
            this.lbtimk.Name = "lbtimk";
            this.lbtimk.Size = new System.Drawing.Size(10, 13);
            this.lbtimk.TabIndex = 3;
            this.lbtimk.Text = " ";
            // 
            // rbuser
            // 
            this.rbuser.AutoSize = true;
            this.rbuser.Location = new System.Drawing.Point(56, 74);
            this.rbuser.Name = "rbuser";
            this.rbuser.Size = new System.Drawing.Size(89, 17);
            this.rbuser.TabIndex = 2;
            this.rbuser.TabStop = true;
            this.rbuser.Text = "Tìm theo user";
            this.rbuser.UseVisualStyleBackColor = true;
            this.rbuser.CheckedChanged += new System.EventHandler(this.rbuser_CheckedChanged);
            // 
            // rbten
            // 
            this.rbten.AutoSize = true;
            this.rbten.Location = new System.Drawing.Point(56, 51);
            this.rbten.Name = "rbten";
            this.rbten.Size = new System.Drawing.Size(84, 17);
            this.rbten.TabIndex = 1;
            this.rbten.TabStop = true;
            this.rbten.Text = "Tìm theo tên";
            this.rbten.UseVisualStyleBackColor = true;
            this.rbten.CheckedChanged += new System.EventHandler(this.rbten_CheckedChanged);
            // 
            // rbma
            // 
            this.rbma.AutoSize = true;
            this.rbma.Location = new System.Drawing.Point(56, 28);
            this.rbma.Name = "rbma";
            this.rbma.Size = new System.Drawing.Size(91, 17);
            this.rbma.TabIndex = 0;
            this.rbma.TabStop = true;
            this.rbma.Text = "Tìm Theo Mã ";
            this.rbma.UseVisualStyleBackColor = true;
            this.rbma.CheckedChanged += new System.EventHandler(this.rbma_CheckedChanged);
            // 
            // bttao
            // 
            this.bttao.Location = new System.Drawing.Point(78, 155);
            this.bttao.Name = "bttao";
            this.bttao.Size = new System.Drawing.Size(75, 23);
            this.bttao.TabIndex = 15;
            this.bttao.Text = "Tạo Mới";
            this.bttao.UseVisualStyleBackColor = true;
            this.bttao.Click += new System.EventHandler(this.bttao_Click);
            // 
            // lnan
            // 
            this.lnan.AutoSize = true;
            this.lnan.ForeColor = System.Drawing.Color.Red;
            this.lnan.Location = new System.Drawing.Point(78, 128);
            this.lnan.Name = "lnan";
            this.lnan.Size = new System.Drawing.Size(64, 13);
            this.lnan.TabIndex = 16;
            this.lnan.Text = "                   ";
            // 
            // btnot
            // 
            this.btnot.Location = new System.Drawing.Point(300, 194);
            this.btnot.Name = "btnot";
            this.btnot.Size = new System.Drawing.Size(197, 23);
            this.btnot.TabIndex = 17;
            this.btnot.Text = "Nhân Viên Chưa Có Tài Khoản";
            this.btnot.UseVisualStyleBackColor = true;
            this.btnot.Click += new System.EventHandler(this.btnot_Click);
            // 
            // bthome
            // 
            this.bthome.Location = new System.Drawing.Point(78, 194);
            this.bthome.Name = "bthome";
            this.bthome.Size = new System.Drawing.Size(75, 23);
            this.bthome.TabIndex = 18;
            this.bthome.Text = "Home";
            this.bthome.UseVisualStyleBackColor = true;
            this.bthome.Click += new System.EventHandler(this.bthome_Click);
            // 
            // FormQuanLytk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 566);
            this.Controls.Add(this.bthome);
            this.Controls.Add(this.btnot);
            this.Controls.Add(this.lnan);
            this.Controls.Add(this.bttao);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.dtglogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbtennv1);
            this.Controls.Add(this.cbmanv1);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormQuanLytk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.FormQuanLytk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtglogin)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.ComboBox cbmanv1;
        private System.Windows.Forms.TextBox tbtennv1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtglogin;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.RadioButton rbuser;
        private System.Windows.Forms.RadioButton rbten;
        private System.Windows.Forms.RadioButton rbma;
        private System.Windows.Forms.Label lbtimk;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox tbtim;
        private System.Windows.Forms.Button bttao;
        private System.Windows.Forms.Label lnan;
        private System.Windows.Forms.Button btnot;
        private System.Windows.Forms.Button bthome;
    }
}