using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exel = Microsoft.Office.Interop.Excel;

namespace BaiTapLonLTTQ
{
    public partial class FormHDBan : Form
    {
        BanHang2017.Classes.DataProcess dtbase = new BanHang2017.Classes.DataProcess();
        int ok = 0;
        public FormHDBan()
        {
            InitializeComponent();
        }

        private void FormHDBan_Load(object sender, EventArgs e)
        {
           
            string sql1;
            if(ểvedasxag5B.quyen==3)
            {
                string q = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
                DataTable u = new DataTable();
                u = dtbase.SelectTable(q);
                sql1 = "select* from dbo.HoaDonBan where MaNV='"+u.Rows[0][0]+"'";
            }
            else
            {
                 sql1 = "select* from dbo.HoaDonBan ";
            }
            DataTable h = new DataTable();
            h = dtbase.SelectTable(sql1);
            cbmahd.DataSource = h;
            cbmahd.DisplayMember = "MaHDB";
            cbmahd.ValueMember = "MaHDB";
            //load masp
            string sql2 = "select *from dbo.SanPham";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(sql2);
            cbmasp.DataSource = k;
            cbmasp.DisplayMember = "MaSP";
            cbmasp.ValueMember = "MaSP";
            groupBox2.Enabled = true;
            tbsl.Text = "";
            ok = 0;
            cbmahd.Enabled = true;
            cbmahd.DropDownStyle = ComboBoxStyle.DropDownList;
            dtp.Enabled = false;
            if(ểvedasxag5B.quyen==2)
            {
                bthem.Visible = false;
                btluu.Visible = false;
                bthuy.Visible = false;
                btthanhtoan.Visible = false;
                btin.Visible = false;
                btthoat.Visible = false;
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbmahd_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable h1 = new DataTable();
            string sql1 = "select* from dbo.HoaDonBan where MaHDB='"+cbmahd.Text+"' ";
            h1 = dtbase.SelectTable(sql1);
            cbmanv.DataSource = h1;
            cbmanv.DisplayMember = "MaNV";
            cbmanv.ValueMember = "MaNV";
            cbmakh.DataSource = h1;
            cbmakh.DisplayMember = "MaKH";
            cbmakh.ValueMember = "MaKH";

            SqlConnection con = dtbase.laycon();
            con.Open();
            SqlCommand cm = new SqlCommand(sql1, con);
            SqlDataReader rd = cm.ExecuteReader();
            if(rd.HasRows)
            {
                
                rd.Read();
                dtp.Text = rd.GetDateTime(3).ToString();
                cbmanv.Text = rd.GetString(1).ToString();
                cbmakh.Text = rd.GetString(2).ToString();

            }
            string s = "select ao.MaSP,SanPham.TenSP,GiaBan,SoLuong,Sale,(GiaBan*SoLuong*((100-sale)/100)) as thanhtien from ao inner join dbo.SanPham on dbo.SanPham.MaSP=ao.MaSP where MaHDB='"+cbmahd.Text+"'";
            DataTable l = new DataTable();
            l = dtbase.SelectTable(s);
            dtgview.DataSource = l;
            dtgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgview.Columns[0].HeaderText = "Mã SP";
            dtgview.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgview.Columns[2].HeaderText = "Đơn Giá";
            dtgview.Columns[3].HeaderText = "Số Lượng";
            dtgview.Columns[4].HeaderText = "Giảm Giá";
            dtgview.Columns[5].HeaderText = "Thành Tiền";
            DataTable kk = new DataTable();
            kk = dtbase.SelectTable(" select sum(GiaBan*SoLuong*((100-sale)/100)) as thanhtien from ao where MaHDB = '"+cbmahd.Text+"'");
            tbtotal.Text = kk.Rows[0][0].ToString();
        }

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = "select *from dbo.NhanVien where MaNV='"+cbmanv.SelectedValue.ToString()+"'";
            DataTable p = new DataTable();
            p = dtbase.SelectTable(s1);
            tbnv.Text = p.Rows[0][1].ToString();
        }

        private void cbmakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s1 = "select *from dbo.KhachHang where MaKH='" + cbmakh.SelectedValue.ToString() + "'";
            DataTable p = new DataTable();
            p = dtbase.SelectTable(s1);
            tbtenkh.Text = p.Rows[0][1].ToString();
            tbdiachi.Text = p.Rows[0][2].ToString();
            tbsdt.Text = p.Rows[0][4].ToString();
            string sq = " select distinct dbo.kt('" + cbmasp.Text + "','" + dtp.Text + "','" + cbmakh.Text + "') from dbo.SanPham,dbo.KhachHang";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(sq);
            tbgiamgia.Text = k.Rows[0][0].ToString();
        }

