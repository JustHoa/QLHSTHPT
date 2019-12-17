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
    public partial class FormTongKetLop : Form
    {
        public int clkMan = 0;
        FormChinh formChinh;

        public FormTongKetLop()
        {
            InitializeComponent();
        }

        public FormTongKetLop(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelENH.Text = labelELop.Text = "";

            if (comboBoxNH.Text == "")
            {
                labelENH.Text = "Chọn năm học trước!";
                comboBoxNH.Focus();
                return;
            }

            if (comboBoxLop.Text == "")
            {
                labelELop.Text = "Chọn lớp học trước!";
                comboBoxLop.Focus();
                return;
            }

            panelLC.Enabled = false;
            standaloneBarDockControl1.Enabled = true;
            panelTK.Enabled = true;
        }

        private void FormTongKetLop_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            panelLC.Enabled = true;
            standaloneBarDockControl1.Enabled = panelTK.Enabled = false;

            try
            {
                this.sP_NAMHOC_CNTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_NAMHOC_CN, Program.maGV);
                comboBoxNH.SelectedIndex = -1;
                comboBoxNH.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void sP_NAMHOC_CNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelENH.Text = labelELop.Text = "";

            try
            {
                this.sP_LOP_NAMHOC_CNTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_LOP_NAMHOC_CN, Program.maGV, int.Parse(comboBoxNH.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                labelENH.Text = "Chọn năm học trước!";
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_TBM_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_TBM_LOP, comboBoxLop.SelectedValue.ToString(), 1);
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns.Add("DTBHK", typeof(string));
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns["DTBHK"].ReadOnly = false;
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns.Add("HOCLUC", typeof(string));
                this.qLHSTHPTDataSet1.SP_TBM_LOP.Columns["HOCLUC"].ReadOnly = false;
                clkMan = 1;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            int count = sP_TBM_LOPBindingSource.Count;
            int slG = 0, slK = 0, slTB = 0, slY = 0, slKe = 0;
            for (int i = 0; i < count; i++)
            {
                try
                {
                    float dHoa = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["HÓA"].ToString());
                    //float dSinh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SINH"].ToString());
                    //float dAnh = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ANH"].ToString());
                    //float dGDCD = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["GDCD"].ToString());
                    //float dToan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["TOÁN"].ToString());
                    //float dLy = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["LÝ"].ToString());
                    //float dVan = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["VĂN"].ToString());
                    //float dSu = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["SỬ"].ToString());
                    //float dDia = float.Parse(((DataRowView)sP_TBM_LOPBindingSource[i])["ĐỊA"].ToString());
                    float dSinh = 7;
                    float dAnh = 7;
                    float dGDCD = 06;
                    float dToan = 6.5f;
                    float dLy = 06;
                    float dVan = 6.5f;
                    float dSu = 08;
                    float dDia = 06;
                    float dTB = (dHoa + dSinh + dAnh + dGDCD + 2 * dToan + dLy + 2 * dVan + dSu + dDia) / 11;
                    gridView1.SetRowCellValue(i, "DTBHK", dTB);

                    string hl = Helper.hocLuc(dTB, dHoa, dSinh, dAnh, dGDCD, dToan, dLy, dVan, dSu, dDia);
                    gridView1.SetRowCellValue(i, "HOCLUC", hl);
                    switch (hl)
                    {
                        case "Giỏi":
                            slG++;
                            break;
                        case "Khá":
                            slK++;
                            break;
                        case "Trung bình":
                            slTB++;
                            break;
                        case "Yếu":
                            slY++;
                            break;
                        case "Kém":
                            slKe++;
                            break;
                    }
                }
                catch { }
            }
            textBoxG.Text = slG + "/" + count + " học sinh";
            textBoxK.Text = slK + "/" + count + " học sinh";
            textBoxTB.Text = slTB + "/" + count + " học sinh";
            textBoxY.Text = slY + "/" + count + " học sinh";
            textBoxKe.Text = slKe + "/" + count + " học sinh";

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.sP_TBM_LOPTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_TBM_LOP, comboBoxLop.SelectedValue.ToString(), 2);
                clkMan = 2;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelTK.Enabled = false;
            standaloneBarDockControl1.Enabled = false;
            panelLC.Enabled = true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int count = sP_TBM_LOPBindingSource.Count;
            string maLop = comboBoxLop.SelectedValue.ToString();
            for (int i = 0; i < count; i++)
            {
                string maHS = ((DataRowView)sP_TBM_LOPBindingSource[i])["MAHS"].ToString();
                string hocLuc = gridView1.GetRowCellValue(i, "HOCLUC").ToString();
                switch (hocLuc)
                {
                    case "Giỏi":
                        hocLuc = "G";
                        break;
                    case "Khá":
                        hocLuc = "K";
                        break;
                    case "Trung bình":
                        hocLuc = "TB";
                        break;
                    case "Yếu":
                        hocLuc = "Y";
                        break;
                    case "Kém":
                        hocLuc = "Ke";
                        break;
                }
                Helper.capNhatHocLuc(clkMan, maHS, maLop, hocLuc);
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clkMan = 3;
        }
    }
}
