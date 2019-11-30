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
    public partial class FormTimGV : Form
    {
        FormChinh formChinh;
        FormPhanCongGV formPhanCongGV;

        public FormTimGV(FormChinh formChinh, FormPhanCongGV formPhanCongGV)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formPhanCongGV = formPhanCongGV;
        }

        private void FormTimGV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPhanCongGV.labelEMaGV.Text = "";
            formPhanCongGV.textBoxMaGV.Text = this.textBoxMaGV.Text;
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimGV_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void textBoxTim_TextChanged(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.Filter = "TENGV LIKE '%" + textBoxTim.Text +
                "%' OR MAGV LIKE '%" + textBoxTim.Text + "%' OR TOMON LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo tên giáo viên, mã giáo viên hoặc môn học", textBoxTim);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
