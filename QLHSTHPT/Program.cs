﻿using System;
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
        public static int vitri = 0;
        public static int clkSave = 0;
        public static int clkMan = 0;
        public static int clkOK = 0;
        public static string connectionString = "";
        public static SqlConnection sqlConnection;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            Application.Run(new FormDangNhap());
        }
    }
}
