using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program7
{
    // Toan tu
    // + - * /
    // %: Chia lay du
    // += -= *= /=; a+=2 <=> a = a + 2
    // ++ --
    public static void Main()
    {

        int a = 5;
        Console.WriteLine(a++); //5
        Console.WriteLine(++a); //7
        Console.WriteLine(a--); //7
        Console.WriteLine(a--); //6
        Console.WriteLine(--a); //4

        // Toan tu 3 ngoi:
        // Bieu thuc 1 ? Bieu thuc 2 : Bieu thuc 3

        // ***
        int x = 2;
        if (x % 2 == 0)
            Console.WriteLine("{0} la so chan", x);
        else Console.WriteLine("{0} la so le", x);

        // Tuong duong ***
        Console.WriteLine(x + " la so " + (x % 2 == 0 ? "chan" : "le"));

    }
}
