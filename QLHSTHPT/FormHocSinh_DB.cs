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
    public partial class FormHocSinh_DB : Form
    {
        public FormHocSinh_DB()
        {
            InitializeComponent();
        }

        private void FormHocSinh_DB_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.SP_DSHS_TUDO' table. You can move, or remove it, as needed.
            this.sP_DSHS_TUDOTableAdapter.Fill(this.qLHSTHPTDataSet.SP_DSHS_TUDO);

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sP_DSHS_TUDOTableAdapter.Fill(this.qLHSTHPTDataSet.SP_DSHS_TUDO);
        }
    }
}
