using DevExpress.XtraGrid.Columns;
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
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

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
            }
            foreach (string loai in Program.arr15p)
            {
                if (gridView1.Columns[loai] != null)
                {
                    gridView1.Columns[loai].Visible = false;
                    gridView1.Columns.Remove(gridView1.Columns[loai]);
                }
            }
            foreach (string loai in Program.arr1T)
            {
                if (gridView1.Columns[loai] != null)
                {
                    gridView1.Columns[loai].Visible = false;
                    gridView1.Columns.Remove(gridView1.Columns[loai]);
                }
            }

            Program.arrMieng.Clear();
            Program.arr15p.Clear();
            Program.arr1T.Clear();

        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.panel2.Visible = false;
            this.bar2.Visible = false;
            this.sP_BANGDIEMLOPGridControl.Visible = false;
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
                this.error2.Text = "Lỗi: Không lấy được dữ liệu. Xem lại thông tin Năm học hoặc Học kỳ!";
                return;
            }
            this.panel1.Visible = false;
            this.bar2.Visible = true;
            this.sP_BANGDIEMLOPGridControl.Visible = true;

            resetData();

            //kiem tra trong bang PHANCONGCV
            string sql = "EXEC SP_KTCV '" + Program.maGV + "', '" + comboBoxLop.SelectedValue.ToString() + "', '" + comboBoxMH.SelectedValue.ToString() + "'," + int.Parse(comboBoxHK.SelectedValue.ToString()) + "," + int.Parse(comboBoxNH.SelectedValue.ToString()); ;
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
                string str4 = "KTHK_1, KTHK_2";
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
                    "FROM(SELECT MAHS, TENHS FROM HOCSINH WHERE MALOP = @MALOP) HS " +
                    "LEFT OUTER JOIN (SELECT * FROM DIEM WHERE MAMH = @MAMH AND MAHK = @MAHK AND MANH = @MANH) D " +
                    "ON (HS.MAHS = D.MAHS)) SOURCETABLE " +
                    "PIVOT (SUM(DIEM) FOR [LOAIDIEM] IN (" + str + ")) as pivottable " +
                    "where TENHS IS NOT NULL " +
                    "ORDER BY MAHS";
                SqlCommand sqlCommand2 = new SqlCommand(sql2, Program.sqlConnection);
                int dataReader2 = sqlCommand2.ExecuteNonQuery();
                
                try
                {
                    this.sP_BANGDIEMLOPTableAdapter.Fill(this.qLHSTHPTDataSet.SP_BANGDIEMLOP, comboBoxLop.SelectedValue.ToString(), comboBoxMH.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
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
            string maMH = this.comboBoxMH.SelectedValue.ToString();
            int maHK = int.Parse(this.comboBoxHK.SelectedValue.ToString());
            int maNH = int.Parse(this.comboBoxNH.SelectedValue.ToString());
            int count = this.sP_BANGDIEMLOPBindingSource.Count;

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
                                string diem1 = gridView1.GetRowCellValue(i, co).ToString();
                                float diem = float.Parse(((DataRowView)sP_BANGDIEMLOPBindingSource[i])[co.FieldName].ToString());
                                if (diem < 0 || diem > 10)
                                {
                                    MessageBox.Show("Điểm sinh viên nằm trong khoảng từ 0 đến 10. Chú ý!");
                                    return;
                                }
                                else
                                {
                                    string sql = "EXEC SP_CAPNHATDIEM '" + maHS + "', '" + maMH + "', " +
                                        maHK + "," + maNH + ", '" + co.ToString() + "', " + diem;
                                    SqlCommand sqlcommand = new SqlCommand(sql, Program.sqlConnection);
                                    sqlcommand.ExecuteNonQuery();
                                }
                            }

                            catch (FormatException)
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            this.bar2.Visible = false;
            this.sP_BANGDIEMLOPGridControl.Visible = false;
            this.panel1.Visible = true;
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bar2.Visible = false;
            this.sP_BANGDIEMLOPGridControl.Visible = false;
            this.panel1.Visible = true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            //gridView1.Columns[colName].Name = "col" + colName;
            //qLHSTHPTDataSet.SP_BANGDIEMLOP.Columns.Add(colName, typeof(Double));
            //qLHSTHPTDataSet.SP_BANGDIEMLOP.Columns[colName].
            //this.sP_BANGDIEMLOPGridControl.Update();
            //gridView1.UpdateSummary();
            //gridView1.UpdateColumnsCustomization();
            //gridView1.RefreshData();
            //this.sP_BANGDIEMLOPTableAdapter.Fill(this.qLHSTHPTDataSet.SP_BANGDIEMLOP, comboBoxLop.SelectedValue.ToString(), comboBoxMH.SelectedValue.ToString(), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (GridColumn co in gridView1.Columns)
            {

                str += (co.AbsoluteIndex + " " + co.FieldName + ", ");
            }
            MessageBox.Show(str);
        }

        private void FormNhapDiem_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(buttonThoat2);
        }
        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        
    }
}

