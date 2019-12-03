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
        FormChinh formChinh;

        public FormHocSinh_DB()
        {
            InitializeComponent();
        }

        public FormHocSinh_DB(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
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

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.RowCount != 0)
            {
                int[] soHS_Lop = Helper.xepLop(gridView1.RowCount);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh nằm ngoài khoảng xếp lớp khả dụng!\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX * Program.MAX_LOP + "\nHiện tại: " + gridView1.RowCount);
                }
                else
                {
                    formChinh.Enabled = false;
                    FormXepLop formXepLop = new FormXepLop(soHS_Lop, this.gridView1, formChinh);
                    formXepLop.Validate();
                    formXepLop.Show();
                }
            }
            else
            {
                MessageBox.Show("Thiếu dữ liệu học sinh!\n Gợi ý: Thêm dữ liệu học sinh từ Excel.");
            }
        }
    }
}
