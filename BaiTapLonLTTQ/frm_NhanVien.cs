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
using ThucHanh1;
namespace BTL_BacVu
{
    public partial class frm_NhanVien : Form
    {
        Dataprocess process = new Dataprocess();
        int them = 0;
        int sua = 0;
        int timkiem = 0;
        public frm_NhanVien()
        {
            InitializeComponent();
            loadMaNV();
            loadData(cbb_MaNV.SelectedValue.ToString());
            loadGridView();
            congtac(true);
        }

        private void loadMaNV()
        {
            string sql = "SELECT *FROM dbo.NhanVien";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            cbb_MaNV.DataSource = dtt;
            cbb_MaNV.ValueMember = "MaNV";
            cbb_MaNV.DisplayMember = "MaNV";
        }
        private void loadData(string dk)
        {
            string sql = "SELECT *FROM dbo.NhanVien where MaNV = '" + dk + "'";
            process.OpenConnect();
            SqlCommand cm = new SqlCommand(sql, process.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_Hoten.Text = rd.GetString(1);
                if(rd.GetSqlBoolean(2)==true)
                {
                    rdbtn_nam.Checked = true;
                }
                else rdbtn_nu.Checked = true;
                richtxt_diachi.Text = rd.GetString(3);             
                txt_email.Text = rd.GetString(4);
                txt_SĐT.Text = rd.GetString(5);
                txt_luong.Text = rd.GetSqlMoney(6).ToString();
            }
            process.CloseConnect();
        }
        private void cbb_MaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(cbb_MaNV.SelectedValue.ToString());
            //DTGridview_TTnhanvien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void loadGridView()
        {
            string sql = "SELECT MaNV AS 'Mã Nhân Viên',TenNV AS 'Tên Nhân Viên', DiaChi AS 'Địa Chỉ', SDT AS 'Số Điện Thoại' FROM dbo.NhanVien";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            DTGridview_TTnhanvien.DataSource = dtt;

            DTGridview_TTnhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void DTGridview_TTnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            string manv = DTGridview_TTnhanvien.Rows[row].Cells[0].Value.ToString();
            cbb_MaNV.Text = manv;
            loadData(manv);
            if(manv=="")
            {
                clean();
            }
        }
        void clean()
        {
            txt_Hoten.Text = "";
            txt_email.Text = "";
            txt_luong.Text = "";
            txt_SĐT.Text = "";
            richtxt_diachi.Text = "";

        }  
        void SinhMaNV()
        {
            process.OpenConnect();
            string sql = " SELECT MaNV FROM dbo.NhanVien ORDER BY MaNV DESC";
            SqlDataReader rd = process.GetData(sql);
            string macu = rd.GetString(0);
            string[] ma = macu.Split('V');
            int duoima = Convert.ToInt32(ma[1]);
            string mamoi = "NV" + (duoima + 1);
            cbb_MaNV.Text = mamoi;
            // MessageBox.Show((duoima+1)+"");
            process.CloseConnect();
        }
        void InsertNhanVien()
        {
            string ma, ten, gioitinh, diachi, email, sdt,luong;
            ma = cbb_MaNV.Text;
            ten = txt_Hoten.Text;
            diachi = richtxt_diachi.Text;
            sdt = txt_SĐT.Text;
            email = txt_email.Text;
            luong = txt_luong.Text;
            if (rdbtn_nam.Checked == true)
            {
                gioitinh = "1";
            }
            else gioitinh = "0";
            string sql = "INSERT dbo.NhanVien VALUES('" + ma + "',N'" + ten + "'," + gioitinh + ",N'" + diachi + "',N'" + email + "','" + sdt + "'," + luong +")";
            try
            {
                //MessageBox.Show(sql);
                process.UpdateData(sql);
                MessageBox.Show("Thêm thành công nhân viên");
                them =0;
                congtac(true);
                cbb_MaNV.Enabled = true;
                loadMaNV();
                loadGridView();
                cbb_MaNV.Text = ma;
                loadData(ma);
            }
            catch { MessageBox.Show("Lỗi thêm nhân viên"); }
        }
        void DeleteNhanVien(string MaNV, string TenNV)
        {
             if(MessageBox.Show("Bạn có chắc muốn xóa nhân viên "+TenNV,"Thông báo", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                string sql = " DELETE dbo.NhanVien WHERE MaNV='" + MaNV + "'";
                //MessageBox.Show(sql);
                try
                {
                    process.UpdateData(sql);
                    MessageBox.Show("Đã xóa thành công nhân viên " + TenNV);
                    loadMaNV();
                    loadGridView();
                }
                catch { MessageBox.Show("Lỗi xóa"); }
            }
        }
        void UpdateNhanVien(string MaNV)
        {
            string ma, ten, gioitinh, diachi, email, sdt, luong;
            ma = cbb_MaNV.Text;
            ten = txt_Hoten.Text;
            diachi = richtxt_diachi.Text;
            sdt = txt_SĐT.Text;
            email = txt_email.Text;
            luong = txt_luong.Text;
            if (rdbtn_nam.Checked == true)
            {
                gioitinh = "1";
            }
            else gioitinh = "0";
            string sql = "UPDATE dbo.NhanVien SET TenNV = N'" + ten + "',DiaChi = N'" + diachi + "',SDT ='" + sdt + "',gioitinh ="+gioitinh+",Email = '"+email +"', Luong = "+luong + " WHERE MaNV = '" + MaNV+ "'";
            try
            {
                //MessageBox.Show(sql);
                process.UpdateData(sql);
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loadGridView();
                sua = 0;
                cbb_MaNV.Enabled = true;
                congtac(true);
            }
            catch { MessageBox.Show("Sửa bị lỗi", "Thông báo", MessageBoxButtons.OK); }
        }
        void congtac(Boolean ok)
        {
            if(ok==true)
            {
                btn_them.Enabled = ok;
                btn_sua.Enabled = ok;
                btn_xoa.Enabled = ok;
                btn_luu.Enabled = false;
            }
            else
            {
                btn_them.Enabled = ok;
                btn_sua.Enabled = ok;
                btn_xoa.Enabled = ok;
                btn_luu.Enabled = true;
            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            SinhMaNV();
            clean();
            DTGridview_TTnhanvien.DataSource =null;
            cbb_MaNV.Enabled = false;
            congtac(false);
            them = 1;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            sua = 1;
            congtac(false);
            cbb_MaNV.Enabled = false;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            if(them ==1)
            {
                InsertNhanVien();
            }
            else if(sua ==1)
            {
                UpdateNhanVien(cbb_MaNV.Text);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DeleteNhanVien(cbb_MaNV.Text, txt_Hoten.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            congtac(true);
            if(them ==1)
            {
                them = 0;
                cbb_MaNV.Enabled = true;
                loadMaNV();
                loadGridView();
            }
            else if(sua==1)
            {
                sua = 0;
                cbb_MaNV.Enabled = true;
                loadData(cbb_MaNV.Text);
            }
            else if(timkiem ==1)
            {
                timkiem = 0;
                loadMaNV();
                loadData(cbb_MaNV.SelectedValue.ToString());
                loadGridView();
                congtac(true);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string ten = txt_timkiemNV.Text;
            if (ten != "")
            {
                timkiem = 1;
                string sql = "SELECT MaNV AS 'Mã Nhân Viên',TenNV AS 'Tên Nhân Viên', DiaChi AS 'Địa Chỉ', SDT AS 'Số Điện Thoại' FROM dbo.NhanVien Where TenNV like '%"+ten+"%'";
                DataTable dtt = new DataTable();
                dtt = process.SelectTable(sql);
                DTGridview_TTnhanvien.DataSource = dtt;
                cbb_MaNV.DataSource = dtt;
                cbb_MaNV.ValueMember = "Mã Nhân Viên";
                cbb_MaNV.DisplayMember = "Mã Nhân Viên";
            }
            else MessageBox.Show("Nhập tên bạn muốn tìm kiếm");
        }

        private void txt_SĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < Convert.ToInt16('0') || Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9')) && Convert.ToInt16(e.KeyChar) != 8)
            {
                e.Handled = true;
                MessageBox.Show("Phải nhập số");
            }
        }
    }
}
