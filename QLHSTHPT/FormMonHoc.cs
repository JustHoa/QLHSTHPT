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
    public partial class FormMonHoc : Form
    {
        public int clkSave = 0;
        public int clkMan = 0;
        public int clkOK = 0;

        FormChinh formChinh;

        public FormMonHoc(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }


        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHSTHPTDataSet.MONHOC);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCGridControl.Enabled = false;
            this.groupBoxCT.Enabled = true;
            this.mONHOCBindingSource.AddNew();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Update(this.qLHSTHPTDataSet.MONHOC);
            this.mONHOCGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
            MessageBox.Show("Lưu thay đổi thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.EndEdit();
            MessageBox.Show("Nhắc nhở: Bạn cần Lưu để thực hiện thay đổi!");
            this.mONHOCGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.mONHOCBindingSource.CancelEdit();
            this.mONHOCGridControl.Enabled = true;
            this.groupBoxCT.Enabled = false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
