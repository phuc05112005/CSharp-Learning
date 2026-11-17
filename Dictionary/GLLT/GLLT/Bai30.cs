using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai30
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dic = new() { { "A", 1 }, { "B", 2 }, { "C", 3 }, { "D", 4 } };
            Console.Write("Chuoi ky tu sau tach la: ");
            List<string> dsKey = dic.Keys.ToList();
            foreach(string x in dsKey)
            {
                Console.Write(x + " ");
            }

            // Cach khac
            Console.Write("\nDanh sach sau khi tach la: ");
            foreach(string key in dic.Keys)
            {
                Console.Write(key + " ");
            }

            Console.Write("\nDanh sach sau khi tach la: ");
            foreach(int value in dic.Values)
            {
                Console.Write(value + " ");
            }

            int tong = 0;
            foreach(int x in dic.Values)
            {
                tong += x;
            }
            Console.Write("\nTong cac so la: " + tong);


            // Chuyen doi chuoi sang so
            Console.WriteLine();
            string chuoiChu = "ABCD";
            string chuoiSo = "";
            foreach (char i in chuoiChu)
            {
                Console.Write(i + " ");
                chuoiSo += dic[i.ToString()];
            }
            Console.Write("\nChuoi sau khi chuyen doi: " + chuoiSo);
        }
    }
}
