using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class HocSinh_LL
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public string ghiChu { get; set; }

        public HocSinh_LL()
        {
        }

        public HocSinh_LL(string maHS, string tenHS, string ghiChu)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.ghiChu = ghiChu;
        }
    }
}
