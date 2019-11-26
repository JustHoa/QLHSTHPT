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
    public partial class FormTimNH : Form
    {
        FormChinh formChinh;
        FormPhanCongGV formPhanCongGV;

        public FormTimNH(FormChinh formChinh, FormPhanCongGV formPhanCongGV)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formPhanCongGV = formPhanCongGV;
        }

        private void FormTimNH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet.NAMHOC);

        }

        private void nAMHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nAMHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPhanCongGV.labelEMaNH.Text = "";
            formPhanCongGV.textBoxMaNH.Text = this.textBoxMaNH.Text;
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimNH_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
