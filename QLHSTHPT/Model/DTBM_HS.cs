using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class DTBM_HS
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public float diemTB { get; set; }

        public DTBM_HS(string maHS, string tenHS, float diemTB)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diemTB = diemTB;
        }
    }
}
