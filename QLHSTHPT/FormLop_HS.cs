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

        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;
        public string maHS = "";

        FormChinh formChinh;

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
            }
            else
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = false;
            }
            this.ControlBox = false;
            this.groupBoxCTLop.Enabled = false;
            this.groupBoxCTHS.Enabled = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet.HOCSINH);

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
            this.barButtonItem1.Enabled = false;
            this.barButtonItem2.Enabled = false;
            this.barButtonItem3.Enabled = false;
            this.barButtonItem4.Enabled = false;
            this.barButtonItem5.Enabled = false;
            this.standaloneBarDockControl2.Enabled = false;
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.lOPGridControl.Enabled = false;
            this.labelTim1.Enabled = false;
            this.textBoxTim1.Enabled = false;
            this.groupBoxCTLop.Enabled = true;
            this.lOPBindingSource.AddNew();
            this.textBoxML.Text = Helper.createMaLop(lOPBindingSource);
            this.textBoxBan.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.barButtonItem1.Enabled = false;
            this.barButtonItem2.Enabled = false;
            this.barButtonItem3.Enabled = false;
            this.barButtonItem4.Enabled = false;
            this.barButtonItem5.Enabled = false;
            this.standaloneBarDockControl2.Enabled = false;
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.lOPGridControl.Enabled = false;
            this.labelTim1.Enabled = false;
            this.textBoxTim1.Enabled = false;
            this.groupBoxCTLop.Enabled = true;
            this.textBoxBan.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = lOPBindingSource.Position;
            string maLop = ((DataRowView)lOPBindingSource[vitri])["MALOP"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maLop + "', 'HOCSINH'";
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
                        clkMan = 1;
                        this.lOPBindingSource.RemoveCurrent();
                        formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                        //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                        //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
                        //this.mONHOCTableAdapter.Update(this.aSD_DataSet.MONHOC);
                        //MessageBox.Show("Xóa môn học thành công!");
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
            this.lOPTableAdapter.Update(this.qLHSTHPTDataSet.LOP);
            this.lOPGridControl.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
            clkSave = 1;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            //MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);
            this.lOPGridControl.Enabled = true;
            this.labelTim1.Enabled = true;
            this.textBoxTim1.Enabled = true;
            this.groupBoxCTLop.Enabled = false;
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((clkMan == 0 && clkOK == 0) || ((clkMan == 1 || clkOK == 1) && clkSave == 1))
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxTenLop.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên lớp. Chú ý!");
                textBoxTenLop.Focus();
                return;
            }

            if (this.textBoxBan.Text == "")
            {
                MessageBox.Show("Chưa nhập Bộ môn giảng dạy. Chú ý!");
                textBoxBan.Focus();
                return;
            }

            if (this.textBoxMHK.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã học kỳ. Chú ý!");
                textBoxMHK.Focus();
                return;
            }

            if (this.textBoxMNH.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã năm học. Chú ý!");
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
                MessageBox.Show("Mã lớp đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
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
                this.hOCSINHGridControl.Enabled = true;
                this.labelTim2.Enabled = true;
                this.textBoxTim2.Enabled = true;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.barButtonItem1.Enabled = true;
            this.barButtonItem2.Enabled = true;
            this.barButtonItem3.Enabled = true;
            this.barButtonItem4.Enabled = true;
            this.barButtonItem5.Enabled = true;
            this.standaloneBarDockControl2.Enabled = true;
            this.hOCSINHGridControl.Enabled = true;
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
            this.tableLayoutPanel1.Enabled = false;
            this.barButtonItem7.Enabled = false;
            this.barButtonItem8.Enabled = false;
            this.barButtonItem9.Enabled = false;
            this.barButtonItem10.Enabled = false;
            this.barButtonItem11.Enabled = false;
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.groupBoxCTHS.Enabled = true;
            this.hOCSINHBindingSource.AddNew();
            this.textBoxMHS.Text = Helper.createMaHS(maHS);
            int vitri = lOPBindingSource.Position;
            string maLop = ((DataRowView)lOPBindingSource[vitri])["MALOP"].ToString().Trim();
            this.textBoxMLHS.Text = maLop;
            this.textBoxTenHS.Focus();
            this.comboBoxGT.SelectedIndex = 0;
            this.checkBoxNghi.Checked = false;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.tableLayoutPanel1.Enabled = false;
            this.barButtonItem7.Enabled = false;
            this.barButtonItem8.Enabled = false;
            this.barButtonItem9.Enabled = false;
            this.barButtonItem10.Enabled = false;
            this.barButtonItem11.Enabled = false;
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim2.Enabled = false;
            this.textBoxTim2.Enabled = false;
            this.groupBoxCTHS.Enabled = true;
            this.textBoxTenHS.Focus();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = hOCSINHBindingSource.Position;
            string maHS = ((DataRowView)hOCSINHBindingSource[vitri])["MAHS"].ToString().Trim();
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
                        clkMan = 1;
                        this.hOCSINHBindingSource.RemoveCurrent();
                        formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                        //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                        //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connectionString;
                        //this.mONHOCTableAdapter.Update(this.aSD_DataSet.MONHOC);
                        //MessageBox.Show("Xóa môn học thành công!");
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
            this.hOCSINHTableAdapter.Update(this.qLHSTHPTDataSet.HOCSINH);
            this.hOCSINHGridControl.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem7.Enabled = true;
            this.barButtonItem8.Enabled = true;
            this.barButtonItem9.Enabled = true;
            this.barButtonItem10.Enabled = true;
            this.barButtonItem11.Enabled = true;
            clkSave = 1;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet.HOCSINH);
            this.hOCSINHGridControl.Enabled = true;
            this.labelTim2.Enabled = true;
            this.textBoxTim2.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem7.Enabled = true;
            this.barButtonItem8.Enabled = true;
            this.barButtonItem9.Enabled = true;
            this.barButtonItem10.Enabled = true;
            this.barButtonItem11.Enabled = true;
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((clkMan == 0 && clkOK == 0) || ((clkMan == 1 || clkOK == 1) && clkSave == 1))
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBoxTenHS.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên học sinh. Chú ý!");
                textBoxTenHS.Focus();
                return;
            }

            if (this.textBoxDC.Text == "")
            {
                MessageBox.Show("Chưa nhập Địa chỉ. Chú ý!");
                textBoxDC.Focus();
                return;
            }

            if (this.dateEditNS.Text == "")
            {
                MessageBox.Show("Chưa nhập Ngày sinh. Chú ý!");
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
                    MessageBox.Show("Năm sinh không hợp lý. Chú ý!");
                    dateEditNS.Focus();
                    return;
                }
            }

            if (this.textBoxDT.Text == "")
            {
                MessageBox.Show("Chưa nhập Điện thoại. Chú ý!");
                textBoxDT.Focus();
                return;
            }

            if (this.textBoxDToc.Text == "")
            {
                MessageBox.Show("Chưa nhập Dân tộc. Chú ý!");
                textBoxDToc.Focus();
                return;
            }

            string sql = "EXEC SP_KTMA '" + textBoxMHS.Text + "', 'HOCSINH'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = hOCSINHBindingSource.Position;
            //int position = hOCSINHBindingSource.Find("MAHS", textBoxMHS.Text);
            int position = -1;
            for (int i = 0; i < hOCSINHBindingSource.Count; i++)
            {
                if (((DataRowView)hOCSINHBindingSource[i])["MAHS"].ToString() == textBoxMHS.Text)
                {
                    position = i;
                    break;
                }
            }
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                MessageBox.Show("Mã học sinh đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.hOCSINHBindingSource.EndEdit();
                maHS = Helper.createMaHS(maHS);
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.hOCSINHGridControl.Enabled = true;
                this.labelTim2.Enabled = true;
                this.textBoxTim2.Enabled = true;
                this.groupBoxCTHS.Enabled = false;
                this.tableLayoutPanel1.Enabled = true;
                this.barButtonItem7.Enabled = true;
                this.barButtonItem8.Enabled = true;
                this.barButtonItem9.Enabled = true;
                this.barButtonItem10.Enabled = true;
                this.barButtonItem11.Enabled = true;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.textBoxMHS.Text = "";
            //this.textBoxMLHS.Text = "";
            this.hOCSINHBindingSource.CancelEdit();
            this.hOCSINHGridControl.Enabled = true;
            this.textBoxTim2.Enabled = true;
            this.labelTim2.Enabled = true;
            this.groupBoxCTHS.Enabled = false;
            this.tableLayoutPanel1.Enabled = true;
            this.barButtonItem7.Enabled = true;
            this.barButtonItem8.Enabled = true;
            this.barButtonItem9.Enabled = true;
            this.barButtonItem10.Enabled = true;
            this.barButtonItem11.Enabled = true;
        }

        private void textBoxTim2_TextChanged(object sender, EventArgs e)
        {
            hOCSINHBindingSource.Filter = "TENHS LIKE '%" + textBoxTim2.Text +
                "%' OR MAHS LIKE '%" + textBoxTim2.Text + "%' OR MALOP LIKE '%" + textBoxTim2.Text + "%'";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            this.labelTitHS.Text = gridView1.GetFocusedRowCellValue("MALOP").ToString();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            this.labelTitHS.Text = gridView1.GetFocusedRowCellValue("MALOP").ToString();
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
    }
}
