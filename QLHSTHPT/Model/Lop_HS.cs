using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class Lop_HS
    {
        public string maHS { get; set; }
        public string maLop { get; set; }

        public Lop_HS()
        {
        }

        public Lop_HS(string maHS, string maLop)
        {
            this.maHS = maHS;
            this.maLop = maLop;
        }
    }
}
