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
    public partial class FormSLHS11 : Form
    {
        FormLL11 formLL11;

        public FormSLHS11()
        {
            InitializeComponent();
        }

        private void FormSLHS11_Load(object sender, EventArgs e)
        {

        }

        public FormSLHS11(FormLL11 formLL11)
        {
            InitializeComponent();
            this.formLL11 = formLL11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maxLop = int.Parse(nupLop.Value.ToString());
            int minSS = int.Parse(nupMin.Value.ToString());
            int maxSS = int.Parse(nupMax.Value.ToString());
            if (maxLop <= 0)
            {
                error.Text = "Lỗi: Số lượng lớp phải lớn hơn 0!";
                nupLop.Focus();
                return;
            }
            if (minSS <= 0)
            {
                error.Text = "Lỗi: Sỉ số ít nhất phải lớn hơn 0!";
                nupMin.Focus();
                return;
            }
            if (maxSS <= 0)
            {
                error.Text = "Lỗi: Sỉ số nhiều nhất phải lớn hơn 0!";
                nupMax.Focus();
                return;
            }
            if (maxSS <= minSS)
            {
                error.Text = "Lỗi: Sỉ số nhiều nhất phải lớn hơn sỉ số ít nhất!";
                nupMax.Focus();
                return;
            }

            int[] temp = new int[maxLop];
            int soLop = 0;
            List<string> arrTenLop = new List<string>();
            temp = Helper.xepLop(formLL11.v_XL11BindingSource.Count, maxLop, minSS, maxSS);
            if (temp[0] == 0)
                error.Text = "Lỗi: Số lượng lớp tối đa hoặc khoảng sỉ số không khả dụng!";
            else
            {
                formLL11.soHS_Lop = temp;

                formLL11.barButtonItem1.Enabled = true;
                for (int i = 0; i < maxLop; i++)
                {
                    if (formLL11.soHS_Lop[i] != 0)
                    {
                        soLop += 1;
                    }
                }

                formLL11.textBoxSoLop.Text = soLop.ToString();

                for (int i = 0; i < soLop; i++)
                {
                    arrTenLop.Add("11A" + (i + 1));
                }
                formLL11.comboBoxTenLop.DataSource = arrTenLop;
                formLL11.comboBoxTenLop.SelectedIndex = 0;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
