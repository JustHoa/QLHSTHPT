using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHSTHPT.Model
{
    class HS
    {
        public string maHS { get; set; }
        public string tenHS { get; set; }

        public HS(string maHS, string tenHS)
        {
            this.maHS = maHS;
            this.tenHS = tenHS;
        }
    }
}
