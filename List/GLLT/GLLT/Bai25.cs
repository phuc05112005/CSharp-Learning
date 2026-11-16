using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai25
    {
        static void Main3(string[] args)
        {
            Console.Write("Nhap so luong phan tu trong danh sach: ");
            int n = int.Parse(Console.ReadLine());
            List<int> list = new();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i);
                int num = int.Parse(Console.ReadLine());
                list.Add(num);
            }

            Console.Write("\nDanh sach sau khi them: ");
            for(int i = 0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            // Tao danh sach moi binh phuong cac phan tu o danh sach cu
            Console.Write("\nDanh sach cac phan tu sau khi binh phuong: ");
            List<double> list2 = new();
            foreach(int x in list)
            {
                list2.Add(Math.Pow(x, 2));
            }
            foreach(int x in list2)
            {
                Console.Write(x + " ");
            }

            // Dem co bao nhieu phan tu trong danh sach lon hon 20
            int count = 0;
            foreach(int x in list2)
            {
                if(x > 50)
                {
                    count++;
                }
            }
            Console.Write("\nSo luong phan tu trong danh sach lon hon 50: " + count);
        }
    }
}
