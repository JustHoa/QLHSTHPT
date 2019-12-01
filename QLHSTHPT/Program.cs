using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Data.SqlClient;

namespace QLHSTHPT
{
    static class Program
    {
        public static string server = "";
        public static string loginName = "";
        public static string password = "";
        public static string group = "";
        public static string maGV = "";
        public static string tenGV = "";
        public static int vitri = 0;

        public static int MIN = 35;
        public static int MAX = 45;
        public static int MAX_LOP = 8;

        public static bool flagMieng = false;
        public static bool flag15p = false;
        public static bool flag1T = false;
        public static int addMieng = 4;
        public static int add15p = 6;
        public static int add1T = 8;
        public static List<string> arrMieng = new List<string>();
        public static List<string> arr15p = new List<string>();
        public static List<string> arr1T = new List<string>();

        public static string connectionString = "";
        public static SqlConnection sqlConnection;

        public static FormDangNhap formDangNhap;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            formDangNhap = new FormDangNhap();
            Application.Run(formDangNhap);
            //Application.Run(new Form1());
        }
    }
}
