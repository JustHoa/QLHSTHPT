using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class DTBMHK_HS
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public float diemTB { get; set; }

        public DTBMHK_HS()
        {
        }

        public DTBMHK_HS(string maHS, string tenHS, float diemTB)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diemTB = diemTB;
        }
    }
}
