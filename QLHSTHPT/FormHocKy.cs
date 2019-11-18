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
    public partial class FormHocKy : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormHocKy(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormHocKy_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.groupBoxCT.Enabled = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hOCKYGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.hOCKYBindingSource.AddNew();
            this.textBoxMHK.Text = Helper.createAutoIncre(hOCKYBindingSource, "MAHK");
            this.comboBoxTh.SelectedIndex = 0;
            this.textBoxTen.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hOCKYGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTen.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = hOCKYBindingSource.Position;
            string maHK = ((DataRowView)hOCKYBindingSource[vitri])["MAHK"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maHK + "', 'LOP_HK'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Học kỳ đã đi vào hoạt động. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkMan = 1;
                        this.hOCKYBindingSource.RemoveCurrent();
                        MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
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
            this.hOCKYTableAdapter.Update(this.qLHSTHPTDataSet.HOCKY);
            clkSave = 1;
            MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
            this.hOCKYGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((clkMan == 0 && clkOK == 0) || ((clkMan == 1 || clkOK == 1) && clkSave == 1))
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show("Tìm kiếm theo Tên học kỳ", textBoxTim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên học kỳ. Chú ý!");
                textBoxTen.Focus();
                return;
            }

            if (this.textBoxNg.Text == "")
            {
                MessageBox.Show("Chưa nhập Ngày bắt đầu. Chú ý!");
                textBoxNg.Focus();
                return;
            }

            string sql = "EXEC SP_KT_NAMHOC_HOCKY 'HOCKY', '" + textBoxTen.Text + "', " +
                int.Parse(comboBoxTh.Text) + ", " + int.Parse(textBoxNg.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = hOCKYBindingSource.Position;
            //int position = hOCKYBindingSource.Find("NAMBD", textBoxBD.Text);
            //if ((dataReader.Read() || position != -1) && nowPosition != position)
            //{
            //    MessageBox.Show("Học kỳ đã tồn tại. Chú ý!");
            //    dataReader.Close();
            //    return;
            //}
            //else
            {
                this.hOCKYBindingSource.EndEdit();
                MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.hOCKYGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.hOCKYBindingSource.CancelEdit();
            this.hOCKYGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void textBoxNg_TextChanged(object sender, EventArgs e)
        {
            int thangBD = int.Parse(this.comboBoxTh.Text);
            int ngayBD = int.Parse(this.textBoxNg.Text);
            if (ngayBD < 1 || ngayBD > 31)
            {
                this.labelENg.Text = "Ngày không hợp lệ!";
                this.button1.Enabled = false;
                this.textBoxNg.Focus();
            }
            if (thangBD == 2 && ngayBD > 29)
            {
                this.labelENg.Text = "Ngày không hợp lệ!";
                this.button1.Enabled = false;
                this.textBoxNg.Focus();
                //if (Helper.namNhuan(date.Nam))
                //{
                //    if (ngayBD > 29)
                //        return 0;
                //}
                //else
                //{
                //    if (ngayBD > 28)
                //    {
                //        return 0;
                //    }
                //}
            }
            else if ((thangBD == 4 || thangBD == 6 || thangBD == 9 || thangBD == 11) && ngayBD > 30)
            {
                this.labelENg.Text = "Ngày không hợp lệ!";
                this.button1.Enabled = false;
                this.textBoxNg.Focus();
            }
            else if ((thangBD == 1 || thangBD == 3 || thangBD == 5 || thangBD == 7 || thangBD == 8 || thangBD == 10 || thangBD == 12) && ngayBD > 31)
            {
                this.labelENg.Text = "Ngày không hợp lệ!";
                this.button1.Enabled = false;
                this.textBoxNg.Focus();
            }
            else
            {
                this.labelENg.Text = "";
                this.button1.Enabled = true;
            }
        }

        private void textBoxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelET.Text = "Tên năm học không chứa kí tự đặc biệt, trừ kí tự '-'!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelET.Text = "Tên năm học không chứa kí tự đặc biệt, trừ kí tự '-'!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelET.Text = "Tên năm học không chứa kí tự đặc biệt, trừ kí tự '-'!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelET.Text = "Tên năm học không chứa kí tự đặc biệt, trừ kí tự '-'!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelET.Text = "Tên năm học không chứa kí tự đặc biệt, trừ kí tự '-'!";
                e.Handled = true;
            }
            else
            {
                this.labelET.Text = "";
                e.Handled = false;
            }
        }
    }
}
