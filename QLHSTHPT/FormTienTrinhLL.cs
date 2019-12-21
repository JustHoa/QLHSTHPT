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
    public partial class FormTienTrinhLL : Form
    {
        Form form;
        ComboBox comboBox;
        BindingSource bindingSource;
        List<Lop> arrLop;
        int[] soHS_Lop = new int [8];

        FormLL10 formLL10;
        FormLL11 formLL11;
        FormLL12 formLL12;
        FormChinh formChinh;
        List<Lop> arrLop10;
        List<Lop> arrLop11;
        List<Lop> arrLop12;
        public FormTienTrinhLL()
        {
            InitializeComponent();
        }

        public FormTienTrinhLL(Form form, ComboBox comboBox, BindingSource bindingSource)
        {
            InitializeComponent();
            this.form = form;
            this.comboBox = comboBox;
            this.bindingSource = bindingSource;
        }

        public FormTienTrinhLL(FormLL10 formLL10)
        {
            InitializeComponent();
            this.formLL10 = formLL10;
        }

        public FormTienTrinhLL(FormLL11 formLL11)
        {
            InitializeComponent();
            this.formLL11 = formLL11;
        }

        public FormTienTrinhLL(FormLL12 formLL12)
        {
            InitializeComponent();
            this.formLL12 = formLL12;
        }

        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            //ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        private void FormTienTrinhLL_Load(object sender, EventArgs e)
        {
            panelAddNH.Visible = true;
            panelAddNH.Dock = DockStyle.Fill;
            panelAddLop.Visible = panelAddHS.Visible = false;
            chkbAddNH.BackColor = Color.Orange;

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);
            this.textBoxMNH.Text = (int.Parse(Helper.createAutoIncre(nAMHOCBindingSource, "MANH")) + 1).ToString();
        }

        private void FormTienTrinhLL_SizeChanged(object sender, EventArgs e)
        {
            progressBar.Width = progressBar.Parent.Width - 3;
            CenterControlInParent(this.progressBar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            progressBar.Value = 33;
            chkbAddNH.Checked = true;
            chkbAddNH.BackColor = Color.Turquoise;
            chkbAddLop.BackColor = Color.Orange;

            panelAddLop.Visible = true;
            panelAddLop.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHS.Visible = false;

            arrLop = new List<Lop>();
            string maLop = Helper.createMaLop();
            int maNH = Helper.layMaNHMoiNhat();

            //kt lop vs maNH

            foreach (var item in comboBox.Items)
            {
                arrLop.Add(new Lop(maLop, item.ToString(), maNH, "Ban cơ bản", 10));
                int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maLop = maLop.Substring(0, 4) + part3;
            }
            gridControl1.DataSource = arrLop;
            gridView3.Columns[0].Caption = "MÃ LỚP";
            gridView3.Columns[0].OptionsColumn.ReadOnly = true;
            gridView3.Columns[1].Caption = "TÊN LỚP";
            gridView3.Columns[1].OptionsColumn.ReadOnly = true;
            gridView3.Columns[2].Caption = "MÃ NĂM HỌC";
            gridView3.Columns[2].OptionsColumn.ReadOnly = true;
            gridView3.Columns[3].Caption = "BAN";
            gridView3.Columns[3].OptionsColumn.ReadOnly = true;
            gridView3.Columns[4].Caption = "KHỐI";
            gridView3.Columns[4].OptionsColumn.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            labelEMNH.Text = labelETNH.Text = labelENBD.Text = labelENKT.Text = "";

            if (this.textBoxTNH.Text == "")
            {
                this.labelETNH.Text = "Chưa nhập Tên năm học. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên năm học. Chú ý!");
                textBoxTNH.Focus();
                return;
            }

            if (this.textBoxNBD.Text == "")
            {
                this.labelENBD.Text = "Chưa nhập Năm bắt đầu. Chú ý!";
                //MessageBox.Show("Chưa nhập Năm bắt đầu. Chú ý!");
                textBoxNBD.Focus();
                return;
            }

            if (this.textBoxNKT.Text == "")
            {
                this.labelENKT.Text = "Chưa nhập Năm kết thúc. Chú ý!";
                //MessageBox.Show("Chưa nhập Năm kết thúc. Chú ý!");
                textBoxNKT.Focus();
                return;
            }

            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter Return = new SqlParameter();
            SqlParameter dbMaNH = new SqlParameter();
            SqlParameter dbTenNH = new SqlParameter();
            SqlParameter dbNamBD = new SqlParameter();
            SqlParameter dbNamKT = new SqlParameter();

            Return.DbType = DbType.Int32;
            Return.ParameterName = "@return_value";
            Return.Direction = ParameterDirection.ReturnValue;

            dbMaNH.DbType = DbType.String;
            dbMaNH.ParameterName = "@MANH";
            dbMaNH.Direction = ParameterDirection.Input;
            dbMaNH.Value = textBoxMNH.Text;

            dbTenNH.DbType = DbType.String;
            dbTenNH.ParameterName = "@TENNH";
            dbTenNH.Direction = ParameterDirection.Input;
            dbTenNH.Value = textBoxTNH.Text;

            dbNamBD.DbType = DbType.Int32;
            dbNamBD.ParameterName = "@NAMBD";
            dbNamBD.Direction = ParameterDirection.Input;
            dbNamBD.Value = textBoxNBD.Text;

            dbNamKT.DbType = DbType.Int32;
            dbNamKT.ParameterName = "@NAMKT";
            dbNamKT.Direction = ParameterDirection.Input;
            dbNamKT.Value = textBoxNKT.Text;

            sqlCommand.Connection = Program.sqlConnection;
            sqlCommand.CommandText = "SP_THEM_NH";
            sqlCommand.Parameters.Add(Return);
            sqlCommand.Parameters.Add(dbMaNH);
            sqlCommand.Parameters.Add(dbTenNH);
            sqlCommand.Parameters.Add(dbNamBD);
            sqlCommand.Parameters.Add(dbNamKT);
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
                this.labelENBD.Text = "Năm bắt đầu đã tồn tại. Chú ý!";
                textBoxNBD.Focus();
                return;
            }
            if (Return.Value.ToString().Equals("2"))
            {
                this.labelENKT.Text = "Năm kết thúc đã tồn tại. Chú ý!";
                //MessageBox.Show("Mã giáo viên đã liên kết với tài khoản khác. Chú ý!");
                textBoxNKT.Focus();
                return;
            }
            if (Return.Value.ToString().Equals("3"))
            {
                this.labelETNH.Text = "Tên năm học đã tồn tại. Chú ý!";
                //MessageBox.Show("Mã giáo viên đã liên kết với tài khoản khác. Chú ý!");
                textBoxTNH.Focus();
                return;
            }
            if (Return.Value.ToString().Equals("0"))
            {
                progressBar.Value = 33;
                chkbAddNH.Checked = true;
                chkbAddNH.BackColor = Color.Turquoise;
                chkbAddLop.BackColor = Color.Orange;

                panelAddLop.Visible = true;
                panelAddLop.Dock = DockStyle.Fill;
                panelAddNH.Visible = panelAddHS.Visible = false;

                arrLop = new List<Lop>();
                string maLop = Helper.createMaLop();
                int maNH = Helper.layMaNHMoiNhat();

                //kt lop vs maNH

                foreach (var item in comboBox.Items)
                {
                    arrLop.Add(new Lop(maLop, item.ToString(), maNH, "Ban cơ bản", 10));
                    int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                    string part3 = _part3.ToString().PadLeft(6, '0');
                    maLop = maLop.Substring(0, 4) + part3;
                }
                gridControl1.DataSource = arrLop;
                gridView3.Columns[0].Caption = "MÃ LỚP";
                gridView3.Columns[0].OptionsColumn.ReadOnly = true;
                gridView3.Columns[1].Caption = "TÊN LỚP";
                gridView3.Columns[1].OptionsColumn.ReadOnly = true;
                gridView3.Columns[2].Caption = "MÃ NĂM HỌC";
                gridView3.Columns[2].OptionsColumn.ReadOnly = true;
                gridView3.Columns[3].Caption = "BAN";
                gridView3.Columns[3].OptionsColumn.ReadOnly = true;
                gridView3.Columns[4].Caption = "KHỐI";
                gridView3.Columns[4].OptionsColumn.ReadOnly = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelEMNH.Text = labelETNH.Text = labelENBD.Text = labelENKT.Text = "";
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);
            this.textBoxMNH.Text = (int.Parse(Helper.createAutoIncre(nAMHOCBindingSource, "MANH")) + 1).ToString();

            panelAddNH.Visible = true;
            panelAddNH.Dock = DockStyle.Fill;
            panelAddLop.Visible = panelAddHS.Visible = false;

            labelEML.Text = labelETL.Text = labelENH.Text = labelEBan.Text = labelEKhoi.Text = "";

            progressBar.Value = 0;
            chkbAddNH.Checked = false;
            chkbAddLop.BackColor = Color.Turquoise;
            chkbAddNH.BackColor = Color.Orange;

            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);
            this.textBoxMNH.Text = (int.Parse(Helper.createAutoIncre(nAMHOCBindingSource, "MANH")) + 1).ToString();

            panelAddNH.Visible = true;
            panelAddNH.Dock = DockStyle.Fill;
            panelAddLop.Visible = panelAddHS.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar.Value = 67;
            chkbAddLop.Checked = true;
            chkbAddLop.BackColor = Color.Turquoise;
            chkbAddHS.BackColor = Color.Orange;

            panelAddHS.Visible = true;
            panelAddHS.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddLop.Visible = false;

            try
            {
                this.sP_LOP_NAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LOP_NAMHOC, Helper.layMaNHMoiNhat());
                textBoxSLLop.Text = comboBoxLopNH.Items.Count.ToString();
                comboBoxLopNH.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            soHS_Lop = Helper.xepLop(bindingSource.Count);
        }
        
        private void textBoxTL_TextChanged(object sender, EventArgs e)
        {
            gridView3.SetFocusedRowCellValue("tenLop", textBoxTL.Text);
        }

        private void gridView3_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textBoxML.Text = gridView3.GetFocusedRowCellValue("maLop").ToString();
            textBoxTL.Text = gridView3.GetFocusedRowCellValue("tenLop").ToString();
            textBoxNH.Text = gridView3.GetFocusedRowCellValue("maNH").ToString();
            textBoxBan.Text = gridView3.GetFocusedRowCellValue("ban").ToString();
            textBoxKhoi.Text = gridView3.GetFocusedRowCellValue("maKhoi").ToString();
        }

        private void textBoxNH_TextChanged(object sender, EventArgs e)
        {
            gridView3.SetFocusedRowCellValue("maNH", textBoxNH.Text);
        }

        private void textBoxBan_TextChanged(object sender, EventArgs e)
        {
            gridView3.SetFocusedRowCellValue("ban", textBoxBan.Text);
        }

        private void textBoxKhoi_TextChanged(object sender, EventArgs e)
        {
            gridView3.SetFocusedRowCellValue("maKhoi", textBoxKhoi.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.labelEML.Text = this.labelETL.Text = this.labelENH.Text = labelEBan.Text = "";

            for (int i = 0; i < gridView3.RowCount; i++)
            {
                string maLop = gridView3.GetRowCellValue(i, "maLop").ToString();
                string tenLop = gridView3.GetRowCellValue(i, "tenLop").ToString();
                int maNH = int.Parse(gridView3.GetRowCellValue(i, "maNH").ToString());
                string ban = gridView3.GetRowCellValue(i, "ban").ToString();
                int maKhoi = int.Parse(gridView3.GetRowCellValue(i, "maKhoi").ToString());

                SqlCommand sqlCommand1 = new SqlCommand();
                SqlParameter dbMaLop = new SqlParameter();
                SqlParameter dbTenLop = new SqlParameter();
                SqlParameter dbMaNH = new SqlParameter();
                SqlParameter dbBan = new SqlParameter();
                SqlParameter dbMaKhoi = new SqlParameter();

                dbMaLop.DbType = DbType.String;
                dbMaLop.ParameterName = "@MALOP";
                dbMaLop.Direction = ParameterDirection.Input;
                dbMaLop.Value = maLop;

                dbTenLop.DbType = DbType.String;
                dbTenLop.ParameterName = "@TENLOP";
                dbTenLop.Direction = ParameterDirection.Input;
                dbTenLop.Value = tenLop;

                dbMaNH.DbType = DbType.String;
                dbMaNH.ParameterName = "@MANH";
                dbMaNH.Direction = ParameterDirection.Input;
                dbMaNH.Value = maNH;

                dbBan.DbType = DbType.String;
                dbBan.ParameterName = "@BAN";
                dbBan.Direction = ParameterDirection.Input;
                dbBan.Value = ban;

                dbMaKhoi.DbType = DbType.String;
                dbMaKhoi.ParameterName = "@MAKHOI";
                dbMaKhoi.Direction = ParameterDirection.Input;
                dbMaKhoi.Value = maKhoi;

                sqlCommand1.Connection = Program.sqlConnection;
                sqlCommand1.CommandText = "SP_THEM_LOP";
                sqlCommand1.Parameters.Add(dbMaLop);
                sqlCommand1.Parameters.Add(dbTenLop);
                sqlCommand1.Parameters.Add(dbMaNH);
                sqlCommand1.Parameters.Add(dbBan);
                sqlCommand1.Parameters.Add(dbMaKhoi);
                sqlCommand1.CommandType = CommandType.StoredProcedure;
                try
                {
                    sqlCommand1.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    string tenNH = Helper.layNamHoc(maNH);
                    MessageBox.Show("Lỗi: Không thể lưu thông tin lớp.\n\n" +
                        "Hãy đảm bảo bạn đang sử dụng mã của năm học mới!\n\n" +
                        "Mã năm học đang sử dụng: " + maNH +
                        "\nNăm học: " + tenNH +
                        "\n\nGợi ý: Đổi tên năm học");
                    return;
                }
            }
            progressBar.Value = 67;
            chkbAddLop.Checked = true;
            chkbAddLop.BackColor = Color.Turquoise;
            chkbAddHS.BackColor = Color.Orange;

            panelAddHS.Visible = true;
            panelAddHS.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddLop.Visible = false;

            try
            {
                this.sP_LOP_NAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LOP_NAMHOC, Helper.layMaNHMoiNhat());
                textBoxSLLop.Text = comboBoxLopNH.Items.Count.ToString();
                comboBoxLopNH.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            soHS_Lop = Helper.xepLop(bindingSource.Count);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int indexBS = 0, indexCB = 0;
            for (int i = 0; i < soHS_Lop.Length; i++)
            {
                if (soHS_Lop[i] != 0)
                {
                    try
                    {
                        comboBoxLopNH.SelectedIndex = indexCB++;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Lớp chưa được tạo!", "Lên lớp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string maLop = comboBoxLopNH.SelectedValue.ToString();
                    for (int j = 0; j < soHS_Lop[i]; j++)
                    {
                        string maHS = ((DataRowView)bindingSource[indexBS++])["MAHS"].ToString();

                        SqlCommand sqlCommand = new SqlCommand();
                        SqlParameter dbMaHS = new SqlParameter();
                        SqlParameter dbMaLop = new SqlParameter();

                        dbMaHS.DbType = DbType.String;
                        dbMaHS.ParameterName = "@MAHS";
                        dbMaHS.Direction = ParameterDirection.Input;
                        dbMaHS.Value = maHS;

                        dbMaLop.DbType = DbType.String;
                        dbMaLop.ParameterName = "@MALOP";
                        dbMaLop.Direction = ParameterDirection.Input;
                        dbMaLop.Value = maLop;

                        sqlCommand.Connection = Program.sqlConnection;
                        sqlCommand.CommandText = "SP_LL_HS_LOP";
                        sqlCommand.Parameters.Add(dbMaHS);
                        sqlCommand.Parameters.Add(dbMaLop);
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (SqlException se)
                        {
                            MessageBox.Show(se.Message);
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Tiến trình lên lớp đã hoàn tất!", "Lên lớp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sP_LOP_NAMHOCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<HS> ds = new BindingList<HS>();
            int numLeft = 0;
            int index = this.comboBoxLopNH.SelectedIndex;
            this.textBoxSiSo.Text = soHS_Lop[index].ToString() + " học sinh";
            this.labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + comboBoxLopNH.Text;
            for (int i = 0; i < index; i++)
            {
                numLeft += soHS_Lop[i];
            }
            for (int j = 0; j < soHS_Lop[index]; j++)
            {
                string maHS = ((DataRowView)bindingSource[numLeft])["MAHS"].ToString();
                string tenHS = ((DataRowView)bindingSource[numLeft])["TENHS"].ToString();
                ds.Add(new HS(maHS, tenHS));
                numLeft++;
            }
            ds.AllowNew = true;
            gridControl2.DataSource = ds;
            gridView4.Columns[0].Caption = "MÃ HỌC SINH";
            gridView4.Columns[1].Caption = "TÊN HỌC SINH";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            progressBar.Value = 33;
            chkbAddLop.Checked = false;
            chkbAddHS.BackColor = Color.Turquoise;
            chkbAddLop.BackColor = Color.Orange;

            panelAddLop.Visible = true;
            panelAddLop.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHS.Visible = false;

            arrLop = new List<Lop>();
            string maLop = Helper.createMaLop();
            int maHK = Helper.layMaHKMoiNhat();
            int maNH = Helper.layMaNHMoiNhat();

            //kt lop vs maNH

            foreach (var item in comboBox.Items)
            {
                arrLop.Add(new Lop(maLop, item.ToString(), maNH, "Ban cơ bản", 10));
                int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maLop = maLop.Substring(0, 4) + part3;
            }
        }
    }
}
