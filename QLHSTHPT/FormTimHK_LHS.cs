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
    public partial class FormTimHK_LHS : Form
    {
        FormChinh formChinh;
        FormLop_HS formLop_HS;

        public FormTimHK_LHS()
        {
            InitializeComponent();
        }

        public FormTimHK_LHS(FormChinh formChinh, FormLop_HS formLop_HS)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formLop_HS = formLop_HS;
        }

        private void FormTimHK_LHS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCKY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // formLop_HS.labelEMaHK.Text = "";
            //formLop_HS.textBoxMHK.Text = this.textBoxMaHK.Text;
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

        private void FormTimHK_LHS_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
