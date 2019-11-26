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

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void FormTimLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPhanCongGV.labelEMaLop.Text = "";
            formPhanCongGV.textBoxMaLop.Text = this.textBoxMaLop.Text;
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
            lOPBindingSource.Filter = "TENLOP LIKE '%" + textBoxTim.Text +
                "%' OR MALOP LIKE '%" + textBoxTim.Text + "%'";
        }

        private void textBoxTim_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Tìm kiếm theo Tên lớp hoặc Mã lớp", textBoxTim);
        }
    }
}
