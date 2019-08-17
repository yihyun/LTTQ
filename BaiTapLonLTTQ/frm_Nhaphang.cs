using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThucHanh1;
using Excel = Microsoft.Office.Interop.Excel;
using BaiTapLonLTTQ;
namespace BTL_BacVu
{
    public partial class frm_nhaphang : Form
    {
        Dataprocess dtprocess = new Dataprocess();
        int selectRowNow;
        int them = -1, sua = -1, loiThemHDN = 0;
        int dangsua = 0;
        Boolean loadSL = true;
        public frm_nhaphang()
        {
            InitializeComponent();
            loadcombobox();
            loadcombobox1();
            Loaddata();
            loadTenNCC();
            congtac(true);
            phanquyen();
        }
        private void phanquyen()
        {
            if(ểvedasxag5B.quyen==2)
            {
                btn_in.Visible = false;
                btn_luu.Visible = false;
                btt_lammoi.Visible = false;
                btt_ok.Visible = false;
                btt_them.Visible = false;
                btt_xoa.Visible = false;
                btt_sua.Visible = false;
            }
        }
        private void cbb_MaHDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Loaddata();
                loadMaSP(cbb_MaHDN.SelectedValue.ToString());
                loadGridview(cbb_MaHDN.SelectedValue.ToString());
                tinhtongtien();
                loadSL_CTHDB(true);
            }
            catch { }
        }
        private void Loaddata()
        {
            try
            {
                string sql = "SELECT CTHoaDonNhap.MaHDN,NhanVien.MaNV,TenNV," +
                    "MaNCC,NgayNhap,GhiChu,GiaNhap,SoLuong FROM HoaDonNhap JOIN " +
                    "CTHoaDonNhap ON CTHoaDonNhap.MaHDN = HoaDonNhap.MaHDN JOIN " +
                    "NhanVien ON NhanVien.MaNV = HoaDonNhap.MaNV WHERE CTHoaDonNhap.MaHDN = '" + cbb_MaHDN.SelectedValue.ToString() + "'";
                dtprocess.OpenConnect();
                SqlCommand cm = new SqlCommand(sql, dtprocess.sqlConn);
                SqlDataReader rd = cm.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                    cbb_MaNV.Text = rd.GetString(1).ToString();
                    txt_TenNV.Text = rd.GetString(2).ToString();
                    cbb_MaNCC.Text = rd.GetString(3).ToString();
                    DTpicker_ngaynhap.Text = rd.GetSqlDateTime(4).ToString();
                    try
                    {
                        richtext_ghichu.Text = rd.GetString(5).ToString();
                    }
                    catch
                    {
                        richtext_ghichu.Text = "";
                    }
                    //txt_NhaCC.Text = rd.GetString(1).ToString();
                    loadMaSP(cbb_MaHDN.SelectedValue.ToString());
                    //txt_TenSP.Text = rd.GetString(1).ToString();
                }
                rd.Close();
                dtprocess.CloseConnect();
                loadSL_CTHDB(true);
                loadGridview(cbb_MaHDN.SelectedValue.ToString());
                tinhtongtien();
                // loadTenNCC();
            }
            catch { }
        }
        private void txt_soluong1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập số");
            }
        }
        private void cbb_MaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTenSP();
            loadSL_CTHDB(loadSL);
            try
            {
                dtprocess.OpenConnect();
                SqlCommand cm = new SqlCommand("SELECT SanPham.MaSP,SanPham.TenSP, SoLuong,GiaNhap FROM dbo.SanPham JOIN dbo.CTHoaDonNhap ON CTHoaDonNhap.MaSP = SanPham.MaSP where CTHoaDonNhap.MaSP = '" + cbb_MaSP.SelectedValue.ToString() + "'", dtprocess.sqlConn);
                SqlDataReader rd = cm.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Read();
                   // txt_TenSP.Text = rd.GetString(1).ToString();
                    string gianhap = rd.GetSqlValue(3).ToString();
                    string[] gianhap1 = gianhap.Split('.');
                    txt_gianhap.Text = gianhap1[0];
                }
                rd.Close();
                dtprocess.CloseConnect();
            }
            catch { }
        }
        private void loadSL_CTHDB(Boolean ok)
        {
             if(ok==true)
             {
                try
                {
                    string sql = "SELECT SanPham.MaSP,TenSP, SoLuong,GiaNhap FROM dbo.SanPham JOIN dbo.CTHoaDonNhap ON CTHoaDonNhap.MaSP = SanPham.MaSP where CTHoaDonNhap.MaSP = '" + cbb_MaSP.SelectedValue.ToString() + "' and dbo.CTHoaDonNhap.MaHDN = '" + cbb_MaHDN.SelectedValue.ToString().Trim() + "'";
                    dtprocess.OpenConnect();
                    //MessageBox.Show(sql);
                    SqlCommand cm = new SqlCommand(sql, dtprocess.sqlConn);
                    SqlDataReader rd = cm.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        txt_soluong.Text = rd.GetSqlInt32(2).ToString();
                    }
                    rd.Close();
                    dtprocess.CloseConnect();
                }
                catch { }
             }
        }
        private void cbb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT MaNV,TenNV FROM dbo.NhanVien where MaNV = '" + cbb_MaNV.SelectedValue.ToString() + "'", dtprocess.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_TenNV.Text = rd.GetString(1).ToString();
            }
            rd.Close();
            dtprocess.CloseConnect();
        }
        private void txt_soluong1_TextChanged(object sender, EventArgs e)
        {
            if (txt_gianhap.Text != "" && txt_soluong.Text != "")
            {
                long gia, sl = 0;
                try
                {
                    sl = Convert.ToInt32(txt_soluong.Text.ToString());
                    string dk = txt_gianhap.Text;
                    string[] dk1 = dk.Split('.');
                    gia = Convert.ToInt32(dk1[0]);
                }
                catch
                {
                    sl = 0;
                    gia = 0;
                }
                txt_thanhtien.Text = " " + (sl * gia);
            }
            else txt_thanhtien.Text = "0";
        }
        private void Gridview_HDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectRowNow = e.RowIndex;
            try
            {
                int hang = e.RowIndex;
                cbb_MaSP.Text = Gridview_HDN.Rows[hang].Cells[0].Value.ToString();
                txt_TenSP.Text = Gridview_HDN.Rows[hang].Cells[1].Value.ToString();
                txt_soluong.Text = Gridview_HDN.Rows[hang].Cells[2].Value.ToString();
                txt_gianhap.Text = Gridview_HDN.Rows[hang].Cells[3].Value.ToString();
                txt_thanhtien.Text = Gridview_HDN.Rows[hang].Cells[4].Value.ToString();
            }
            catch
            {

            }
        }
        private void Gridview_HDN_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Gridview_HDN.RowCount != 1)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa ", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteCTHD();
                    try
                    {
                        cbb_MaSP.Text = Gridview_HDN.Rows[0].Cells[0].Value.ToString().Trim();
                    }
                    catch
                    {
                    }
                    if (Gridview_HDN.RowCount == 1)
                    {
                        if (MessageBox.Show("Hóa đơn này không có sp nào ban có muôn xóa HĐ k?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            deleteHDN();
                        }
                    }
                }
                else
                {
                    loadGridview(cbb_MaHDN.Text);
                }
            }
            else
            {
                if (MessageBox.Show("Hóa đơn này không có sp nào ban có muôn xóa HĐ k?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteHDN();
                }
            }
        }

        private void loadcombobox()
        {
            DataTable dtt = new DataTable();
            //load lên mã hóa đơn nhập
            string sql = "SELECT * FROM HoaDonNhap";
            if(ểvedasxag5B.quyen == 3)
            {
                string q = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
                DataTable u = new DataTable();
                u = dtprocess.SelectTable(q);
                sql = "SELECT * FROM HoaDonNhap where MaNV='" + u.Rows[0][0] + "'";
            }
            dtt = dtprocess.SelectTable(sql);
            cbb_MaHDN.DataSource = dtt;
            cbb_MaHDN.DisplayMember = "MaHDN";
            cbb_MaHDN.ValueMember = "MaHDN";

            dtt = dtprocess.SelectTable("SELECT * FROM NhaCungCap");
            cbb_MaNCC.DataSource = dtt;
            cbb_MaNCC.DisplayMember = "MaNCC";
            cbb_MaNCC.ValueMember = "MaNCC";

        }
        private void loadcombobox1()
        {
            DataTable dtt = new DataTable();
            //load lên Mã nhân viên
            //string sql = "SELECT * FROM NhanVien";
            string sql = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
            if (ểvedasxag5B.quyen == 3)
            {
                string q = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
                DataTable u = new DataTable();
                u = dtprocess.SelectTable(q);
                sql = "SELECT * FROM NhanVien where MaNV='" + u.Rows[0][0] + "'";
            }
            dtt = dtprocess.SelectTable(sql);
            cbb_MaNV.DataSource = dtt;
            cbb_MaNV.DisplayMember = "MaNV";
            cbb_MaNV.ValueMember = "MaNV";

            //load lên mã nhà cung cấp

            //load lên mã sản phẩm
            loadMaSP();
        }
        private void loadMaSP()
        {
            DataTable dtt = new DataTable();
            dtt = dtprocess.SelectTable("SELECT * FROM SanPham");
            cbb_MaSP.DataSource = dtt;
            cbb_MaSP.DisplayMember = "MaSP";
            cbb_MaSP.ValueMember = "MaSP";
        }
        private void loadMaNV()
        {
            DataTable dtt = new DataTable();
            //load lên Mã nhân viên
            //string sql = "SELECT * FROM NhanVien";
            string sql = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
            if (ểvedasxag5B.quyen == 3)
            {
                string q = "select *from dbo.[User] where username='" + ểvedasxag5B.username + "'";
                DataTable u = new DataTable();
                u = dtprocess.SelectTable(q);
                sql = "SELECT * FROM NhanVien where = MaNV='" + u.Rows[0][0] + "'";
            }
            dtt = dtprocess.SelectTable(sql);
            cbb_MaNV.DataSource = dtt;
            cbb_MaNV.DisplayMember = "MaNV";
            cbb_MaNV.ValueMember = "MaNV";
        }
        private void tinhtongtien()
        {
            int sohang = Gridview_HDN.RowCount;
            long tien = 0;
            for (int i = 0; i < sohang; i++)
            {
                long t;
                try
                {
                    string dk1 = Gridview_HDN.Rows[i].Cells[4].Value.ToString();
                    string[] dk = dk1.Split('.');
                    t = Convert.ToInt32(dk[0]);
                }
                catch
                {
                    t = 0;
                }
                tien += t;
            }
            txt_tongtien.Text = "" + tien;
        }
        private void loadMaSP(String dk)
        {
            DataTable dtt = new DataTable();
            //load lên mã hóa đơn nhập
            dtt = dtprocess.SelectTable("SELECT CTHoaDonNhap.MaSP  FROM dbo.SanPham JOIN dbo.CTHoaDonNhap ON CTHoaDonNhap.MaSP = SanPham.MaSP WHERE MaHDN = '" + dk + "'");
            cbb_MaSP.DataSource = dtt;
            cbb_MaSP.DisplayMember = "MaSP";
            cbb_MaSP.ValueMember = "MaSP";
            btt_ok.Enabled = false;
            btt_huy.Enabled = false;
        }
        private void loadGridview(string dk)
        {
            DataTable dtt = new DataTable();
            //load lên mã hóa đơn nhập
            dtt = dtprocess.SelectTable("SELECT CTHoaDonNhap.MaSP,TenSP,SoLuong,GiaNhap,SoLuong*GiaNhap AS 'Thành Tiền' FROM dbo.SanPham JOIN dbo.CTHoaDonNhap ON CTHoaDonNhap.MaSP = SanPham.MaSP JOIN dbo.HoaDonNhap ON HoaDonNhap.MaHDN = CTHoaDonNhap.MaHDN where CTHoaDonNhap.MaHDN = '" + dk + "'");
            Gridview_HDN.DataSource = dtt;
            Gridview_HDN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tinhtongtien();
        }
        private void loadTenNCC()
        {
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT * FROM NhaCungCap where MaNCC = '" + cbb_MaNCC.SelectedValue.ToString() + "'", dtprocess.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                richtxt_TeNCC.Text = rd.GetString(1).ToString();
            }
            rd.Close();
            dtprocess.CloseConnect();
        }
        private void loadTenSP()
        {
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT * FROM SanPham where MaSP = '" + cbb_MaSP.SelectedValue.ToString() + "'", dtprocess.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_TenSP.Text = rd.GetString(1).ToString();
            }
            rd.Close();
            dtprocess.CloseConnect();
        }
        private void cbb_MaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadTenNCC();
        }
        private Boolean kiemtraMaHDN(string ma)
        {
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT MaHDN FROM HoaDonNhap", dtprocess.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                if (ma == rd.GetString(0).ToString())
                {
                    return false;
                }
            }
            rd.Close();
            dtprocess.CloseConnect();
            return true;
        }
        private void InsertHDN()
        {
            dtprocess.OpenConnect();
            String MaHND, MaNCC, MaNV, ngay = " ",ghichu =" ";
            MaHND = cbb_MaHDN.Text.Trim();
            if (kiemtraMaHDN(MaHND) == false)
            {
                MessageBox.Show("Mã vừa nhập bị trùng", "Lỗi Nhập", MessageBoxButtons.OK);
                cbb_MaHDN.Text = "";
                return;
            }
            MaNCC = cbb_MaNCC.Text.Trim();
            MaNV = cbb_MaNV.Text.Trim();
            ngay = DTpicker_ngaynhap.Text.Trim();
            ghichu = richtext_ghichu.Text.Trim();
            if (MaHND != "" && MaNCC != "" && MaNCC != "")
            {
                string sql = "INSERT dbo.HoaDonNhap VALUES('" + MaHND + "','" + MaNV + "','" + MaNCC + "','" + ngay + "','"+ghichu+"')";
                try
                {
                    //MessageBox.Show(sql);
                    dtprocess.UpdateData(sql);                   
                    MessageBox.Show("Đã thêm thành công hóa đơn nhập");
                    congtac(true);
                    //loadcombobox();
                    //loadcombobox1();
                    cbb_MaHDN.Text = MaHND;
                }
                catch
                {
                    MessageBox.Show("Lỗi thêm hóa đơn");
                    loiThemHDN = 1;
                }
            }
            else
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Lỗi Nhập", MessageBoxButtons.OK);
                loiThemHDN = 1;
                btt_ok.Enabled = true;
            }
            dtprocess.CloseConnect();

        }
        private void InsertCTHDN()
        {
            if (cbb_MaSP.Text != "" && txt_soluong.Text != "" && txt_gianhap.Text != "")
            {
                dtprocess.OpenConnect();
                String MaHDN1, MaSP;
                long gia;
                int soluong;
                MaHDN1 = cbb_MaHDN.Text.Trim();
                MaSP = cbb_MaSP.Text.Trim();
                try
                {
                    string dk = txt_gianhap.Text.Trim();
                    string[] dk1 = dk.Split('.');
                    gia = Convert.ToInt32(dk1[0]);
                    soluong = Convert.ToInt32(txt_soluong.Text.Trim());
                }
                catch
                {
                    gia = 0;
                    soluong = 0;
                }
                string sql = "INSERT dbo.CTHoaDonNhap VALUES('" + MaHDN1 + "','" + MaSP + "'," + gia + "," + soluong + ")";
                try
                {
                    updateSLSPTang(true, soluong, MaSP);
                    dtprocess.UpdateData(sql);
                    MessageBox.Show("Đã thêm thành công sản phẩm");
                    congtac(true);
                }
                catch
                {
                    MessageBox.Show("Sản phẩm đã có trong hóa đơn", "Lỗi", MessageBoxButtons.OK);
                    //loithemCTHDN = 1;
                    cleanCT_HDN();
                    if (sua == 0)
                    {
                        btt_ok.Enabled = true;
                    }
                }
                loadGridview(MaHDN1);
                dtprocess.CloseConnect();
            }
            else
            {
                MessageBox.Show("Cân nhập đầy đủ thông tin chi tiết hóa đơn", "Lỗi Thêm CTHDN", MessageBoxButtons.OK);
               // updateSL = false;
                btt_ok.Enabled = true;
               // loithemCTHDN =1;
            }
        }
        private void UpdateHDN()
        {
            dtprocess.OpenConnect();
            String MaHND, MaNCC, MaNV, ngay = " ", ghichu = " ";
            MaHND = cbb_MaHDN.Text.Trim();
            if (kiemtraMaHDN(MaHND) == false)
            {
                MessageBox.Show("Mã vừa nhập bị trùng", "Lỗi Nhập", MessageBoxButtons.OK);
                cbb_MaHDN.Text = "";
                return;
            }
            MaNCC = cbb_MaNCC.Text.Trim();
            MaNV = cbb_MaNV.Text.Trim();
            ngay = DTpicker_ngaynhap.Text.Trim();
            ghichu = richtext_ghichu.Text.Trim();
            if (MaHND != "" && MaNCC != "" && MaNCC != "")
            {
                string sql = "UPDATE dbo.HoaDonNhap SET  MaNV ='" + MaNV + "', MaNCC = '" + MaNCC + "', NgayNhap = '" + ngay + "',GhiChu = '" + ghichu + "' WHERE MaHDN ='"+MaHND+"'";
                try
                {
                     dtprocess.UpdateData(sql);
                     MessageBox.Show("Sửa thành công hóa đơn");
                    //MessageBox.Show(sql);
                    //congtac(true);
                    btn_luu.Visible = false;
                    dangsua = 0;
                }
                catch
                {
                    MessageBox.Show("Lỗi sửa Hóa đơn nhập");
                    btn_luu.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin", "Lỗi Nhập", MessageBoxButtons.OK);
            }
            dtprocess.CloseConnect();

        }
        private void UpdateCTHDN()
        {
            if (txt_soluong.Text != "" && txt_gianhap.Text != "")
            {
                dtprocess.OpenConnect();
                String MaHDN1, MaSP;
                long gia;
                int soluong;
                MaHDN1 = cbb_MaHDN.Text.Trim();
                MaSP = cbb_MaSP.Text.Trim();
                try
                {
                    string dk = txt_gianhap.Text.Trim();
                    string[] dk1 = dk.Split('.');
                    gia = Convert.ToInt32(dk1[0]);
                    soluong = Convert.ToInt32(txt_soluong.Text.Trim());
                }
                catch
                {
                    gia = 0;
                    soluong = 0;
                }
                string sql = "UPDATE dbo.CTHoaDonNhap SET GiaNhap = '" + gia + "', SoLuong = " + soluong +" where MaHDN ='"+MaHDN1 +"' AND MaSP = '"+MaSP+"'";
                try
                {
                    updateSLSPTang(false, soluong, MaSP);
                    dtprocess.UpdateData(sql);
                    tinhtongtien();
                    //MessageBox.Show(sql);
                    MessageBox.Show("Đã sửa thành công");
                    cbb_MaSP.DropDownStyle = ComboBoxStyle.DropDown;
                    congtac(true);
                    cbb_MaHDN.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Lỗi sửa chi tiết hóa đơn", "Lỗi", MessageBoxButtons.OK);
                }
                loadGridview(MaHDN1);
                dtprocess.CloseConnect();
            }
            else MessageBox.Show("Cân nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK);
        }
        private int getSLton(string masp)
        {
            String slton = "0";
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT dbo.SanPham.SLton FROM dbo.SanPham where MaSP ='" + masp + "'", dtprocess.sqlConn);
            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            try
            {
                slton = reader.GetSqlInt32(0).ToString();
            }
            catch { }
            return Convert.ToInt32(slton);
        }
        private void updateSLSPTang(Boolean them,int soluong,string masp)
        {
            int index = selectRowNow;
            int getSL_text = 0;
            try { getSL_text = Convert.ToInt32(txt_soluong.Text); } catch { }
            dtprocess.OpenConnect();
            int sl;
            if(them==true)
            {
                sl = getSL_text + getSLton(masp);
                string sql = "UPDATE dbo.SanPham SET SLton =" + sl + " where MaSP = '" + masp + "'";
                //MessageBox.Show(sql);
                dtprocess.UpdateData(sql);
            }
            else 
            {
               string slcu = Gridview_HDN.Rows[index].Cells[2].Value.ToString();
               sl = getSLton(masp) - Convert.ToInt32(slcu) + soluong;
               string sql = "UPDATE dbo.SanPham SET SLton =" + sl + " where MaSP = '" + masp + "'";
               //MessageBox.Show(sql);
               dtprocess.UpdateData(sql);
            }
            dtprocess.CloseConnect();
        }
        private void UpdateSLgiam(int Soluong,string masp)
        {           
            int sl = getSLton(masp) - Soluong;
            string sql = "UPDATE dbo.SanPham SET SLton =" + sl + " where MaSP = '" + masp + "'";
            //MessageBox.Show(sql);
            dtprocess.UpdateData(sql);
        }
        private void deleteCTHD()
        {
            int t = selectRowNow;
            int max = Gridview_HDN.RowCount;
            if(t ==-1||t==max-1)
            {
                MessageBox.Show("Chọn bản ghi muôn xóa");
            }
            else
            {
                string soluong, MaSP, sqldelete,TenSP, MaHDN;
                MaHDN = cbb_MaHDN.SelectedValue.ToString();
                MaSP = Gridview_HDN.Rows[t].Cells[0].Value.ToString().Trim();
                TenSP = Gridview_HDN.Rows[t].Cells[1].Value.ToString().Trim();
                soluong = Gridview_HDN.Rows[t].Cells[2].Value.ToString().Trim();
                int soluong1 = Convert.ToInt32(soluong);
                sqldelete = "DELETE FROM dbo.CTHoaDonNhap WHERE MaHDN ='" + MaHDN + "' AND MaSP = '" + MaSP + "'";
                //MessageBox.Show(sqldelete);          
                try
                {
                    dtprocess.OpenConnect();
                    UpdateSLgiam(soluong1, MaSP);
                    dtprocess.UpdateData(sqldelete);
                    loadGridview(cbb_MaHDN.Text);
                    tinhtongtien();
                    string chuoi = "Đã xóa sản phầm " + TenSP + " khỏi hóa đơn " + MaHDN;
                    MessageBox.Show(chuoi);
                    dtprocess.CloseConnect();
                }
                catch
                {
                    MessageBox.Show("Lỗi xóa");
                }

            }
        }
        private void deleteHDN()
        {
            string MaHDN = cbb_MaHDN.Text.Trim();
            string sql = "DELETE dbo.HoaDonNhap WHERE MaHDN = '" + MaHDN + "'";
            dtprocess.OpenConnect();
            try
            {
                dtprocess.UpdateData(sql);
                MessageBox.Show("xóa thành công hóa đơn");
                loadcombobox();
            }
            catch
            {
                MessageBox.Show("Lỗi xóa hóa đơn");
            }
            dtprocess.CloseConnect();
        }
        private void sinhMaHD()
        {
            dtprocess.OpenConnect();
            SqlCommand cm = new SqlCommand("SELECT dbo.HoaDonNhap.MaHDN FROM dbo.HoaDonNhap ORDER BY MaHDN DESC", dtprocess.sqlConn);
            SqlDataReader reader = cm.ExecuteReader();
            reader.Read();
            String resultString = reader.GetString(0).ToString();    
            resultString = Regex.Match(resultString, @"\d+").Value;
            int ma = 1 + Convert.ToInt32(resultString);
            string mamoi = "HDN" + ma;
            cbb_MaHDN.Text = mamoi;
        }
        private void cleanHDN()
        {
            cbb_MaNV.Text = "";
            cbb_MaNCC.Text = "";
            txt_TenNV.Text = "";
            richtxt_TeNCC.Text = "";
            DTpicker_ngaynhap.Text = "";
            richtext_ghichu.Text = "";
        }
        private void cleanCT_HDN()
        {
            cbb_MaSP.Text = "";
            txt_TenSP.Text = "";
            txt_soluong.Text = "";
            txt_gianhap.Text = "";
        }
        private void btt_them_Click(object sender, EventArgs e)
        {
            loadSL = false;
            txt_tongtien.Text = "0";
            //cbb_MaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_MaHDN.Enabled = false;
            loadcombobox1();
            cleanCT_HDN();
            cleanHDN();
            Gridview_HDN.DataSource = null;
            congtac(false);
            sinhMaHD();
            them = 0;
            sua = -1;
        }

        private void btt_lammoi_Click(object sender, EventArgs e)
        {
            loadcombobox();
            loadcombobox1();
            Loaddata();
            loadTenNCC();
            congtac(true);
            cbb_MaSP.DropDownStyle = ComboBoxStyle.DropDown;
            cbb_MaHDN.Enabled = true;
            cbb_MaSP.Enabled = true;
            btn_luu.Visible = false;
            dangsua = 0;
            them = -1;
            sua = -1;
            loiThemHDN = 0;

        }

        private void btt_ok_Click(object sender, EventArgs e)
        {
            //btt_ok.Enabled = false;
            if (them == 0)
            {
                InsertHDN();
                if(loiThemHDN==0)
                {
                    //if (MessageBox.Show("Bạn có muôn thêm mặt hàng hay k?", "Thêm mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    if(1==1)
                    {
                        InsertCTHDN();
                        if (MessageBox.Show("Bạn có muôn thêm mặt hàng hay k?", "Thêm mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            congtac(false);
                            cleanCT_HDN();
                            them++;
                        }
                        else
                        {
                            congtac(true);
                            cbb_MaHDN.Enabled = true;
                            //loadcombobox();
                            //loadGridview(cbb_MaHDN.Text);
                        }
                    }
                }
                loiThemHDN = 0;
            }
            else if(them>0)
            {
                InsertCTHDN();
                if (MessageBox.Show("Bạn có muốn thêm mặt hàng hay k?", "Thêm mặt hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cleanCT_HDN();
                    congtac(false);
                }
                else
                {
                    congtac(true);
                    cbb_MaHDN.Enabled = true;
                    //loadcombobox();
                    //loadGridview(cbb_MaHDN.Text);
                }
            }
            if(sua==0)
            {
                them = -1;
                InsertCTHDN();
            }
            if(sua==1)
            {
                UpdateCTHDN();
            }
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            cbb_MaHDN.Text = "";
            cleanCT_HDN();
            cleanHDN();
            Gridview_HDN.DataSource = null;
            string ngay = dtpicker_ChonNgay.Text;
            DataTable dtt = new DataTable();
            //load lên mã hóa đơn nhập
            dtt = dtprocess.SelectTable("SELECT * FROM HoaDonNhap WHERE NgayNhap ='"+ngay+"'");
            cbb_MaHDN.DataSource = dtt;
            cbb_MaHDN.DisplayMember = "MaHDN";
            cbb_MaHDN.ValueMember = "MaHDN";
            loadTenNCC();
            if(cbb_MaHDN.Text =="")
            {
                MessageBox.Show("Không có hóa đơn nào trong ngày " + ngay);
                txt_tongtien.Text = "0";
            }
        }

        private void btt_huy_Click(object sender, EventArgs e)
        {
            congtac(true);
            string mahd = cbb_MaHDN.Text;
            cbb_MaHDN.Enabled = true;
            cbb_MaSP.DropDownStyle = ComboBoxStyle.DropDown;
            if (them==0)
            {
                loadcombobox();
                loadcombobox1();
                Loaddata();
                loadTenNCC();
                return;
            }
            else if(sua==0)
            {
                loadcombobox();
                cbb_MaHDN.Text = mahd;
            }
        }

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            if(Gridview_HDN.RowCount ==1)
            {
                if (MessageBox.Show("Hóa đơn này không có sp nào ban có muôn xóa HĐ k?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deleteHDN();
                    return;
                }
            }
            if (MessageBox.Show("Bạn có muốn xóa hóa đơn này k?", "Xóa Hóa Đơn", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int n = Gridview_HDN.RowCount;
                string MaSP,soluong;
                for(int i=0;i<n-1;i++)
                {
                    MaSP = Gridview_HDN.Rows[i].Cells[0].Value.ToString().Trim();
                    soluong = Gridview_HDN.Rows[i].Cells[2].Value.ToString().Trim();
                    int soluong1 = Convert.ToInt32(soluong);
                    UpdateSLgiam(soluong1, MaSP);
                }
                //MessageBox.Show("" + Gridview_HDN.RowCount);
                deleteHDN();
            }
        }
        private void btt_sua_Click(object sender, EventArgs e)
        {
            dangsua = 1;
            them = -1;
            if (MessageBox.Show("Bạn có muốn thêm mặt hàng vào hóa đơn này k?", "Thêm Mặt Hàng", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                congtac(false);
                //loadcombobox1();
                loadMaSP();
                loadSL = false;
                cleanCT_HDN();
                sua = 0;
            }
            else 
            {
                congtac(false);
                sua = 1;
                cbb_MaHDN.Enabled = false;
                cbb_MaSP.DropDownStyle = ComboBoxStyle.DropDownList;                
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            UpdateHDN();
        }

        private void cbb_MaNCC_TextChanged(object sender, EventArgs e)
        {
            if(dangsua==1)
            {
                btn_luu.Visible = true;
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            int n = Gridview_HDN.Rows.Count;
            if (Gridview_HDN.Rows.Count > 0) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 12;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "CỬA HÀNG BÁN PHỤ KIÊN Ô TÔ";
                //
                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 12;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: 37B - TT Đông Anh - Hà Nội";
                //
                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 12;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 0976967619";
                //
                Excel.Range header = (Excel.Range)exSheet.Cells[5, 2];
                exSheet.get_Range("B5:G5").Merge(true);
                header.Font.Size = 13;
                header.Font.Bold = true;
                header.Font.Color = Color.Red;
                header.Value = "DANH SÁCH CÁC MẶT HÀNG";
                //Định dạng tiêu đề bảng
                exSheet.get_Range("A7:G7").Font.Bold = true;
                exSheet.get_Range("A7:G7").HorizontalAlignment =
                Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã SP";
                exSheet.get_Range("C7").Value = "Tên Tên Sản Phẩm";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Số lượng";
                //exSheet.get_Range("E7").Value = "";
                exSheet.get_Range("F7").Value = "Gía nhập";
                exSheet.get_Range("G7").Value = "Thanh tiền";
                //In dữ liệu
                for (int i = 0; i < Gridview_HDN.Rows.Count - 1; i++)
                {
                    try
                    {
                        exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                        exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                        exSheet.get_Range("C" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[1].Value.ToString();
                        exSheet.get_Range("B" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[0].Value.ToString();
                        exSheet.get_Range("D" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[2].Value.ToString();
                       // exSheet.get_Range("E" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[3].Value.ToString();
                        exSheet.get_Range("F" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[3].Value.ToString();
                        exSheet.get_Range("G" + (i + 8).ToString()).Value = Gridview_HDN.Rows[i].Cells[4].Value.ToString();
                    }
                    catch { }
                }

                exSheet.get_Range("E" + (n + 8).ToString()).Value = "Tổng tiền";
                exSheet.get_Range("G" + (n + 8).ToString()).Value = txt_tongtien.Text;


                exSheet.Name = "Hang";
                exBook.Activate(); //Kích hoạt file Excel
                                   //Thiết lập các thuộc tính của SaveFileDialog
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
                MessageBox.Show("In thanh công hóa đơn");
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }
        private void congtac(Boolean ok)
        {
            if(ok==true)
            {
                btt_them.Enabled = ok;
                btt_sua.Enabled = ok;
                btt_xoa.Enabled = ok;
                btt_ok.Enabled = false;
                btt_huy.Enabled = false;
            }
            else
            {
                btt_them.Enabled = ok;
                btt_sua.Enabled = ok;
                btt_xoa.Enabled = ok;
                btt_ok.Enabled = true;
                btt_huy.Enabled = true;
            }
        }
    }
}
      