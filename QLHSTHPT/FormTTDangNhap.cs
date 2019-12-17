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
    public partial class FormTTDangNhap : Form
    {
        FormChinh formChinh;

        public FormTTDangNhap(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormTTDangNhap_Load(object sender, EventArgs e)
        {
            this.panelInfo.Enabled = false;
            this.panelPass.Visible = false;
            try
            {
                this.sP_TAIKHOANINFOTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_TAIKHOANINFO, Program.maGV);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.panelInfo.Enabled = true;
            this.panelPass.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter dbMaGV = new SqlParameter();
            SqlParameter dbTenGV = new SqlParameter();
            SqlParameter dbGioiTinh = new SqlParameter();
            SqlParameter dbNgaySinh = new SqlParameter();
            SqlParameter dbDiaChi = new SqlParameter();
            SqlParameter dbDienThoai = new SqlParameter();

            dbMaGV.DbType = DbType.String;
            dbMaGV.ParameterName = "@MAGV";
            dbMaGV.Direction = ParameterDirection.Input;
            dbMaGV.Value = Program.maGV;

            dbTenGV.DbType = DbType.String;
            dbTenGV.ParameterName = "@TENGV";
            dbTenGV.Direction = ParameterDirection.Input;
            dbTenGV.Value = textBoxTenGV.Text;

            dbGioiTinh.DbType = DbType.String;
            dbGioiTinh.ParameterName = "@GIOITINH";
            dbGioiTinh.Direction = ParameterDirection.Input;
            dbGioiTinh.Value = comboBoxGT.Text;

            dbNgaySinh.DbType = DbType.String;
            dbNgaySinh.ParameterName = "@NGAYSINH";
            dbNgaySinh.Direction = ParameterDirection.Input;
            dbNgaySinh.Value = dateEditNS.Text;

            dbDiaChi.DbType = DbType.String;
            dbDiaChi.ParameterName = "@DIACHI";
            dbDiaChi.Direction = ParameterDirection.Input;
            dbDiaChi.Value = textBoxDC.Text ;

            dbDienThoai.DbType = DbType.String;
            dbDienThoai.ParameterName = "@DIENTHOAI";
            dbDienThoai.Direction = ParameterDirection.Input;
            dbDienThoai.Value = textBoxDT.Text;

            
            try
            {
                sqlCommand.Connection = Program.sqlConnection;
                sqlCommand.CommandText = "SP_CAPNHAT_GV";
                sqlCommand.Parameters.Add(dbMaGV);
                sqlCommand.Parameters.Add(dbTenGV);
                sqlCommand.Parameters.Add(dbGioiTinh);
                sqlCommand.Parameters.Add(dbNgaySinh);
                sqlCommand.Parameters.Add(dbDiaChi);
                sqlCommand.Parameters.Add(dbDienThoai);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thay đổi");
            }
            catch (SqlException se)
            {
                MessageBox.Show("Loi1: " + se.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelInfo.Enabled = false;
        }
    }
}
