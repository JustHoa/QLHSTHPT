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
    public partial class FormTimInfoHS : Form
    {
        FormChinh formChinh;
        FormLop_HS formLop_HS;

        public FormTimInfoHS()
        {
            InitializeComponent();
        }

        public FormTimInfoHS(FormChinh formChinh, FormLop_HS formLop_HS)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formLop_HS = formLop_HS;
        }

        private void FormTimInfoHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.HOCSINH' table. You can move, or remove it, as needed.
            this.hOCSINHTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCSINH);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLop_HS.labelEMaHS.Text = "";
            formLop_HS.labelEHT.Text = "";
            formLop_HS.labelEDC.Text = "";
            formLop_HS.labelENS.Text = "";
            formLop_HS.labelEDT.Text = "";
            formLop_HS.labelEDTo.Text = "";

            formLop_HS.textBoxMHS.Text = this.textBoxMHS.Text;
            formLop_HS.textBoxTenHS.Text = this.textBoxTenHS.Text;
            formLop_HS.textBoxDC.Text = this.textBoxDC.Text;
            formLop_HS.dateEditNS.Text = this.textBoxNS.Text;
            formLop_HS.comboBoxGT.Text = this.textBoxGT.Text;
            formLop_HS.textBoxDT.Text = this.textBoxDT.Text;
            formLop_HS.textBoxDToc.Text = this.textBoxDTo.Text;
            formLop_HS.checkBoxNghi.Checked = this.checkBoxNghi.Checked;
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

        private void FormTimInfoHS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
