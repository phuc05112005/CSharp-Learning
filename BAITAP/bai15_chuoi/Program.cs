using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.bai15_chuoi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string chuoi = "Xin chao Viet Nam";
            Console.WriteLine($"Trong chuoi ky tu: {chuoi}");
            int demThuong = 0;
            int demInHoa = 0;
            int demSo = 0;
            int demSpace = 0;

            char[] lst = chuoi.ToCharArray();

            foreach (char c in lst)
            {
                if (char.IsLower(c))
                {
                    demThuong++;
                }
                else if (char.IsUpper(c))
                {
                    demInHoa++;
                }
                else if (char.IsNumber(c))
                {
                    demSo++;     
                }
                else if (char.IsWhiteSpace(c))
                {
                    demSpace++;
                }
            }
            Console.WriteLine($"Trong chuoi co {demThuong} ky tu thuong");
            Console.WriteLine($"Trong chuoi co {demInHoa} ky tu in hoa");
            Console.WriteLine($"Trong chuoi co {demSo} ky tu so");
            Console.WriteLine($"Trong chuoi co {demSpace} ky tu space");

            // Ham Copyto
            string chuoi2 = "123456";
            char[] lst2 = new char[6];
            lst2[0] = 'a';
            lst2[1] = 'b';
            Console.WriteLine(lst2);
            chuoi2.CopyTo(1, lst2, 2, 4);
            Console.WriteLine(lst2);

            // Ham bool EndsWith
            string chuoi3 = "abcxyz.mp3";
            bool kt = chuoi3.EndsWith(".mp3");
            Console.WriteLine(kt);

            // string.Format
            string chuoi4;
            int n = 14;
            chuoi4 = string.Format($"n= {n}, co can bac 2 la {Math.Sqrt(n)}");
            Console.WriteLine(chuoi4);

            // Ham Equals
            string chuoi6 = "haha";
            string chuoi7 = "hihi";
            bool kt2 = chuoi6.Equals(chuoi7);
            Console.WriteLine(kt2);

            // Insert
            string chuoi8 = "123";
            string chuoi9 = "456";
            chuoi8 = chuoi8.Insert(3, chuoi9);
            Console.WriteLine(chuoi8);

            Console.ReadKey();
        }
    }
}
