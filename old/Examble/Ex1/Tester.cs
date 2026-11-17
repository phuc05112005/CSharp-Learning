using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tester
{
    public static void Main1()
    {
        ThoiGian tg = new ThoiGian();
        tg.nhap();
        Console.WriteLine(tg.ToString());

        Console.WriteLine("=====");
        ThoiGian tg1 = new ThoiGian(2026, 7, 6,8,46,10);
        Console.WriteLine(tg1.ToString());

        Console.WriteLine("=====");
        ThoiGian tg2 = new ThoiGian(tg1);
        Console.WriteLine(tg2.ToString());

        Console.WriteLine("=====");
        ThoiGian tg3 = new ThoiGian(DateTime.Now);
        Console.WriteLine(tg3.ToString());
    }
}