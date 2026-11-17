using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP
{
    internal class Program
    {
        // Kiem tra so nguyen to
        public static void Main1(string[] args)
        {
            int a;
            Console.Write("Nhao vao so nguyen a: ");
            a = int.Parse(Console.ReadLine());

            if (a <= 0)
            {
                Console.Write("nhap so lon hon 0!!! Nhap lai: ");
                a = int.Parse(Console.ReadLine());  
            }
            int demUoc = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                    demUoc++;
                    Console.WriteLine(demUoc);
            }
            if(demUoc == 2)
            {
                Console.WriteLine("{0} LA SO NGUYEN TO", a);
            }
            else
            {
                Console.WriteLine("{0} KHONG PHAI LA SO NGUYEN TO", a);
            }
            Console.ReadLine();
        }
    }
}
