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
    public partial class FormThemHK_LL : Form
    {
        FormTienTrinhLL formTienTrinhLL;

        public FormThemHK_LL()
        {
            InitializeComponent();
        }

        public FormThemHK_LL(FormTienTrinhLL formTienTrinhLL)
        {
            InitializeComponent();
            this.formTienTrinhLL = formTienTrinhLL;
        }

        private void hOCKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOCKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet1);

        }

        private void FormThemHK_LL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.HOCKY' table. You can move, or remove it, as needed.
            this.hOCKYTableAdapter.Fill(this.qLHSTHPTDataSet1.HOCKY);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
