using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public partial class FormThemNH_LL : Form
    {
        FormTienTrinhLL formTienTrinhLL;

        public FormThemNH_LL()
        {
            InitializeComponent();
        }

        public FormThemNH_LL(FormTienTrinhLL formTienTrinhLL)
        {
            InitializeComponent();
            this.formTienTrinhLL = formTienTrinhLL;
        }

        private void FormThemNH_LL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHSTHPTDataSet1.NAMHOC' table. You can move, or remove it, as needed.
            this.nAMHOCTableAdapter.Fill(this.qLHSTHPTDataSet1.NAMHOC);

            //this.nAMHOCBindingSource.AddNew();
            //this.textBoxMNH.Text = Helper.createAutoIncre(nAMHOCBindingSource, "MANH");
            //this.textBoxTNH.Focus();
        }

        private void buttonSkip_Click(object sender, EventArgs e)
        {
            this.Close();

            formTienTrinhLL.progressBar.Value = 25;
            formTienTrinhLL.chkbAddNH.Checked = true;

            // tien trinh them hoc ky
            FormThemHK_LL f = new FormThemHK_LL(formTienTrinhLL);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxTNH.Text == "")
            {
                this.labelETNH.Text = "Chưa nhập Tên năm học. Chú ý!";
                //MessageBox.Show("Chưa nhập Tên năm học. Chú ý!");
                textBoxTNH.Focus();
                return;
            }

            if (this.textBoxNBD.Text == "")
            {
                this.labelENBD.Text = "Chưa nhập Năm bắt đầu. Chú ý!";
                //MessageBox.Show("Chưa nhập Năm bắt đầu. Chú ý!");
                textBoxNBD.Focus();
                return;
            }

            if (this.textBoxNKT.Text == "")
            {
                this.labelENKT.Text = "Chưa nhập Năm kết thúc. Chú ý!";
                //MessageBox.Show("Chưa nhập Năm kết thúc. Chú ý!");
                textBoxNKT.Focus();
                return;
            }

            string sql = "EXEC SP_KT_NAMHOC_HOCKY 'NAMHOC', '" + textBoxTNH.Text + "', " +
                int.Parse(textBoxNBD.Text) + ", " + int.Parse(textBoxNKT.Text);
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int nowPosition = nAMHOCBindingSource.Position;
            int position = nAMHOCBindingSource.Find("NAMBD", textBoxNBD.Text);
            if ((dataReader.Read() || position != -1) && nowPosition != position)
            {
                this.labelENBD.Text = "Năm học đã tồn tại. Chú ý!";
                //MessageBox.Show("Năm học đã tồn tại. Chú ý!");
                textBoxNBD.Focus();
                dataReader.Close();
                return;
            }
            else
            {
                this.nAMHOCBindingSource.EndEdit();
                this.nAMHOCTableAdapter.Update(this.qLHSTHPTDataSet1.NAMHOC);
                dataReader.Close();

                formTienTrinhLL.progressBar.Value = 25;
                formTienTrinhLL.chkbAddNH.Checked = true;

                this.Close();

                // tien trinh them hoc ky
                FormThemHK_LL f = new FormThemHK_LL(formTienTrinhLL);
                f.MdiParent = formTienTrinhLL.MdiParent;
                f.Show();
            }
        }
    }
}
