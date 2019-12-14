using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using QLHSTHPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class FormDiemTBM_HK : Form
    {
        public int clkSave = 1;

        List<string> listCotDiem;
        string selectedItemText;
        int SelectedIndex;

        FormChinh formChinh;
        FormNhapDiem formNhapDiem;

        public FormDiemTBM_HK()
        {
            InitializeComponent();
        }

        public FormDiemTBM_HK(FormChinh formChinh, FormNhapDiem formNhapDiem)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formNhapDiem = formNhapDiem;
        }

        private void FormDiemTBM_HK_Load(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            listCotDiem = new List<string>();
            foreach (GridColumn co in formNhapDiem.gridView1.Columns)
            {
                if (co.FieldName != "MAHS" && co.FieldName != "TENHS")
                    listCotDiem.Add(co.FieldName);
            }
            listBox1.DataSource = listCotDiem;
        }

        private void FormDiemTBM_HK_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelELB1.Text = labelELB2.Text = "";
            if (listBox1.SelectedIndex == -1)
                labelELB1.Text = "Chọn một cột điểm!";
            else
            {
                selectedItemText = listBox1.SelectedItem.ToString();
                SelectedIndex = listBox1.SelectedIndex;
                listBox2.Items.Add(selectedItemText);
                if (listCotDiem != null)
                    listCotDiem.RemoveAt(SelectedIndex);
                DataBinding();
                checkBox1.Enabled = true;
            }
        }

        private void DataBinding()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = listCotDiem;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelELB1.Text = labelELB2.Text = "";
            if (listBox2.SelectedIndex == -1)
                labelELB2.Text = "Chọn một cột điểm!";
            else
            {
                selectedItemText = listBox2.SelectedItem.ToString();
                SelectedIndex = listBox2.SelectedIndex;
                listCotDiem.Add(selectedItemText); ;
                listBox2.Items.RemoveAt(listBox2.Items.IndexOf(listBox2.SelectedItem));
                DataBinding();
                if (listBox2.Items.Count == 0)
                    checkBox1.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelELB1.Text = labelELB2.Text = "";
            while (listBox1.Items.Count != 0)
            {
                listBox2.Items.Add(listBox1.Items[0]);
                if (listCotDiem != null)
                    listCotDiem.Remove(listBox1.Items[0].ToString());
                DataBinding();
                checkBox1.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelELB1.Text = labelELB2.Text = "";
            while (listBox2.Items.Count != 0)
            {
                listCotDiem.Add(listBox2.Items[0].ToString()); ;
                listBox2.Items.RemoveAt(0);
                DataBinding();
            }
            checkBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labelELB1.Text = labelELB2.Text = "";
            List<string> arrDiemMieng = new List<string>();
            List<string> arrDiem15p = new List<string>();
            List<string> arrDiem1T = new List<string>();
            List<DTBMHK_HS> arrData = new List<DTBMHK_HS>();
            string diemHK = "";

            foreach (var co in listBox2.Items)
            {
                switch (co.ToString().Split('_')[0])
                {
                    case "MIENG":
                        arrDiemMieng.Add(co.ToString());
                        break;
                    case "KT15P":
                        arrDiem15p.Add(co.ToString());
                        break;
                    case "KTTIET":
                        arrDiem1T.Add(co.ToString());
                        break;
                }
                if (co.ToString() == "KTHK")
                    diemHK = "KTHK";
            }

            if (diemHK == "")
            {
                MessageBox.Show("Lỗi: Cột điểm Kiểm tra học kỳ chưa được chọn");
                return;
            }
            else
            {
                panelSetup.Enabled = false;
                string maHS = "", tenHS = "";
                //string maLop = formNhapDiem.comboBoxLop.Text;
                //string maMH = formNhapDiem.comboBoxMH.Text;
                //string maHK = formNhapDiem.comboBoxHK.Text;
                int count = formNhapDiem.gridView1.RowCount;

                for (int i = 0; i < count; i++)
                {
                    float _diemMieng = 0, _diem15p = 0, _diem1T = 0, _diemHK = 0, diemTB = 0;
                    maHS = formNhapDiem.gridView1.GetRowCellValue(i, "MAHS").ToString();
                    tenHS = formNhapDiem.gridView1.GetRowCellValue(i, "TENHS").ToString();
                    _diemHK = float.Parse(formNhapDiem.gridView1.GetRowCellValue(i, "KTHK").ToString());

                    foreach (string item in arrDiemMieng)
                    {
                        _diemMieng += float.Parse(formNhapDiem.gridView1.GetRowCellValue(i, item).ToString());
                    }
                    foreach (string item in arrDiem15p)
                    {
                        _diem15p += float.Parse(formNhapDiem.gridView1.GetRowCellValue(i, item).ToString());
                    }
                    foreach (string item in arrDiem1T)
                    {
                        _diem1T += float.Parse(formNhapDiem.gridView1.GetRowCellValue(i, item).ToString());
                    }
                    diemTB = (_diemMieng + _diem15p + _diem1T * 2 + _diemHK * 3) / (arrDiemMieng.Count + arrDiem15p.Count + 2 * arrDiem1T.Count + 3);
                   // MessageBox.Show(maHS + " " + (_diemMieng + _diem15p + _diem1T * 2 + _diemHK * 3).ToString() + " " + (arrDiemMieng.Count + arrDiem15p.Count + 2 * arrDiem1T.Count + 3));
                    arrData.Add(new DTBMHK_HS (maHS, tenHS, float.Parse(diemTB.ToString("0.00"))));
                }
                gridControl1.DataSource = arrData;
                gridView1.Columns[0].Caption = "MÃ HS";
                gridView1.Columns[1].Caption = "TÊN HS";
                gridView1.Columns[2].Caption = "ĐIỂM TB";

                clkSave = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            labelELB1.Text = labelELB2.Text = "";
            listCotDiem = new List<string>();
            foreach (GridColumn co in formNhapDiem.gridView1.Columns)
            {
                if (co.FieldName != "MAHS" && co.FieldName != "TENHS")
                    listCotDiem.Add(co.FieldName);
            }
            listBox1.DataSource = listCotDiem;
            listBox2.Items.Clear();
        }

        private async void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelSetup.Enabled = true;
            panelCTCD.BackColor = Color.MediumTurquoise;
            await Task.Delay(TimeSpan.FromMilliseconds(500));
            panelCTCD.BackColor = Color.Turquoise;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                textBoxCT.Text = "";
            }
            else
            {
                labelELB1.Text = labelELB2.Text = "";
                List<string> arrDiemMieng = new List<string>();
                List<string> arrDiem15p = new List<string>();
                List<string> arrDiem1T = new List<string>();
                string diemHK = "";

                foreach (var co in listBox2.Items)
                {
                    switch (co.ToString().Split('_')[0])
                    {
                        case "MIENG":
                            arrDiemMieng.Add(co.ToString());
                            break;
                        case "KT15P":
                            arrDiem15p.Add(co.ToString());
                            break;
                        case "KTTIET":
                            arrDiem1T.Add(co.ToString());
                            break;
                    }
                    if (co.ToString() == "KTHK")
                        diemHK = "KTHK";
                }

                if (diemHK == "")
                {
                    checkBox1.Checked = false;
                    MessageBox.Show("Lỗi: Cột điểm Kiểm tra học kỳ chưa được chọn");
                    return;
                }
                else
                {
                    string congThucDM = "";
                    string congThucD15 = "";
                    string congThucD1T = "";
                    string congThucTB = "";
                    string tuSo = "";
                    int heSo = 0;
                    for (int i = 0; i < arrDiemMieng.Count; i++)
                    {
                        if (i == arrDiemMieng.Count - 1)
                            congThucDM += arrDiemMieng[i];
                        else congThucDM += arrDiemMieng[i] + " + ";
                    }
                    for (int i = 0; i < arrDiem15p.Count; i++)
                    {
                        if (i == arrDiem15p.Count - 1)
                            congThucD15 += arrDiem15p[i];
                        else congThucD15 += arrDiem15p[i] + " + ";
                    }
                    for (int i = 0; i < arrDiem1T.Count; i++)
                    {
                        if (i == arrDiem1T.Count - 1)
                            congThucD1T += arrDiem1T[i];
                        else congThucD1T += arrDiem1T[i] + " + ";
                    }
                    heSo = arrDiemMieng.Count + arrDiem15p.Count + 2 * arrDiem1T.Count + 3;
                    congThucTB = string.Format("Điểm trung bình = [{0} + {1} + ({2}) x 2 + KTHK x 3] / {3}", congThucDM, congThucD15, congThucD1T, heSo);
                    textBoxCT.Text = congThucTB;

                }
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (clkSave == 1)
            {
                this.Visible = false;
                formChinh.Activate();
                formChinh.Enabled = true;
            }
            else
                if (MessageBox.Show("Chưa lưu dữ liệu. Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Visible = false;
                formChinh.Activate();
                formChinh.Enabled = true;
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            processBarTB.Visible = true;
            int count = gridView1.RowCount;
            string maLop = formNhapDiem.comboBoxLop.SelectedValue.ToString();
            string maMH = formNhapDiem.comboBoxMH.SelectedValue.ToString();
            int maHK = int.Parse(formNhapDiem.comboBoxHK.SelectedValue.ToString());

            for (int i = 0; i < count; i++)
            {
                string maHS = gridView1.GetRowCellValue(i, "maHS").ToString();
                float diemTB = float.Parse(gridView1.GetRowCellValue(i, "diemTB").ToString());

                SqlCommand sqlCommand = new SqlCommand();
                SqlParameter dbMaHS = new SqlParameter();
                SqlParameter dbMaLop = new SqlParameter();
                SqlParameter dbMaMH = new SqlParameter();
                SqlParameter dbMaHK = new SqlParameter();
                SqlParameter dbDiemTBM = new SqlParameter();

                dbMaHS.DbType = DbType.String;
                dbMaHS.ParameterName = "@MAHS";
                dbMaHS.Direction = ParameterDirection.Input;
                dbMaHS.Value = maHS;

                dbMaLop.DbType = DbType.String;
                dbMaLop.ParameterName = "@MALOP";
                dbMaLop.Direction = ParameterDirection.Input;
                dbMaLop.Value = maLop;

                dbMaMH.DbType = DbType.String;
                dbMaMH.ParameterName = "@MAMH";
                dbMaMH.Direction = ParameterDirection.Input;
                dbMaMH.Value = maMH;

                dbMaHK.DbType = DbType.Int32;
                dbMaHK.ParameterName = "@MAHK";
                dbMaHK.Direction = ParameterDirection.Input;
                dbMaHK.Value = maHK;

                dbDiemTBM.DbType = DbType.Double;
                dbDiemTBM.ParameterName = "@DIEMTBM";
                dbDiemTBM.Direction = ParameterDirection.Input;
                dbDiemTBM.Value = diemTB;

                try
                {
                    sqlCommand.Connection = Program.sqlConnection;
                    sqlCommand.CommandText = "SP_CAPNHAT_DTBMHK";
                    sqlCommand.Parameters.Add(dbMaHS);
                    sqlCommand.Parameters.Add(dbMaLop);
                    sqlCommand.Parameters.Add(dbMaMH);
                    sqlCommand.Parameters.Add(dbMaHK);
                    sqlCommand.Parameters.Add(dbDiemTBM);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.ExecuteNonQuery();
                    processBarTB.Value = (i + 1) * 100 / count;
                }
                catch (SqlException se)
                {
                    MessageBox.Show("Loi: " + se.Message);
                    processBarTB.Visible = false;
                    return;
                }

                if (i == count - 1)
                {
                    clkSave = 1;
                    MessageBox.Show("Lưu điểm trung bình thành công!");
                    processBarTB.Visible = false;
                }
            }
        }
    }
}
