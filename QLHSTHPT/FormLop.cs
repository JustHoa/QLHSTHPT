﻿using System;
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
    public partial class FormLop : Form
    {
        public FormLop()
        {
            InitializeComponent();
        }

        private void FormLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLHSTHPTDataSet.LOP);
        
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }


        private void lOPBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLHSTHPTDataSet);

        }
    }
}
