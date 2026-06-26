using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.Vonglap16
{
    internal class Program
    {
        public static void Main1()
        {
            int m = 1;
            int s = 0;
            for (int i = 1; i <=10; i++)
            {
                m *= i;
                Console.WriteLine(m);
                s += m;
            }
            Console.WriteLine("Tong s: {0}",s);
            Console.ReadLine();
        }
    }
}
