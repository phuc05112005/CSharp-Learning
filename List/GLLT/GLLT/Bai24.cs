using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai24
    {
        static void Main2(string[] args)
        {
            Console.Write("Nhap so luong phan tu trong danh sach: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new();
            Random rand = new Random();
            for(int i = 0; i< n; i++)
            {
                list.Add(rand.Next(1, 100));
            }

            Console.Write("Danh sach cac phan tu: ");
            foreach(int x in list)
            {
                Console.Write(x + " ");
            }
            Console.Read();
        }
    }
}
