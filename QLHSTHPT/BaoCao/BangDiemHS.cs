using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLHSTHPT.BaoCao
{
    public partial class BangDiemHS : DevExpress.XtraReports.UI.XtraReport
    {
        public BangDiemHS()
        {
            InitializeComponent();
        }

        public BangDiemHS(string maHS, string maNH, string maHK)
        {
            InitializeComponent();
            XRTableCell d = new XRTableCell();
            d.Text = "fdf";
            d.Font = new Font("Tahoma", 8,  FontStyle.Bold);
            d.ForeColor = System.Drawing.Color.FromArgb(75, 75, 75);
            d.BorderWidth = 0;
            d.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableRow2.Cells.Add(d);

            this.sqlDataSource1.Fill(maHS, maNH, maHK);
        }
    }
}
