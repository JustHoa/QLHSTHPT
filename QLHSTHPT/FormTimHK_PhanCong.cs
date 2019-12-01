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
    public partial class FormTimHK_PhanCong : Form
    {
        FormChinh formChinh;
        FormPhanCongGV formPhanCongGV;

        public FormTimHK_PhanCong(FormChinh formChinh, FormPhanCongGV formPhanCongGV)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.formPhanCongGV = formPhanCongGV;
        }

        private void FormTimHK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet.HOCKY);

        }

        private void hOCKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formPhanCongGV.labelEMaHK.Text = "";
            formPhanCongGV.textBoxMaHK.Text = this.textBoxMaHK.Text;
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void FormTimHK_FormClosing(object sender, FormClosingEventArgs e)
        {
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
    }
}
