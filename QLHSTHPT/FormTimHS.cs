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
    public partial class FormTimHS : Form
    {
        FormChinh formChinh;
        FormBangDiemHS formBangDiemHS;
        public FormTimHS()
        {
            InitializeComponent();
        }

        public FormTimHS(FormChinh formChinh, FormBangDiemHS formBangDiemHS)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formBangDiemHS = formBangDiemHS;
        }

        private void hOCSINHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCSINHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void FormTimHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet.HOCSINH);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formBangDiemHS.labelEMaHS.Text = "";
            formBangDiemHS.textBoxMaHS.Text = this.textBoxMaHS.Text;
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimHS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
