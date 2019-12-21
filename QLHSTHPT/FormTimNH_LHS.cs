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
    public partial class FormTimNH_LHS : Form
    {
        FormChinh formChinh;
        FormLop_HS formLop_HS;

        public FormTimNH_LHS()
        {
            InitializeComponent();
        }

        public FormTimNH_LHS(FormChinh formChinh, FormLop_HS formLop_HS)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formLop_HS = formLop_HS;
        }

        private void FormTimNH_LHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formLop_HS.labelEMaNH.Text = "";
            formLop_HS.textBoxMNH.Text = this.textBoxMaNH.Text;
            formLop_HS.textBoxTenNH.Text = this.textBoxTenNH.Text;
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

        private void FormTimNH_LHS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
