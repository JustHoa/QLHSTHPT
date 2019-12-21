using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class Lop
    {
        public string maLop { get; set; }
        public string tenLop { get; set; }
        public int maNH { get; set; }
        public string ban { get; set; }
        public int maKhoi { get; set; }


        public Lop()
        {
        }

        public Lop(string maLop, string tenLop, int maNH, string ban, int maKhoi)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.maNH = maNH;
            this.ban = ban;
            this.maKhoi = maKhoi;
        }

        public Lop(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }
    }
}
