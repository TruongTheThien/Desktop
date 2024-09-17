using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVienSachCaNhan
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_thongke());

           /* LoginForm loginForm = new LoginForm();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                
               
            }
            else
            {
                // Nếu đăng nhập thất bại hoặc người dùng đóng form đăng nhập, thoát ứng dụng
                Application.Exit();

            }*/
        }
    }
}
    