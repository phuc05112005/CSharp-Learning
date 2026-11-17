using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var y = 113;
            Console.WriteLine("Kieu du lieu cua y la {0}", y.GetType().ToString());
            var z = "Toan";
            Console.WriteLine("Kieu du lieu cua z la {0}", z.GetType().ToString());
            Console.ReadKey();
        }
    }
}
