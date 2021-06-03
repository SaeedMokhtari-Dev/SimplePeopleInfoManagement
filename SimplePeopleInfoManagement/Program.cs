using SimplePeopleInfoManagement.DbContext;
using SimplePeopleInfoManagement.Entity;
using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SimplePeopleInfoManagement
{
    static class Program
    {
        /// <summary>
        /// Enable high DPI
        /// </summary>
        static readonly bool HighDPIEnabled = false;

        /// <summary>
        /// Load for high DPI
        /// </summary>
        /// <returns></returns>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (HighDPIEnabled && Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["culture"]))
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["culture"]);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ConfigurationManager.AppSettings["culture"]);
            }

            FormMain formMain = new FormMain();
            if (HighDPIEnabled)
                formMain.AutoScaleMode = AutoScaleMode.Dpi;

            if (!File.Exists(@".\db\db.sqlite"))
            {
                using (DbConnection connection = new SQLiteConnection(ConnectionHelper.ConnectionString))
                {
                    using (var _context = new PeopleInfoDbContext(connection, true))
                    {
                        // ReSharper disable once UnusedVariable
                        Category category = new Category
                        {
                            Title = "فامیل",
                            Description = string.Empty,
                            CreatedUtc = DateTime.Now
                        };

                        _context.Categories.Add(category);
                        _context.SaveChanges();

                    }
                }
            }
            Application.Run(formMain);
        }
    }
}
