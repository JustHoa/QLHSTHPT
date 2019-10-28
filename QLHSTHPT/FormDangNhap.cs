using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string database = "QLHSTHPT";
            Program.server = "ADMIN";
            Program.loginName = textBoxLoginName.Text;
            Program.password = textBoxPassword.Text;
            Program.connectionString = "Server=" + Program.server + ";"
                + "Database=" + database + ";"
                + "User id=" + Program.loginName + ";"
                + "Password=" + Program.password;
            Program.sqlConnection = new SqlConnection(Program.connectionString);
            try
            {
                Program.sqlConnection.Open();
                //Program.loginHienTai = Program.loginName;
                //Program.passwordHienTai = Program.password;
                FormChinh formChinh = new FormChinh();
                formChinh.Activate();
                formChinh.Show();
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
