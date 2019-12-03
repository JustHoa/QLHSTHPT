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
    public partial class FormHocSinh : Form
    {
        FormChinh formChinh;
        public int clkMan = 0;
        public int clkOK = 0;

        public FormHocSinh()
        {
            InitializeComponent();
        }

        public FormHocSinh(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.groupBoxCT.Enabled = false;


            if (Program.group == "PGV")
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = true;
            }
            else
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem5.Enabled = false;
            }

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet.HOCSINH);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.hOCSINHBindingSource.AddNew();
            this.textBoxMaHS.Text = Helper.createMaHS(hOCSINHBindingSource);
            this.textBoxTenHS.Focus();
            this.comboBoxGT.SelectedIndex = 0;
            this.checkBoxNghi.Checked = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.hOCSINHGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTenHS.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            int vitri = hOCSINHBindingSource.Position;
            string maHS = ((DataRowView)hOCSINHBindingSource[vitri])["MAHS"].ToString().Trim();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet.HOCSINH);
            this.hOCSINHGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.hOCSINHTableAdapter.Update(this.qLHSTHPTDataSet.HOCSINH);
            this.hOCSINHGridControl.Enabled = true;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.labelEHT.Text = this.textBoxDC.Text = this.dateEditNS.Text = this.textBoxDT.Text = this.textBoxDToc.Text = "";

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

            string sql = "EXEC SP_KTMA '" + textBoxMaHS.Text + "', 'HOCSINH'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = hOCSINHBindingSource.Position;
            //int position = hOCSINHBindingSource.Find("MAHS", textBoxMHS.Text);
            int position = -1;
            for (int i = 0; i < hOCSINHBindingSource.Count; i++)
            {
                if (((DataRowView)hOCSINHBindingSource[i])["MAHS"].ToString() == textBoxMaHS.Text)
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
                this.hOCSINHBindingSource.EndEdit();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.hOCSINHGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.labelEHT.Text = this.textBoxDC.Text = this.dateEditNS.Text = this.textBoxDT.Text = this.textBoxDToc.Text = "";
            this.hOCSINHBindingSource.CancelEdit();
            this.hOCSINHGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }
    }
}
