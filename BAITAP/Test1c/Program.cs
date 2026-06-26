using System;

class Variable
{
    public static void Main()
    {
        int radius = 4;
        const double PI = 3.14159;
        double area, circum;

        area = PI * radius * radius;
        circum = 2 * PI * radius;

        Console.WriteLine("Raidus= {0}, PI = {1}", radius, PI);
        Console.WriteLine("Dien tich {0}", area);
        Console.WriteLine("Chu vi {0}", circum);
    }
}