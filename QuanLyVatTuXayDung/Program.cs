using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyVatTuXayDung
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
            Application.Run(new frmQuanLyVatTu());
        }
    }
    class mySave
    {
        static Boolean kt = true;
        static Boolean ad = false;
        static string id = null;
        public static Boolean KT
        {
            get { return kt; }
            set { kt = value; }
        }
        public static Boolean isAdmin
        {
            get { return ad; }
            set { ad = value; }
        }
        public static string getID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
