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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dIEMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dIEMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.qLHSTHPTDataSet.DIEM);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }
    }
}
