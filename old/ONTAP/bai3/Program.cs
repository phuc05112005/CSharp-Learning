class bai3
{
    static void Main(string[] args)
    {
        int i1 = 2;
        int i2 = 5;
        int i3 = -3;
        double d1 = 2.0;
        double d2 = 5.0;
        double d3 = -0.5;

        int a = i1 + (i2 * i3);
        int b = i1 * (i2 + i3);
        int c = i1 / (i2 + i3);
        float d = (float)i1 / i2 + i3;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
    }
}