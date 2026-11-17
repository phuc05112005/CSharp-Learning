using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.Vonglap14
{
    public class Program
    {
        public static void Main1()
        {
            int n;
            Console.Write("Nhap so le bat ky: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("So vua nhap khong phai la so le!");
            }
            else
            {
                int tongLe = 0;
                for (int i = 1; i <= n; i += 2)
                {
                    if( i == 3)
                    {
                        continue;
                    }
                    else
                    {
                        tongLe += i;
                    }
                }
                Console.WriteLine("Tong cac so le: {0}", tongLe);
            }
        }
    }
}
