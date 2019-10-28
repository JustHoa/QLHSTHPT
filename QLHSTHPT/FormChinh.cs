using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Data.SqlClient;

namespace QLHSTHPT
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
        }

        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormChinh_Load(object sender, EventArgs e)
        {
            string sql = "EXEC SP_DANGNHAP " + Program.loginName;
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            dataReader.Read();
            toolStripStatusLabelMGV.Text = "MAGV = " + dataReader.GetValue(0).ToString().Trim();
            toolStripStatusLabelTen.Text = "| HOTEN = " + dataReader.GetValue(1).ToString().Trim();
            toolStripStatusLabelNhom.Text = "| NHOM = " + dataReader.GetValue(2).ToString().Trim();
            Program.group = dataReader.GetValue(2).ToString();

            //if (Program.group == "PKeToan")
            //{
            //    this.ribbonPageQT.Visible = false;
            //    this.ribbonPageBC.Visible = false;
            //}
            //else this.ribbonPageKT.Visible = false;

            dataReader.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVien f = new FormGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormHocSinh));
            if (frm != null) frm.Activate();
            else
            {
                FormHocSinh f = new FormHocSinh();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormNamHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormNamHoc f = new FormNamHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormHocKy));
            if (frm != null) frm.Activate();
            else
            {
                FormHocKy f = new FormHocKy();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLop_SV));
            if (frm != null) frm.Activate();
            else
            {
                FormLop_SV f = new FormLop_SV();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}