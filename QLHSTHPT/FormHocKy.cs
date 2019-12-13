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
        //public int clkSave = 0;
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
            if (Program.group == "PGV")
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem6.Enabled = true;
            }
            else
            {
                this.barButtonItem1.Enabled = this.barButtonItem2.Enabled = this.barButtonItem3.Enabled = this.barButtonItem4.Enabled = this.barButtonItem6.Enabled = false;
            }
            this.ControlBox = false;
            this.groupBoxCT.Enabled = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem6.Enabled = false;
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
            formChinh.toolStripStatusLabelNote.Text = "";
            barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem6.Enabled = false;
            this.hOCKYGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTen.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
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
            this.hOCKYTableAdapter.Update(this.qLHSTHPTDataSet.HOCKY);
            clkMan = clkMan = 0;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            //MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
            barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem6.Enabled = true;
            this.hOCKYGridControl.Enabled = true;
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

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            //toolTip1.Show("Tìm kiếm theo Tên học kỳ", textBoxTim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelET.Text = this.labelENg.Text = "";

            if (this.textBoxTen.Text == "")
            {
                this.labelET.Text = "Chưa nhập Tên học kỳ. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên học kỳ. Chú ý!");
                textBoxTen.Focus();
                return;
            }

            if (this.textBoxNg.Text == "")
            {
                this.labelENg.Text = "Chưa nhập Ngày bắt đầu.Chú ý!";
                //MessageBox.Show("Chưa nhập Ngày bắt đầu. Chú ý!");
                textBoxNg.Focus();
                return;
            }

            if (int.Parse(textBoxNg.Text) > 31 && (int.Parse(comboBoxTh.Text) == 1 || int.Parse(comboBoxTh.Text) == 3 || int.Parse(comboBoxTh.Text) == 5 || int.Parse(comboBoxTh.Text) == 7 || int.Parse(comboBoxTh.Text) == 8 || int.Parse(comboBoxTh.Text) == 10 || int.Parse(comboBoxTh.Text) == 12))
            {
                this.labelENg.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
                textBoxNg.Focus();
                return;
            } 
            else if (int.Parse(textBoxNg.Text) > 30 && (int.Parse(comboBoxTh.Text) == 4 || int.Parse(comboBoxTh.Text) == 6 || int.Parse(comboBoxTh.Text) == 9 || int.Parse(comboBoxTh.Text) == 11))
            {
                this.labelENg.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
                textBoxNg.Focus();
                return;
            }
            else if (int.Parse(textBoxNg.Text) > 29 && int.Parse(comboBoxTh.Text) == 2)
            {
                this.labelENg.Text = "Ngày bắt đầu không hợp lệ. Chú ý!";
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
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem6.Enabled = true;
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
            this.labelET.Text = this.labelENg.Text = "";
            this.hOCKYBindingSource.CancelEdit();
            barButtonItem1.Enabled = barButtonItem2.Enabled = barButtonItem3.Enabled = barButtonItem4.Enabled = barButtonItem6.Enabled = true;
            this.hOCKYGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;

        }

        private void textBoxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelET.Text = "Tên học kỳ không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelET.Text = "Tên học kỳ không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelET.Text = "Tên học kỳ không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelET.Text = "Tên học kỳ không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelET.Text = "Tên học kỳ không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelET.Text = "";
                e.Handled = false;
            }
        }

        private void textBoxNg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelENg.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelENg.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelENg.Text = "Ngày bắt đầu chỉ bao gồm số!";
                e.Handled = true;
            }
        }
    }
}
