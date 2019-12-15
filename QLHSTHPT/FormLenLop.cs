using DevExpress.XtraBars;
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
    public partial class FormLenLop : Form
    {
        FormChinh formChinh;

        public FormLenLop()
        {
            InitializeComponent();
        }

        public FormLenLop(FormChinh formChinh)
        {
            InitializeComponent();
            this.formChinh = formChinh;
        }

        private Form checkExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLL10));
            if (frm != null) frm.Activate();
            else
            {
                FormLL10 f = new FormLL10(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Visible = false;
            formChinh.Activate();
            formChinh.Enabled = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLL11));
            if (frm != null) frm.Activate();
            else
            {
                FormLL11 f = new FormLL11(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.checkExists(typeof(FormLL12));
            if (frm != null) frm.Activate();
            else
            {
                FormLL12 f = new FormLL12(this);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void FormLenLop_Load(object sender, EventArgs e)
        {
            FormLL10 f10 = new FormLL10(this);
            f10.MdiParent = this;
            f10.Show();

            FormLL11 f11 = new FormLL11(this);
            f11.MdiParent = this;
            f11.Show();

            FormLL12 f12 = new FormLL12(this);
            f12.MdiParent = this;
            f12.Show();

            f10.Activate();
        }
    }
}
