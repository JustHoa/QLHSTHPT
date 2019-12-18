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
            formXetLenLop.labelNamBD.Text = int.Parse(textBoxNBD.Text).ToString();
            
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
