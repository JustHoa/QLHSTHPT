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
            Program.maGV = dataReader.GetValue(0).ToString().Trim();
            Program.tenGV = dataReader.GetValue(1).ToString().Trim();
            Program.group = dataReader.GetValue(2).ToString();

            //if (Program.group == "PKeToan")
            //{
            //    this.ribbonPageQT.Visible = false;
            //    this.ribbonPageBC.Visible = false;
            //}
            //else this.ribbonPageKT.Visible = false;
            if (Program.group == "PGV")
            {
                this.ribbonQLTK.Visible = true;
                this.ribbonPCCV.Visible = true;
            }
            else
            {
                this.ribbonQLTK.Visible = false;
                this.ribbonPCCV.Visible = false;
            }

            dataReader.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVien f = new FormGiaoVien(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormHocSinh_Excel));
            if (frm != null) frm.Activate();
            else
            {
                FormHocSinh_Excel f = new FormHocSinh_Excel(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormMonHoc f = new FormMonHoc(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormNamHoc));
            if (frm != null) frm.Activate();
            else
            {
                FormNamHoc f = new FormNamHoc(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormHocKy));
            if (frm != null) frm.Activate();
            else
            {
                FormHocKy f = new FormHocKy(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormLop_HS));
            if (frm != null) frm.Activate();
            else
            {
                FormLop_HS f = new FormLop_HS(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormNhapDiem f = new FormNhapDiem(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormQLTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormQLTaiKhoan f = new FormQLTaiKhoan(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormTTDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormTTDangNhap f = new FormTTDangNhap(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.formDangNhap.Visible = true;
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormPhanCongGV));
            if (frm != null) frm.Activate();
            else
            {
                FormPhanCongGV f = new FormPhanCongGV(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormBangDiemHS));
            if (frm != null) frm.Activate();
            else
            {
                FormBangDiemHS f = new FormBangDiemHS(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormCV));
            if (frm != null) frm.Activate();
            else
            {
                FormCV f = new FormCV(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormLop));
            if (frm != null) frm.Activate();
            else
            {
                FormLop f = new FormLop(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormHocSinh));
            if (frm != null) frm.Activate();
            else
            {
                FormHocSinh f = new FormHocSinh(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormXetLenLop));
            if (frm != null) frm.Activate();
            else
            {
                FormXetLenLop f = new FormXetLenLop(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.toolStripStatusLabelNote.Text = "";

            Form frm = this.checkExists(typeof(FormTongKetLop));
            if (frm != null) frm.Activate();
            else
            {
                FormTongKetLop f = new FormTongKetLop(this);
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}