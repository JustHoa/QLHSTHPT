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
    public partial class FormCV : Form
    {
        FormChinh formChinh;

        public FormCV()
        {
            InitializeComponent();
        }

        public FormCV(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labelEMaNH.Text = "";
            if (textBoxMaNH.Text == "")
            {
                this.labelEMaNH.Text = "Chưa nhập Mã năm học. Chú ý!";
                this.textBoxMaNH.Focus();
                return;
            }

            try
            {
                this.sP_CV_GVTableAdapter.Fill(this.qLHSTHPTDataSet1.SP_CV_GV, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBoxMaNH.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(comboBoxHK.Text, typeof(int))))));
                if (sP_CV_GVBindingSource.Count == 0)
                {
                    MessageBox.Show("Giáo viên chưa có thông tin phân công nhiệm vụ giảng dạy!");
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCV_Load(object sender, EventArgs e)
        {
            this.textBoxMaGV.Text = Program.maGV;
            this.textBoxTenGV.Text = Program.tenGV;
            this.textBoxMaNH.Select();
            this.comboBoxHK.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimNH_CongViec f = new FormTimNH_CongViec(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked)
            {
                sP_CV_GVBindingSource.RemoveFilter();
                labelTitle.Text = "THÔNG TIN GIẢNG DẠY";
            }
            else
            {
                sP_CV_GVBindingSource.Filter = "CHUNHIEM = 1";
                labelTitle.Text = "THÔNG TIN CHỦ NHIỆM";
            }
        }

        private void textBoxMaNH_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaNH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > (char)47) && (e.KeyChar < (char)58)) //so
            {
                this.labelEMaNH.Text = "";
                e.Handled = false;
            }
            else if ((e.KeyChar == (char)13) || (e.KeyChar == (char)8)) //enter, backspace
            {
                this.labelEMaNH.Text = "";
                e.Handled = false;
            }
            else
            {
                this.labelEMaNH.Text = "Điện thoại chỉ bao gồm số!";
                e.Handled = true;
            }
        }
    }
}
