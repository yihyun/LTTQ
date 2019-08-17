using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmLoaiSP : Form
    {
        DataProcess data = new DataProcess();
        public frmLoaiSP()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            cboMaLoaiSP.DataSource = data.SelectTable("SELECT MaLoaiSP FROM dbo.LoaiSP");
            cboMaLoaiSP.DisplayMember = "MaLoaiSP";
            cboMaLoaiSP.ValueMember = "MaLoaiSP";

            dgvShowLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowLoaiSP.DataSource = data.SelectTable("SELECT * FROM dbo.LoaiSP");
            dgvShowLoaiSP.ReadOnly = true;

            label4.Font = new Font("Arial", 20, FontStyle.Bold);
            label5.Font = new Font("Arial", 9, FontStyle.Bold);

            DataTable dt = data.SelectTable("SELECT LoaiSP, GhiChu FROM dbo.LoaiSP WHERE MaLoaiSP = '" +
                cboMaLoaiSP.SelectedValue.ToString() + "'");
            txtGhiChu.Text = dt.Rows[0]["GhiChu"].ToString();
            txtLoaiSP.Text = dt.Rows[0]["LoaiSP"].ToString();

            enableButton(true, true, true, false, false);
        }

        private void setNullAllTextBox()
        {
            cboMaLoaiSP.Text = null;
            txtGhiChu.Text = null;
            txtLoaiSP.Text = null;
        }
        private void enableButton(bool a, bool b, bool c, bool d, bool e)
        {
            btnTao.Enabled = a;
            btnSua.Enabled = b;
            btnXoa.Enabled = c;
            btnLuu.Enabled = d;
            btnHuy.Enabled = e;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            setNullAllTextBox();
            enableButton(false, false, false, false, true);
            int k = Convert.ToInt16(data.SelectTable("SELECT " +
                "MAX(MaLoaiSP) FROM  dbo.LoaiSP").Rows[0][0].ToString()) + 1;
            cboMaLoaiSP.Text = Convert.ToString(k);
            cboMaLoaiSP.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            enableButton(false, false, false, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMaLoaiSP.Text != "")
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa bản ghi này?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)

                {
                    // kiem tra so luong san pham thuoc loai nay
                    int row = data.SelectTable("SELECT MaSP FROM dbo.SanPham WHERE LoaiSP = '"+
                        cboMaLoaiSP.SelectedValue.ToString()+"'").Rows.Count;
                    if (row < 1)
                    {
                        data.UpdateData("DELETE FROM dbo.LoaiSP WHERE MaLoaiSP = '" + cboMaLoaiSP.Text + "'");
                        loadData();
                    }
                    else
                        MessageBox.Show("Bạn không thể xóa bản ghi này, bởi nó có chứa một số sản phẩm !", "Cảnh báo", MessageBoxButtons.OK);
                }
                else if (dialogResult == DialogResult.No)
                {
                    // btnSua.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa !", "Cảnh báo");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // kiểm tra loại sp đã có chưa
            int row = data.SelectTable("SELECT MaLoaiSP FROM dbo.LoaiSP WHERE MaLoaiSP = '"+
                cboMaLoaiSP.Text + "'").Rows.Count;
            
            if (row < 1)
            {
                // insert loại sp
                data.UpdateData("INSERT INTO dbo.LoaiSP VALUES('" + Convert.ToInt16(cboMaLoaiSP.Text)+"', N'" + 
                    txtLoaiSP.Text + "', N'" + txtGhiChu.Text + "')");
            }
            else
            {
                // update loại sp
                data.UpdateData("UPDATE dbo.LoaiSP SET GhiChu = N'" + 
                    txtGhiChu.Text + "' WHERE MaLoaiSP = '" + cboMaLoaiSP.Text + "'");
            }

            btnLuu.Enabled = false;
            loadData();
            enableButton(true, true, true, false, false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (btnTao.Enabled == false || btnSua.Enabled == false)
            {
                cboMaLoaiSP.Enabled = true;
                loadData();
            }
            
            enableButton(true, true, true, false, true);
        }
        

        private void cboMaLoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void txtLoaiSP_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void dgvShowLoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                enableButton(true, true, true, false, false);
                cboMaLoaiSP.Text = dgvShowLoaiSP.SelectedRows[0].Cells["MaLoaiSP"].Value.ToString();
                txtLoaiSP.Text = dgvShowLoaiSP.SelectedRows[0].Cells["LoaiSP"].Value.ToString();
                txtGhiChu.Text = dgvShowLoaiSP.SelectedRows[0].Cells["GhiChu"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) {}
        }

        private void dgvShowLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                enableButton(true, true, true, false, false);
                int row = dgvShowLoaiSP.SelectedCells[0].RowIndex;
                cboMaLoaiSP.Text = dgvShowLoaiSP.SelectedRows[row].Cells["MaLoaiSP"].Value.ToString();
                txtLoaiSP.Text = dgvShowLoaiSP.SelectedRows[row].Cells["LoaiSP"].Value.ToString();
                txtGhiChu.Text = dgvShowLoaiSP.SelectedRows[row].Cells["GhiChu"].Value.ToString();
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void dgvShowLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvShowLoaiSP_CellClick(sender, e);
        }

        private void separatorControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
