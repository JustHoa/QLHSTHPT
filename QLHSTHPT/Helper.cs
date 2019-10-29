using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    class Helper
    {
        static public string[] createMaGV(BindingSource bindingSource)
        {
            string[] maGV = new string[2];
            Boolean flagGV = false, flagPV = false;

            for (int i = bindingSource.Count - 2; i >= 0; i--)
            {
                string id = ((DataRowView)bindingSource[i])["MAGV"].ToString();
                string part1 = id.Substring(0, 2);
                string part2 = DateTime.Today.Year.ToString().Substring(2, 2);
                int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                if (part1.Equals("GV") && flagGV == false)
                {
                    maGV[0] = part1 + part2 + part3;
                    flagGV = true;
                }
                if (part1.Equals("PV") && flagPV == false)
                {                   
                    maGV[1] = part1 + part2 + part3;
                    flagPV = true;
                }
                if (flagGV == true && flagPV == true) break;
            }

            if (flagGV == false) maGV[0] = "GV" + DateTime.Today.Year.ToString().Substring(2, 2) + "000001";
            if (flagPV == false) maGV[1] = "PV" + DateTime.Today.Year.ToString().Substring(2, 2) + "000001";

            return maGV;
        }

        static public string createMaHS (BindingSource bindingSource)
        {
            string maHS = "";
            int last = bindingSource.Count - 2;
            if(last >= 0)
            {
                string id = ((DataRowView)bindingSource[last])["MAHS"].ToString();
                int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                string part3 = _part3.ToString().PadLeft(6, '0');
                maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + part3;
            }
            else maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + "1";
            return maHS;
        }
    }
}
