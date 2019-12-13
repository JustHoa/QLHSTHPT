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
    public partial class FormGiaoVien : Form
    {
        //public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormGiaoVien(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
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
            this.comboBoxGT.SelectedIndex = 0;
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet1.GIAOVIEN);
            this.bOMONTableAdapter.Fill(this.qLHSTHPTDataSet1.BOMON);
            this.groupBoxCT.Enabled = false;
            this.textBoxTenBM.Text = comboBoxMaBM.SelectedValue.ToString();
        }

        //private void textBoxTim_Leave(object sender, EventArgs e)
        //{
        //    if (textBoxTim.Text == "")
        //    {
        //        textBoxTim.Text = "Tìm kiếm...";
        //        textBoxTim.ForeColor = Color.Gray;
        //    }
        //}

        //private void textBoxTim_Enter(object sender, EventArgs e)
        //{
        //    //toolTip1.Show("Tìm kiếm theo tên giáo viên, mã giáo viên hoặc môn học", textBoxTim);
        //    if (textBoxTim.Text == "Tìm kiếm...")
        //    {
        //        textBoxTim.Text = "";
        //        textBoxTim.ForeColor = Color.Black;
        //    }
        //}

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.Filter = "TENGV LIKE '%" + textBoxTim.Text + 
                "%' OR MAGV LIKE '%" + textBoxTim.Text + "%'";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.gIAOVIENGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.comboBoxMGV.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxMGV.Enabled = true;
            this.gIAOVIENBindingSource.AddNew();
            this.comboBoxMGV.DataSource = Helper.createMaGV(gIAOVIENBindingSource);
            this.comboBoxMGV.SelectedIndex = 0;
            this.textBoxTenGV.Focus();
            this.comboBoxGT.SelectedIndex = 0;
            this.comboBoxMaBM.SelectedIndex = 0;
            this.checkBoxNghi.Checked = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            Program.vitri = gIAOVIENBindingSource.Position;
            this.gIAOVIENGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.comboBoxMGV.Enabled = false;
            this.textBoxTenGV.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            int vitri = gIAOVIENBindingSource.Position;
            string maGV = ((DataRowView)gIAOVIENBindingSource[vitri])["MAGV"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maGV + "', 'PHANCONGGV'";
                SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Giáo viên đã được phân công nhiệm vụ. Không thể xóa!");
                    dataReader.Close();
                }
                else
                {

                    if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        clkMan = 1;
                        this.gIAOVIENBindingSource.RemoveCurrent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelEDT.Text = this.labelEDC.Text = this.labelENS.Text = this.labelETen.Text = this.labelETo.Text = "";
            this.gIAOVIENBindingSource.CancelEdit();
            this.comboBoxMGV.DropDownStyle = ComboBoxStyle.DropDown;
            //this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet1.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.gIAOVIENTableAdapter.Update(this.qLHSTHPTDataSet1.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
            //clkSave = 1;
            clkMan = clkOK = 0;
            formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            //formChinh.toolStripStatusLabelNote.Text = "Lưu thay đổi thành công!";
            //MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelEDT.Text = this.labelEDC.Text = this.labelENS.Text = this.labelETen.Text = this.labelETo.Text = "";

            if (this.textBoxTenGV.Text == "")
            {
                this.labelETen.Text = "Chưa nhập Tên giáo viên. Chú ý!";
                //essageBox.Show("Chưa nhập Tên giáo viên. Chú ý!");
                textBoxTenGV.Focus();
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

            string sql = "EXEC SP_KTMA '" + comboBoxMGV.Text + "', 'GIAOVIEN'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = gIAOVIENBindingSource.Position;
            int position = gIAOVIENBindingSource.Find("MAGV", comboBoxMGV.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.gIAOVIENBindingSource.EndEdit();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.gIAOVIENGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                this.comboBoxMGV.DropDownStyle = ComboBoxStyle.DropDown;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            if (clkMan == 0 && clkOK == 0)
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo tên giáo viên, mã giáo viên hoặc môn học", textBoxTim);
        }

        private void textBoxTenGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)32) && (e.KeyChar < (char)45)) // ki tu dac biet
            {
                this.labelETen.Text = "Tên giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)45) && (e.KeyChar < (char)48))
            {
                this.labelETen.Text = "Tên giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)57) && (e.KeyChar < (char)65))
            {
                this.labelETen.Text = "Tên giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)90) && (e.KeyChar < (char)97))
            {
                this.labelETen.Text = "Tên giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else if ((e.KeyChar > (char)122) && (e.KeyChar < (char)126))
            {
                this.labelETen.Text = "Tên giáo viên không chứa kí tự đặc biệt!";
                e.Handled = true;
            }
            else
            {
                this.labelETen.Text = "";
                e.Handled = false;
            }
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

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet1);

        }

        private void comboBoxMaBM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTenBM.Text = comboBoxMaBM.SelectedValue.ToString();
            }
            catch { }
        }
    }
}
