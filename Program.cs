using System;
using System.Windows.Forms;
using ActivityManagement.Data;

namespace ActivityManagement
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new ApplicationDbContext();
            SeedData.Initialize(context);
            Application.Run(new Form1());
        }
    }
}
