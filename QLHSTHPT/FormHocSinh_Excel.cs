﻿using DevExpress.DataAccess.Excel;
using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace QLHSTHPT
{
    public partial class FormHocSinh_Excel : Form
    {
        string maHS = "";
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        OleDbConnection OleDbcon;

        public FormHocSinh_Excel(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        public FormHocSinh_Excel()
        {
            InitializeComponent();
        }

        private void FormHocSinh_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            if (this.gridView1.RowCount == 0)
            {
                barButtonItem8.Enabled = barButtonItem5.Enabled = barButtonItem2.Enabled = false;
            }

            //MessageBox.Show(this.gridView1.RowCount.ToString());
            string sql = "SELECT TOP(1) * FROM HOCSINH ORDER BY MAHS DESC";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                maHS = dataReader.GetValue(0).ToString().Trim();
            }
            else
            {
                maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + "0000000";
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            openFileDialog.ShowDialog();

            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                this.labelEFile.Text = "";

                textBoxFileName.Text = openFileDialog.FileName;

                OleDbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog.FileName + ";Extended Properties=Excel 12.0;");

                OleDbcon.Open();

                DataTable dt = OleDbcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                OleDbcon.Close();

                comboBoxSheetName.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    String sheetName = dt.Rows[i]["TABLE_NAME"].ToString();

                    sheetName = sheetName.Substring(0, sheetName.Length - 1);

                    comboBoxSheetName.Items.Add(sheetName);

                }

                this.labelESheet.Text = "";

                comboBoxSheetName.SelectedIndex = 0;
            }
        }

        private void comboBoxSheetName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelEFile.Text = labelESheet.Text = "";

            if (textBoxFileName.Text == "")
            {
                labelEFile.Text = "Chưa nhập Tên file. Chú ý!";
                textBoxFileName.Focus();
                return;
            }

            if (comboBoxSheetName.Text == "")
            {
                labelESheet.Text = "Chưa nhập Tên sheet. Chú ý!";
                comboBoxSheetName.Focus();
                return;
            }

            ExcelDataSource excelDataSource1 = new ExcelDataSource();
            excelDataSource1.FileName = textBoxFileName.Text;
            ExcelSourceOptions excelSourceOptions1 = new ExcelSourceOptions();
            ExcelWorksheetSettings excelWorksheetSettings1 = new ExcelWorksheetSettings();
            excelWorksheetSettings1.WorksheetName = comboBoxSheetName.Text;
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            excelDataSource1.SourceOptions = excelSourceOptions1;

            try
            {
                excelDataSource1.Fill();
                gridControl1.DataSource = excelDataSource1;
                gridView1.Columns["STT"].Visible = false;
                barButtonItem8.Enabled = barButtonItem5.Enabled = barButtonItem2.Enabled = true;
            }
            catch (Exception ex)
            {
                barButtonItem8.Enabled = barButtonItem5.Enabled = barButtonItem2.Enabled = false;
                MessageBox.Show("Lỗi: " + textBoxFileName.Text + " không tồn tại hoặc chứa dữ liệu không tương thích." +
                    "\n\nGợi ý: Đảm bảo file excel có các trường sau:\n       STT, TENHS, NGAYSINH, GIOITINH, DIACHI, DANTOC, DIENTHOAI");
                textBoxFileName.Focus();
            }
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OleDbcon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + textBoxFileName.Text + ";Extended Properties=Excel 12.0;");

                OleDbcon.Open();

                DataTable dt = OleDbcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                OleDbcon.Close();

                comboBoxSheetName.Items.Clear();

                for (int i = 0; i < dt.Rows.Count; i++)

                {

                    String sheetName = dt.Rows[i]["TABLE_NAME"].ToString();

                    sheetName = sheetName.Substring(0, sheetName.Length - 1);

                    comboBoxSheetName.Items.Add(sheetName);

                }

                comboBoxSheetName.SelectedIndex = 0;
                labelESheet.Text = "";
            }
            catch
            {
                labelESheet.Text = "Đang tìm Tên sheet...";
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.processBar.Visible = true;

            //if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK) Close();
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                string maHS = gridView1.GetRowCellValue(i, "MAHS").ToString();
                string tenHS = gridView1.GetRowCellValue(i, "TENHS").ToString();
                DateTime ngaySinh = DateTime.Parse(gridView1.GetRowCellValue(i, "NGAYSINH").ToString());
                string gioiTinh = gridView1.GetRowCellValue(i, "GIOITINH").ToString();
                string diaChi = gridView1.GetRowCellValue(i, "DIACHI").ToString();
                string danToc = gridView1.GetRowCellValue(i, "DANTOC").ToString();
                string dienThoai = gridView1.GetRowCellValue(i, "DIENTHOAI").ToString();
                int nghiHoc = 0;

                SqlCommand sqlCommand = new SqlCommand();
                SqlParameter Return = new SqlParameter();
                SqlParameter dbMaHS = new SqlParameter();
                SqlParameter dbTenHS = new SqlParameter();
                SqlParameter dbNgaySinh = new SqlParameter();
                SqlParameter dbGioiTinh = new SqlParameter();
                SqlParameter dbDiaChi = new SqlParameter();
                SqlParameter dbDanToc = new SqlParameter();
                SqlParameter dbDienThoai = new SqlParameter();
                SqlParameter dbNghiHoc = new SqlParameter();

                Return.DbType = DbType.Int32;
                Return.ParameterName = "@return_value";
                Return.Direction = ParameterDirection.ReturnValue;

                dbMaHS.DbType = DbType.String;
                dbMaHS.ParameterName = "@MAHS";
                dbMaHS.Direction = ParameterDirection.Input;
                dbMaHS.Value = maHS;

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

                dbNghiHoc.DbType = DbType.Int32;
                dbNghiHoc.ParameterName = "@NGHIHOC";
                dbNghiHoc.Direction = ParameterDirection.Input;
                dbNghiHoc.Value = nghiHoc;

                sqlCommand.Connection = Program.sqlConnection;
                sqlCommand.CommandText = "SP_CAPNHAT_HS";
                sqlCommand.Parameters.Add(Return);
                sqlCommand.Parameters.Add(dbMaHS);
                sqlCommand.Parameters.Add(dbTenHS);
                sqlCommand.Parameters.Add(dbNgaySinh);
                sqlCommand.Parameters.Add(dbGioiTinh);
                sqlCommand.Parameters.Add(dbDiaChi);
                sqlCommand.Parameters.Add(dbDienThoai);
                sqlCommand.Parameters.Add(dbDanToc);
                sqlCommand.Parameters.Add(dbNghiHoc);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    formChinh.processBar.Value = (i + 1) / gridView1.RowCount * 100;
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Loi: " + se.Message);
                    formChinh.processBar.Visible = false;
                    break;
                }
                if (i == gridView1.RowCount - 1) 
                {
                    MessageBox.Show("Lưu thành công!");
                    formChinh.processBar.Visible = false;
                }
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                int [] soHS_Lop = Helper.xepLop(gridView1.RowCount);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh nằm ngoài khoảng xếp lớp khả dụng!\n\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX*Program.MAX_LOP + "\n\nHiện tại: " + gridView1.RowCount);
                }
                else
                {
                    formChinh.Enabled = false;
                    FormXepLop formXepLop = new FormXepLop(soHS_Lop, this.gridView1, formChinh);
                    formXepLop.Validate();
                    formXepLop.Show();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu học sinh!\n\nGợi ý: Thêm dữ liệu học sinh từ Excel.");
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] sd = Helper.xepLop(47);
            string str = "";
            for (int i= 0; i<sd.Length; i++)
            {
                str += sd[i] + " ";
            }
            MessageBox.Show(str);
            ExcelDataSource excelDataSource1 = new ExcelDataSource();
            excelDataSource1.FileName = textBoxFileName.Text;
            ExcelSourceOptions excelSourceOptions1 = new ExcelSourceOptions();
            ExcelWorksheetSettings excelWorksheetSettings1 = new ExcelWorksheetSettings();
            excelWorksheetSettings1.WorksheetName = comboBoxSheetName.Text;
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            excelDataSource1.SourceOptions = excelSourceOptions1;
            excelDataSource1.Fill();
            gridControl1.DataSource = excelDataSource1;
            gridView1.Columns["STT"].Visible = false;
        }
    }
}
