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
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
      

        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.qLHSTHPTDataSet.MONHOC);
        }

        private void tENMHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tENMHTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.mONHOCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

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
    }
}
