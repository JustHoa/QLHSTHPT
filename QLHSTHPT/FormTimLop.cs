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
    public partial class FormTimLop : Form
    {
        FormChinh formChinh;
        FormPhanCongGV formPhanCongGV;

        public FormTimLop(FormChinh formChinh, FormPhanCongGV formPhanCongGV)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formPhanCongGV = formPhanCongGV;
        }

        private void FormTimLop_Load(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet2.SP_DSLOP_FI' table. You can move, or remove it, as needed.
            this.sP_DSLOP_FITableAdapter.Fill(this.qLHSTHPTDataSet2.SP_DSLOP_FI);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPhanCongGV.labelEMaLop.Text = "";
            formPhanCongGV.textBoxMaLop.Text = this.textBoxMaLop.Text;
           // formPhanCongGV.textBoxMaNH.Text = ((DataRowView)lOPBindingSource[lOPBindingSource.Position])["MANH"].ToString().Trim();
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            sP_DSLOP_FIBindingSource.Filter = "TENLOP LIKE '%" + textBoxTim.Text +
                "%' OR MALOP LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên lớp hoặc Mã lớp", textBoxTim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
