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
using BaiTapLonLTTQ;
using ThucHanh1;
namespace BTL_BacVu
{
    public partial class frm_NhaCC: Form
    {
        Dataprocess process = new Dataprocess();
        int sua = 0;
        public frm_NhaCC()
        {
            InitializeComponent();
            if(ểvedasxag5B.quyen!=1)
            {
                btn_them.Visible = false;
                btn_sua.Visible = false;
                btn_huy.Visible = false;
                btn_luu.Visible = false;
                btn_xoa.Visible = false;
            }
            loadGridView();
            loadMaNCC();
            loadData(cbb_MaNCC.SelectedValue.ToString());
            BatLuuHuy(false);
        }

        private void loadGridView()
        {
            string sql = "SELECT *FROM dbo.NhaCungCap";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            DTGrid_NhaCC.DataSource = dtt;

            DTGrid_NhaCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadMaNCC()
        {
            string sql = "SELECT *FROM dbo.NhaCungCap";
            DataTable dtt = new DataTable();
            dtt = process.SelectTable(sql);
            cbb_MaNCC.DataSource = dtt;
            cbb_MaNCC.ValueMember = "MaNCC";
            cbb_MaNCC.DisplayMember = "MaNCC";
        }
        private void loadData(string dk)
        {
            string sql = "SELECT *FROM dbo.NhaCungCap where MaNCC = '" + dk + "'";
            process.OpenConnect();
            SqlCommand cm = new SqlCommand(sql, process.sqlConn);
            SqlDataReader rd = cm.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                txt_TenNCC.Text = rd.GetString(1);
                richTxt_diachi.Text = rd.GetString(2);
                txt_SDT.Text = rd.GetString(3);
            }
            process.CloseConnect();
        }
        private void cbb_MaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData(cbb_MaNCC.SelectedValue.ToString());
        }
        private void DTGrid_NhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            string mancc = DTGrid_NhaCC.Rows[n].Cells[0].Value.ToString();
            cbb_MaNCC.Text = mancc;
            loadData(mancc);
        }
        private void sinhMaNCC()
        {
            process.OpenConnect();
            string sql = " SELECT MaNCC FROM dbo.NhaCungCap ORDER BY MaNCC DESC";
            SqlDataReader rd = process.GetData(sql);
            string macu = rd.GetString(0);
            string[] ma = macu.Split('C');
            int duoima = Convert.ToInt32(ma[2]);
            cbb_MaNCC.DropDownStyle = ComboBoxStyle.DropDown;
            string mamoi = "NCC" + (duoima + 1);
            if(duoima < 9)
            {
                mamoi = "NCC0" + (duoima + 1);
            }
            cbb_MaNCC.Text = mamoi;
            cbb_MaNCC.Enabled = false;
           // MessageBox.Show((duoima+1)+"");
            process.CloseConnect();
        }
        private void clean()
        {
            richTxt_diachi.Text = "";
            txt_SDT.Text = "";
            txt_TenNCC.Text = "";

        }
        private void InsertNCC()
        {
            string ma, ten, diachi, sdt;
            ma = cbb_MaNCC.Text;
            ten = txt_TenNCC.Text;
            diachi = richTxt_diachi.Text;
            sdt = txt_SDT.Text;
            string sql = "INSERT dbo.NhaCungCap VALUES('" + ma + "',N'" + ten + "',N'" + diachi + "','" + sdt + "')";
           // MessageBox.Show(sql);
            try
            {
                process.UpdateData(sql);
                MessageBox.Show("Thêm thành công nhà cung cấp");
                Batthemsuaxoa(true);
                BatLuuHuy(false);
                loadGridView();
                loadMaNCC();
                cbb_MaNCC.Enabled = true;
                cbb_MaNCC.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch { MessageBox.Show("Lỗi thêm nhà cc"); }
        }
        private void DeleteNCC(string MaNCC,string tenNCC)
        {
            string sql = " DELETE dbo.NhaCungCap WHERE MaNCC='" + MaNCC + "'";
            try
            {
                process.UpdateData(sql);
                MessageBox.Show("Đã xóa thành công nhà cung cấp " + tenNCC);
                loadMaNCC();
                loadGridView();
            }
            catch {MessageBox.Show("Lỗi xóa"); }
        }
        private void UpdateNCC(string MaNCC)
        {
            string ten, diachi, sdt;
            ten = txt_TenNCC.Text;
            diachi = richTxt_diachi.Text;
            sdt = txt_SDT.Text;
            string sql = "UPDATE dbo.NhaCungCap SET TenNCC = N'" + ten + "',DiaChi =N'" + diachi + "',SDT ='" + sdt + "' WHERE MaNCC = '"+MaNCC+"'" ;
           // MessageBox.Show(sql);
            try
            {
                process.UpdateData(sql);
                sua = 0;
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK);
                loadGridView();
                loadData(cbb_MaNCC.Text);
                Batthemsuaxoa(true);
                BatLuuHuy(false);
                cbb_MaNCC.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Sửa bị lỗi", "Thông báo", MessageBoxButtons.OK);
            }
        }
        private void BatLuuHuy(Boolean OK)
        {
            btn_luu.Enabled = OK;
            btn_huy.Enabled = OK;
        }
        private void Batthemsuaxoa(Boolean ok)
        {
            btn_them.Enabled = ok;
            btn_sua.Enabled = ok;
            btn_xoa.Enabled = ok;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            sinhMaNCC();
            clean();
            BatLuuHuy(true);
            Batthemsuaxoa(false);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maNCC = cbb_MaNCC.Text;
            string ten = txt_TenNCC.Text;
            if((MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp "+ten,"Thông báo",MessageBoxButtons.YesNo))==DialogResult.Yes)
            {
                DeleteNCC(maNCC, ten);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            cbb_MaNCC.Enabled = false;
            BatLuuHuy(true);
            Batthemsuaxoa(false);
            sua = 1;
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {   
            if(sua==1)
            {
                UpdateNCC(cbb_MaNCC.Text);
                return;
            }
            else
            {
                InsertNCC();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            if(sua==1)
            {
                Batthemsuaxoa(true);
                BatLuuHuy(false);
                loadData(cbb_MaNCC.Text);
                cbb_MaNCC.Enabled = true;
            }
            else
            {
                Batthemsuaxoa(true);
                loadMaNCC();
                cbb_MaNCC.DropDownStyle = ComboBoxStyle.DropDownList;
                BatLuuHuy(false);
                cbb_MaNCC.Enabled = true;
            }
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((Convert.ToInt16(e.KeyChar)< Convert.ToInt16('0')|| Convert.ToInt16(e.KeyChar) > Convert.ToInt16('9'))&& Convert.ToInt16(e.KeyChar)!=8)
            {
                e.Handled = true;
                MessageBox.Show("Nhập số");
           }
        }
    }
}
