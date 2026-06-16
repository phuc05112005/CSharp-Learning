using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.bai15_chuoi
{
    internal class Program
    {
        public static void Main1(string[] args)
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

            // IndexOf
            string chuoi10 = "baigjfa";
            int kq = chuoi10.IndexOf("a");
            Console.WriteLine(kq);

            // LastIndexOf
            string chuoi11 = "baigjfa";
            int kq2 = chuoi11.LastIndexOf("a");
            Console.WriteLine(kq2);

            // Remove
            string chuoi12 = "baigjfa";
            chuoi12 = chuoi12.Remove(3, 2);
            Console.WriteLine(chuoi12);

            // Replay
            string chuoi13 = "abc1234512345";
            chuoi13 = chuoi13.Replace("45", "abc");
            Console.WriteLine(chuoi13);

            // bool StartsWith
            string chuoi14 = "ditimthanhcong";
            bool kt3 = chuoi14.StartsWith("ditim");
            Console.WriteLine(kt3);

            // Substring
            string chuoi15 = "12345";
            string chuoi16 = chuoi15.Substring(2, 3);
            Console.WriteLine(chuoi16);

            // ToLower, ToUpper
            string chuoi17 = "Le hOANG pHUC";
            Console.WriteLine(chuoi17.ToLower());
            Console.WriteLine(chuoi17.ToUpper());

            // Trim()
            string chuoi18 = "          abc           ";
            Console.WriteLine(chuoi18.Trim());
            Console.WriteLine(chuoi18.TrimEnd());
            Console.WriteLine(chuoi18.TrimStart());

            // Split
            string chuoi19 = @"D:\Exercises\C_sharp\BAITAP";
            string[] lst3 = chuoi19.Split('\\');
            Console.WriteLine(lst3[0]);
            Console.WriteLine(lst3[1]);
            Console.WriteLine(lst3[2]);
            Console.WriteLine(lst3[3]);

            // joint string
            string[] lst4 = new string[3];
            lst4[0] = "Le";
            lst4[1] = "Hoang";
            lst4[2] = "Phuc";

            string chuoi20 = string.Join(" ", lst4);
            Console.WriteLine(chuoi20);

            Console.ReadKey();
        }
    }
}
