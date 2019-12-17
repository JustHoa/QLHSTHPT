using QLHSTHPT.Model;
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
    public partial class FormLL10 : Form
    {
        FormLenLop formLenLop;
        int[] soHS_Lop;

        public FormLL10()
        {
            InitializeComponent();
        }

        public FormLL10(FormLenLop formLenLop)
        {
            InitializeComponent();
            this.formLenLop = formLenLop;
        }

        private void FormLL10_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.V_XL10' table. You can move, or remove it, as needed.
            this.v_XL10TableAdapter.Fill(this.qLHSTHPTDataSet1.V_XL10);

            int soLop = 0;
            List<string> arrTenLop = new List<string>();
            if (v_XL10BindingSource.Count != 0)
            {
                soHS_Lop = Helper.xepLop(v_XL10BindingSource.Count);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh lên lớp nằm ngoài khoảng xếp lớp khả dụng!\n\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX * Program.MAX_LOP + "\n\nHiện tại: " + v_XL10BindingSource.Count);
                    barButtonItem5.Enabled = false;
                }
                else
                {
                    barButtonItem5.Enabled = true;
                    for (int i = 0; i < Program.MAX_LOP; i++)
                    {
                        if (soHS_Lop[i] != 0)
                        {
                            soLop += 1;
                        }
                    }

                    this.textBoxSoLop.Text = soLop.ToString();

                    for (int i = 0; i < soLop; i++)
                    {
                        arrTenLop.Add("10A" + (i + 1));
                    }
                    this.comboBoxTenLop.DataSource = arrTenLop;
                    this.comboBoxTenLop.SelectedIndex = 0;
                }
            }
            else
            {
                barButtonItem5.Enabled = false;
                MessageBox.Show("Thiếu dữ liệu học sinh!\n\nGợi ý: Thêm dữ liệu học sinh từ Excel:\n\nQuản trị -> Excel-Học sinh");
            }
        }

        private void comboBoxTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingList<HocSinh_LL> ds = new BindingList<HocSinh_LL>();
            int numLeft = 0;
            int index = this.comboBoxTenLop.SelectedIndex;
            this.textBoxSiSo.Text = soHS_Lop[index].ToString() + " học sinh";
            this.labelTitleHS.Text = "DANH SÁCH DỰ KIẾN HỌC SINH LỚP " + comboBoxTenLop.Text;
            for (int i = 0; i < index; i++)
            {
                numLeft += soHS_Lop[i];
            }
            for (int j = 0; j < soHS_Lop[index]; j++)
            {
                string maHS = ((DataRowView)v_XL10BindingSource[numLeft])["MAHS"].ToString();
                string tenHS = ((DataRowView)v_XL10BindingSource[numLeft])["TENHS"].ToString();
                string ghiChu = ((DataRowView)v_XL10BindingSource[numLeft])["GHICHU"].ToString();
                
                ds.Add(new HocSinh_LL(maHS, tenHS, ghiChu));
                numLeft++;
            }
            ds.AllowNew = true;
            gridControl1.DataSource = ds;
            gridView1.Columns[0].Caption = "MAHS";
            gridView1.Columns[1].Caption = "TENHS";
            gridView1.Columns[2].Caption = "GHICHU";
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formLenLop._ll10 == 0)
            {
                formLenLop._ll10 = 1;
                FormTienTrinhLL f = new FormTienTrinhLL(this, comboBoxTenLop, v_XL10BindingSource);
                f.Text = "Tiến trình lên lớp 10";
                f.MdiParent = formLenLop;
                f.Show();
            }
            else formLenLop.toolStripStatusLabelNote.Text = "Tiến trình lên lớp 10 đang mở!";
        }
    }
}
