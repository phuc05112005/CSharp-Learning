using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T temp;
        temp = a;
        a = b;
        b = temp;
    }
    static void Main(string[] args)
    {
        string a = "Abc";
        string b = "Xyz";

        Console.WriteLine($"a: {a}, b: {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a: {a}, b: {b}");

    }
}