using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GaLaiLapTrinh
{
    internal class dowhile
    {
        static void Main1(string[] args)
        {
            int i = 0;
            while (i<= 10)
            {
                Console.Write(i + " ");
                i++;
            }

            int a = 1;
            int tong = 0;
            do
            {
                tong += a;
                a++;
            } while (a <= 5);
            Console.WriteLine("\nTong tu 1 den 5 la: " + tong);
            Console.Read();
        }
    }
}
