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
    public partial class FormLL12 : Form
    {
        FormLenLop formLenLop;
        int[] soHS_Lop;

        public FormLL12()
        {
            InitializeComponent();
        }

        public FormLL12(FormLenLop formLenLop)
        {
            InitializeComponent();
            this.formLenLop = formLenLop;
        }

        private void FormLL12_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.V_XL12' table. You can move, or remove it, as needed.
            this.v_XL12TableAdapter.Fill(this.qLHSTHPTDataSet1.V_XL12);

            int soLop = 0;
            List<string> arrTenLop = new List<string>();
            if (v_XL12BindingSource.Count != 0)
            {
                soHS_Lop = Helper.xepLop(gridView1.RowCount);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh lên lớp nằm ngoài khoảng xếp lớp khả dụng!\n\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX * Program.MAX_LOP + "\n\nHiện tại: " + v_XL12BindingSource.Count);
                    barButtonItem1.Enabled = false;
                }
                else
                {
                    barButtonItem1.Enabled = true;
                    for (int i = 0; i < Program.MAX_LOP; i++)
                    {
                        if (soHS_Lop[i] != 0)
                        {
                            soLop += 1;
                        }
                    }

                    this.textBoxSiSo.Text = soLop.ToString();

                    for (int i = 0; i < soLop; i++)
                    {
                        arrTenLop.Add("12A" + (i + 1));
                    }
                    this.comboBoxTenLop.DataSource = arrTenLop;
                    this.comboBoxTenLop.SelectedIndex = 0;
                }
            }
            else
            {
                barButtonItem1.Enabled = false;
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
                string maHS = ((DataRowView)v_XL12BindingSource[numLeft])["MAHS"].ToString();
                string tenHS = ((DataRowView)v_XL12BindingSource[numLeft])["TENHS"].ToString();
                string ghiChu = ((DataRowView)v_XL12BindingSource[numLeft])["GHICHU"].ToString();

                ds.Add(new HocSinh_LL(maHS, tenHS, ghiChu));
                numLeft++;
            }
            ds.AllowNew = true;
            gridControl1.DataSource = ds;
            gridView1.Columns[0].Caption = "MAHS";
            gridView1.Columns[1].Caption = "TENHS";
            gridView1.Columns[2].Caption = "GHICHU";
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formLenLop._ll12 == 0)
            {
                formLenLop._ll12 = 1;
                FormTienTrinhLL f = new FormTienTrinhLL(this);
                f.Text = "Tiến trình lên lớp 12";
                f.MdiParent = formLenLop;
                f.Show();
            }
            else formLenLop.toolStripStatusLabelNote.Text = "Tiến trình lên lớp 12 đang mở!";
        }
    }
}
