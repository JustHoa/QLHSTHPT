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
    public partial class FormTimHK_CongViec : Form
    {
        FormChinh formChinh;
        FormCV formCV;

        public FormTimHK_CongViec()
        {
            InitializeComponent();
        }

        public FormTimHK_CongViec(FormChinh formChinh, FormCV formCV)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formCV = formCV;
        }

        private void FormTimHK_CongViec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCV.labelEMaHK.Text = "";
            formCV.textBoxMaHK.Text = this.textBoxMaHK.Text;
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

        private void FormTimHK_CongViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
