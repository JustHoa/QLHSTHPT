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
            if (textBoxMaNH.Text == "")
            {
                this.labelEMaNH.Text = "Chưa nhập Mã năm học. Chú ý!";
                this.textBoxMaNH.Focus();
                return;
            }

            if (textBoxMaHK.Text == "")
            {
                this.labelEMaHK.Text = "Chưa nhập Mã học kỳ. Chú ý!";
                this.textBoxMaHK.Focus();
                return;
            }

            try
            {
                this.sP_CV_GVTableAdapter.Fill(this.qLHSTHPTDataSet.SP_CV_GV, Program.maGV, new System.Nullable<int>(((int)(System.Convert.ChangeType(textBoxMaNH.Text, typeof(int))))), new System.Nullable<int>(((int)(System.Convert.ChangeType(textBoxMaHK.Text, typeof(int))))));
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
            this.textBoxMaNH.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimNH_CongViec f = new FormTimNH_CongViec(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimHK_CongViec f = new FormTimHK_CongViec(formChinh, this);
            f.Activate();
            f.Show();
        }
    }
}
