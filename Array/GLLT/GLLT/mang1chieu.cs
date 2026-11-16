using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GLLT
{
    internal class mang1chieu
    {
        static void Main1(string[] args)
        {
            int[] arr = { 7, 2, 8, 4, 9, 6, 1, 4, 5 };
            foreach(int x in arr)
            {
                Console.Write(x + " ");
            }

            // Dao nguoc mang
            Console.WriteLine();
            Array.Reverse(arr);
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }

            // Sap xep tang dan
            Array.Sort(arr);
            Console.WriteLine();
            for(int i = 0; i<arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }



            // Vi du
            Console.Write("\nNhap so luong phan tu trong mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];
            Random rand = new Random();

            Console.Write("Danh sach phan tu ngau nhien trong mang: ");
            for(int i = 0; i < n; i++)
            {
                mang[i] = rand.Next(100);
                Console.Write(mang[i] + " ");
            }

            Console.Write("\nDanh sach phan tu trong mang sau khi dao nguoc: ");
            Array.Reverse(mang);
            foreach(int x in mang)
            {
                Console.Write(x + " ");
            }

            Console.Write("\nDanh sach phan tu trong mang sau khi sao xep tang dan: ");
            //Array.Sort(mang);
            foreach (int x in mang)
            {
                Console.Write(x + " ");
            }

            Console.Write("\nTong gia tri cac phan tu trong mang: ");
            int tong = 0;
            foreach(int x in mang) {
                tong += x;
            }
            Console.Write(tong);

            // BinarySearch
            Console.Write("\nNhap gia tri can tim: ");
            int num = int.Parse(Console.ReadLine());
            int kq = Array.BinarySearch(mang, num);
            if(kq != -1)
            {
                Console.WriteLine("So can tim co trong mang, o vi tri thu {0}!", kq);
            } else
            {
                Console.WriteLine("So can tim khong co trong mang!");
            }

            // Khong dung BinarySearch
            Console.Write("\nNhap gia tri can tim: ");
            int num2 = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 0; i<mang.Length;i++)
            {
                if(num2 == mang[i])
                {
                    Console.WriteLine("So {0} co trong mang, o vi tri thu {1}!", num, i);
                    count++;
                }
            }
            if(count == 0)
                Console.WriteLine("So can tim khong co trong mang!");

            Console.Read();
        }
    }
}
