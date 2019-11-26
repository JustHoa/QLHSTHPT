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
    public partial class FormQLTaiKhoan : Form
    {
        public bool clkOK = false;

        FormChinh formChinh;
        public FormQLTaiKhoan(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormQLTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            this.ControlBox = false;

            this.panelCTTK.Enabled = false;
            this.labelMK.Visible = false;
            this.labelMK2.Visible = false;
            this.textBoxMK.Visible = false;
            this.textBoxMK2.Visible = false;
            this.buttonOK1.Visible = false;
            this.buttonHuy1.Visible = false;
            this.gIAOVIENGridControl.Visible = false;
            this.groupBoxAddAcc.Visible = false;
            this.labelTim2.Visible = false;
            this.textBoxTim2.Visible = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.V_DSTAIKHOAN' table. You can move, or remove it, as needed.
            this.v_DSTAIKHOANTableAdapter.Fill(this.qLHSTHPTDataSet.V_DSTAIKHOAN);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableLayoutPanel1.Visible = true;
            this.panelCTTK.Enabled = true;
            this.labelMK.Visible = true;
            this.labelMK2.Visible = true;
            this.textBoxMK.Visible = true;
            this.textBoxMK2.Visible = true;
            this.buttonOK1.Visible = true;
            this.buttonHuy1.Visible = true;
            this.gIAOVIENGridControl.Visible = false;
            this.groupBoxAddAcc.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "ALTER LOGIN " + textBoxTenDN.Text + " WITH PASSWORD = '" + textBoxMK2.Text + "'";
            //string sql = "EXEC SP_DOIMATKHAU '" + textBoxTenDN.Text + "', '" + textBoxMK2.Text + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            try
            {
                int dataReader = sqlCommand.ExecuteNonQuery();
                formChinh.toolStripStatusLabelNote.Text = "Thành công";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);
            }
        }

        private void buttonHuy1_Click(object sender, EventArgs e)
        {
            this.v_DSTAIKHOANGridControl.Enabled = true;
            this.panelCTTK.Enabled = false;
            this.labelMK.Visible = false;
            this.labelMK2.Visible = false;
            this.textBoxMK.Visible = false;
            this.textBoxMK2.Visible = false;
            this.buttonOK1.Visible = false;
            this.buttonHuy1.Visible = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableLayoutPanel1.Visible = false;
            this.gIAOVIENGridControl.Visible = true;
            this.groupBoxAddAcc.Visible = true;
            this.labelTim2.Visible = true;
            this.textBoxTim2.Visible = true;
            this.comboBoxRole.SelectedIndex = 0;
        }

        private void buttonOK2_Click(object sender, EventArgs e)
        {
            this.labelETDN.Text = this.labelEMK.Text = this.labelEMK2.Text = "";
            if (this.textBoxLogin.Text == "")
            {
                //MessageBox.Show("Chưa nhập Tên đăng nhập. Chú ý!");
                this.labelETDN.Text = "Chưa nhập Tên đăng nhập. Chú ý!";
                textBoxLogin.Focus();
                return;
            }

            if (this.textBoxAddMK.Text == "")
            {
                //essageBox.Show("Chưa nhập Mật khẩu. Chú ý!");
                this.labelEMK.Text = "Chưa nhập Mật khẩu. Chú ý!";
                textBoxAddMK.Focus();
                return;
            }

            if (this.textBoxAddMK2.Text == "")
            {
                //MessageBox.Show("Chưa nhập Mật khẩu xác nhận. Chú ý!");
                this.labelEMK2.Text = "Chưa nhập Mật khẩu xác nhận. Chú ý!";
                textBoxAddMK2.Focus();
                return;
            }

            //string sql = "EXEC SP_TAOLOGIN '" + textBoxLoginName.Text + "', '"
            //    + textBoxPass.Text + "', '" + textBoxUserName.Text + "', '"
            //    + comboBoxRole.Text + "'";
            //SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            //sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter Return = new SqlParameter();
            SqlParameter login = new SqlParameter();
            SqlParameter pass = new SqlParameter();
            SqlParameter username = new SqlParameter();
            SqlParameter role = new SqlParameter();

            Return.DbType = DbType.Int32;
            Return.ParameterName = "@return_value";
            Return.Direction = ParameterDirection.ReturnValue;

            login.DbType = DbType.String;
            login.ParameterName = "@LGNAME";
            login.Direction = ParameterDirection.Input;
            login.Value = textBoxLogin.Text;

            pass.DbType = DbType.String;
            pass.ParameterName = "@PASS";
            pass.Direction = ParameterDirection.Input;
            pass.Value = textBoxAddMK2.Text;

            username.DbType = DbType.String;
            username.ParameterName = "@USERNAME";
            username.Direction = ParameterDirection.Input;
            username.Value = textBoxMGV.Text;

            role.DbType = DbType.String;
            role.ParameterName = "@ROLE";
            role.Direction = ParameterDirection.Input;
            role.Value = comboBoxRole.Text;

            sqlCommand.Connection = Program.sqlConnection;
            sqlCommand.CommandText = "SP_TAOLOGIN";
            sqlCommand.Parameters.Add(Return);
            sqlCommand.Parameters.Add(pass);
            sqlCommand.Parameters.Add(username);
            sqlCommand.Parameters.Add(login);
            sqlCommand.Parameters.Add(role);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Loi: " + se.Message);
            }
            //int retval = (int)sqlCommand.Parameters["@returnValue"].Value;
            //MessageBox.Show(sqlCommand.Parameters["@returnValue"].Value.ToString());
            if (Return.Value.ToString().Equals("1"))
            {
                //MessageBox.Show("Login name đã tồn tại. Chú ý!");
                this.labelETDN.Text = "Tên đăng nhập đã tồn tại. Chú ý!";
                textBoxLogin.Focus();
                return;
            }
            if (Return.Value.ToString().Equals("2"))
            {
                this.labelEMGV.Text = "Mã giáo viên đã liên kết với tài khoản khác. Chú ý!";
                //MessageBox.Show("Mã giáo viên đã liên kết với tài khoản khác. Chú ý!");
                textBoxLogin.Focus();
                return;
            }
            if (Return.Value.ToString().Equals("0"))
            {
                MessageBox.Show("Thành công!");
                clkOK = true;
                return;
            }
        }

        private void buttonHuy2_Click(object sender, EventArgs e)
        {
            this.gIAOVIENGridControl.Visible = false;
            this.groupBoxAddAcc.Visible = false;
            this.labelTim2.Visible = false;
            this.textBoxTim2.Visible = false;
            this.tableLayoutPanel1.Visible = true;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!clkOK)
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void textBoxTim1_TextChanged(object sender, EventArgs e)
        {
            v_DSTAIKHOANBindingSource.Filter = "MAGV LIKE '%" + textBoxTim1.Text + "%'";
        }

        private void textBoxTim1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Mã giáo viên", textBoxTim1);
        }

        private void textBoxTim2_TextChanged(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.Filter = "MAGV LIKE '%" + textBoxTim2.Text + "%' OR TENGV LIKE '%" + textBoxTim2.Text + "%'";
        }

        private void textBoxTim2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Mã giáo viên hoặc Tên giáo viên", textBoxTim1);
        }
    }
}
