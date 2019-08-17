using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Excel = Microsoft.Office.Interop.Excel;
using BaiTapLonLTTQ;
namespace QuanLyBanHang
{
    public partial class frmBaoCaoDoanhThu : Form
    {
        private DateTime date = new DateTime();
        private DataProcess data = new DataProcess();
        private DataTable dataTableDoanhThu = null;
        private string sql;
        private string s;
        private double tongnhap = 0, tongban = 0, loinhuan = 0;
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void addataTableDoanhThuNam()
        {
            for(int i = 2000; i <= 2100; i++)
            {
                comboBox1.Items.Add(i);
            }
            comboBox1.SelectedItem = DateTime.Now.Year;
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            addataTableDoanhThuNam();
            comboBox2.Text = "Tất cả";
            radioButton1.Checked = true;

            groupBox2.Enabled = radioButton1.Checked;
            groupBox3.Enabled = radioButton2.Checked;

            dateTimePicker1.Value = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
            date = dateTimePicker2.Value;



            loadReport();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = radioButton1.Checked;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Enabled = radioButton2.Checked;
        }

        private void setDataTable()
        {
            sql = "SELECT * FROM dbo.DoanhThu ";
            dataTableDoanhThu = null;
            // xét giá trị câu lệnh truy vấn
            if (radioButton1.Checked == true)
            {
                if (comboBox2.Text == "Tất cả")
                {
                    sql += "WHERE YEAR(NgayLap) = '" + Convert.ToInt16(comboBox1.Text) + "'";
                    s = "(Trong năm " + comboBox1.Text + ")";
                }
                else
                {
                    sql += "WHERE YEAR(NgayLap) = '" + Convert.ToInt16(comboBox1.Text) + "' " +
                        "AND MONTH(NgayLap) = '" + Convert.ToInt16(comboBox2.Text) + "'";
                    s = "(Tháng " + comboBox2.Text + " Năm " + comboBox1.Text + ")";
                }
            }
            else
            {
                sql += "WHERE NgayLap BETWEEN '" + dateTimePicker1.Value + "' AND '" +
                    dateTimePicker2.Value + "'";
                s = "(Từ ngày: " + dateTimePicker1.Text + " Đến ngày: " + dateTimePicker2.Text + ")";
            }

            // lấy dữ liệu vào datatable
            dataTableDoanhThu = data.SelectTable(sql);
        }
        private void loadReport()
        {
            tongnhap = 0;
            tongban = 0;
            loinhuan = 0;
            sql = "SELECT * FROM dbo.DoanhThu ";
            // xét giá trị câu lệnh truy vấn
            if (radioButton1.Checked == true)
            {
                if (comboBox2.Text == "Tất cả")
                {
                    sql += "WHERE YEAR(NgayLap) = '" + Convert.ToInt16(comboBox1.Text) + "'";
                    s = "(Trong năm " + comboBox1.Text + ")";
                }
                else
                {
                    sql += " WHERE YEAR(NgayLap) = '" + Convert.ToInt16(comboBox1.Text) + "' " +
                        "AND MONTH(NgayLap) = '" + Convert.ToInt16(comboBox2.Text) + "'";
                    s = "(Tháng " + comboBox2.Text + " Năm " + comboBox1.Text + ")";
                }
            }
            else
            {
                sql += " WHERE NgayLap BETWEEN '" + dateTimePicker1.Value + "' AND '" +
                    dateTimePicker2.Value + "'";
                s = "(Từ ngày: " + dateTimePicker1.Text + " Đến ngày: " + dateTimePicker2.Text + ")";
            }

            DataTable dataTableDoanhThu = null;
            dataTableDoanhThu = data.SelectTable(sql);
            // lấy dữ liệu vào datatable
            dataTableDoanhThu = data.SelectTable(sql);

            // Khởi tạo đổi tượng DataSet DoanhThu
            dtsDoanhThu dataSetDoanhThu = new dtsDoanhThu();
            // đổ dữ liệu
            DataRow dtRow;
            for (int i = 0; i < dataTableDoanhThu.Rows.Count; i++)
            {
                dtRow = dataSetDoanhThu.Tables["DoanhThu"].NewRow();
                dtRow["MaHDB"] = dataTableDoanhThu.Rows[i]["MaHDB"].ToString();
                dtRow["MaSP"] = dataTableDoanhThu.Rows[i]["MaSP"].ToString();
                dtRow["TenSP"] = dataTableDoanhThu.Rows[i]["TenSP"].ToString();
                dtRow["SoLuong"] = Convert.ToInt16(dataTableDoanhThu.Rows[i]["SoLuong"].ToString());

                dtRow["GiaNhap"] = Convert.ToDouble(dataTableDoanhThu.Rows[i]["GiaNhap"].ToString());
                tongnhap += Convert.ToDouble(dataTableDoanhThu.Rows[i]["GiaNhap"].ToString());

                dtRow["GiaBan"] = Convert.ToDouble(dataTableDoanhThu.Rows[i]["GiaBan"].ToString());
                tongban += Convert.ToDouble(dataTableDoanhThu.Rows[i]["GiaBan"].ToString());

                dtRow["LaiLo"] = Convert.ToDouble(dataTableDoanhThu.Rows[i]["LaiLo"].ToString());
                loinhuan += Convert.ToDouble(dataTableDoanhThu.Rows[i]["LaiLo"].ToString());

                dtRow["NgayLap"] = string.Format("{0:MM/dd/yyyy}", dataTableDoanhThu.Rows[i]["NgayLap"].ToString());
            }
            // gọi đối tượng report đã thiết kế
            //string file = System.IO.Directory.GetCurrentDirectory() + "//Report//crptDoanhThu.rpt";
            crptDoanhThu rptDoanhThu = new crptDoanhThu();



            rptDoanhThu.SetDataSource(dataTableDoanhThu);
            // xet thời gian của chi tiết báo cáo

            // Lấy tất cả các đối tượng thuộc   rptDoanhThu
            ReportObjects rptObjects = rptDoanhThu.ReportDefinition.ReportObjects;
            // Sàn lọc lấy đối tượng txtNgayThang từ rptObjects
            TextObject selectObj = (TextObject)rptObjects["txtNgayThang"];
            selectObj.Text = s;

            
            TextObject toTongNhap = (TextObject)rptObjects["txtTongNhap"];
            toTongNhap.Text = Convert.ToString(tongnhap) + " VNĐ";

            TextObject toTongBan = (TextObject)rptObjects["txtTongBan"];
            toTongBan.Text = Convert.ToString(tongban) + " VNĐ";

            TextObject toLoiNhuan = (TextObject)rptObjects["txtLoiNhuan"];
            toLoiNhuan.Text = Convert.ToString(loinhuan) + " VNĐ";



            //Đặt nguồn cho điều khiển CrystalReportViewer là đối tượng ReportDocument
            //ReportDocument đã chứa report đã tạo
            crystalReportViewer1.ReportSource = rptDoanhThu;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            loadReport();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            if(dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateTimePicker2.Value = date;
            }
            else
            {
                date = dateTimePicker2.Value;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataTableDoanhThu = null;
            setDataTable();
            if (dataTableDoanhThu.Rows.Count > 0)
            {
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                exSheet.get_Range("A1:C1").Merge(true);
                exSheet.get_Range("A1:C1").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                tenCuaHang.Font.Size = 16;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "Công ty TNHH Xuất Nhập Khẩu Thương Mại Vũ Lâm";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                exSheet.get_Range("A2:C2").Merge(true);
                exSheet.get_Range("A2:C2").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                dcCuaHang.Font.Size = 11;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Địa chỉ: Số 64B, ngõ 51, Lương Khánh Thiện, Hoàng Mai, HN";

                Excel.Range emailCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                exSheet.get_Range("A3:C3").Merge(true);
                exSheet.get_Range("A3:C3").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                emailCuaHang.Font.Size = 11;
                emailCuaHang.Font.Bold = true;
                emailCuaHang.Font.Color = Color.Blue;
                emailCuaHang.Value = "Email: Vulam.kd@gmail.com";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[4, 1];
                exSheet.get_Range("A4:C4").Merge(true);
                exSheet.get_Range("A4:C4").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                dtCuaHang.Font.Size = 11;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "SĐT:  0934236743 / 0968802223";

                Excel.Range ngaylap = (Excel.Range)exSheet.Cells[4, 7];
                //exSheet.get_Range("F4:G4").Merge(true);
                exSheet.get_Range("G4").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                ngaylap.Font.Size = 11;
                ngaylap.Font.Bold = true;
                ngaylap.Font.Color = Color.Blue;
                exSheet.get_Range("G4").Value = "Ngày lập: " + Convert.ToString(DateTime.Now.Date);

                Excel.Range header = (Excel.Range)exSheet.Cells[7, 3];
                exSheet.get_Range("C7:E7").Merge(true);
                header.get_Range("C7:E7").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                header.Font.Size = 18;
                header.Font.Bold = true;
                header.Value = "BÁO CÁO DOANH THU BÁN HÀNG";

                Excel.Range subtitle = (Excel.Range)exSheet.Cells[8, 3];
                subtitle.get_Range("C8:E8").Merge(true);
                subtitle.get_Range("C8:E8").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                subtitle.Font.Size = 12;
                subtitle.Value = s;

                //Định dạng tiêu đề bảng
                exSheet.get_Range("A11:H11").Font.Bold = true;
                exSheet.get_Range("A11:H11").HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A11").Value = "Ngày lập";
                exSheet.get_Range("A11").ColumnWidth = 20;

                exSheet.get_Range("B11").Value = "Mã SP";
                exSheet.get_Range("B11").ColumnWidth = 12;

                exSheet.get_Range("C11").Value = "Tên sản phẩm";
                exSheet.get_Range("C11").ColumnWidth = 31.5;

                exSheet.get_Range("D11").Value = "Số lượng";
                exSheet.get_Range("D11").ColumnWidth = 9.2;

                exSheet.get_Range("E11").Value = "Giá nhập";
                exSheet.get_Range("E11").ColumnWidth = 15;

                exSheet.get_Range("F11").Value = "Giá bán";
                exSheet.get_Range("F11").ColumnWidth = 15;

                exSheet.get_Range("G11").Value = "Lãi lỗ";
                exSheet.get_Range("G11").ColumnWidth = 15;

                exSheet.get_Range("H11").Value = "Mã HĐB";
                exSheet.get_Range("H11").ColumnWidth = 10;

                //In dữ liệu
                for (int i = 0; i < dataTableDoanhThu.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 12).ToString() + ":H" + (i + 12).ToString()).Font.Bold = false;

                    exSheet.get_Range("A" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["NgayLap"].ToString();
                    exSheet.get_Range("B" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["MaSP"].ToString();
                    exSheet.get_Range("C" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["TenSP"].ToString();
                    exSheet.get_Range("D" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["SoLuong"].ToString();
                    exSheet.get_Range("E" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["GiaNhap"].ToString();
                    exSheet.get_Range("F" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["GiaBan"].ToString();
                    exSheet.get_Range("G" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["LaiLo"].ToString();
                    exSheet.get_Range("H" + (i + 12).ToString()).Value =
                        dataTableDoanhThu.Rows[i]["MaHDB"].ToString();
                }

                // set dữ liệu phần footer
                int k = dataTableDoanhThu.Rows.Count + 2;
                exSheet.get_Range("F" + (k + 12).ToString()).Value = "Tổng nhập:";
                exSheet.get_Range("F" + (k + 12).ToString()).HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                exSheet.get_Range("G" + (k + 12).ToString()).Value = Convert.ToString(tongban);

                exSheet.get_Range("F" + (k + 13).ToString()).Value = "Tổng bán:";
                exSheet.get_Range("F" + (k + 13).ToString()).HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                exSheet.get_Range("G" + (k + 13).ToString()).Value = Convert.ToString(tongban);

                exSheet.get_Range("F" + (k + 14).ToString()).Value = "Lợi nhuận:";
                exSheet.get_Range("F" + (k + 14).ToString()).HorizontalAlignment =
                    Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                exSheet.get_Range("G" + (k + 14).ToString()).Value = Convert.ToString(loinhuan);

                exSheet.Name = "Hang";
                exBook.Activate();

                //Kích hoạt file Excel
                //Thiết lập các thuộc tính của SaveFileDialog

                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc) " +
                    "| *.doc | All files(*.*) | *.* ";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xls";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }
    }
}
