using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHSTHPT
{
    public static class Helper
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
                string part3 = "";
                if (part1.Equals("GV") && flagGV == false)
                {
                    if (part2 == id.Substring(2, 2))
                    {
                        int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                        part3 = _part3.ToString().PadLeft(6, '0');
                    }
                    else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
                    {
                        part3 = "1".PadLeft(6, '0');
                    }

                    maGV[0] = part1 + part2 + part3;
                    flagGV = true;
                }
                if (part1.Equals("PV") && flagPV == false)
                {
                    if (part2 == id.Substring(2, 2))
                    {
                        int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                        part3 = _part3.ToString().PadLeft(6, '0');
                    }
                    else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
                    {
                        part3 = "1".PadLeft(6, '0');
                    }

                    maGV[1] = part1 + part2 + part3;
                    flagPV = true;
                }
                if (flagGV == true && flagPV == true) break;
            }

            if (flagGV == false) maGV[0] = "GV" + DateTime.Today.Year.ToString().Substring(2, 2) + "000001";
            if (flagPV == false) maGV[1] = "PV" + DateTime.Today.Year.ToString().Substring(2, 2) + "000001";

            return maGV;
        }

        static public string createMaHS(string id)
        {
            string part2 = DateTime.Today.Year.ToString().Substring(2, 2);
            string part3 = "";
            if (part2 == id.Substring(2, 2))
            {
                int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                part3 = _part3.ToString().PadLeft(6, '0');
            }
            else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
            {
                part3 = "000001";
            }
            return "HS" + part2 + part3;
        }

        static public string createMaHS(BindingSource bindingSource)
        {
            string maHS = "";
            int last = bindingSource.Count - 2;
            if (last >= 0)
            {
                string id = ((DataRowView)bindingSource[last])["MAHS"].ToString();
                string part2 = DateTime.Today.Year.ToString().Substring(2, 2);
                string part3 = "";
                if (part2 == id.Substring(2, 2))
                {
                    int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                    part3 = _part3.ToString().PadLeft(6, '0');
                }
                else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
                {
                    part3 = "1".PadLeft(6, '0');
                }

                maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + part3;
            }
            else maHS = "HS" + DateTime.Today.Year.ToString().Substring(2, 2) + "1";
            return maHS;
        }

        static public string createMaLop(BindingSource bindingSource)
        {
            string maLop = "";
            int last = bindingSource.Count - 2;
            if (last >= 0)
            {
                string id = ((DataRowView)bindingSource[last])["MALOP"].ToString();
                string part2 = DateTime.Today.Year.ToString().Substring(2, 2);
                string part3 = "";
                if (part2 == id.Substring(2, 2))
                {
                    int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                    part3 = _part3.ToString().PadLeft(6, '0');
                }
                else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
                {
                    part3 = "1".PadLeft(6, '0');
                }

                maLop = "LO" + DateTime.Today.Year.ToString().Substring(2, 2) + part3;
            }
            else maLop = "LO" + DateTime.Today.Year.ToString().Substring(2, 2) + "1";
            return maLop;
        }

        static public string createMaLop()
        {
            string maLop = "", id = "";
            string sql = "SELECT TOP(1) * FROM LOP ORDER BY MALOP DESC";
            SqlCommand sqlCommand = new SqlCommand(sql, Program.sqlConnection);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                id = dataReader.GetValue(0).ToString().Trim();
                dataReader.Close();
            }
            else
            {
                id = "LO" + DateTime.Today.Year.ToString().Substring(2, 2) + "0000000";
                dataReader.Close();
            }
    
            string part2 = DateTime.Today.Year.ToString().Substring(2, 2);
            string part3 = "";
            if (part2 == id.Substring(2, 2))
            {
                int _part3 = int.Parse(id.Substring(4, 6)) + 1;
                part3 = _part3.ToString().PadLeft(6, '0');
            }
            else if (int.Parse(part2) > int.Parse(id.Substring(2, 2)))
            {
                part3 = "1".PadLeft(6, '0');
            }

            maLop = "LO" + DateTime.Today.Year.ToString().Substring(2, 2) + part3;
           
            return maLop;
        }

        static public string createMaNH(BindingSource bindingSource)
        {
            int last = bindingSource.Count - 2;
            int id = int.Parse(((DataRowView)bindingSource[last])["MANH"].ToString());
            int maNH = id + 1;
            return maNH.ToString();
        }

        static public string createAutoIncre(BindingSource bindingSource, string propColumn)
        {
            int last = bindingSource.Count - 2;
            int _id = int.Parse(((DataRowView)bindingSource[last])[propColumn].ToString());
            int id = _id + 1;
            return id.ToString();
        }

        static public bool namNhuan(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) ||
                (year % 400 == 0));
        }

        public static int Find(this BindingSource source, params Key[] keys)
        {
            PropertyDescriptor[] properties = new PropertyDescriptor[keys.Length];

            ITypedList typedList = source as ITypedList;

            if (source.Count <= 0) return -1;

            PropertyDescriptorCollection props;

            if (typedList != null) // obtain the PropertyDescriptors from the list
            {
                props = typedList.GetItemProperties(null);
            }
            else // use the TypeDescriptor on the first element of the list
            {
                props = TypeDescriptor.GetProperties(source[0]);
            }

            for (int i = 0; i < keys.Length; i++)
            {
                properties[i] = props.Find(keys[i].PropertyName, true); // will throw if the property isn't found
            }

            for (int i = 0; i < source.Count; i++)
            {
                object row = source[i];
                bool match = true;

                for (int p = 0; p < keys.Length; p++)
                {
                    if (properties[p].GetValue(row) != keys[p].Value)
                    {
                        match = false;
                        break;
                    }
                }

                if(match) return i;
            }

            return -1;
        }

        public static int [] xepLop (int soLuongSV)
        {
            int[] arrSV_Lop = new int[Program.MAX_LOP];
            for (int i = 1; i <= Program.MAX_LOP; i++)
            {
                int svLop = soLuongSV / i;
                if (svLop >= Program.MIN && svLop <= Program.MAX)
                {
                    for (int j = 0; j < i; j++)
                    {
                        arrSV_Lop[j] = svLop;
                    }
                    int svLe = soLuongSV % i;
                    int index = 0;
                    for (int k = i; k >= 1; k--)
                    {
                        for (int loop = 0; loop < k; loop++)
                        {
                            arrSV_Lop[index++] += svLe / k;
                            if (index == i) index = 0;
                        }
                        //svLop += svLe / k;
                        svLe = svLe % k;
                    }

                }
                else continue;
            }
            return arrSV_Lop;
        }
    }
}
