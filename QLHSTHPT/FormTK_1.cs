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
    public partial class FormTK_1 : Form
    {
        FormChinh formChinh;
        public string maHS;
        public string tenHS;
        public string diemTK;
        public string dToan;
        public string dVan;
        public string dHoa;
        public string dSinh;
        public string dANh;
        public string dGDCD;
        public string dLy;
        public string dSu;
        public string dDia;

        public FormTK_1()
        {
            InitializeComponent();
        }

        public FormTK_1(FormChinh formChinh, string maHS, string tenHS, string diemTK, string dToan, string dVan, string dHoa, string dSinh, string dANh, string dGDCD, string dLy, string dSu, string dDia)
        {
            InitializeComponent();
            this.formChinh = formChinh;
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diemTK = diemTK;
            this.dToan = dToan;
            this.dVan = dVan;
            this.dHoa = dHoa;
            this.dSinh = dSinh;
            this.dANh = dANh;
            this.dGDCD = dGDCD;
            this.dLy = dLy;
            this.dSu = dSu;
            this.dDia = dDia;
        }

        private void FormTK_1_Load(object sender, EventArgs e)
        {
            textBoxMHS.Text = this.maHS;
            textBoxTHS.Text = this.tenHS;
            textBoxDTK.Text = this.diemTK;
            textBoxToan.Text = this.dToan;
            textBoxVan.Text = this.dVan;
            textBoxHoa.Text = this.dHoa;
            textBoxSinh.Text = this.dSinh;
            textBoxAnh.Text = this.dANh;
            textBoxGDCD.Text = this.dGDCD;
            textBoxLy.Text = this.dLy;
            textBoxSu.Text = this.dSu;
            textBoxDia.Text = this.dDia;
        }

        private void FormTK_1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }
    }
}