        private void dtgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbmasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = dtbase.laycon();
            string s = "select *from dbo.SanPham where MaSP='"+cbmasp.Text+"'";
            con.Open();
            SqlCommand cm = new SqlCommand(s, con);
            SqlDataReader rd = cm.ExecuteReader();
            if(rd.HasRows)
            {
                rd.Read();
                tbsp.Text = rd.GetString(1).ToString();
                tbdg.Text = rd.GetInt32(8).ToString();
            }
            string sq = " select distinct dbo.kt('"+cbmasp.Text+"','"+dtp.Text+"','"+cbmakh.Text+"') from dbo.SanPham,dbo.KhachHang";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(sq);
            tbgiamgia.Text =k.Rows[0][0].ToString();
        }

        private void tbsl_TextChanged(object sender, EventArgs e)
        {
            if (tbsl.Text == "")
            {
                int k = Convert.ToInt32("0") * Convert.ToInt32(tbdg.Text);
                tbthanhtien.Text = k.ToString();
            }
            else
            {
                try
                {
                    double k = Convert.ToInt32(tbsl.Text) * Convert.ToInt32(tbdg.Text)*((100-Convert.ToDouble(tbgiamgia.Text))/100);
                    tbthanhtien.Text = k.ToString();
                }
                catch(FormatException) { MessageBox.Show("Bạn hãy nhập vào 1 số!", "TB"); tbsl.Focus(); tbsl.Text = ""; }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy hóa đơn này không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable l = new DataTable();
                l = dtbase.SelectTable("select *from dbo.CTHoaDonBan where dbo.CTHoaDonBan.MaHDB='" + cbmahd.Text + "'");
                int k = l.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    DataTable dthang = dtbase.SelectTable("select * from dbo.SanPham where MaSP='" + l.Rows[i][1].ToString() + "'");
                    int soluongcu = Convert.ToInt32(dthang.Rows[0][7].ToString());
                    int soluongmoi = soluongcu + Convert.ToInt32(l.Rows[i][3].ToString());
                    dtbase.UpdateData("update dbo.SanPham set dbo.SanPham.SLton=" + soluongmoi + " where MaSP='" + l.Rows[i][1].ToString() + "'");
                }
                dtbase.UpdateData("Delete dbo.CTHoaDonBan where dbo.CTHoaDonBan.MaHDB='" + cbmahd.Text + "'");
                dtbase.UpdateData("Delete dbo.HoaDonBan where dbo.HoaDonBan.MaHDB='" + cbmahd.Text + "'");
                MessageBox.Show("Bạn Đã Hủy Thành Công", "TB");
                FormHDBan_Load(sender, e);
            }
        }

        private void bthem_Click(object sender, EventArgs e)
        {
            ok = 1;
            cbmahd.DropDownStyle = ComboBoxStyle.DropDown;
            cbmahd.Enabled = false;
            dtp.Enabled = true;
            Random r = new Random();
       b2:  string ma = "HD"+r.Next(1,100000)+"";
            DataTable h = new DataTable();
            h = dtbase.SelectTable("select *from dbo.HoaDonBan where MaHDB='"+ma+"'");
            if (h.Rows.Count == 0) cbmahd.Text = ma;
            else goto b2;
            dtp.Text = DateTime.Now.ToString();
            DataTable k3 = new DataTable();
             k3 = dtbase.SelectTable("select *from dbo.NhanVien");
             cbmanv.DataSource = k3;
             cbmanv.DisplayMember = "MaNV";
             cbmanv.ValueMember = "MaNV";
            string u = Properties.Settings.Default.user;
            DataTable k = new DataTable();
            cbmanv.SelectedIndex = 0;
            k = dtbase.SelectTable("select dbo.[User].MaNV,TenNV from dbo.[User] inner join dbo.NhanVien on dbo.[User].MaNV=dbo.NhanVien.MaNV where dbo.[User].Username='"+u+"'");
            cbmanv.DataSource = k;
            DataTable k1 = new DataTable();
            k1 = dtbase.SelectTable("select *from dbo.KhachHang");
            cbmakh.DataSource = k1;
            cbmakh.DisplayMember = "MaKH";
            cbmakh.ValueMember = "MaKH";
            dtgview.DataSource = null;
        }

        private void tbgiamgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            string sq = " select distinct dbo.kt('" + cbmasp.Text + "','" + dtp.Text + "','" + cbmakh.Text + "') from dbo.SanPham,dbo.KhachHang";
            DataTable k = new DataTable();
            k = dtbase.SelectTable(sq);
            tbgiamgia.Text = k.Rows[0][0].ToString();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            if(ok==0)
            {
                string s = "select *from dbo.CTHoaDonBan where MaHDB='" + cbmahd.Text + "' and MaSP='" + cbmasp.Text + "'";
                DataTable h = new DataTable();
                h = dtbase.SelectTable(s);
                DataTable hr = new DataTable();
                hr = dtbase.SelectTable("select *from dbo.SanPham where MaSP='" + cbmasp.Text + "'");
                int kt1 = Convert.ToInt32(hr.Rows[0][7].ToString()) - Convert.ToInt32(tbsl.Text);
                if (kt1 < 0)
                {
                    MessageBox.Show("Sản phẩm này không đủ chỉ còn " + Convert.ToInt32(hr.Rows[0][7].ToString()) + " sản phẩm", "TB");
                    tbsl.Text = "";
                    tbsl.Focus();
                }
                else
                {
                    if (h.Rows.Count > 0)
                    {
                        DataTable hq = new DataTable();
                        hq = dtbase.SelectTable("select *from dbo.SanPham where MaSP='" + cbmasp.Text + "'");
                        DataTable hq1 = new DataTable();
                        hq1 = dtbase.SelectTable("select *from dbo.CTHoaDonBan where MaSP='" + cbmasp.Text + "' and MaHDB='" + cbmahd.Text + "'");
                        int slc = Convert.ToInt32(hq.Rows[0][7].ToString());
                        int slm = slc - Convert.ToInt32(tbsl.Text);
                        double tt = Convert.ToInt32(hq1.Rows[0][4]);
                        double tt1 = tt + Convert.ToDouble(tbthanhtien.Text);
                        string update = "update dbo.SanPham set SLton=" + slm + " where MaSP='" + cbmasp.Text + "'";
                        dtbase.UpdateData(update);
                        int m = (Convert.ToInt32(tbsl.Text) + Convert.ToInt32(hq1.Rows[0][3].ToString()));
                        dtbase.UpdateData("delete dbo.CTHoaDonBan where MaHDB='" + cbmahd.Text + "' and MaSP='" + cbmasp.Text + "'");
                        dtbase.UpdateData("insert into dbo.CTHoaDonBan values('" + cbmahd.Text + "','" + cbmasp.Text + "'," + Convert.ToInt32(tbdg.Text) + "," + m + ","+tt1+")");
                        MessageBox.Show("Cập nhật thành công!", "TB");
                        string l = "" + cbmahd.Text + "";
                        FormHDBan_Load(sender, e);
                        cbmahd.SelectedValue = l;
                    }
                    else
                    {
                        double p= Convert.ToDouble(tbthanhtien.Text);
                        int slc = Convert.ToInt32(hr.Rows[0][7].ToString());
                        int slm = slc - Convert.ToInt32(tbsl.Text);
                        string update = "update dbo.SanPham set SLton=" + slm + " where MaSP='" + cbmasp.Text + "'";
                        dtbase.UpdateData(update);
                        dtbase.UpdateData("insert into dbo.CTHoaDonBan values('" + cbmahd.Text + "','" + cbmasp.Text + "'," + Convert.ToInt32(tbdg.Text) + "," + Convert.ToInt32(tbsl.Text) + ","+p+")");
                        MessageBox.Show("Thêm Sản Phẩm Thành Công!", "TB");
                        string l = "" + cbmahd.Text + "";
                        FormHDBan_Load(sender, e);
                        cbmahd.SelectedValue = l;
                    }
                }
            }
            else
            {
                string s = "select *from dbo.CTHoaDonBan where MaHDB='" + cbmahd.Text + "' and MaSP='" + cbmasp.Text + "'";
                DataTable h = new DataTable();
                h = dtbase.SelectTable(s);
                DataTable hr = new DataTable();
                hr = dtbase.SelectTable("select *from dbo.SanPham where MaSP='" + cbmasp.Text + "'");
                int kt1 = Convert.ToInt32(hr.Rows[0][7].ToString()) - Convert.ToInt32(tbsl.Text);
                if (kt1 < 0)
                {
                    if (MessageBox.Show("Sản phẩm này không đủ chỉ còn " + Convert.ToInt32(hr.Rows[0][7].ToString()) + " sản phẩm! Bạn có muốn lập hóa đơn nữa không?", "TB",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        tbsl.Text = "";
                        tbsl.Focus();
                    }
                    else FormHDBan_Load(sender, e);
                }
                else
                {
                    double p = Convert.ToDouble(tbthanhtien.Text);
                    string s3 = "update dbo.SanPham set dbo.SanPham.SLton=" + kt1 + " where MaSP='" + cbmasp.Text + "'";
                    dtbase.UpdateData(s3);
                    string s1 = "INSERT INTO dbo.HoaDonBan VALUES('" + cbmahd.Text + "','" + cbmanv.Text + "','" + cbmakh.Text + "','" + Convert.ToDateTime(dtp.Text.ToString()) + "','')";
                    dtbase.UpdateData(s1);
                    string s2 = "INSERT INTO dbo.CTHoaDonBan VALUES('" + cbmahd.Text + "','" + cbmasp.Text + "',"+Convert.ToInt32(tbdg.Text)+"," + Convert.ToInt32(tbsl.Text) + ","+p+")";
                    dtbase.UpdateData(s2);
                    MessageBox.Show("Bạn Đã Thêm Thành Công", "Thông Báo");
                    string l = "" + cbmahd.Text + "";
                    FormHDBan_Load(sender, e);
                    cbmahd.SelectedValue = l;
                    ok = 0;
                }
            }
            
           

        }

        private void dtgview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Sản Phẩm này ra khỏi hóa đơn không?", "TB", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtgview.Rows.Count == 2)
                {
                    MessageBox.Show("Còn 1 mặt hàng bạn nên hủy hóa đơn này đi", "TB");
                        FormHDBan_Load(sender, e);
                }
                else
                {
                    DataTable dthang = dtbase.SelectTable("select * from dbo.SanPham where MaSP='" + dtgview.CurrentRow.Cells[0].Value.ToString() + "'");
                    int soluongcu = Convert.ToInt32(dthang.Rows[0][7].ToString());
                    int soluongmoi = soluongcu + Convert.ToInt32(dtgview.CurrentRow.Cells[3].Value.ToString());
                    dtbase.UpdateData("update dbo.SanPham set dbo.SanPham.SLton=" + soluongmoi + " where MaSP='" + dtgview.CurrentRow.Cells[0].Value.ToString() + "'");
                    dtbase.UpdateData("Delete dbo.CTHoaDonBan where MaHDB='" + cbmahd.Text + "' and MaSP='" + dtgview.CurrentRow.Cells[0].Value.ToString() + "'");
                    string l = "" + cbmahd.Text + "";
                    FormHDBan_Load(sender, e);
                    cbmahd.SelectedValue = l;
                   
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbnhan.Enabled = true;
            btin.Enabled = true;
            lbnhan.Text = "Số Tiền Khách Đưa";
            lbtra.Text = "Tiền Trả Lại";
            

        }

        private void tbnhan_TextChanged(object sender, EventArgs e)
        {
            if (tbnhan.Text == "")
            {
                int k = Convert.ToInt32("0") - Convert.ToInt32(tbtotal.Text);
                tbtra.Text = k.ToString();
            }
            else
            {
                try
                {
                    int k = Convert.ToInt32(tbnhan.Text) - Convert.ToInt32(tbtotal.Text);
                    tbtra.Text = k.ToString();
                }
                catch (FormatException) { MessageBox.Show("Vui lòng nhập số!", "TB"); tbnhan.Text = ""; tbnhan.Focus(); }
            }
           
        }

        private void btin_Click(object sender, EventArgs e)
        {
            exel.Application app = new exel.Application();
            exel.Workbook book = app.Workbooks.Add(exel.XlWBATemplate.xlWBATWorksheet);
            exel.Worksheet ss = (exel.Worksheet)book.ActiveSheet;
            exel.Range tenCuaHang = (exel.Range)ss.Cells[1, 1];
            tenCuaHang.Font.Size = 12; tenCuaHang.Font.Bold = true;
            tenCuaHang.Font.Color = Color.Blue;
            tenCuaHang.Value = "CỬA HÀNG LINH KIỆN Ô TÔ";

            exel.Range dcCuaHang = (exel.Range)ss.Cells[2, 1];
            dcCuaHang.Font.Size = 12;
            dcCuaHang.Font.Bold = true;
            dcCuaHang.Font.Color = Color.Blue;
            dcCuaHang.Value = "Địa chỉ: 1194 - Đường Láng - Hà Nội";

            exel.Range dtCuaHang = (exel.Range)ss.Cells[3, 1];
            dtCuaHang.Font.Size = 12; dtCuaHang.Font.Bold = true;
            dtCuaHang.Font.Color = Color.Blue;
            dtCuaHang.Value = "Điện thoại: 012987667";


            exel.Range header = (exel.Range)ss.Cells[8, 7];
            ss.get_Range("G8:H8").Merge(true);
            header.Font.Size = 13;
            header.Font.Bold = true;
            header.Font.Color = Color.Red;
            header.Value = "HÓA ĐƠN";

            exel.Range dcTenKH = (exel.Range)ss.Cells[5, 1];
            dcTenKH.Font.Size = 10;
            dcTenKH.Font.Bold = true;
            dcTenKH.Font.Color = Color.Black;
            dcTenKH.Value = "Tên Khách Hàng:";

            exel.Range dcdiachi = (exel.Range)ss.Cells[6, 1];
            dcdiachi.Font.Size = 10;
            dcdiachi.Font.Bold = true;
            dcdiachi.Font.Color = Color.Black;
            dcdiachi.Value = "Địa Chỉ:";

            exel.Range dcSDT = (exel.Range)ss.Cells[7, 1];
            dcSDT.Font.Size = 10;
            dcSDT.Font.Bold = true;
            dcSDT.Font.Color = Color.Black;
            dcSDT.Value = "Số Điện Thoại:";
            ss.Cells[5, 3] = tbtenkh.Text;
            ss.Cells[6, 3] = tbdiachi.Text;
            exel.Range sdt = (exel.Range)ss.Cells[7, 3];
            ss.get_Range("C7:D7").Merge(true);
            sdt.Value = "" + tbsdt.Text + "";
            exel.Range stt = (exel.Range)ss.Cells[11, 4];
            stt.Value = "STT";
            ss.get_Range("F11:G11").Merge(true);
            ss.get_Range("J11:K11").Merge(true);
          /*  for (int i = 1; i <= dtgview.Rows.Count - 1; i++)
            {
                ss.Cells[i + 11, 4] = i;
            }*/
            for (int i = 0; i < dtgview.Columns.Count; i++)
            {
                ss.Cells[11, i + 5] = dtgview.Columns[i].HeaderText;
            }

            for (int i = 1; i < dtgview.Rows.Count; i++)
            {
                for (int j = 1; j <= dtgview.Columns.Count; j++)
                    if (dtgview.Rows[i - 1].Cells[j - 1].Value != null)
                    {
                        ss.get_Range("F"+(i+11)+":G"+(i+11)+"").Merge(true);
                        ss.get_Range("J" + (i + 11) + ":K" + (i + 11) + "").Merge(true);
                        ss.Cells[i + 11, j + 4] = dtgview.Rows[i - 1].Cells[j - 1].Value.ToString();
                    }
            }
            int k = dtgview.Rows.Count;
            ss.get_Range("J" + (k + 11) + ":K" + (k + 11) + "").Merge(true);
            ss.get_Range("G" + (k + 11) + ":H" + (k + 11) + "").Merge(true);
            ss.Cells[k + 11, 7] = "Tổng Tiền";
            ss.Cells[k + 11, 10] = tbtotal.Text;
            ss.get_Range("J" + (k + 12) + ":K" + (k + 12) + "").Merge(true);
            ss.get_Range("G" + (k + 12) + ":H" + (k + 12) + "").Merge(true);
            ss.Cells[k + 12, 7] = "Khách Đưa";
            ss.Cells[k + 12, 10] = tbnhan.Text;
            ss.get_Range("J" + (k + 13) + ":K" + (k + 13) + "").Merge(true);
            ss.get_Range("G" + (k + 13) + ":H" + (k + 13) + "").Merge(true);
            ss.Cells[k + 13, 7] = "Trả Lại";
            ss.Cells[k + 13, 10] = tbtra.Text;


            book.Activate();
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Excel Document(*.xls)|*.xls  |Word Document(*.doc) |*.doc|All files(*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".xls";
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            book.SaveAs(dlgSave.FileName.ToString());
            app.Quit();
            lbnhan.Text = "";
            lbtra.Text = "";
            tbnhan.Text = "";
            tbnhan.Enabled = false;
            tbtra.Text = "";
            btin.Enabled = false;
                
        }
    }
}
