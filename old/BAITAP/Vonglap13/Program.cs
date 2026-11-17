using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP._01
{
    public class Program
    {

        public static void Main1(string[] args)
        {
            int a;
            Console.Write("Nhap so nguyen a: ");
            a = int.Parse(Console.ReadLine());

            int tongChan = 0;
            if (a % 2 != 0)
            {
                Console.WriteLine("Toi khong tinh tong so le, bye bye!!!");
            }
            else
            {
                for(int i = 0; i <= a; i += 2)
                {
                    tongChan += i;
                }
                Console.WriteLine("Tong so chan tu 0 den {0}: {1}", a, tongChan);

            }
            Console.ReadLine();
            
        }


    }
}
