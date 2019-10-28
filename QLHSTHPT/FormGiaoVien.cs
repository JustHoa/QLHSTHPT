﻿using System;
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
        public FormGiaoVien()
        {
            InitializeComponent();
        }

        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            this.comboBoxGT.SelectedIndex = 0;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            this.groupBoxCT.Enabled = false;
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
            //MessageBox.Show(textBoxTim.Text);
            try
            {
                this.gIAOVIENTableAdapter.FillByFilter(this.qLHSTHPTDataSet.GIAOVIEN, textBoxTim.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENGridControl.Enabled = false;
            this.textBoxTim.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.gIAOVIENBindingSource.AddNew();
            this.textBoxMGV.Focus();
            this.comboBoxGT.SelectedIndex = 0;
            this.checkBoxNghi.Checked = false;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.vitri = gIAOVIENBindingSource.Position;
            this.gIAOVIENGridControl.Enabled = false;
            this.groupBoxCT.Enabled = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
                        Program.clkMan = 1;
                        this.gIAOVIENBindingSource.RemoveCurrent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.gIAOVIENBindingSource.CancelEdit();
            //this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Update(this.qLHSTHPTDataSet.GIAOVIEN);
            this.gIAOVIENGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
            Program.clkSave = 1;
            MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.clkOK = 1;
            if (this.textBoxMGV.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã giáo viên. Chú ý!");
                textBoxMGV.Focus();
                return;
            }

            if (this.textBoxTenGV.Text == "")
            {
                MessageBox.Show("Chưa nhập Tên giáo viên. Chú ý!");
                textBoxTenGV.Focus();
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

            if (this.textBoxTM.Text == "")
            {
                MessageBox.Show("Chưa nhập Tổ môn. Chú ý!");
                textBoxTM.Focus();
                return;
            }
            //this.gIAOVIENBindingSource.EndEdit();
            string sql = "EXEC SP_KTMA '" + textBoxMGV.Text + "', 'GIAOVIEN'";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = gIAOVIENBindingSource.Position;
            int position = gIAOVIENBindingSource.Find("MAGV", textBoxMGV.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                MessageBox.Show("Mã giáo viên đã tồn tại. Chú ý!");
                dataReader.Close();
                return;
            }
            else
            {
                this.gIAOVIENBindingSource.EndEdit();
                MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
                this.gIAOVIENGridControl.Enabled = true;
                this.groupBoxCT.Enabled = false;
                dataReader.Close();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ((Program.clkMan == 0 && Program.clkOK == 0) || ((Program.clkMan == 1 || Program.clkOK == 1) && Program.clkSave == 1))
                this.Close();
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo tên giáo viên, mã giáo viên hoặc môn học", textBoxTim);
        }
    }
}