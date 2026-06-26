class Program3
{
    static void Main1(string[] args)
    {
        string s;
        Console.Write("Nhap vao chuoi ki tu: ");
        s = Console.ReadLine();

        Check((x) => x.Length > 3, s);

    }

    static void Check(Func<string, bool> f, string s)
    {
        if (f(s))
        {
            Console.WriteLine("Dung");
        }
        else
        {
            Console.WriteLine("Sai");
        }
    }
}