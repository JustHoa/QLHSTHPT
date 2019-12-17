using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class FormXetLenLop : Form
    {
        FormChinh formChinh;

        public FormXetLenLop()
        {
            InitializeComponent();
        }

        public FormXetLenLop(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.sP_DSLOP_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP_NH, new System.Nullable<int>(((int)(System.Convert.ChangeType(mANHToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                //this.sP_HLCN_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_HLCN_LOP, mALOPToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormXetLenLop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            //int namBD = DateTime.Today.Year - 1; dung
            int namBD = DateTime.Today.Year; //sai, nam nay la NAMKT
            labelTitleNH.Text = "DANH SÁCH LỚP NĂM HỌC " + (namBD - 1) + "-" + namBD;
            try
            {
                this.sP_DSLOP10_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP10_NH, DateTime.Today.Year);
                this.sP_DSLOP11_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP11_NH, DateTime.Today.Year);
                this.sP_DSLOP12_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP12_NH, DateTime.Today.Year);

                int viTri = sP_DSLOP10_NHBindingSource.Position;
                string maLop = ((DataRowView)sP_DSLOP10_NHBindingSource[viTri])["MALOP"].ToString().Trim();
                string tenLop = ((DataRowView)sP_DSLOP10_NHBindingSource[viTri])["TENLOP"].ToString().Trim();
                labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + tenLop;
                this.sP_OL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_OL_LOP, maLop);
                this.sP_LL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LL_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }
        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                int viTri = sP_DSLOP10_NHBindingSource.Position;
                string maLop = ((DataRowView)sP_DSLOP10_NHBindingSource[viTri])["MALOP"].ToString().Trim();
                string tenLop = ((DataRowView)sP_DSLOP10_NHBindingSource[viTri])["TENLOP"].ToString().Trim();
                labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + tenLop;
                this.sP_OL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_OL_LOP, maLop);
                this.sP_LL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LL_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            try
            {
                int viTri = sP_DSLOP11_NHBindingSource.Position;
                string maLop = ((DataRowView)sP_DSLOP11_NHBindingSource[viTri])["MALOP"].ToString().Trim();
                string tenLop = ((DataRowView)sP_DSLOP11_NHBindingSource[viTri])["TENLOP"].ToString().Trim();
                labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + tenLop;
                this.sP_OL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_OL_LOP, maLop);
                this.sP_LL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LL_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void gridView3_Click(object sender, EventArgs e)
        {
            try
            {
                int viTri = sP_DSLOP12_NHBindingSource.Position;
                string maLop = ((DataRowView)sP_DSLOP12_NHBindingSource[viTri])["MALOP"].ToString().Trim();
                string tenLop = ((DataRowView)sP_DSLOP12_NHBindingSource[viTri])["TENLOP"].ToString().Trim();
                labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + tenLop;
                this.sP_OL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_OL_LOP, maLop);
                this.sP_LL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LL_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.Enabled = false;
            FormLenLop f = new FormLenLop(formChinh);
            f.Activate();
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formChinh.Enabled = false;
            FormTimNH_XLL f = new FormTimNH_XLL(formChinh, this);
            f.Activate();
            f.Show();
        }
    }
}
