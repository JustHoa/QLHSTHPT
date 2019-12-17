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
    public partial class FormTimNH_XLL : Form
    {
        FormChinh formChinh;
        FormXetLenLop formXetLenLop;

        public FormTimNH_XLL()
        {
            InitializeComponent();
        }

        public FormTimNH_XLL(FormChinh formChinh, FormXetLenLop formXetLenLop)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formXetLenLop = formXetLenLop;
        }

        private void FormTimNH_XLL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int namBD = int.Parse(textBoxNBD.Text);
            formXetLenLop.labelTitleNH.Text = "DANH SÁCH LỚP NĂM HỌC " + namBD + "-" + (namBD + 1);
            try
            {
                formXetLenLop.sP_DSLOP10_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP10_NH, namBD);
                formXetLenLop.sP_DSLOP11_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP11_NH, namBD);
                formXetLenLop.sP_DSLOP12_NHTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_DSLOP12_NH, namBD);

                int viTri = formXetLenLop.sP_DSLOP10_NHBindingSource.Position;
                string maLop = ((DataRowView)formXetLenLop.sP_DSLOP10_NHBindingSource[viTri])["MALOP"].ToString().Trim();
                string tenLop = ((DataRowView)formXetLenLop.sP_DSLOP10_NHBindingSource[viTri])["TENLOP"].ToString().Trim();
                formXetLenLop.labelTitleHS.Text = "DANH SÁCH HỌC SINH LỚP " + tenLop;
                formXetLenLop.sP_OL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_OL_LOP, maLop);
                formXetLenLop.sP_LL_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LL_LOP, maLop);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return;
            }
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimNH_XLL_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
