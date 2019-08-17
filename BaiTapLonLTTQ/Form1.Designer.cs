namespace BaiTapLonLTTQ
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbuser1 = new System.Windows.Forms.TextBox();
            this.tbnv1 = new System.Windows.Forms.TextBox();
            this.tbpw1 = new System.Windows.Forms.TextBox();
            this.btlogin = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbdangnhap1 = new System.Windows.Forms.Label();
            this.lbhien = new System.Windows.Forms.Label();
            this.ckhien = new System.Windows.Forms.CheckBox();
            this.cknho = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // tbuser1
            // 
            this.tbuser1.Location = new System.Drawing.Point(255, 118);
            this.tbuser1.Name = "tbuser1";
            this.tbuser1.Size = new System.Drawing.Size(281, 20);
            this.tbuser1.TabIndex = 4;
            this.tbuser1.TextChanged += new System.EventHandler(this.tbuser1_TextChanged);
            // 
            // tbnv1
            // 
            this.tbnv1.Location = new System.Drawing.Point(255, 168);
            this.tbnv1.Name = "tbnv1";
            this.tbnv1.ReadOnly = true;
            this.tbnv1.Size = new System.Drawing.Size(281, 20);
            this.tbnv1.TabIndex = 5;
            // 
            // tbpw1
            // 
            this.tbpw1.Location = new System.Drawing.Point(255, 213);
            this.tbpw1.Multiline = true;
            this.tbpw1.Name = "tbpw1";
            this.tbpw1.PasswordChar = '*';
            this.tbpw1.Size = new System.Drawing.Size(281, 20);
            this.tbpw1.TabIndex = 6;
            this.tbpw1.TextChanged += new System.EventHandler(this.tbpw1_TextChanged);
            // 
            // btlogin
            // 
            this.btlogin.Image = global::BaiTapLonLTTQ.Properties.Resources.Apply_16x16;
            this.btlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btlogin.Location = new System.Drawing.Point(255, 317);
            this.btlogin.Name = "btlogin";
            this.btlogin.Size = new System.Drawing.Size(75, 23);
            this.btlogin.TabIndex = 7;
            this.btlogin.Text = "   Log in";
            this.btlogin.UseVisualStyleBackColor = true;
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // btexit
            // 
            this.btexit.Image = global::BaiTapLonLTTQ.Properties.Resources.Cancel_16x16;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(461, 317);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 9;
            this.btexit.Text = "   Exit";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lbdangnhap1
            // 
            this.lbdangnhap1.AutoSize = true;
            this.lbdangnhap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangnhap1.ForeColor = System.Drawing.Color.Red;
            this.lbdangnhap1.Location = new System.Drawing.Point(266, 62);
            this.lbdangnhap1.Name = "lbdangnhap1";
            this.lbdangnhap1.Size = new System.Drawing.Size(85, 16);
            this.lbdangnhap1.TabIndex = 10;
            this.lbdangnhap1.Text = "Đăng Nhập";
            // 
            // lbhien
            // 
            this.lbhien.AutoSize = true;
            this.lbhien.ForeColor = System.Drawing.Color.Red;
            this.lbhien.Location = new System.Drawing.Point(252, 251);
            this.lbhien.Name = "lbhien";
            this.lbhien.Size = new System.Drawing.Size(43, 13);
            this.lbhien.TabIndex = 11;
            this.lbhien.Text = "            ";
            // 
            // ckhien
            // 
            this.ckhien.AutoSize = true;
            this.ckhien.Location = new System.Drawing.Point(255, 279);
            this.ckhien.Name = "ckhien";
            this.ckhien.Size = new System.Drawing.Size(95, 17);
            this.ckhien.TabIndex = 12;
            this.ckhien.Text = "Hiện mật khẩu";
            this.ckhien.UseVisualStyleBackColor = true;
            this.ckhien.CheckedChanged += new System.EventHandler(this.ckhien_CheckedChanged);
            // 
            // cknho
            // 
            this.cknho.AutoSize = true;
            this.cknho.Location = new System.Drawing.Point(461, 279);
            this.cknho.Name = "cknho";
            this.cknho.Size = new System.Drawing.Size(93, 17);
            this.cknho.TabIndex = 13;
            this.cknho.Text = "Nhớ mật khẩu";
            this.cknho.UseVisualStyleBackColor = true;
            this.cknho.CheckedChanged += new System.EventHandler(this.cknho_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 369);
            this.Controls.Add(this.cknho);
            this.Controls.Add(this.ckhien);
            this.Controls.Add(this.lbhien);
            this.Controls.Add(this.lbdangnhap1);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btlogin);
            this.Controls.Add(this.tbpw1);
            this.Controls.Add(this.tbnv1);
            this.Controls.Add(this.tbuser1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbuser1;
        private System.Windows.Forms.TextBox tbnv1;
        private System.Windows.Forms.TextBox tbpw1;
        private System.Windows.Forms.Button btlogin;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lbdangnhap1;
        private System.Windows.Forms.Label lbhien;
        private System.Windows.Forms.CheckBox ckhien;
        private System.Windows.Forms.CheckBox cknho;
    }
}

