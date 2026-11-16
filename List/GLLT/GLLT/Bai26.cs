using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai26
    {
        static void Main4(string[] args)
        {
            List<string> quest = new() { "2 + 5 + 7 =", "5 * 10 =", "sqrt(16)=", "12 % 2=", "5 // 2=" };
            List<int> result = new() { 14, 50, 4, 0, 4 };
            for (int i = 0; i < quest.Count; i++)
            {
                Console.WriteLine(quest[i]);
                Console.Write("Nhap cau tra loi: ");
                int ans = int.Parse(Console.ReadLine());
                if(ans == result[i])
                {
                    Console.Write("Chinh xac!");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Sai roi! Dap an la: " + result[i]);
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
