using DevExpress.XtraGrid.Columns;
using QLHSTHPT.Model;
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
    public partial class FormNhapDiem : Form
    {
        public int clkSave = 1;

        FormChinh formChinh;

        public FormNhapDiem(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void nAMHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void resetData()
        {
            // reset data
            Program.addMieng = 4;
            Program.add15p = 6;
            Program.add1T = 8;
            Program.flagMieng = false;
            Program.flag15p = false;
            Program.flag1T = false;

            foreach (string loai in Program.arrMieng)
            {
                if(gridView1.Columns[loai] != null)
                {
                    gridView1.Columns[loai].Visible = false;
                    gridView1.Columns.Remove(gridView1.Columns[loai]);
                } 
                if (qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai] != null)
                {
                    qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Remove(qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai]);
                }
            }
            foreach (string loai in Program.arr15p)
            {
                if (gridView1.Columns[loai] != null)
                {
                    gridView1.Columns[loai].Visible = false;
                    gridView1.Columns.Remove(gridView1.Columns[loai]);
                }
                if (qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai] != null)
                {
                    qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Remove(qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai]);
                }
            }
            foreach (string loai in Program.arr1T)
            {
                if (gridView1.Columns[loai] != null)
                {
                    gridView1.Columns[loai].Visible = false;
                    gridView1.Columns.Remove(gridView1.Columns[loai]);
                }
                if (qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai] != null)
                {
                    qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Remove(qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[loai]);
                }
            }

            Program.arrMieng.Clear();
            Program.arr15p.Clear();
            Program.arr1T.Clear();

        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.panel2.Visible = false;
            this.bar2.Visible = false;
            this.sP_BANGDIEMLOPGridControl.Visible = false;
            this.textBoxTim.Visible = this.labelTim.Visible = false;
            try
            {
                this.sP_NAMHOC_DESCTableAdapter.Fill(this.qLHSTHPTDataSet.SP_NAMHOC_DESC, Program.maGV);
                this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
                this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                if(comboBoxLop.SelectedValue == null)
                {
                    this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, 2, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                    comboBoxLop.SelectedValue = 2;
                }
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                this.panel2.Visible = true;
            }
        }

        private void nAMHOCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
                this.error.Text = "";
                this.error2.Text = "";
            }
            catch (System.Exception ex)
            {
                this.error.Text = "Lỗi: Không có thông tin giảng dạy " + this.comboBoxHK.Text + " " + this.comboBoxNH.Text;
            }
        }

        private void comboBoxHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
                this.error.Text = "";
                this.error2.Text = "";
            }
            catch (System.Exception ex)
            {
                this.error.Text = "Lỗi: Không có thông tin giảng dạy " + this.comboBoxHK.Text + " " + this.comboBoxNH.Text;
            }
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
                this.error.Text = "";
                this.error2.Text = "";
            }
            catch (System.Exception ex)
            {
                this.error.Text = "Lỗi: Không có thông tin giảng dạy " + this.comboBoxHK.Text + " " + this.comboBoxNH.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBoxLop.SelectedValue == null || this.comboBoxMH.SelectedValue == null)
            {
                this.error2.Text = "Lỗi: Không lấy được dữ liệu.\n\nXem lại thông tin Năm học hoặc Học kỳ!";
                return;
            }
            this.panel1.Visible = false;
            this.bar2.Visible = true;
            this.sP_BANGDIEMLOPGridControl.Dock = DockStyle.Fill;
            this.sP_BANGDIEMLOPGridControl.Visible = true;
            this.textBoxTim.Visible = this.labelTim.Visible = true;

            resetData();

            //kiem tra trong bang PHANCONGCV
            string sql = "EXEC SP_KTCV '" + Program.maGV + "', '" + comboBoxLop.SelectedValue.ToString() + "', '" + comboBoxMH.SelectedValue.ToString() + "'," + int.Parse(comboBoxHK.SelectedValue.ToString()) + "," + int.Parse(comboBoxNH.SelectedValue.ToString());
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                dataReader.Close();
                string sql1 = "EXEC SP_LOAIDIEMLOP '" + comboBoxLop.SelectedValue.ToString() + "', '" + comboBoxMH.SelectedValue.ToString() + "', " + int.Parse(comboBoxHK.SelectedValue.ToString()) + ", " + int.Parse(comboBoxNH.SelectedValue.ToString()); ;
                SqlCommand sqlCommand1 = new SqlCommand(sql1, Program.sqlConnection);
                SqlDataReader dataReader1 = sqlCommand1.ExecuteReader();
                while (dataReader1.Read())
                {
                    string loai = dataReader1.GetValue(0).ToString();
                    string[] arr = new string[2];
                    arr = loai.Split('_');
                    switch (arr[0])
                    {
                        case "MIENG":
                            Program.arrMieng.Add(loai);
                            break;
                        case "KT15P":
                            Program.arr15p.Add(loai);
                            break;
                        case "KTTIET":
                            Program.arr1T.Add(loai);
                            break;
                    }
                }
                dataReader1.Close();

                string str1 = "MIENG_1, MIENG_2";
                string str2 = "KT15P_1, KT15P_2";
                string str3 = "KTTIET_1, KTTIET_2";
                string str4 = "KTHK";
                int posMieng = 4;
                int pos15p = 4 + Program.arrMieng.Count() + 2;
                int pos1T = 4 + Program.arrMieng.Count() + 2 + Program.arr15p.Count() + 2;
                foreach (string loai in Program.arrMieng) 
                {
                    str1 += (", " + loai);
                    GridColumn column = gridView1.Columns.AddVisible(loai, loai);
                    gridView1.Columns[loai].VisibleIndex = posMieng;
                    posMieng += 1;
                }
                foreach (string loai in Program.arr15p)
                {
                    str2 += (", " + loai);
                    GridColumn column = gridView1.Columns.AddVisible(loai, loai);
                    gridView1.Columns[loai].VisibleIndex = pos15p;
                    pos15p += 1;
                }
                foreach (string loai in Program.arr1T)
                {
                    str3 += (", " + loai);
                    GridColumn column = gridView1.Columns.AddVisible(loai, loai);
                    gridView1.Columns[loai].VisibleIndex = pos1T;
                    pos1T += 1;
                }
                string str = str1 + "," + str2 + "," + str3 + "," + str4;
                //MessageBox.Show(str);
                string sql2 = "ALTER PROC [dbo].[SP_BANGDIEMLOP] " +
                    "( @MALOP VARCHAR(10), @MAMH VARCHAR(10), @MAHK INT, @MANH INT) " +
                    "AS SELECT MAHS, TENHS, " + str +
                    " FROM(SELECT HS.MAHS, TENHS, LOAIDIEM, DIEM " +
                    "FROM(SELECT HSL.MAHS, TENHS FROM HOCSINH HS, " +
                    "(SELECT * FROM HS_LOP WHERE MALOP = @MALOP) HSL WHERE HS.MAHS = HSL.MAHS) HS " +
                    "LEFT OUTER JOIN (SELECT D.* FROM DIEM D, " +
                    "(SELECT * FROM PHANCONGGV WHERE MALOP = @MALOP AND MAMH = @MAMH AND MAHK = @MAHK AND MANH = @MANH) PC " +
                    "WHERE D.MAPHC = PC.MAPHC) DI " +
                    "ON (HS.MAHS = DI.MAHS)) SOURCETABLE " +
                    "PIVOT (MAX(DIEM) FOR [LOAIDIEM] IN (" + str + ")) as pivottable " +
                    "where TENHS IS NOT NULL " +
                    "ORDER BY MAHS";
                SqlCommand sqlCommand2 = new SqlCommand(sql2, Program.sqlConnection);
                int dataReader2 = sqlCommand2.ExecuteNonQuery();
                
                try
                {
                    this.sP_BANGDIEMLOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_BANGDIEMLOP, comboBoxLop.SelectedValue.ToString(), comboBoxMH.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dataReader.Close();
                MessageBox.Show("Truy cập trái phép! Xem lại thông tin nhập điểm đã chọn!");
                return;
            }
            

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.processBar.Visible = true;
            textBoxTim.Focus();
            string maMH = this.comboBoxMH.SelectedValue.ToString();
            int maHK = int.Parse(this.comboBoxHK.SelectedValue.ToString());
            int maNH = int.Parse(this.comboBoxNH.SelectedValue.ToString());
            int count = this.sP_BANGDIEMLOPBindingSource.Count;
            float diem = 0;

            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    string maHS = ((DataRowView)sP_BANGDIEMLOPBindingSource[i])["MAHS"].ToString().Trim();
                    foreach (GridColumn co in gridView1.Columns)
                    {
                        if(co.FieldName != "MAHS" && co.FieldName != "TENHS")
                        {
                            try
                            {
                                diem = float.Parse(gridView1.GetRowCellValue(i, co.FieldName).ToString());
                            }

                            catch (FormatException e1)
                            {
                                diem = 0;
                            }
                            if (diem < 0 || diem > 10)
                            {
                                MessageBox.Show("Điểm sinh viên nằm trong khoảng từ 0 đến 10. Chú ý!");
                                return;
                            }
                            else
                            {
                                SqlCommand sqlCommand = new SqlCommand();
                                SqlParameter dbMaGV = new SqlParameter();
                                SqlParameter dbMaLop = new SqlParameter();
                                SqlParameter dbMaHS = new SqlParameter();
                                SqlParameter dbMaMH = new SqlParameter();
                                SqlParameter dbMaHK = new SqlParameter();
                                SqlParameter dbMaNH = new SqlParameter();
                                SqlParameter dbLoaiDiem = new SqlParameter();
                                SqlParameter dbDiem = new SqlParameter();
                                SqlParameter dbHeSo = new SqlParameter();

                                dbMaGV.DbType = DbType.String;
                                dbMaGV.ParameterName = "@MAGV";
                                dbMaGV.Direction = ParameterDirection.Input;
                                dbMaGV.Value = Program.maGV;

                                dbMaLop.DbType = DbType.String;
                                dbMaLop.ParameterName = "@MALOP";
                                dbMaLop.Direction = ParameterDirection.Input;
                                dbMaLop.Value = comboBoxLop.SelectedValue;

                                dbMaHS.DbType = DbType.String;
                                dbMaHS.ParameterName = "@MAHS";
                                dbMaHS.Direction = ParameterDirection.Input;
                                dbMaHS.Value = maHS;

                                dbMaMH.DbType = DbType.String;
                                dbMaMH.ParameterName = "@MAMH";
                                dbMaMH.Direction = ParameterDirection.Input;
                                dbMaMH.Value = maMH;

                                dbMaHK.DbType = DbType.Int32;
                                dbMaHK.ParameterName = "@MAHK";
                                dbMaHK.Direction = ParameterDirection.Input;
                                dbMaHK.Value = maHK;

                                dbMaNH.DbType = DbType.Int32;
                                dbMaNH.ParameterName = "@MANH";
                                dbMaNH.Direction = ParameterDirection.Input;
                                dbMaNH.Value = maNH;

                                dbLoaiDiem.DbType = DbType.String;
                                dbLoaiDiem.ParameterName = "@LOAIDIEM";
                                dbLoaiDiem.Direction = ParameterDirection.Input;
                                dbLoaiDiem.Value = co.FieldName;

                                dbDiem.DbType = DbType.Decimal;
                                dbDiem.ParameterName = "@DIEM";
                                dbDiem.Direction = ParameterDirection.Input;
                                if (diem != 0)
                                   dbDiem.Value = diem;
                                else
                                    dbDiem.Value = DBNull.Value;

                                dbHeSo.DbType = DbType.Int32;
                                dbHeSo.ParameterName = "@HESO";
                                dbHeSo.Direction = ParameterDirection.Input;
                                if (co.FieldName == "KTHK")
                                    dbHeSo.Value = 3;
                                switch (co.FieldName.Split('_')[0])
                                {
                                    case "MIENG":
                                        dbHeSo.Value = 1;
                                        break;
                                    case "KT15P":
                                        dbHeSo.Value = 1;
                                        break;
                                    case "KTTIET":
                                        dbHeSo.Value = 2;
                                        break;
                                }

                                try
                                {
                                    sqlCommand.Connection = Program.sqlConnection;
                                    sqlCommand.CommandText = "SP_CAPNHATDIEM";
                                    sqlCommand.Parameters.Add(dbMaGV);
                                    sqlCommand.Parameters.Add(dbMaLop);
                                    sqlCommand.Parameters.Add(dbMaHS);
                                    sqlCommand.Parameters.Add(dbMaMH);
                                    sqlCommand.Parameters.Add(dbMaHK);
                                    sqlCommand.Parameters.Add(dbMaNH);
                                    sqlCommand.Parameters.Add(dbLoaiDiem);
                                    sqlCommand.Parameters.Add(dbDiem);
                                    sqlCommand.Parameters.Add(dbHeSo);
                                    sqlCommand.CommandType = CommandType.StoredProcedure;
                                    sqlCommand.ExecuteNonQuery();
                                    formChinh.processBar.Value = (i + 1) * 100 / count;
                                }
                                catch (SqlException se)
                                {
                                    formChinh.processBar.Visible = false;
                                    MessageBox.Show("Loi1: " + se.Message);
                                    return;
                                }
                            }
                        }
                    }
                    if (i == count - 1)
                    {
                        clkSave = 1;
                        MessageBox.Show("Lưu điểm thành công!");
                        formChinh.processBar.Visible = false;
                    }
                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Hãy đảm bảo bạn đã lưu dữ liệu trước khi thoát. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.bar2.Visible = false;
                this.sP_BANGDIEMLOPGridControl.Visible = false;
                this.textBoxTim.Visible = this.labelTim.Visible = false;
                this.panel1.Visible = true;
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textBoxTim.Focus();
            //Program.addMieng = 4 + Program.arrMieng.Count();
            //int pos15p = 4 + Program.arrMieng.Count() + 2;
            //int pos1T = 4 + Program.arrMieng.Count() + 2 + Program.arr15p.Count() + 2;
            string colName = "";
            if(Program.arrMieng.Count == 0)
            {
                colName = "MIENG_3";
                Program.arrMieng.Add(colName);
            }
            else
            {
                string[] spl = Program.arrMieng.Last().Split('_');
                colName = "MIENG_" + (int.Parse(spl[1]) + 1);
                Program.arrMieng.Add(colName);
            }
           
            GridColumn column = gridView1.Columns.AddVisible(colName, colName);
            gridView1.Columns[colName].VisibleIndex = Program.addMieng + Program.arrMieng.Count() - 1;
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Add(colName, typeof(Double));
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[colName].ReadOnly = false;

            // -----------------
            //string maHS = ((DataRowView)sP_BANGDIEMLOPBindingSource[0])["MAHS"].ToString().Trim();
            //string maMH = this.comboBoxMH.SelectedValue.ToString();
            //int maHK = int.Parse(this.comboBoxHK.SelectedValue.ToString());
            //int maNH = int.Parse(this.comboBoxNH.SelectedValue.ToString());
            //SqlCommand sqlCommand = new SqlCommand();
            //SqlParameter dbMaGV = new SqlParameter();
            //SqlParameter dbMaLop = new SqlParameter();
            //SqlParameter dbMaHS = new SqlParameter();
            //SqlParameter dbMaMH = new SqlParameter();
            //SqlParameter dbMaHK = new SqlParameter();
            //SqlParameter dbMaNH = new SqlParameter();
            //SqlParameter dbLoaiDiem = new SqlParameter();
            //SqlParameter dbDiem = new SqlParameter();
            //SqlParameter dbHeSo = new SqlParameter();

            //dbMaGV.DbType = DbType.String;
            //dbMaGV.ParameterName = "@MAGV";
            //dbMaGV.Direction = ParameterDirection.Input;
            //dbMaGV.Value = Program.maGV;

            //dbMaLop.DbType = DbType.String;
            //dbMaLop.ParameterName = "@MALOP";
            //dbMaLop.Direction = ParameterDirection.Input;
            //dbMaLop.Value = comboBoxLop.SelectedValue;

            //dbMaHS.DbType = DbType.String;
            //dbMaHS.ParameterName = "@MAHS";
            //dbMaHS.Direction = ParameterDirection.Input;
            //dbMaHS.Value = maHS;

            //dbMaMH.DbType = DbType.String;
            //dbMaMH.ParameterName = "@MAMH";
            //dbMaMH.Direction = ParameterDirection.Input;
            //dbMaMH.Value = maMH;

            //dbMaHK.DbType = DbType.Int32;
            //dbMaHK.ParameterName = "@MAHK";
            //dbMaHK.Direction = ParameterDirection.Input;
            //dbMaHK.Value = maHK;

            //dbMaNH.DbType = DbType.Int32;
            //dbMaNH.ParameterName = "@MANH";
            //dbMaNH.Direction = ParameterDirection.Input;
            //dbMaNH.Value = maNH;

            //dbLoaiDiem.DbType = DbType.String;
            //dbLoaiDiem.ParameterName = "@LOAIDIEM";
            //dbLoaiDiem.Direction = ParameterDirection.Input;
            //dbLoaiDiem.Value = colName;

            //dbDiem.DbType = DbType.Double;
            //dbDiem.ParameterName = "@DIEM";
            //dbDiem.Direction = ParameterDirection.Input;
            //dbDiem.Value = DBNull.Value;

            //dbHeSo.DbType = DbType.Int32;
            //dbHeSo.ParameterName = "@HESO";
            //dbHeSo.Direction = ParameterDirection.Input;
            //dbHeSo.Value = DBNull.Value;

            //try
            //{
            //    sqlCommand.Connection = Program.sqlConnection;
            //    sqlCommand.CommandText = "SP_CAPNHATDIEM";
            //    sqlCommand.Parameters.Add(dbMaGV);
            //    sqlCommand.Parameters.Add(dbMaLop);
            //    sqlCommand.Parameters.Add(dbMaHS);
            //    sqlCommand.Parameters.Add(dbMaMH);
            //    sqlCommand.Parameters.Add(dbMaHK);
            //    sqlCommand.Parameters.Add(dbMaNH);
            //    sqlCommand.Parameters.Add(dbLoaiDiem);
            //    sqlCommand.Parameters.Add(dbDiem);
            //    sqlCommand.Parameters.Add(dbHeSo);
            //    sqlCommand.CommandType = CommandType.StoredProcedure;
            //    sqlCommand.ExecuteNonQuery();
            //}
            //catch (SqlException se)
            //{
            //    MessageBox.Show("Loi: " + se.Message);
            //}

            //string str1 = "MIENG_1, MIENG_2";
            //string str2 = "KT15P_1, KT15P_2";
            //string str3 = "KTTIET_1, KTTIET_2";
            //string str4 = "KTHK_1, KTHK_2";

            //foreach (string loai in Program.arrMieng)
            //{
            //    str1 += (", " + loai);
            //}
            //foreach (string loai in Program.arr15p)
            //{
            //    str2 += (", " + loai);
            //}
            //foreach (string loai in Program.arr1T)
            //{
            //    str3 += (", " + loai);
            //}
            //string str = str1 + "," + str2 + "," + str3 + "," + str4;
            ////MessageBox.Show(str);
            //string sql2 = "ALTER PROC [dbo].[SP_BANGDIEMLOP] " +
            //        "( @MALOP VARCHAR(10), @MAMH VARCHAR(10), @MAHK INT, @MANH INT) " +
            //        "AS SELECT MAHS, TENHS, " + str +
            //        " FROM(SELECT HS.MAHS, TENHS, LOAIDIEM, DIEM " +
            //        "FROM(SELECT HSL.MAHS, TENHS FROM HOCSINH HS, " +
            //        "(SELECT * FROM HS_LOP WHERE MALOP = @MALOP) HSL WHERE HS.MAHS = HSL.MAHS) HS " +
            //        "LEFT OUTER JOIN (SELECT D.* FROM DIEM D, " +
            //        "(SELECT * FROM PHANCONGGV WHERE MALOP = @MALOP AND MAMH = @MAMH AND MAHK = @MAHK AND MANH = @MANH) PC " +
            //        "WHERE D.MAPHC = PC.MAPHC) DI " +
            //        "ON (HS.MAHS = DI.MAHS)) SOURCETABLE " +
            //        "PIVOT (SUM(DIEM) FOR [LOAIDIEM] IN (" + str + ")) as pivottable " +
            //        "where TENHS IS NOT NULL " +
            //        "ORDER BY MAHS";
            //SqlCommand sqlCommand2 = new SqlCommand(sql2, Program.sqlConnection);
            //int dataReader2 = sqlCommand2.ExecuteNonQuery();

            //try
            //{
            //    this.sP_BANGDIEMLOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_BANGDIEMLOP, comboBoxLop.SelectedValue.ToString(), comboBoxMH.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));

            //    SqlCommand sqlCommand1 = new SqlCommand();
            //    SqlParameter dbLoaiDiem1 = new SqlParameter();
            //    dbLoaiDiem1.DbType = DbType.String;
            //    dbLoaiDiem1.ParameterName = "@LOAIDIEM";
            //    dbLoaiDiem1.Direction = ParameterDirection.Input;
            //    dbLoaiDiem1.Value = colName;
            //    sqlCommand1.Connection = Program.sqlConnection;
            //    sqlCommand1.CommandText = "SP_XOADIEM_NULL";
            //    sqlCommand1.Parameters.Add(dbLoaiDiem1);
            //    sqlCommand1.CommandType = CommandType.StoredProcedure;
            //    sqlCommand1.ExecuteNonQuery();
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textBoxTim.Focus();
            string colName = "";
            if (Program.arr15p.Count == 0)
            {
                colName = "KT15P_3";
                Program.arr15p.Add(colName);
            }
            else
            {
                string[] spl = Program.arr15p.Last().Split('_');
                colName = "KT15P_" + (int.Parse(spl[1]) + 1);
                Program.arr15p.Add(colName);
            }
            GridColumn column = gridView1.Columns.AddVisible(colName, colName);
            gridView1.Columns[colName].VisibleIndex = Program.add15p + Program.arrMieng.Count() + Program.arr15p.Count() - 1;
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Add(colName, typeof(Double));
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[colName].ReadOnly = false;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            textBoxTim.Focus();
            string colName = "";
            if (Program.arr1T.Count == 0)
            {
                colName = "KTTIET_3";
                Program.arr1T.Add(colName);
            }
            else
            {
                string[] spl = Program.arr1T.Last().Split('_');
                colName = "KTTIET_" + (int.Parse(spl[1]) + 1);
                Program.arr1T.Add(colName);
            }
            GridColumn column = gridView1.Columns.AddVisible(colName, colName);
            gridView1.Columns[colName].VisibleIndex = Program.add1T + Program.arrMieng.Count() + Program.arr15p.Count() + Program.arr1T.Count() - 1;
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns.Add(colName, typeof(Double));
            this.qLHSTHPTDataSet1.SP_BANGDIEMLOP.Columns[colName].ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string str = "";
            //foreach (GridColumn co in gridView1.Columns)
            //{

            //    str += (co.AbsoluteIndex + " " + co.FieldName + ", ");
            //}
            //MessageBox.Show(str);
            Close();
        }

        private void FormNhapDiem_SizeChanged(object sender, EventArgs e)
        {
            //CenterControlInParent(buttonThoat2);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            sP_BANGDIEMLOPBindingSource.Filter = "TENHS LIKE '%" + textBoxTim.Text +
                "%' OR MAHS LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên học sinh hoặc Mã học sinh", textBoxTim);
        }

        private void textBoxTim_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_BANGDIEMLOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_BANGDIEMLOP, comboBoxLop.SelectedValue.ToString(), comboBoxMH.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.panel1.Visible = false;
            this.bar2.Visible = true;
            this.sP_BANGDIEMLOPGridControl.Dock = DockStyle.Fill;
            this.sP_BANGDIEMLOPGridControl.Visible = true;
            this.textBoxTim.Visible = this.labelTim.Visible = true;
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int count = this.sP_BANGDIEMLOPBindingSource.Count;
            for (int i = 0; i < count; i++)
            {
                string maHS = ((DataRowView)sP_BANGDIEMLOPBindingSource[i])["MAHS"].ToString().Trim();
                foreach (GridColumn co in gridView1.Columns)
                {
                    if (co.FieldName != "MAHS" && co.FieldName != "TENHS")
                    {
                        try
                        {
                            float diem = float.Parse(gridView1.GetRowCellValue(i, co.FieldName).ToString());
                        }

                        catch (FormatException e1)
                        {
                            MessageBox.Show("Dữ liệu chưa hoàn chỉnh.\n\nCập nhật đầy đủ các cột điểm để tiếp tục!");
                            return;
                        }
                    }
                }
            }

            if (clkSave == 0)
            {
                MessageBox.Show("Dữ liệu chưa được lưu.\n\nHãy lưu thay đổi để tiếp tục!");
                return;
            }
            else
            {
                formChinh.Enabled = false;
                FormDiemTBM_HK f = new FormDiemTBM_HK(formChinh, this);
                f.Activate();
                f.Show();
            }
        }

        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            clkSave = 0;
        }
    }
}

