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
        int[] soHS_Lop;

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
            panelAddHK.Visible = panelAddLop.Visible = panelAddHS.Visible = false;
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
            progressBar.Value = 25;
            chkbAddNH.Checked = true;
            chkbAddNH.BackColor = Color.Turquoise;
            chkbAddHK.BackColor = Color.Orange;

            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCKY);
            this.textBoxMHK.Text = (int.Parse(Helper.createAutoIncre(hOCKYBindingSource, "MAHK")) + 1).ToString();
            this.comboBoxTBD.SelectedIndex = 0;

            panelAddHK.Visible = true;
            panelAddHK.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddLop.Visible = panelAddHS.Visible = false;
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

            string sql = "EXEC SP_KT_NAMHOC_HOCKY 'NAMHOC', '" + textBoxTNH.Text + "', " +
                int.Parse(textBoxNBD.Text) + ", " + int.Parse(textBoxNKT.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = nAMHOCBindingSource.Position;
            int position = nAMHOCBindingSource.Find("NAMBD", textBoxNBD.Text);
            if (dataReader.Read())
            {
                this.labelENBD.Text = "Năm học đã tồn tại. Chú ý!";
                //MessageBox.Show("Năm học đã tồn tại. Chú ý!");
                textBoxNBD.Focus();
                dataReader.Close();
                return;
            }
            else
            {
                //this.nAMHOCBindingSource.EndEdit();
                this.nAMHOCTableAdapter.Update(this.qLHSTHPTDataSet1.NAMHOC);
                dataReader.Close();

                progressBar.Value = 25;
                chkbAddNH.Checked = true;
                chkbAddNH.BackColor = Color.Turquoise;
                chkbAddHK.BackColor = Color.Orange;

                this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCKY);
                this.textBoxMHK.Text = (int.Parse(Helper.createAutoIncre(hOCKYBindingSource, "MAHK")) + 1).ToString();
                this.comboBoxTBD.SelectedIndex = 0;

                panelAddHK.Visible = true;
                panelAddHK.Dock = DockStyle.Fill;
                panelAddNH.Visible = panelAddLop.Visible = panelAddHS.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelEMNH.Text = labelETNH.Text = labelENBD.Text = labelENKT.Text = "";

            progressBar.Value = 0;
            chkbAddNH.Checked = false;
            chkbAddHK.BackColor = Color.Turquoise;
            chkbAddNH.BackColor = Color.Orange;

            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);
            this.textBoxMNH.Text = (int.Parse(Helper.createAutoIncre(nAMHOCBindingSource, "MANH")) + 1).ToString();

            panelAddNH.Visible = true;
            panelAddNH.Dock = DockStyle.Fill;
            panelAddHK.Visible = panelAddLop.Visible = panelAddHS.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelEMHK.Text = labelETHK.Text = labelETBD.Text = labelENgay.Text = "";

            if (this.textBoxTHK.Text == "")
            {
                this.labelETHK.Text = "Chưa nhập Tên học kỳ. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên năm học. Chú ý!");
                textBoxTHK.Focus();
                return;
            }

            if (this.textBoxNgay.Text == "")
            {
                this.labelENgay.Text = "Chưa nhập Ngày bắt đầu. Chú ý!";
                //MessageBox.Show("Chưa nhập Năm kết thúc. Chú ý!");
                textBoxNgay.Focus();
                return;
            }

            if (int.Parse(textBoxNgay.Text) > 31 && (int.Parse(comboBoxTBD.Text) == 1 || int.Parse(comboBoxTBD.Text) == 3 || int.Parse(comboBoxTBD.Text) == 5 || int.Parse(comboBoxTBD.Text) == 7 || int.Parse(comboBoxTBD.Text) == 8 || int.Parse(comboBoxTBD.Text) == 10 || int.Parse(comboBoxTBD.Text) == 12))
            {
                this.labelENgay.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
                textBoxNgay.Focus();
                return;
            }
            else if (int.Parse(textBoxNgay.Text) > 30 && (int.Parse(comboBoxTBD.Text) == 4 || int.Parse(comboBoxTBD.Text) == 6 || int.Parse(comboBoxTBD.Text) == 9 || int.Parse(comboBoxTBD.Text) == 11))
            {
                this.labelENgay.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
                textBoxNgay.Focus();
                return;
            }
            else if (int.Parse(textBoxNgay.Text) > 29 && int.Parse(comboBoxTBD.Text) == 2)
            {
                this.labelENgay.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
                textBoxNgay.Focus();
                return;
            }

            //string sql = "EXEC SP_KT_NAMHOC_HOCKY 'NAMHOC', '" + textBoxTHK.Text + "', " +
            //    int.Parse(comboBoxTBD.Text) + ", " + int.Parse(textBoxNgay.Text);
            //SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            //SqlDataReader dataReader = sqlCommand.ExecuteReader();
            //int nowPosition = nAMHOCBindingSource.Position;
            //int position = nAMHOCBindingSource.Find("NAMBD", textBoxNBD.Text);
            //if ((dataReader.Read() || position != -1) && nowPosition != position)
            //{
            //    this.labelENBD.Text = "Năm học đã tồn tại. Chú ý!";
            //    //MessageBox.Show("Năm học đã tồn tại. Chú ý!");
            //    textBoxNBD.Focus();
            //    dataReader.Close();
            //    return;
            //}
            //else
            {
                //this.nAMHOCBindingSource.EndEdit();
                this.nAMHOCTableAdapter.Update(this.qLHSTHPTDataSet1.NAMHOC);
                //dataReader.Close();

                progressBar.Value = 50;
                chkbAddHK.Checked = true;
                chkbAddHK.BackColor = Color.Turquoise;
                chkbAddLop.BackColor = Color.Orange;

                panelAddLop.Visible = true;
                panelAddLop.Dock = DockStyle.Fill;
                panelAddNH.Visible = panelAddHK.Visible = panelAddHS.Visible = false;

                // do du lieu vao gridview
                arrLop = new List<Lop>();
                string maLop = Helper.createMaLop();
                int maHK = Helper.layMaHKMoiNhat();
                int maNH = Helper.layMaNHMoiNhat();
                foreach (var item in comboBox.Items)
                {
                    arrLop.Add(new Lop(maLop, item.ToString(), maHK, maNH, "Ban cơ bản", 10));
                    int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                    string part3 = _part3.ToString().PadLeft(6, '0');
                    maLop = maLop.Substring(0, 4) + part3;
                }
                gridControl1.DataSource = arrLop;
                gridView3.Columns[0].Caption = "MÃ LỚP";
                gridView3.Columns[0].OptionsColumn.ReadOnly = true;
                gridView3.Columns[1].Caption = "TÊN LỚP";
                gridView3.Columns[1].OptionsColumn.ReadOnly = true;
                gridView3.Columns[2].Caption = "MÃ HỌC KỲ";
                gridView3.Columns[2].OptionsColumn.ReadOnly = true;
                gridView3.Columns[3].Caption = "MÃ NĂM HỌC";
                gridView3.Columns[3].OptionsColumn.ReadOnly = true;
                gridView3.Columns[4].Caption = "BAN";
                gridView3.Columns[4].OptionsColumn.ReadOnly = true;
                gridView3.Columns[5].Caption = "KHỐI";
                gridView3.Columns[5].OptionsColumn.ReadOnly = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar.Value = 50;
            chkbAddHK.Checked = true;
            chkbAddHK.BackColor = Color.Turquoise;
            chkbAddLop.BackColor = Color.Orange;

            panelAddLop.Visible = true;
            panelAddLop.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHK.Visible = panelAddHS.Visible = false;

            arrLop = new List<Lop>();
            string maLop = Helper.createMaLop();
            int maHK = Helper.layMaHKMoiNhat();
            int maNH = Helper.layMaNHMoiNhat();

            //kt lop vs maNH

            foreach (var item in comboBox.Items)
            {
                arrLop.Add(new Lop(maLop, item.ToString(), maHK, maNH, "Ban cơ bản", 10));
                int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maLop = maLop.Substring(0, 4) + part3;
            }
            gridControl1.DataSource = arrLop;
            gridView3.Columns[0].Caption = "MÃ LỚP";
            gridView3.Columns[0].OptionsColumn.ReadOnly = true;
            gridView3.Columns[1].Caption = "TÊN LỚP";
            gridView3.Columns[1].OptionsColumn.ReadOnly = true;
            gridView3.Columns[2].Caption = "MÃ HỌC KỲ";
            gridView3.Columns[2].OptionsColumn.ReadOnly = true;
            gridView3.Columns[3].Caption = "MÃ NĂM HỌC";
            gridView3.Columns[3].OptionsColumn.ReadOnly = true;
            gridView3.Columns[4].Caption = "BAN";
            gridView3.Columns[4].OptionsColumn.ReadOnly = true;
            gridView3.Columns[5].Caption = "KHỐI";
            gridView3.Columns[5].OptionsColumn.ReadOnly = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelEMHK.Text = labelETHK.Text = labelETBD.Text = labelENgay.Text = ""; 

            progressBar.Value = 25;
            chkbAddHK.Checked = false;
            chkbAddHK.BackColor = Color.Orange;
            chkbAddLop.BackColor = Color.Turquoise;

            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCKY);
            this.textBoxMHK.Text = (int.Parse(Helper.createAutoIncre(hOCKYBindingSource, "MAHK")) + 1).ToString();

            panelAddHK.Visible = true;
            panelAddHK.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddLop.Visible = panelAddHS.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar.Value = 75;
            chkbAddLop.Checked = true;
            chkbAddLop.BackColor = Color.Turquoise;
            chkbAddHS.BackColor = Color.Orange;

            panelAddHS.Visible = true;
            panelAddHS.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHK.Visible = panelAddLop.Visible = false;

            try
            {
                this.sP_LOP_NAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LOP_NAMHOC, Helper.layMaNHMoiNhat());
                textBoxSLLop.Text = comboBoxLopNH.Items.Count.ToString();
                comboBoxLopNH.SelectedIndex = 0;
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
            textBoxHK.Text = gridView3.GetFocusedRowCellValue("maHK").ToString();
            textBoxNH.Text = gridView3.GetFocusedRowCellValue("maNH").ToString();
            textBoxBan.Text = gridView3.GetFocusedRowCellValue("ban").ToString();
            textBoxKhoi.Text = gridView3.GetFocusedRowCellValue("maKhoi").ToString();
        }

        private void textBoxHK_TextChanged(object sender, EventArgs e)
        {
            gridView3.SetFocusedRowCellValue("maHK", textBoxHK.Text);
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
            this.labelEML.Text = this.labelETL.Text = this.labelENH.Text = this.labelEMHK.Text = labelEBan.Text = "";

            for (int i = 0; i < gridView3.RowCount; i++)
            {
                string maLop = gridView3.GetRowCellValue(i, "maLop").ToString();
                string tenLop = gridView3.GetRowCellValue(i, "tenLop").ToString();
                int maHK = int.Parse(gridView3.GetRowCellValue(i, "maHK").ToString());
                int maNH = int.Parse(gridView3.GetRowCellValue(i, "maNH").ToString());
                string ban = gridView3.GetRowCellValue(i, "ban").ToString();
                int maKhoi = int.Parse(gridView3.GetRowCellValue(i, "maKhoi").ToString());

                SqlCommand sqlCommand1 = new SqlCommand();
                SqlParameter dbMaLop = new SqlParameter();
                SqlParameter dbTenLop = new SqlParameter();
                SqlParameter dbMaHK = new SqlParameter();
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

                dbMaHK.DbType = DbType.String;
                dbMaHK.ParameterName = "@MAHK";
                dbMaHK.Direction = ParameterDirection.Input;
                dbMaHK.Value = maHK;

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
                sqlCommand1.Parameters.Add(dbMaHK);
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
            progressBar.Value = 75;
            chkbAddLop.Checked = true;
            chkbAddLop.BackColor = Color.Turquoise;
            chkbAddHS.BackColor = Color.Orange;

            panelAddHS.Visible = true;
            panelAddHS.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHK.Visible = panelAddLop.Visible = false;

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
                    comboBoxLopNH.SelectedIndex = indexCB++;
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
            MessageBox.Show("Tiến trình lên lớp 10 đã hoàn tất");
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
            progressBar.Value = 50;
            chkbAddLop.Checked = false;
            chkbAddHS.BackColor = Color.Turquoise;
            chkbAddLop.BackColor = Color.Orange;

            panelAddLop.Visible = true;
            panelAddLop.Dock = DockStyle.Fill;
            panelAddNH.Visible = panelAddHK.Visible = panelAddHS.Visible = false;

            arrLop = new List<Lop>();
            string maLop = Helper.createMaLop();
            int maHK = Helper.layMaHKMoiNhat();
            int maNH = Helper.layMaNHMoiNhat();

            //kt lop vs maNH

            foreach (var item in comboBox.Items)
            {
                arrLop.Add(new Lop(maLop, item.ToString(), maHK, maNH, "Ban cơ bản", 10));
                int _part3 = int.Parse(maLop.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maLop = maLop.Substring(0, 4) + part3;
            }
        }
    }
}
