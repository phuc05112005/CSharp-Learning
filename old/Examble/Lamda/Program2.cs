class Program2
{
    static void Main(string[] args)
    {
        int[] arr = [341, 315, 654, 5211, 8420, 12, 5235, 653, 78434];

        Filter((x) => x > 1000, arr);
    }

    static void Filter(Func< int, bool> f, int[] arr)
    {
        foreach (int i in arr)
        {
            if (f(i))
            {
                Console.WriteLine(i);
            }
        }
    }
}