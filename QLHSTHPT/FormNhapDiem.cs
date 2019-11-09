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
        public FormNhapDiem()
        {
            InitializeComponent();
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
                gridView1.Columns[loai].Visible = false;
            }
            foreach (string loai in Program.arr15p)
            {
                gridView1.Columns[loai].Visible = false;
            }
            foreach (string loai in Program.arr1T)
            {
                gridView1.Columns[loai].Visible = false;
            }

            Program.arrMieng.Clear();
            Program.arr15p.Clear();
            Program.arr1T.Clear();

        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.bar2.Visible = false;
            this.sP_BANGDIEMLOPGridControl.Visible = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet.NAMHOC);

        }

        private void nAMHOCComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxHK_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_LOP_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_LOP_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))));
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.sP_MONHOC_GV_TDTableAdapter.Fill(this.qLHSTHPTDataSet.SP_MONHOC_GV_TD, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.SelectedValue, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxNH.SelectedValue, typeof(int))))), comboBoxLop.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                    GridColumn column = gridView1.Columns.AddVisible(loai, string.Empty);
                    gridView1.Columns.Add(column);
                    gridView1.Columns[loai].VisibleIndex = posMieng;
                    posMieng += 1;
                }
                foreach (string loai in Program.arr15p)
                {
                    str2 += (", " + loai);
                    GridColumn column = gridView1.Columns.AddVisible(loai, string.Empty);
                    gridView1.Columns.Add(column);
                    gridView1.Columns[loai].VisibleIndex = pos15p;
                    pos15p += 1;
                }
                foreach (string loai in Program.arr1T)
                {
                    str3 += (", " + loai);
                    GridColumn column = gridView1.Columns.AddVisible(loai, string.Empty);
                    gridView1.Columns.Add(column);
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
            GridColumn column = gridView1.Columns.AddVisible(colName, string.Empty);
            gridView1.Columns[colName].VisibleIndex = Program.addMieng + Program.arrMieng.Count() - 1;
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
            GridColumn column = gridView1.Columns.AddVisible(colName, string.Empty);
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
            GridColumn column = gridView1.Columns.AddVisible(colName, string.Empty);
            gridView1.Columns[colName].VisibleIndex = Program.add1T + Program.arrMieng.Count() + Program.arr15p.Count() + Program.arr1T.Count() - 1;
        }
    }
}

