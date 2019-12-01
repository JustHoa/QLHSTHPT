using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class HocSinh
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }
        public string ngaySinh { get; set; }
        public string gioiTinh { get; set; }
        public string diaChi { get; set; }
        public string danToc { get; set; }
        public string dienThoai { get; set; }
        public string maLop { get; set; }
        public int nghiHoc { get; set; }

        public HocSinh()
        {
        }

        public HocSinh(string maHS, string tenHS, string ngaySinh, string gioiTinh, string diaChi, string danToc, string dienThoai, string maLop, int nghiHoc)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.danToc = danToc;
            this.dienThoai = dienThoai;
            this.maLop = maLop;
            this.nghiHoc = nghiHoc;
        }
    }
}
