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
    public partial class FormTTDangNhap : Form
    {
        FormChinh formChinh;

        public FormTTDangNhap(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormTTDangNhap_Load(object sender, EventArgs e)
        {
            this.panelInfo.Enabled = false;
            this.panelPass.Visible = false;
            try
            {
                this.sP_TAIKHOANINFOTableAdapter.Fill(this.qLHSTHPTDataSet.SP_TAIKHOANINFO, Program.maGV);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
