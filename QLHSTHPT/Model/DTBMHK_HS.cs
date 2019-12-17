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
        public float dHoa { get; set; }
        public float dSinh { get; set; }
        public float dAnh { get; set; }
        public float dGDCD { get; set; }
        public float dToan { get; set; }
        public float dLy { get; set; }
        public float dVan { get; set; }
        public float dSu { get; set; }
        public float dDia { get; set; }
        public float diemTB { get; set; }
        public string hocLuc { get; set; }

        public DTBMHK_HS()
        {
        }

        public DTBMHK_HS(string maHS, string tenHS, float diemTB)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
            this.diemTB = diemTB;
        }

        public DTBMHK_HS(string maHS, string tenHS, float dHoa, float dSinh, float dAnh, float dGDCD, float dToan, float dLy, float dVan, float dSu, float dDia, float diemTB, string hocLuc) : this(maHS, tenHS, dHoa)
        {
            this.dSinh = dSinh;
            this.dAnh = dAnh;
            this.dGDCD = dGDCD;
            this.dToan = dToan;
            this.dLy = dLy;
            this.dVan = dVan;
            this.dSu = dSu;
            this.dDia = dDia;
            this.diemTB = diemTB;
            this.hocLuc = hocLuc;
        }

        public DTBMHK_HS(string maHS, string tenHS, float dHoa, float dSinh, float dAnh, float dGDCD, float dToan, float dLy, float dVan, float dSu, float dDia) : this(maHS, tenHS, dHoa)
        {
            this.dSinh = dSinh;
            this.dAnh = dAnh;
            this.dGDCD = dGDCD;
            this.dToan = dToan;
            this.dLy = dLy;
            this.dVan = dVan;
            this.dSu = dSu;
            this.dDia = dDia;
        }
    }
}
