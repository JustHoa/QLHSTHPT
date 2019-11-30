using DevExpress.XtraReports.UI;
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
    public partial class FormBangDiemHS : Form
    {
        FormChinh formChinh;

        public FormBangDiemHS(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private void FormBangDiemHS_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void CenterControlInParent(Control ctrlToCenter)
        {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
            //ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }

        private void FormBangDiemHS_SizeChanged(object sender, EventArgs e)
        {
            CenterControlInParent(this.textBoxMaHS);
            this.textBoxMaNH.Left = this.textBoxMaHK.Left = this.textBoxMaHS.Left;
            this.labelMaHS.Left = this.labelMaHK.Left = this.labelMaNH.Left = this.textBoxMaHS.Left - (this.labelMaHS.Width + 3);
            this.buttonBrMaHS.Left = this.buttonBrMaNH.Left = this.buttonBrMaHK.Left = this.textBoxMaHS.Left + this.textBoxMaHS.Width + 3;
            this.buttonOK.Left = this.textBoxMaHS.Left;
            this.buttonThoat.Left = this.buttonBrMaHS.Right - this.buttonThoat.Width;

        }

        private void buttonBrMaHS_Click(object sender, EventArgs e)
        {
            formChinh.Enabled = false;
            FormTimHS f = new FormTimHS(formChinh, this);
            f.Activate();
            f.Show();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            // dk

            BaoCao.BangDiemHS bc = new BaoCao.BangDiemHS(textBoxMaHK.Text, textBoxMaNH.Text, textBoxMaHK.Text);
            ReportPrintTool show = new ReportPrintTool(bc);
            show.ShowPreview();
        }
    }
}
