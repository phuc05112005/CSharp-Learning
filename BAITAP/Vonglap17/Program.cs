using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.Vonglap17
{
    internal class Program
    {
        // Tim tat ca nhung so hoan hao trong pham v 1 - 1000
        // 6 = 1+2+3
        public static void Main1()
        {
            //int n;
            //Console.Write("Nhap bat ky: ");
            //n = int.Parse(Console.ReadLine());
            //int tong = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    Console.WriteLine(i);
            //    if (n % i == 0)
            //    {
            //        tong += i;
            //        Console.WriteLine("Tong = {0}", tong);
            //    }
            //}

            //if (tong == n)
            //{
            //    Console.WriteLine("So {0} la so hoan hao!", n);
            //}
            //else
            //{
            //    Console.WriteLine("So {0} khong phai so hoan hao", n);
            //}

            Console.Write("So hoan hao tu 1 den 1000 gom: ");

            for (int n = 1; n <= 1000; n++)
            {
                int tong = 0;
                for (int i = 1; i<n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }
                if (tong == n)
                {
                    Console.Write(n+ " ");
                }
            }
        }
    }
}
