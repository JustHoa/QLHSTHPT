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
    public partial class FormNamHoc : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormNamHoc(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormNamHoc_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.groupBoxCT.Enabled = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet.NAMHOC);

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nAMHOCGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.nAMHOCBindingSource.AddNew();
            this.textBoxMNH.Text = Helper.createAutoIncre(nAMHOCBindingSource, "MANH");
            this.textBoxTen.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nAMHOCGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTen.Focus();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nAMHOCTableAdapter.Update(this.qLHSTHPTDataSet.NAMHOC);
            clkSave = 1;
            MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int vitri = nAMHOCBindingSource.Position;
            string maNH = ((DataRowView)nAMHOCBindingSource[vitri])["MANH"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maNH + "', 'LOP_NH'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Năm học đã đi vào hoạt động. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkMan = 1;
                        this.nAMHOCBindingSource.RemoveCurrent();
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

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet.NAMHOC);
            this.nAMHOCGridControl.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.nAMHOCBindingSource.CancelEdit();
            this.nAMHOCGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên năm học. Chú ý!");
                textBoxTen.Focus();
                return;
            }

            if (this.textBoxBD.Text == "")
            {
                MessageBox.Show("Chưa nhập Năm bắt đầu. Chú ý!");
                textBoxBD.Focus();
                return;
            }

            if (this.textBoxKT.Text == "")
            {
                MessageBox.Show("Chưa nhập Năm kết thúc. Chú ý!");
                textBoxKT.Focus();
                return;
            }

            string sql = "EXEC SP_KT_NAMHOC_HOCKY 'NAMHOC', '" + textBoxTen.Text + "', " +
                int.Parse(textBoxBD.Text) + ", " + int.Parse(textBoxKT.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = nAMHOCBindingSource.Position;
            int position = nAMHOCBindingSource.Find("NAMBD", textBoxBD.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                MessageBox.Show("Năm học đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.nAMHOCBindingSource.EndEdit();
                MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.nAMHOCGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            nAMHOCBindingSource.Filter = "TENNH LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên năm học", textBoxTim);
        }

        private void textBoxBD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int namBD = int.Parse(this.textBoxBD.Text);
                this.textBoxKT.Text = (namBD + 1).ToString();
            }
            catch(Exception ex) { }
        }

        private void textBoxKT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int namKT = int.Parse(this.textBoxKT.Text);
                this.textBoxBD.Text = (namKT - 1).ToString();
            }
            catch (Exception ex) { }
        }

        private void textBoxBD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEBD.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEBD.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEBD.Text = "Năm bắt đầu chỉ bao gồm số!";
                e.Handled = true;
            }
        }

        private void textBoxKT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEKT.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEKT.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEKT.Text = "Năm kết thúc chỉ bao gồm số!";
                e.Handled = true;
            }
        }
        //can xem lai
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
