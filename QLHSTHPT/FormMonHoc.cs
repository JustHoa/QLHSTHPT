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
    public partial class FormMonHoc : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormMonHoc(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }


        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            if (Program.group == "PGV")
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem6.Enabled = true;
            }
            else
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem6.Enabled = false;
            }
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHSTHPTDataSet.MONHOC);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.mONHOCGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.mONHOCBindingSource.AddNew();
            this.textBoxMaMH.Focus();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Update(this.qLHSTHPTDataSet.MONHOC);
                this.mONHOCGridControl.Enabled = true;
                this.groupBoxCT.Enabled = false;
                clkMan = clkOK = 1;
                formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelETMH.Text = this.labelEMMH.Text = "";

            if (this.textBoxMaMH.Text == "")
            {
                this.labelEMMH.Text = "Chưa nhập Mã môn học. Chú ý!";
                //MessageBox.Show("Chưa nhập Ngày bắt đầu. Chú ý!");
                textBoxMaMH.Focus();
                return;
            }

            if (this.textBoxTenMH.Text == "")
            {
                this.labelETMH.Text = "Chưa nhập Tên môn học. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên học kỳ. Chú ý!");
                textBoxTenMH.Focus();
                return;
            }
            
            string sql = "EXEC SP_KTMA '" + textBoxMaMH.Text + "', 'MONHOC'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = mONHOCBindingSource.Position;
            int position = mONHOCBindingSource.Find("MAMH", textBoxMaMH.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                this.labelEMMH.Text = "Mã môn học đã tồn tại. Chú ý!";
                dataReader.Close();
                return;
            }
            else
            {
                this.mONHOCBindingSource.EndEdit();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.mONHOCGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.CancelEdit();
            this.mONHOCGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            int vitri = mONHOCBindingSource.Position;
            string maMH = ((DataRowView)mONHOCBindingSource[vitri])["MAMH"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maMH + "', 'PHANCONGGV_MH'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Môn học đã có lịch giảng dạy. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkMan = 1;
                        this.mONHOCBindingSource.RemoveCurrent();
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

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            mONHOCBindingSource.Filter = "TENMH LIKE '%" + textBoxTim.Text +
                "%' OR MAMH LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên môn học hoặc Mã môn học", textBoxTim);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.mONHOCGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTenMH.Focus();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.mONHOCTableAdapter.Fill(this.qLHSTHPTDataSet.MONHOC);
            this.mONHOCGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (clkMan == 0 && clkOK == 0)
            {
                formChinh.toolStripStatusLabelNote.Text = "";
                this.Close();
            }
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                formChinh.toolStripStatusLabelNote.Text = "";
                Close();
            }
        }
    }
}
