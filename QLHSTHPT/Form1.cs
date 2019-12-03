using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void gIAOVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.qLHSTHPTDataSet.GIAOVIEN);

        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (gridView1 != null)
            {
                gridView1.ExportToXlsx("D://KhoaLuan//MainViewData.xlsx");
                Process excelexport = new Process();
                excelexport.StartInfo.FileName = "EXCEL.exe";
                excelexport.StartInfo.Arguments = "MainViewData.xlsx";
                excelexport.Start();
            }
        }
    }
}
