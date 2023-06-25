using _3.BUS.Properties;
using _3.BUS.View.ALL;
using _3.BUS.View.Frm_SanPham;
using _3.BUS.View.LogIn;
using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FromSanPham;
using _3.GUI.Views;

namespace _3.BUS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FRDangNhap());
        }
    }
}