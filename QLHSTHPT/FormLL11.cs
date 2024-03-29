﻿using QLHSTHPT.Model;
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
    public partial class FormLL11 : Form
    {
        FormLenLop formLenLop;
        public int[] soHS_Lop;

        public FormLL11()
        {
            InitializeComponent();
        }

        public FormLL11(FormLenLop formLenLop)
        {
            InitializeComponent();
            this.formLenLop = formLenLop;
        }

        private void FormLL11_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.V_XL11' table. You can move, or remove it, as needed.
            this.v_XL11TableAdapter.Fill(this.qLHSTHPTDataSet1.V_XL11);

            int soLop = 0;
            List<string> arrTenLop = new List<string>();
            if (v_XL11BindingSource.Count != 0)
            {
                soHS_Lop = Helper.xepLop(v_XL11BindingSource.Count);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh lên lớp nằm ngoài khoảng xếp lớp khả dụng!\n\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX * Program.MAX_LOP + "\n\nHiện tại: " + v_XL11BindingSource.Count, "Lớp 11", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    this.textBoxSoLop.Text = soLop.ToString();

                    for (int i = 0; i < soLop; i++)
                    {
                        arrTenLop.Add("11A" + (i + 1));
                    }
                    this.comboBoxTenLop.DataSource = arrTenLop;
                    this.comboBoxTenLop.SelectedIndex = 0;
                }
            }
            else
            {
                barButtonItem1.Enabled = false;
                MessageBox.Show("Thiếu dữ liệu học sinh!\n\nGợi ý: Thêm dữ liệu học sinh từ Excel:\n\nQuản trị -> Excel-Học sinh", "Lớp 11", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string maHS = ((DataRowView)v_XL11BindingSource[numLeft])["MAHS"].ToString();
                string tenHS = ((DataRowView)v_XL11BindingSource[numLeft])["TENHS"].ToString();
                string ghiChu = ((DataRowView)v_XL11BindingSource[numLeft])["GHICHU"].ToString();

                ds.Add(new HocSinh_LL(maHS, tenHS, ghiChu));
                numLeft++;
            }
            ds.AllowNew = true;
            gridControl1.DataSource = ds;
            gridView2.Columns[0].Caption = "MAHS";
            gridView2.Columns[1].Caption = "TENHS";
            gridView2.Columns[2].Caption = "GHICHU";
        }
        

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (formLenLop._ll11 == 0)
            {
                formLenLop._ll11 = 1;
                FormTienTrinhLL f = new FormTienTrinhLL(this, comboBoxTenLop, v_XL11BindingSource, soHS_Lop);
                f.Text = "Tiến trình lên lớp 11";
                f.MdiParent = formLenLop;
                f.Show();
            }
            else
            {
                formLenLop.toolStripStatusLabelNote.Text = "Tiến trình lên lớp 11 đang mở!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSLHS11 formSLHS11 = new FormSLHS11(this);
            formSLHS11.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.v_XL11TableAdapter.Fill(this.qLHSTHPTDataSet1.V_XL11);

            int soLop = 0;
            List<string> arrTenLop = new List<string>();
            if (v_XL11BindingSource.Count != 0)
            {
                soHS_Lop = Helper.xepLop(v_XL11BindingSource.Count);
                if (soHS_Lop[0] == 0)
                {
                    MessageBox.Show("Số lượng học sinh lên lớp nằm ngoài khoảng xếp lớp khả dụng!\n\nKhoảng khả dụng tối ưu: từ " +
                        Program.MIN + " đến " + Program.MAX * Program.MAX_LOP + "\n\nHiện tại: " + v_XL11BindingSource.Count, "Lớp 11", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    this.textBoxSoLop.Text = soLop.ToString();

                    for (int i = 0; i < soLop; i++)
                    {
                        arrTenLop.Add("11A" + (i + 1));
                    }
                    this.comboBoxTenLop.DataSource = arrTenLop;
                    this.comboBoxTenLop.SelectedIndex = 0;
                }
            }
            else
            {
                barButtonItem1.Enabled = false;
                MessageBox.Show("Thiếu dữ liệu học sinh!\n\nGợi ý: Thêm dữ liệu học sinh từ Excel:\n\nQuản trị -> Excel-Học sinh", "Lớp 11", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
