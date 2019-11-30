using DevExpress.XtraGrid.Views.Grid;
using QLHSTHPT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            int numRight = 0;
            int index = this.comboBoxMaLop.SelectedIndex;
            this.textBoxSLHS.Text = xepLop[index].ToString() + " học sinh";
            for (int i = 0; i < index; i++)
            {
                numLeft += xepLop[i];
            }
            numRight = numLeft + xepLop[index] - 1;
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
                ds.Add(new HocSinh(maHS, tenHS, ngaySinh, gioiTinh, diaChi, danToc, dienThoai, maLop));
                numLeft++;
                idHS = Helper.createMaHS(idHS);
            }
            ds.AllowNew = true;
            gridControl1.DataSource = ds;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void FormXepLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
