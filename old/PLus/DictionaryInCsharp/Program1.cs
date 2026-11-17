using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCsharp
{
    public class Program1
    {
        static void Main1(string[] args)
        {
            Dictionary<int, string> Sp = new Dictionary<int, string>();
            Sp.Add(100, "Laptop");
            Sp.Add(101, "Chuot");
            Sp.Add(102, "Ban phim");

            Console.Write("Nhap ma san pham: ");
            int n = int.Parse(Console.ReadLine());

            if(Sp.ContainsKey(n))
            {
                Console.WriteLine("Ten san pham: " + Sp[n]);
            }
            else
            {
                Console.WriteLine("Khong co ma san pham can tim");
            }
        }
    }
}
