using QL_TTTA_01.Calendar;
using QL_TTTA_01.FDanhSach;
using QL_TTTA_01.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_TTTA_01
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new  FLogin();
            form.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form);
        }
    }
}
