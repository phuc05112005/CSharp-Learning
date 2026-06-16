using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.String19
{
    internal class Program
    {
        public static void Main1(string[] args)
        {
            string str1 = "English = 78 Science = 83 Math = 68 History = 65";
            string[] lst = str1.Split(' ');
            string strSo = "";
            foreach (string s in lst)
            {
                foreach (char c in s)
                {
                    if (char.IsDigit(c))
                    {
                        strSo += s + " ";
                        break;
                    }
                }
                
            }
            Console.WriteLine(strSo);
            strSo = strSo.Trim();

            string[] lst2 = strSo.Split(' ');

            int tong = 0;
            float trungBinh = 0;
            foreach(string x in lst2)
            {
                Console.WriteLine(x);
                tong += int.Parse(x);

            }
            Console.WriteLine(tong);

            trungBinh = tong / (float)lst2.Length;
            Console.WriteLine(trungBinh);
            Console.ReadLine();

        }
    }
}
