using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaLaiLapTrinh
{
    internal class pho
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap so bat ky: ");
            //int a = int.Parse(Console.ReadLine());

            //if(a % 2 == 0)
            //{
            //    int tong = 0;
            //    for(int i = 0; i<=a; i+=2)
            //    {
            //        tong += i;
            //    }
            //    Console.Write("Tong cac so chan tu 0 toi {0} la: " + tong, a);
            //} else
            //{
            //    Console.WriteLine("\nToi ko tinh tong so le, bye bye!");
            //}
            //Console.Read();

            int m = 1;
            int tong = 0;
            for(int i = 1; i<=10; i++)
            {
                m = i * m;
                Console.WriteLine(m);

                tong += m;
            }
            Console.WriteLine("Tong 1! + 2! + ... + 10! = " + tong);

        }
    }
}
