using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai27
    {
        static void Main(string[] args)
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
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }

            // Dem co bao nhieu so nho hon 5 va in ra vi tri index cua so do trong danh sach
            int count = 0;
            Console.Write("\nVi tri index cac so nho hon 5 trong danh sach: ");
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < 5)
                {
                    Console.Write(i + " ");
                    count++;
                }

            }
            Console.WriteLine("\nSo luong phan tu nho hon 5 trong danh sach la: " + count);
        }
    }
}
