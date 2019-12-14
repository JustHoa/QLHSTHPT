using QLHSTHPT.Model;
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
    public partial class FormLop_HS : Form
    {

        //public int clkSaveLop = 0;
        public int clkManLop = 0;
        public int clkOKLop = 0;
        //public int clkSaveHS = 0;
        public int clkManHS = 0;
        public int clkOKHS = 0;
        public string maHS = "";
        private List<Lop_HS> arrDelHS = new List<Lop_HS>();

        FormChinh formChinh;

        internal List<Lop_HS> ArrDelHS { get => arrDelHS; set => arrDelHS = value; }

        public FormLop_HS(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }


        private void FormLop_HS_Load(object sender, EventArgs e)
        {
            if (Program.group == "PGV")
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = true;
                standaloneBarDockControl2.Enabled = true;
            }
            else
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = false;
                standaloneBarDockControl2.Enabled = false;
            }
            this.ControlBox = false;
            this.groupBoxCTLop.Enabled = false;
            this.groupBoxCTHS.Enabled = false;

            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet1.LOP);
            this.kHOITableAdapter.Fill(this.qLHSTHPTDataSet1.KHOI);

            try
            {
                int pos = lOPBindingSource.Position;
                string maLop = ((DataRowView)lOPBindingSource[pos])["MALOP"].ToString().Trim();
                this.labelTitHS.Text = "HỌC SINH LỚP " + maLop;
                this.sP_HS_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HS_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                formChinh.toolStripStatusLabelNote.Text = "Không tìm thấy dữ liệu!";
            }

            string sql = "SELECT TOP(1) * FROM HOCSINH ORDER BY MAHS DESC";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                maHS = dataReader.GetValue(0).ToString().Trim();
                dataReader.Close();
            }
            else
            {
                maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + "0000000";
                dataReader.Close();
            }
        }


        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            this.barButtonItem1.Enabled = false;
            this.barButtonItem2.Enabled = false;
            this.barButtonItem3.Enabled = false;
            this.barButtonItem4.Enabled = false;
            this.barButtonItem5.Enabled = false;
            this.standaloneBarDockControl2.Enabled = false;
            this.sP_HS_LOPGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.lOPGridControl.Enabled = false;
            this.labelTim1.Enabled = false;
            this.textBoxTim1.Enabled = false;
            this.groupBoxCTLop.Enabled = true;
            this.lOPBindingSource.AddNew();
            this.textBoxML.Text = Helper.createMaLop(lOPBindingSource);
            this.comboBoxBan.SelectedIndex = 1;
            this.comboBoxBan.SelectedIndex = 0;
            this.comboBoxMK.SelectedIndex = 1;
            this.comboBoxMK.SelectedIndex = 0;
            textBoxTenLop.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            this.barButtonItem1.Enabled = false;
            this.barButtonItem2.Enabled = false;
            this.barButtonItem3.Enabled = false;
            this.barButtonItem4.Enabled = false;
            this.barButtonItem5.Enabled = false;
            this.standaloneBarDockControl2.Enabled = false;
            this.sP_HS_LOPGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.lOPGridControl.Enabled = false;
            this.labelTim1.Enabled = false;
            this.textBoxTim1.Enabled = false;
            this.groupBoxCTLop.Enabled = true;
            this.textBoxTenLop.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            int vitri = lOPBindingSource.Position;
            string maLop = ((DataRowView)lOPBindingSource[vitri])["MALOP"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maLop + "', 'HS_LOP'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Lớp đã có học sinh. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkManLop = 1;
                        this.lOPBindingSource.RemoveCurrent();
                        formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                    }
                    dataReader.Close();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Update(this.qLHSTHPTDataSet1.LOP);
            this.lOPGridControl.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
            //clkSaveLop = 1;
            clkManLop = clkOKLop = 0;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            //MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet1.LOP);
            try
            {
                int pos = lOPBindingSource.Position;
                string maLop = ((DataRowView)lOPBindingSource[pos])["MALOP"].ToString().Trim();
                this.labelTitHS.Text = "HỌC SINH LỚP " + maLop;
                this.sP_HS_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HS_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                formChinh.toolStripStatusLabelNote.Text = "Không tìm thấy dữ liệu!";
            }
            this.lOPGridControl.Enabled = true;
            this.labelTim1.Enabled = true;
            this.textBoxTim1.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            int savedLop = 0, savedHS = 0;
            //if ((clkManLop == 0 && clkOKLop == 0) || ((clkManLop == 1 || clkOKLop == 1) && clkSaveLop == 1))
            if (clkManLop == 0 && clkOKLop == 0)
                savedLop = 1;
            //if ((clkManHS == 0 && clkOKHS == 0) || ((clkManHS == 1 || clkOKHS == 1) && clkSaveHS == 1))
            if (clkManHS == 0 && clkOKHS == 0)
                savedHS = 1;
            if (savedLop == 1 && savedHS == 1)
                this.Close();
            if (savedLop == 0)
            {
                if (MessageBox.Show("Chưa lưu dữ liệu Lớp. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
                return;
            }
            if (savedHS == 0)
                if (MessageBox.Show("Chưa lưu dữ liệu Học sinh. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelEMaLop.Text = this.labelEBM.Text = this.labelETenLop.Text = this.labelEMaNH.Text = this.labelEMaHK.Text = "";
            if (this.textBoxTenLop.Text == "")
            {
                this.labelETenLop.Text = "Chưa nhập Tên lớp. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên lớp. Chú ý!");
                textBoxTenLop.Focus();
                return;
            }

            if (this.textBoxMHK.Text == "")
            {
                this.labelEMaHK.Text = "Chưa nhập Mã học kỳ. Chú ý!";
                //MessageBox.Show("Chưa nhập Mã học kỳ. Chú ý!");
                textBoxMHK.Focus();
                return;
            }

            if (this.textBoxMNH.Text == "")
            {
                this.labelEMaNH.Text = "Chưa nhập Mã năm học. Chú ý!";
                //MessageBox.Show("Chưa nhập Mã năm học. Chú ý!");
                textBoxMNH.Focus();
                return;
            }

            string sql = "EXEC SP_KTMA '" + textBoxML.Text + "', 'LOP'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            int nowPosition = lOPBindingSource.Position;
            int position = lOPBindingSource.Find("MALOP", textBoxML.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                this.labelEMaLop.Text = "Mã lớp đã tồn tại. Chú ý!";
                //MessageBox.Show("Mã lớp đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            dataReader.Close();
            string sql1 = "EXEC SP_KT_LOP_HK '" + textBoxTenLop.Text + "', " + int.Parse(textBoxMNH.Text);
            SqlCommand sqlCommand1 = new SqlCommand(sql1, Program.sqlConnection);
            SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();

            if (dataReader1.Read())
            {
                this.labelETenLop.Text = "Tên lớp này đã được sử dụng. Chọn tên khác!";
                dataReader1.Close();
                return;
            }
            dataReader1.Close();

            this.lOPBindingSource.EndEdit();
            formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
            //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
            this.lOPGridControl.Enabled = true;
            this.labelTim1.Enabled = true;
            this.textBoxTim1.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
            this.barButtonItem1.Enabled = true;
            this.barButtonItem2.Enabled = true;
            this.barButtonItem3.Enabled = true;
            this.barButtonItem4.Enabled = true;
            this.barButtonItem5.Enabled = true;
            this.standaloneBarDockControl2.Enabled = true;
            this.sP_HS_LOPGridControl.Enabled = true;
            this.labelTim2.Enabled = true;
            this.textBoxTim2.Enabled = true;
            dataReader.Close();
            clkOKLop = 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.barButtonItem1.Enabled = true;
            this.barButtonItem2.Enabled = true;
            this.barButtonItem3.Enabled = true;
            this.barButtonItem4.Enabled = true;
            this.barButtonItem5.Enabled = true;
            this.standaloneBarDockControl2.Enabled = true;
            this.sP_HS_LOPGridControl.Enabled = true;
            this.labelTim2.Enabled = true;
            this.textBoxTim2.Enabled = true;
            this.lOPBindingSource.CancelEdit();
            this.lOPGridControl.Enabled = true;
            this.textBoxTim1.Enabled = true;
            this.labelTim1.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            this.tableLayoutPanel1.Enabled = false;
            this.barButtonItem13.Enabled = false;
            this.barButtonItem14.Enabled = false;
            this.barButtonItem15.Enabled = false;
            this.barButtonItem16.Enabled = false;
            this.barButtonItem17.Enabled = false;
            this.sP_HS_LOPGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.groupBoxCTHS.Enabled = true;
            this.sP_HS_LOPBindingSource.AddNew();
            this.textBoxMLHS.Enabled = false;
            this.textBoxMHS.Text = Helper.createMaHS(maHS);
            this.textBoxMLHS.Enabled = false;
            int vitri = lOPBindingSource.Position;
            string maLop = ((DataRowView)lOPBindingSource[vitri])["MALOP"].ToString().Trim();
            this.textBoxMLHS.Text = maLop;
            this.textBoxTenHS.Focus();
            this.comboBoxGT.SelectedIndex = 0;
            this.checkBoxNghi.Checked = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            this.tableLayoutPanel1.Enabled = false;
            this.barButtonItem13.Enabled = false;
            this.barButtonItem14.Enabled = false;
            this.barButtonItem15.Enabled = false;
            this.barButtonItem16.Enabled = false;
            this.barButtonItem17.Enabled = false;
            this.sP_HS_LOPGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.groupBoxCTHS.Enabled = true;
            this.textBoxTenHS.Focus();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";

            int vitri = sP_HS_LOPBindingSource.Position;
            string maHS = ((DataRowView)sP_HS_LOPBindingSource[vitri])["MAHS"].ToString().Trim();
            MessageBox.Show(maHS);
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maHS + "', 'DIEM'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Học sinh đã có điểm. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkManHS = 1;
                        arrDelHS.Add(new Lop_HS(textBoxMHS.Text, textBoxML.Text));
                        this.sP_HS_LOPBindingSource.RemoveCurrent();
                        formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                        
                    }
                    dataReader.Close();
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Loi");
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Lop_HS lhs in arrDelHS.ToList())
            {
                SqlCommand sqlCommand = new SqlCommand();
                SqlParameter dbMaHS = new SqlParameter();
                SqlParameter dbMaLop = new SqlParameter();

                dbMaHS.DbType = DbType.String;
                dbMaHS.ParameterName = "@MAHS";
                dbMaHS.Direction = ParameterDirection.Input;
                dbMaHS.Value = lhs.maHS;

                dbMaLop.DbType = DbType.String;
                dbMaLop.ParameterName = "@MALOP";
                dbMaLop.Direction = ParameterDirection.Input;
                dbMaLop.Value = lhs.maLop;

                try
                {
                    sqlCommand.Connection = Program.sqlConnection;
                    sqlCommand.CommandText = "[SP_DEL_HS_LOP]";
                    sqlCommand.Parameters.Add(dbMaHS);
                    sqlCommand.Parameters.Add(dbMaLop);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                    arrDelHS.Remove(lhs);
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Loi: " + se.Message);
                    arrDelHS.Remove(lhs);
                    continue;
                }
            }
            for (int i = 0; i < sP_HS_LOPBindingSource.Count; i++)
            {
                SqlCommand sqlCommand = new SqlCommand();
                SqlParameter dbMaHS = new SqlParameter();
                SqlParameter dbTenHS = new SqlParameter();
                SqlParameter dbNgaySinh = new SqlParameter();
                SqlParameter dbGioiTinh = new SqlParameter();
                SqlParameter dbDiaChi = new SqlParameter();
                SqlParameter dbDanToc = new SqlParameter();
                SqlParameter dbDientThoai = new SqlParameter();
                SqlParameter dbNghiHoc = new SqlParameter();
                SqlParameter dbMaLop = new SqlParameter();

                string maHS = ((DataRowView)sP_HS_LOPBindingSource[i])["MAHS"].ToString().Trim();
                string tenHS = ((DataRowView)sP_HS_LOPBindingSource[i])["TENHS"].ToString().Trim();
                DateTime ngaySinh = DateTime.Parse(((DataRowView)sP_HS_LOPBindingSource[i])["NGAYSINH"].ToString().Trim());
                string gioiTinh = ((DataRowView)sP_HS_LOPBindingSource[i])["GIOITINH"].ToString().Trim();
                string diaChi = ((DataRowView)sP_HS_LOPBindingSource[i])["DIACHI"].ToString().Trim();
                string danToc = ((DataRowView)sP_HS_LOPBindingSource[i])["DANTOC"].ToString().Trim();
                string dienThoai = ((DataRowView)sP_HS_LOPBindingSource[i])["DIENTHOAI"].ToString().Trim();
                int nghiHoc = int.Parse(((DataRowView)sP_HS_LOPBindingSource[i])["NGHIHOC"].ToString().Trim());
                string maLop = ((DataRowView)sP_HS_LOPBindingSource[i])["MALOP"].ToString().Trim();

                dbMaHS.DbType = DbType.String;
                dbMaHS.ParameterName = "@MAHS";
                dbMaHS.Direction = ParameterDirection.Input;
                dbMaHS.Value = maHS;

                dbTenHS.DbType = DbType.String;
                dbTenHS.ParameterName = "@TENHS";
                dbTenHS.Direction = ParameterDirection.Input;
                dbTenHS.Value = tenHS;

                dbNgaySinh.DbType = DbType.Date;
                dbNgaySinh.ParameterName = "@NGAYSINH";
                dbNgaySinh.Direction = ParameterDirection.Input;
                dbNgaySinh.Value = ngaySinh;

                dbGioiTinh.DbType = DbType.String;
                dbGioiTinh.ParameterName = "@GIOITINH";
                dbGioiTinh.Direction = ParameterDirection.Input;
                dbGioiTinh.Value = gioiTinh;

                dbDiaChi.DbType = DbType.String;
                dbDiaChi.ParameterName = "@DIACHI";
                dbDiaChi.Direction = ParameterDirection.Input;
                dbDiaChi.Value = diaChi;

                dbDanToc.DbType = DbType.String;
                dbDanToc.ParameterName = "@DANTOC";
                dbDanToc.Direction = ParameterDirection.Input;
                dbDanToc.Value = danToc;

                dbDientThoai.DbType = DbType.String;
                dbDientThoai.ParameterName = "@DIENTHOAI";
                dbDientThoai.Direction = ParameterDirection.Input;
                dbDientThoai.Value = dienThoai;

                dbNghiHoc.DbType = DbType.Int32;
                dbNghiHoc.ParameterName = "@NGHIHOC";
                dbNghiHoc.Direction = ParameterDirection.Input;
                dbNghiHoc.Value = nghiHoc;

                dbMaLop.DbType = DbType.String;
                dbMaLop.ParameterName = "@MALOP";
                dbMaLop.Direction = ParameterDirection.Input;
                dbMaLop.Value = maLop;

                try
                {
                    sqlCommand.Connection = Program.sqlConnection;
                    sqlCommand.CommandText = "SP_UPDATE_HS_LOP";
                    sqlCommand.Parameters.Add(dbMaHS);
                    sqlCommand.Parameters.Add(dbTenHS);
                    sqlCommand.Parameters.Add(dbNgaySinh);
                    sqlCommand.Parameters.Add(dbGioiTinh);
                    sqlCommand.Parameters.Add(dbDiaChi);
                    sqlCommand.Parameters.Add(dbDanToc);
                    sqlCommand.Parameters.Add(dbDientThoai);
                    sqlCommand.Parameters.Add(dbNghiHoc);
                    sqlCommand.Parameters.Add(dbMaLop);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Loi: " + se.Message);
                    return;
                }
            }

            this.sP_HS_LOPGridControl.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem13.Enabled = true;
            this.barButtonItem14.Enabled = true;
            this.barButtonItem15.Enabled = true;
            this.barButtonItem16.Enabled = true;
            this.barButtonItem17.Enabled = true;
            //clkSaveHS = 1;
            clkManHS = clkOKHS = 0;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                int pos = lOPBindingSource.Position;
                string maLop = ((DataRowView)lOPBindingSource[pos])["MALOP"].ToString().Trim();
                this.labelTitHS.Text = "HỌC SINH LỚP " + maLop;
                this.sP_HS_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HS_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            this.sP_HS_LOPGridControl.Enabled = true;
            this.labelTim2.Enabled = true;
            this.textBoxTim2.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem13.Enabled = true;
            this.barButtonItem14.Enabled = true;
            this.barButtonItem15.Enabled = true;
            this.barButtonItem16.Enabled = true;
            this.barButtonItem17.Enabled = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            labelEMaHS.Text = labelEHT.Text = labelEDC.Text = labelEDT.Text = labelEDTo.Text = labelENS.Text = labelEML.Text = "";
            if (this.textBoxMHS.Text == "")
            {
                this.labelEMaHS.Text = "Chưa nhập Mã học sinh. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên học sinh. Chú ý!");
                textBoxMHS.Focus();
                return;
            }

            if (this.textBoxTenHS.Text == "")
            {
                this.labelEHT.Text = "Chưa nhập Tên học sinh. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên học sinh. Chú ý!");
                textBoxTenHS.Focus();
                return;
            }

            if (this.textBoxDC.Text == "")
            {
                this.labelEDC.Text = "Chưa nhập Địa chỉ. Chú ý!";
                //MessageBox.Show("Chưa nhập Địa chỉ. Chú ý!");
                textBoxDC.Focus();
                return;
            }

            if (this.dateEditNS.Text == "")
            {
                this.labelENS.Text = "Chưa nhập Ngày sinh. Chú ý!";
                //MessageBox.Show("Chưa nhập Ngày sinh. Chú ý!");
                dateEditNS.Focus();
                return;
            }
            else
            {
                string[] date;
                date = this.dateEditNS.Text.Split("/".ToCharArray());
                int d = DateTime.Today.Year;
                if (int.Parse(date[2]) >= d)
                {
                    this.labelENS.Text = "Năm sinh không hợp lý. Chú ý!";
                    //MessageBox.Show("Năm sinh không hợp lý. Chú ý!");
                    dateEditNS.Focus();
                    return;
                }
            }

            if (this.textBoxDT.Text == "")
            {
                this.labelEDT.Text = "Chưa nhập Điện thoại. Chú ý!";
                //MessageBox.Show("Chưa nhập Điện thoại. Chú ý!");
                textBoxDT.Focus();
                return;
            }

            if (this.textBoxDToc.Text == "Chưa nhập Dân tộc. Chú ý!")
            {
                this.labelEDTo.Text = "Chưa nhập Dân tộc. Chú ý!";
                //MessageBox.Show("Chưa nhập Dân tộc. Chú ý!");
                textBoxDToc.Focus();
                return;
            }

            string sql = "EXEC SP_KTMA '" + textBoxMHS.Text + "', 'HS_LOP_HS'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = sP_HS_LOPBindingSource.Position;
            //int position = hOCSINHBindingSource.Find("MAHS", textBoxMHS.Text);
            int position = -1;
            for (int i = 0; i < sP_HS_LOPBindingSource.Count; i++)
            {
                if (((DataRowView)sP_HS_LOPBindingSource[i])["MAHS"].ToString() == textBoxMHS.Text)
                {
                    position = i;
                    break;
                }
            }
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                this.labelEMaHS.Text = "Mã học sinh đã tồn tại. Chú ý!";
                //MessageBox.Show("Mã học sinh đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.sP_HS_LOPBindingSource.EndEdit();
                maHS = Helper.createMaHS(maHS);
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.textBoxMLHS.Enabled = true;
                this.sP_HS_LOPGridControl.Enabled = true;
                this.labelTim2.Enabled = true;
                this.textBoxTim2.Enabled = true;
                this.groupBoxCTHS.Enabled = false;
                this.tableLayoutPanel1.Enabled = true;
                this.barButtonItem13.Enabled = true;
                this.barButtonItem14.Enabled = true;
                this.barButtonItem15.Enabled = true;
                this.barButtonItem16.Enabled = true;
                this.barButtonItem17.Enabled = true;
                dataReader.Close();
                clkOKHS = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelEMaHS.Text = labelEHT.Text = labelEDC.Text = labelEDT.Text = labelEDTo.Text = labelENS.Text = labelEML.Text = "";
            this.sP_HS_LOPBindingSource.CancelEdit();
            this.textBoxMLHS.Enabled = true;
            this.sP_HS_LOPGridControl.Enabled = true;
            this.textBoxTim2.Enabled = true;
            this.labelTim2.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem13.Enabled = true;
            this.barButtonItem14.Enabled = true;
            this.barButtonItem15.Enabled = true;
            this.barButtonItem16.Enabled = true;
            this.barButtonItem17.Enabled = true;
        }

        private void textBoxTim2_TextChanged(object sender, EventArgs e)
        {
            sP_HS_LOPBindingSource.Filter = "TENHS LIKE '%" + textBoxTim2.Text +
                "%' OR MAHS LIKE '%" + textBoxTim2.Text + "%' OR MALOP LIKE '%" + textBoxTim2.Text + "%'";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                int pos = lOPBindingSource.Position;
                string maLop = ((DataRowView)lOPBindingSource[pos])["MALOP"].ToString().Trim();
                this.labelTitHS.Text = "HỌC SINH LỚP " + maLop;
                this.sP_HS_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HS_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            try
            {
                int pos = lOPBindingSource.Position;
                string maLop = ((DataRowView)lOPBindingSource[pos])["MALOP"].ToString().Trim();
                this.labelTitHS.Text = "HỌC SINH LỚP " + maLop;
                this.sP_HS_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HS_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void textBoxTim2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên học sinh, Mã học sinh hoặc Mã lớp", textBoxTim2);
        }

        private void textBoxTim1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên lớp hoặc Mã lớp", textBoxTim1);
        }

        private void textBoxTim1_TextChanged(object sender, EventArgs e)
        {
            lOPBindingSource.Filter = "TENLOP LIKE '%" + textBoxTim1.Text +
                "%' OR MALOP LIKE '%" + textBoxTim1.Text + "%'";
        }

        private void groupBoxCTLop_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxTenLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelETenLop.Text = "Tên lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelETenLop.Text = "Tên lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelETenLop.Text = "Tên lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelETenLop.Text = "Tên lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelETenLop.Text = "Tên lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelETenLop.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEBM.Text = "Ban không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEBM.Text = "Ban không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEBM.Text = "Ban không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEBM.Text = "Ban không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEBM.Text = "Ban không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEBM.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxTenHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEHT.Text = "Họ tên học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEHT.Text = "Họ tên học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEHT.Text = "Họ tên học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEHT.Text = "Họ tên học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEHT.Text = "Họ tên học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEHT.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxMLHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)48 && textBoxDT.Text.Length == 0)
            {
                this.labelEDT.Text = "Điện thoại phải bắt đầu bắt đầu bằng 0";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEDT.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEDT.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEDT.Text = "Điện thoại chỉ bao gồm số!";
                e.Handled = true;
            }
        }

        private void buttonTimHS_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimInfoHS f = new FormTimInfoHS(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void textBoxML_KeyPress(object sender, KeyPressEventArgs e)
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

        private void buttonTimHK_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimHK_LHS f = new FormTimHK_LHS(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void buttonTimNH_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimNH_LHS f = new FormTimNH_LHS(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void textBoxMHK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEMaHK.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEMaHK.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEMaHK.Text = "Mã học kỳ chỉ bao gồm số!";
                e.Handled = true;
            }
        }

        private void textBoxMNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEMaNH.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEMaNH.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEMaNH.Text = "Mã năm học chỉ bao gồm số!";
                e.Handled = true;
            }
        }

        private void textBoxMHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEMaHS.Text = "Mã học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEMaHS.Text = "Mã học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEMaHS.Text = "Mã học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEMaHS.Text = "Mã học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEMaHS.Text = "Mã học sinh không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEMaHS.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxMLHS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelEML.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelEML.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelEML.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelEML.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelEML.Text = "Mã lớp không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelEML.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxDToc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
