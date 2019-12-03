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
    public partial class FormLop : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormLop(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormLop_Load(object sender, EventArgs e)
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

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelEMaLop.Text = this.labelEBan.Text = this.labelETenLop.Text = this.labelEMaNH.Text = this.labelEMaHK.Text = "";
            if (this.textBoxTenLop.Text == "")
            {
                this.labelEMaLop.Text = "Chưa nhập Tên lớp. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên lớp. Chú ý!");
                textBoxTenLop.Focus();
                return;
            }

            if (this.comboBoxBan.Text == "")
            {
                this.labelEBan.Text = "Chưa nhập Ban học. Chú ý!";
                //MessageBox.Show("Chưa nhập Bộ môn giảng dạy. Chú ý!");
                comboBoxBan.Focus();
                return;
            }

            if (this.textBoxMaHK.Text == "")
            {
                this.labelEMaHK.Text = "Chưa nhập Mã học kỳ. Chú ý!";
                //MessageBox.Show("Chưa nhập Mã học kỳ. Chú ý!");
                textBoxMaHK.Focus();
                return;
            }

            if (this.textBoxMaNH.Text == "")
            {
                this.labelEMaNH.Text = "Chưa nhập Mã năm học. Chú ý!";
                //MessageBox.Show("Chưa nhập Mã năm học. Chú ý!");
                textBoxMaNH.Focus();
                return;
            }

            string sql = "EXEC SP_KTMA '" + textBoxMaLop.Text + "', 'LOP'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = lOPBindingSource.Position;
            int position = lOPBindingSource.Find("MALOP", textBoxMaLop.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                this.labelEMaLop.Text = "Mã lớp đã tồn tại. Chú ý!";
                //MessageBox.Show("Mã lớp đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.lOPBindingSource.EndEdit();
                formChinh.toolStripStatusLabelNote.Text = "Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!";
                //MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.lOPGridControl.Enabled = true;
                this.labelTim.Enabled = true;
                this.textBoxTim.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
                clkOK = 1;
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.lOPGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.lOPBindingSource.AddNew();
            this.textBoxMaLop.Text = Helper.createMaLop(lOPBindingSource);
            this.comboBoxBan.SelectedIndex = 0;
            this.textBoxTenLop.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.lOPGridControl.Enabled = false;
            this.labelTim.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.textBoxTenLop.Focus();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            int vitri = lOPBindingSource.Position;
            string maLop = ((DataRowView)lOPBindingSource[vitri])["MALOP"].ToString().Trim();
            try
            {
                string sql = "EXEC SP_KIEMTRAXOA '" + maLop + "', 'HOCSINH'";
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
                MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);
            this.lOPGridControl.Enabled = true;
            this.labelTim.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.lOPTableAdapter.Update(this.qLHSTHPTDataSet.LOP);
            this.lOPGridControl.Enabled = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelEMaLop.Text = this.labelEBan.Text = this.labelETenLop.Text = this.labelEMaNH.Text = this.labelEMaHK.Text = "";
            this.lOPBindingSource.CancelEdit();
            this.lOPGridControl.Enabled = true;
            this.textBoxTim.Enabled = true;
            this.labelTim.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }
    }
}
