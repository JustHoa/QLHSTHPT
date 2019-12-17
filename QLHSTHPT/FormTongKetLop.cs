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
    public partial class FormTongKetLop : Form
    {
        public int clkMan = 0;
        FormChinh formChinh;

        public FormTongKetLop()
        {
            InitializeComponent();
        }

        public FormTongKetLop(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelENH.Text = labelELop.Text = "";

            if (comboBoxNH.Text == "")
            {
                labelENH.Text = "Chọn năm học trước!";
                comboBoxNH.Focus();
                return;
            }

            if (comboBoxLop.Text == "")
            {
                labelELop.Text = "Chọn lớp học trước!";
                comboBoxLop.Focus();
                return;
            }

            panelLC.Enabled = false;
            standaloneBarDockControl1.Enabled = true;
            panelTK.Enabled = true;
        }

        private void FormTongKetLop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            panelLC.Enabled = true;
            standaloneBarDockControl1.Enabled = panelTK.Enabled = false;
            sP_TBM_LOPGridControl.Dock = DockStyle.Fill;

            try
            {
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns.Add("DTBHK", typeof(string));
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns["DTBHK"].ReadOnly = false;
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns.Add("HOCLUC", typeof(string));
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns["HOCLUC"].ReadOnly = false;

                this.sP_NAMHOC_CNTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_NAMHOC_CN, Program.maGV);
                comboBoxNH.SelectedIndex = -1;
                comboBoxNH.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void sP_NAMHOC_CNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelENH.Text = labelELop.Text = "";

            try
            {
                this.sP_LOP_NAMHOC_CNTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LOP_NAMHOC_CN, Program.maGV, int.Parse(comboBoxNH.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                labelENH.Text = "Chọn năm học trước!";
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sP_TBM_LOPGridControl.Visible = true;
            gridControl1.Visible = false;
            try
            {
                this.sP_TBM_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_TBM_LOP, comboBoxLop.SelectedValue.ToString(), 1);
                gridView1.Columns[11].Caption = "ĐTB HỌC KỲ I";
                clkMan = 1;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int count = sP_TBM_LOPBindingSource.Count;
            int slG = 0, slK = 0, slTB = 0, slY = 0, slKe = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    float dHoa = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["HÓA"].ToString());
                    //float dSinh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SINH"].ToString());
                    //float dAnh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ANH"].ToString());
                    //float dGDCD = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["GDCD"].ToString());
                    //float dToan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["TOÁN"].ToString());
                    //float dLy = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["LÝ"].ToString());
                    //float dVan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["VĂN"].ToString());
                    //float dSu = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SỬ"].ToString());
                    //float dDia = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ĐỊA"].ToString());
                    float dSinh = 7;
                    float dAnh = 7;
                    float dGDCD = 06;
                    float dToan = 6.5f;
                    float dLy = 06;
                    float dVan = 6.5f;
                    float dSu = 08;
                    float dDia = 06;
                    float dTB = (dHoa + dSinh + dAnh + dGDCD + 2 * dToan + dLy + 2 * dVan + dSu + dDia) / 11;
                    gridView1.SetRowCellValue(i, "DTBHK", dTB.ToString("0.00"));

                    string hl = Helper.hocLuc(dTB, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia);
                    gridView1.SetRowCellValue(i, "HOCLUC", hl);
                    switch (hl)
                    {
                        case "Giỏi":
                            slG++;
                            break;
                        case "Khá":
                            slK++;
                            break;
                        case "Trung bình":
                            slTB++;
                            break;
                        case "Yếu":
                            slY++;
                            break;
                        case "Kém":
                            slKe++;
                            break;
                    }
                }
                catch { }
            }
            textBoxG.Text = slG + "/" + count + " học sinh";
            textBoxK.Text = slK + "/" + count + " học sinh";
            textBoxTB.Text = slTB + "/" + count + " học sinh";
            textBoxY.Text = slY + "/" + count + " học sinh";
            textBoxKe.Text = slKe + "/" + count + " học sinh";

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            sP_TBM_LOPGridControl.Visible = true;
            gridControl1.Visible = false;
            try
            {
                this.sP_TBM_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_TBM_LOP, comboBoxLop.SelectedValue.ToString(), 2);
                gridView1.Columns[11].Caption = "ĐTB HỌC KỲ II";
                clkMan = 2;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int count = sP_TBM_LOPBindingSource.Count;
            int slG = 0, slK = 0, slTB = 0, slY = 0, slKe = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    float dHoa = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["HÓA"].ToString());
                    //float dSinh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SINH"].ToString());
                    //float dAnh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ANH"].ToString());
                    //float dGDCD = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["GDCD"].ToString());
                    //float dToan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["TOÁN"].ToString());
                    //float dLy = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["LÝ"].ToString());
                    //float dVan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["VĂN"].ToString());
                    //float dSu = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SỬ"].ToString());
                    //float dDia = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ĐỊA"].ToString());
                    float dSinh = 7;
                    float dAnh = 7;
                    float dGDCD = 06;
                    float dToan = 6.5f;
                    float dLy = 06;
                    float dVan = 6.5f;
                    float dSu = 08;
                    float dDia = 06;
                    float dTB = (dHoa + dSinh + dAnh + dGDCD + 2 * dToan + dLy + 2 * dVan + dSu + dDia) / 11;
                    gridView1.SetRowCellValue(i, "DTBHK", dTB.ToString("0.00"));

                    string hl = Helper.hocLuc(dTB, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia);
                    gridView1.SetRowCellValue(i, "HOCLUC", hl);
                    switch (hl)
                    {
                        case "Giỏi":
                            slG++;
                            break;
                        case "Khá":
                            slK++;
                            break;
                        case "Trung bình":
                            slTB++;
                            break;
                        case "Yếu":
                            slY++;
                            break;
                        case "Kém":
                            slKe++;
                            break;
                    }
                }
                catch { }
            }
            textBoxG.Text = slG + "/" + count + " học sinh";
            textBoxK.Text = slK + "/" + count + " học sinh";
            textBoxTB.Text = slTB + "/" + count + " học sinh";
            textBoxY.Text = slY + "/" + count + " học sinh";
            textBoxKe.Text = slKe + "/" + count + " học sinh";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelTK.Enabled = false;
            standaloneBarDockControl1.Enabled = false;
            panelLC.Enabled = true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (clkMan == 1 || clkMan == 2)
            {
                int count = sP_TBM_LOPBindingSource.Count;
                string maLop = comboBoxLop.SelectedValue.ToString();
                for (int i = 0; i < count; i++)
                {
                    string maHS = ((DataRowView)sP_TBM_LOPBindingSource[i])["MAHS"].ToString();
                    string hocLuc = gridView1.GetRowCellValue(i, "HOCLUC").ToString();
                    switch (hocLuc)
                    {
                        case "Giỏi":
                            hocLuc = "G";
                            break;
                        case "Khá":
                            hocLuc = "K";
                            break;
                        case "Trung bình":
                            hocLuc = "TB";
                            break;
                        case "Yếu":
                            hocLuc = "Y";
                            break;
                        case "Kém":
                            hocLuc = "Ke";
                            break;
                    }
                    Helper.capNhatHocLuc(clkMan, maHS, maLop, hocLuc);
                }
            }
            else if (clkMan == 3)
            {
                int count = gridView2.RowCount;
                string maLop = comboBoxLop.SelectedValue.ToString();
                for (int i = 0; i < count; i++)
                {
                    string maHS = gridView2.GetRowCellValue(i, "maHS").ToString();
                    string hocLuc = gridView2.GetRowCellValue(i, "hocLuc").ToString();
                    switch (hocLuc)
                    {
                        case "Giỏi":
                            hocLuc = "G";
                            break;
                        case "Khá":
                            hocLuc = "K";
                            break;
                        case "Trung bình":
                            hocLuc = "TB";
                            break;
                        case "Yếu":
                            hocLuc = "Y";
                            break;
                        case "Kém":
                            hocLuc = "Ke";
                            break;
                    }
                    Helper.capNhatHocLuc(clkMan, maHS, maLop, hocLuc);
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Visible = true;
            sP_TBM_LOPGridControl.Visible = false;

            List<DTBMHK_HS> arrDHK1 = new List<DTBMHK_HS>();
            List<DTBMHK_HS> arrDHK2 = new List<DTBMHK_HS>();
            List<DTBMHK_HS> arrDCN = new List<DTBMHK_HS>();

            SqlCommand sqlCommand = new SqlCommand();
            SqlParameter dbMaHK = new SqlParameter();
            SqlParameter dbMaLop = new SqlParameter();

            dbMaHK.DbType = DbType.Int32;
            dbMaHK.ParameterName = "@MAHK";
            dbMaHK.Direction = ParameterDirection.Input;
            dbMaHK.Value = 1;

            dbMaLop.DbType = DbType.String;
            dbMaLop.ParameterName = "@MALOP";
            dbMaLop.Direction = ParameterDirection.Input;
            dbMaLop.Value = comboBoxLop.SelectedValue.ToString();

            try
            {
                sqlCommand.Connection = Program.sqlConnection;
                sqlCommand.CommandText = "SP_TBM_LOP";
                sqlCommand.Parameters.Add(dbMaLop);
                sqlCommand.Parameters.Add(dbMaHK);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string maHS = dataReader.GetValue(0).ToString();
                    string tenHS = dataReader.GetValue(1).ToString();
                    float dToan = float.Parse(dataReader.GetValue(2).ToString());
                    float dLy = float.Parse(dataReader.GetValue(3).ToString());
                    float dHoa = float.Parse(dataReader.GetValue(4).ToString());
                    float dVan = float.Parse(dataReader.GetValue(5).ToString());
                    float dSu = float.Parse(dataReader.GetValue(6).ToString());
                    float dDia = float.Parse(dataReader.GetValue(7).ToString());
                    float dSinh = float.Parse(dataReader.GetValue(8).ToString());
                    float dAnh = float.Parse(dataReader.GetValue(9).ToString());
                    float dGDCD = float.Parse(dataReader.GetValue(10).ToString());
                    //float dToan = 0;
                    //float dLy = 0;
                    //float dHoa = 0;
                    //float dVan = 0;
                    //float dSu = 0;
                    //float dDia = 0;
                    //float dSinh = 0;
                    //float dAnh = 0;
                    //float dGDCD = 0;
                    arrDHK1.Add(new DTBMHK_HS(maHS, tenHS, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia));
                }
                dataReader.Close();
                
            }
            catch (SqlException se)
            {
                MessageBox.Show("Loi: " + se.Message);
            }

            SqlCommand _sqlCommand = new SqlCommand();
            SqlParameter _dbMaHK = new SqlParameter();
            SqlParameter _dbMaLop = new SqlParameter();

            _dbMaHK.DbType = DbType.Int32;
            _dbMaHK.ParameterName = "@MAHK";
            _dbMaHK.Direction = ParameterDirection.Input;
            _dbMaHK.Value = 2;

            _dbMaLop.DbType = DbType.String;
            _dbMaLop.ParameterName = "@MALOP";
            _dbMaLop.Direction = ParameterDirection.Input;
            _dbMaLop.Value = comboBoxLop.SelectedValue.ToString();

            try
            {
                _sqlCommand.Connection = Program.sqlConnection;
                _sqlCommand.CommandText = "SP_TBM_LOP";
                _sqlCommand.Parameters.Add(_dbMaLop);
                _sqlCommand.Parameters.Add(_dbMaHK);
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = _sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string maHS = dataReader.GetValue(0).ToString();
                    string tenHS = dataReader.GetValue(1).ToString();
                    //float dToan = float.Parse(dataReader.GetValue(2).ToString());
                    //float dLy = float.Parse(dataReader.GetValue(3).ToString());
                    //float dHoa = float.Parse(dataReader.GetValue(4).ToString());
                    //float dVan = float.Parse(dataReader.GetValue(5).ToString());
                    //float dSu = float.Parse(dataReader.GetValue(6).ToString());
                    //float dDia = float.Parse(dataReader.GetValue(7).ToString());
                    //float dSinh = float.Parse(dataReader.GetValue(8).ToString());
                    //float dAnh = float.Parse(dataReader.GetValue(9).ToString());
                    //float dGDCD = float.Parse(dataReader.GetValue(10).ToString());
                    float dToan = 0;
                    float dLy = 0;
                    float dHoa = 0;
                    float dVan = 0;
                    float dSu = 0;
                    float dDia = 0;
                    float dSinh = 0;
                    float dAnh = 0;
                    float dGDCD = 0;
                    arrDHK2.Add(new DTBMHK_HS(maHS, tenHS, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia));
                }
                dataReader.Close();

            }
            catch (SqlException se)
            {
                MessageBox.Show("Loi: " + se.Message);
            }

            int slG = 0, slK = 0, slTB = 0, slY = 0, slKe = 0;
            int count = arrDHK1.Count;
            for (int i = 0; i < count; i++)
            {
                string maHS = arrDHK1[i].maHS;
                string tenHS = arrDHK1[i].tenHS;
                float dToan = (arrDHK1[i].dToan + 2 * arrDHK2[i].dToan) / 3;
                float dLy = (arrDHK1[i].dLy + 2 * arrDHK2[i].dLy) / 3;
                float dHoa = (arrDHK1[i].dHoa + 2 * arrDHK2[i].dHoa) / 3;
                float dVan = (arrDHK1[i].dVan + 2 * arrDHK2[i].dVan) / 3;
                float dSu = (arrDHK1[i].dSu + 2 * arrDHK2[i].dSu) / 3;
                float dDia = (arrDHK1[i].dDia + 2 * arrDHK2[i].dDia) / 3;
                float dSinh = (arrDHK1[i].dSinh + 2 * arrDHK2[i].dSinh) / 3;
                float dAnh = (arrDHK1[i].dAnh + 2 * arrDHK2[i].dAnh) / 3;
                float dGDCD = (arrDHK1[i].dGDCD + 2 * arrDHK2[i].dGDCD) / 3;
                //float dToan = 0;
                //float dLy = 0;
                //float dHoa = 0;
                //float dVan = 0;
                //float dSu = 0;
                //float dDia = 0;
                //float dSinh = 0;
                //float dAnh = 0;
                //float dGDCD = 0;
                float dTB = (dHoa + dSinh + dAnh + dGDCD + 2 * dToan + dLy + 2 * dVan + dSu + dDia) / 11;
                string hocLuc = Helper.hocLuc(dTB, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia);
                arrDCN.Add(new DTBMHK_HS(maHS, tenHS, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia, dTB, hocLuc));
                switch (hocLuc)
                {
                    case "Giỏi":
                        slG++;
                        break;
                    case "Khá":
                        slK++;
                        break;
                    case "Trung bình":
                        slTB++;
                        break;
                    case "Yếu":
                        slY++;
                        break;
                    case "Kém":
                        slKe++;
                        break;
                }
            }

            textBoxG.Text = slG + "/" + count + " học sinh";
            textBoxK.Text = slK + "/" + count + " học sinh";
            textBoxTB.Text = slTB + "/" + count + " học sinh";
            textBoxY.Text = slY + "/" + count + " học sinh";
            textBoxKe.Text = slKe + "/" + count + " học sinh";
            gridControl1.DataSource = arrDCN;
            gridView2.Columns[0].Caption = "MAHS";
            gridView2.Columns[1].Caption = "TENHS";
            gridView2.Columns[2].Caption = "HÓA";
            gridView2.Columns[3].Caption = "SINH";
            gridView2.Columns[4].Caption = "ANH";
            gridView2.Columns[5].Caption = "GDCD";
            gridView2.Columns[6].Caption = "TOÁN";
            gridView2.Columns[7].Caption = "LÝ";
            gridView2.Columns[8].Caption = "VĂN";
            gridView2.Columns[9].Caption = "SỬ";
            gridView2.Columns[10].Caption = "ĐỊA";
            gridView2.Columns[11].Caption = "ĐTB CẢ NĂM";
            gridView2.Columns[12].Caption = "HỌC LỰC";
            clkMan = 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (clkMan == 1 || clkMan == 2)
            {
                int count = sP_TBM_LOPBindingSource.Count;
                float max = 0;
                int index = 0;
                for (int i = 0; i < count; i++)
                {
                    float dTB = float.Parse(gridView1.GetRowCellValue(i, "DTBHK").ToString());
                    if (dTB >= max)
                    {
                        max = dTB;
                        index = i;
                    } 
                }
                string maHS = ((DataRowView)sP_TBM_LOPBindingSource[index])["MAHS"].ToString();
                string tenHS = ((DataRowView)sP_TBM_LOPBindingSource[index])["TENHS"].ToString();
                string diemTB = gridView1.GetRowCellValue(index, "DTBHK").ToString();
                string dHoa = ((DataRowView)sP_TBM_LOPBindingSource[index])["HÓA"].ToString();
                string dSinh = ((DataRowView)sP_TBM_LOPBindingSource[index])["SINH"].ToString();
                string dAnh = ((DataRowView)sP_TBM_LOPBindingSource[index])["ANH"].ToString();
                string dGDCD = ((DataRowView)sP_TBM_LOPBindingSource[index])["GDCD"].ToString();
                string dToan = ((DataRowView)sP_TBM_LOPBindingSource[index])["TOÁN"].ToString();
                string dLy = ((DataRowView)sP_TBM_LOPBindingSource[index])["LÝ"].ToString();
                string dVan = ((DataRowView)sP_TBM_LOPBindingSource[index])["VĂN"].ToString();
                string dSu = ((DataRowView)sP_TBM_LOPBindingSource[index])["SỬ"].ToString();
                string dDia = ((DataRowView)sP_TBM_LOPBindingSource[index])["ĐỊA"].ToString();

                formChinh.Enabled = false;
                FormTK_1 f = new FormTK_1(formChinh, maHS, tenHS, diemTB, dToan, dVan, dHoa, dSinh, dAnh, dGDCD, dLy, dSu, dDia);
                f.Activate();
                f.Show();
            }
            else if (clkMan == 3)
            {
                int count = gridView2.RowCount;
                float max = 0;
                int index = 0;
                for (int i = 0; i < count; i++)
                {
                    float dTB = float.Parse(gridView2.GetRowCellValue(i, "diemTB").ToString());
                    if (dTB >= max)
                    {
                        max = dTB;
                        index = i;
                    }
                }
                string maHS = gridView2.GetRowCellValue(index, "maHS").ToString();
                string tenHS = gridView2.GetRowCellValue(index, "tenHS").ToString();
                string diemTB = gridView2.GetRowCellValue(index, "diemTB").ToString();
                string dHoa = gridView2.GetRowCellValue(index, "dHoa").ToString();
                string dSinh = gridView2.GetRowCellValue(index, "dSinh").ToString();
                string dAnh = gridView2.GetRowCellValue(index, "dAnh").ToString();
                string dGDCD = gridView2.GetRowCellValue(index, "dGDCD").ToString();
                string dToan = gridView2.GetRowCellValue(index, "dToan").ToString();
                string dLy = gridView2.GetRowCellValue(index, "dLy").ToString();
                string dVan = gridView2.GetRowCellValue(index, "dVan").ToString();
                string dSu = gridView2.GetRowCellValue(index, "dSu").ToString();
                string dDia = gridView2.GetRowCellValue(index, "dDia").ToString();

                formChinh.Enabled = false;
                FormTK_1 f = new FormTK_1(formChinh, maHS, tenHS, diemTB, dToan, dVan, dHoa, dSinh, dAnh, dGDCD, dLy, dSu, dDia);
                f.Activate();
                f.Show();
            }
        }
    }
}
