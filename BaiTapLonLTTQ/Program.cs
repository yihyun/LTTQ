using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_BacVu;
using QuanLyBanHang;
namespace BaiTapLonLTTQ
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
             //Application.Run(new ểvedasxag5B());
          //  Application.Run(new Main());
            //Application.Run(new frmSP());
             Application.Run(new Login());
            //Application.Run(new frmTaiKhoanCuaToi());
            // Application.Run(new FormKhachHang());
            //Application.Run(new frmLoaiSP());
            //Application.Run(new frmQuanLyTaiKhoan());
            // Application.Run(new FormTKSP());
        }
    }
}
