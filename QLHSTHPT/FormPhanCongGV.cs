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
    public partial class FormPhanCongGV : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormPhanCongGV(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormPhanCongGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet2.PHANCONGGV' table. You can move, or remove it, as needed.
            this.pHANCONGGVTableAdapter.Fill(this.qLHSTHPTDataSet2.PHANCONGGV);
            this.ControlBox = false;
            groupBoxCT.Enabled = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet2.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHSTHPTDataSet2.MONHOC);
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet2.PHANCONGGV' table. You can move, or remove it, as needed.
            this.pHANCONGGVTableAdapter.Fill(this.qLHSTHPTDataSet2.PHANCONGGV);
        }

        private void buttonTimGV_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimGV f = new FormTimGV(formChinh, this);
            //f.Activate();
            //f.Show();
            f.ShowDialog();
        }

        private void buttonTimLop_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimLop f = new FormTimLop(formChinh, this);
            f.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = false;
            formChinh.toolStripStatusLabelNote.Text = "";
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.pHANCONGGVGridControl.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.pHANCONGGVBindingSource.AddNew();
            this.comboBoxMMH.SelectedIndex = 1;
            this.comboBoxMMH.SelectedIndex = 0;
            this.comboBoxMHK.SelectedIndex = 1;
            this.comboBoxMHK.SelectedIndex = 0;
            this.boxSoTiet.Value = 0;
            this.boxSoTiet.Value = 15;
            this.checkBoxCN.Checked = false;
            this.textBoxMaGV.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelEMaGV.Text = labelEMaHK.Text = labelEMaLop.Text = labelEMMH.Text = "";
            this.pHANCONGGVBindingSource.RemoveCurrent();
            this.pHANCONGGVBindingSource.CancelEdit();
            this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = true;
            this.pHANCONGGVGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelEMaGV.Text = this.labelEMaHK.Text = this.labelEMaLop.Text = "";

            if (this.textBoxMaGV.Text == "")
            {
                this.labelEMaGV.Text = "Chưa nhập Mã giáo viên. Chú ý!";
                //essageBox.Show("Chưa nhập Tên giáo viên. Chú ý!");
                textBoxMaGV.Focus();
                return;
            }

            if (this.textBoxMaLop.Text == "")
            {
                this.labelEMaLop.Text = "Chưa nhập Mã lớp. Chú ý!";
                textBoxMaLop.Focus();
                return;
            }

            string sql1 = "EXEC SP_KTMA '" + textBoxMaGV.Text + "', 'GIAOVIEN'";
            SqlCommand sqlCommand1 = new SqlCommand(sql1, Program.sqlConnection);
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
            if (!dataReader1.Read())
            {
                labelEMaGV.Text = "Mã giáo viên không tồn tại. Chú ý!";
                textBoxMaGV.Focus();
                dataReader1.Close();
                return;
            }
            dataReader1.Close();

            string sql2 = "EXEC SP_KTMA '" + textBoxMaLop.Text + "', 'LOP'";
            SqlCommand sqlCommand2 = new SqlCommand(sql2, Program.sqlConnection);
            SqlDataReader dataReader2 = sqlCommand2.ExecuteReader();
            if (!dataReader2.Read())
            {
                labelEMaLop.Text = "Mã lớp không tồn tại. Chú ý!";
                textBoxMaLop.Focus();
                dataReader2.Close();
                return;
            }
            dataReader2.Close();

            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter maGV = new SqlParameter();
            SqlParameter maLop = new SqlParameter();
            SqlParameter maMH = new SqlParameter();
            SqlParameter maHK = new SqlParameter();

            maGV.DbType = DbType.String;
            maGV.ParameterName = "@MAGV";
            maGV.Direction = ParameterDirection.Input;
            maGV.Value = textBoxMaGV.Text;

            maLop.DbType = DbType.String;
            maLop.ParameterName = "@MALOP";
            maLop.Direction = ParameterDirection.Input;
            maLop.Value = textBoxMaLop.Text;

            maMH.DbType = DbType.String;
            maMH.ParameterName = "@MAMH";
            maMH.Direction = ParameterDirection.Input;
            maMH.Value = comboBoxMMH.Text;

            maHK.DbType = DbType.Int32;
            maHK.ParameterName = "@MAHK";
            maHK.Direction = ParameterDirection.Input;
            maHK.Value = comboBoxMHK.Text;

            sqlCommand.Connection = Program.sqlConnection;
            sqlCommand.CommandText = "SP_KT_PHANCONG";
            sqlCommand.Parameters.Add(maGV);
            sqlCommand.Parameters.Add(maLop);
            sqlCommand.Parameters.Add(maMH);
            sqlCommand.Parameters.Add(maHK);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            int nowPosition = pHANCONGGVBindingSource.Position;
            int position = -1;
            for (int i = 0; i < pHANCONGGVBindingSource.Count - 1; i++)
            {
                string _maGV = ((DataRowView)pHANCONGGVBindingSource[i])["MAGV"].ToString().Trim();
                string _maLop = ((DataRowView)pHANCONGGVBindingSource[i])["MALOP"].ToString().Trim();
                string _maMH = ((DataRowView)pHANCONGGVBindingSource[i])["MAMH"].ToString().Trim();
                string _maHK = ((DataRowView)pHANCONGGVBindingSource[i])["MAHK"].ToString().Trim();

                if (maGV.Value.Equals(_maGV) && maLop.Value.Equals(_maLop) && maMH.Value.Equals(_maMH) && maHK.Value.Equals(_maHK))
                {
                    position = i;
                    break;
                }
            }

            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                MessageBox.Show("Nhiệm vụ đã tồn tại. Chú ý!");
                textBoxMaGV.Focus();
                dataReader.Close();
                return;
            }
            else
            {
                this.pHANCONGGVBindingSource.EndEdit();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.pHANCONGGVGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = true;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = false;
            formChinh.toolStripStatusLabelNote.Text = "";
            this.pHANCONGGVGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxMaGV.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                clkMan = 1;
                this.pHANCONGGVBindingSource.RemoveCurrent();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.pHANCONGGVTableAdapter.Fill(this.qLHSTHPTDataSet2.PHANCONGGV);
            this.pHANCONGGVGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.pHANCONGGVTableAdapter.Update(this.qLHSTHPTDataSet2.PHANCONGGV);
            this.pHANCONGGVGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
            //clkSave = 1;
            clkMan = clkOK = 0;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            if (clkMan == 0 && clkOK == 0)
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            pHANCONGGVBindingSource.Filter = "MAGV LIKE '%" + textBoxTim.Text + "%'"; ;
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Mã giáo viên", textBoxTim);
        }

        private void comboBoxMMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.textBoxTenMH.Text = comboBoxMMH.SelectedValue.ToString();
            }
            catch { }
        }

        private void textBoxMaGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEMaGV.Text = "Mã giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEMaGV.Text = "Mã giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEMaGV.Text = "Mã giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEMaGV.Text = "Mã giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEMaGV.Text = "Mã giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEMaGV.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEMaLop.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEMaLop.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEMaLop.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEMaLop.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEMaLop.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEMaLop.Text = "";
                e.Handled = false;
            }
        }
    }
}
