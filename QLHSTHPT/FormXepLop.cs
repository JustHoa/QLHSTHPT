using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using QLHSTHPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class FormXepLop : Form
    {
        public string idHS = "";
        int[] xepLop;
        FormChinh formChinh;
        GridView gridView;

        public FormXepLop()
        {
            InitializeComponent();
        }

        public FormXepLop(int[] xepLop, GridView gridView, FormChinh formChinh)
        {
            InitializeComponent();
            this.xepLop = xepLop;
            this.gridView = gridView;
            this.formChinh = formChinh;
        }

        private void FormXepLop_Load(object sender, EventArgs e)
        {
            string sql = "SELECT TOP(1) * FROM HOCSINH ORDER BY MAHS DESC";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                idHS = dataReader.GetValue(0).ToString().Trim();
                dataReader.Close();
            }
            else
            {
                idHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + "0000000";
                dataReader.Close();
            }

            List<string> arrLop = new List<string>();
            int soLop = 0;

            for (int i = 0; i < Program.MAX_LOP; i++)
            {
                if (xepLop[i] != 0)
                {
                    soLop += 1;
                }
            }

            this.textBoxSL.Text = soLop.ToString();

            string maLop1 = Helper.createMaLop();
            arrLop.Add(maLop1);

            for (int i = 1; i < soLop; i++)
            {
                int _part3 = int.Parse(maLop1.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maLop1 = maLop1.Substring(0, 4) + part3;
                arrLop.Add(maLop1);
            }

            this.comboBoxMaLop.DataSource = arrLop;
            this.comboBoxMaLop.SelectedIndex = 0;
        }

        private void comboBoxMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<HocSinh> ds = new BindingList<HocSinh>();
            int numLeft = 0;
            int index = this.comboBoxMaLop.SelectedIndex;
            this.textBoxSLHS.Text = xepLop[index].ToString() + " học sinh";
            for (int i = 0; i < index; i++)
            {
                numLeft += xepLop[i];
            }
            for (int j = 0; j < xepLop[index]; j++)
            {
                string maHS = Helper.createMaHS(idHS);
                string tenHS = gridView.GetRowCellValue(numLeft, "TENHS").ToString();
                string ngaySinh = gridView.GetRowCellValue(numLeft, "NGAYSINH").ToString();
                string gioiTinh = gridView.GetRowCellValue(numLeft, "GIOITINH").ToString();
                string diaChi = gridView.GetRowCellValue(numLeft, "DIACHI").ToString();
                string danToc = gridView.GetRowCellValue(numLeft, "DANTOC").ToString();
                string dienThoai = gridView.GetRowCellValue(numLeft, "DIENTHOAI").ToString();
                string maLop = comboBoxMaLop.Text;
                int nghiHoc = 0;
                ds.Add(new HocSinh(maHS, tenHS, ngaySinh, gioiTinh, diaChi, danToc, dienThoai, maLop, nghiHoc));
                numLeft++;
                idHS = Helper.createMaHS(idHS);
            }
            ds.AllowNew = true;
            gridControl1.DataSource = ds;
            gridView1.Columns[0].Caption = "MAHS";
            gridView1.Columns[1].Caption = "TENHS";
            gridView1.Columns[2].Caption = "NGAYSINH";
            gridView1.Columns[3].Caption = "GIOITINH";
            gridView1.Columns[4].Caption = "DIACHI";
            gridView1.Columns[5].Caption = "DANTOC";
            gridView1.Columns[6].Caption = "DIENTHOAI";
            gridView1.Columns[7].Caption = "MALOP";
            gridView1.Columns[8].Caption = "NGHIHOC";
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.toolStripStatusLabelNote.Text = "";
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormXepLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string maHS = gridView1.GetRowCellValue(i, "maHS").ToString();
                string tenHS = gridView1.GetRowCellValue(i, "tenHS").ToString();
                DateTime ngaySinh = DateTime.Parse(gridView1.GetRowCellValue(i, "ngaySinh").ToString());
                string gioiTinh = gridView1.GetRowCellValue(i, "gioiTinh").ToString();
                string diaChi = gridView1.GetRowCellValue(i, "diaChi").ToString();
                string danToc = gridView1.GetRowCellValue(i, "danToc").ToString();
                string dienThoai = gridView1.GetRowCellValue(i, "dienThoai").ToString();
                string maLop = gridView1.GetRowCellValue(i, "maLop").ToString();
                int nghiHoc = int.Parse(gridView1.GetRowCellValue(i, "nghiHoc").ToString());

                SqlCommand sqlCommand = new SqlCommand();
                SqlParameter dbMaHS = new SqlParameter();
                SqlParameter dbTenHS = new SqlParameter();
                SqlParameter dbNgaySinh = new SqlParameter();
                SqlParameter dbGioiTinh = new SqlParameter();
                SqlParameter dbDiaChi = new SqlParameter();
                SqlParameter dbDanToc = new SqlParameter();
                SqlParameter dbDienThoai = new SqlParameter();
                SqlParameter dbMaLop = new SqlParameter();
                SqlParameter dbNghiHoc = new SqlParameter();

                dbMaHS.DbType = DbType.String;
                dbMaHS.ParameterName = "@MAHS";
                dbMaHS.Direction = ParameterDirection.Input;
                dbMaHS.Value = maHS; ;

                dbTenHS.DbType = DbType.String;
                dbTenHS.ParameterName = "@TENHS";
                dbTenHS.Direction = ParameterDirection.Input;
                dbTenHS.Value = tenHS;

                dbNgaySinh.DbType = DbType.Date;
                dbNgaySinh.ParameterName = "@NGAYSINH";
                dbNgaySinh.Direction = ParameterDirection.Input;
                dbNgaySinh.Value = ngaySinh;

                dbGioiTinh.DbType = DbType.String;
                dbGioiTinh.ParameterName = "@GIOITINH";
                dbGioiTinh.Direction = ParameterDirection.Input;
                dbGioiTinh.Value = gioiTinh;

                dbDiaChi.DbType = DbType.String;
                dbDiaChi.ParameterName = "@DIACHI";
                dbDiaChi.Direction = ParameterDirection.Input;
                dbDiaChi.Value = diaChi;

                dbDanToc.DbType = DbType.String;
                dbDanToc.ParameterName = "@DANTOC";
                dbDanToc.Direction = ParameterDirection.Input;
                dbDanToc.Value = danToc;

                dbDienThoai.DbType = DbType.String;
                dbDienThoai.ParameterName = "@DIENTHOAI";
                dbDienThoai.Direction = ParameterDirection.Input;
                dbDienThoai.Value = dienThoai;

                dbMaLop.DbType = DbType.String;
                dbMaLop.ParameterName = "@MALOP";
                dbMaLop.Direction = ParameterDirection.Input;
                dbMaLop.Value = maLop;

                dbNghiHoc.DbType = DbType.Int32;
                dbNghiHoc.ParameterName = "@NGHIHOC";
                dbNghiHoc.Direction = ParameterDirection.Input;
                dbNghiHoc.Value = nghiHoc;

                sqlCommand.Connection = Program.sqlConnection;
                sqlCommand.CommandText = "SP_CAPNHAT_HS";
                sqlCommand.Parameters.Add(dbMaHS);
                sqlCommand.Parameters.Add(dbTenHS);
                sqlCommand.Parameters.Add(dbNgaySinh);
                sqlCommand.Parameters.Add(dbGioiTinh);
                sqlCommand.Parameters.Add(dbDiaChi);
                sqlCommand.Parameters.Add(dbDanToc);
                sqlCommand.Parameters.Add(dbDienThoai);
                sqlCommand.Parameters.Add(dbMaLop);
                sqlCommand.Parameters.Add(dbNghiHoc);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Loi: " + se.Message);
                }
            }
            formChinh.toolStripStatusLabelNote.Text = "Lưu thành công!";
        }
    }
}
