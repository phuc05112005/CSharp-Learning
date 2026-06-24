class Program
{
    public static void Main1(string[] args)
    {
        //Func<int, int, string> sum = (int a, int b) => (a + b).ToString();

        //var printUpper = (string s) => s.ToUpper();

        //var a = object (int a, int b) => a > b ? "True" : 0;

        //Console.WriteLine(sum( 3, 2));

        //Console.WriteLine(printUpper("Microsoft.NETCore.App\\8.0.28\\System.Security.Claims.dll"));

        //Console.WriteLine(a(1,2));

        //Console.WriteLine(a(2,1));


        //Console.Write("Nhap vao so a: ");
        //int A = int.Parse(Console.ReadLine());
        //Console.Write("Nhap vao so b: ");
        //int B = int.Parse(Console.ReadLine());

        //Call((a, b) => a + b, A, B);
        //Call((a, b) => a - b + 10, A, B);

        int[] arr = [111, 203, 123, 3123, 45324, 12312, 3143, 351];

        Print((x) => x % 2 != 0, arr);
        Print((x) => x % 2 == 0, arr);   

        }
        //static void Call(Func<int, int, int> f, int a, int b)
        //{
        //    Console.WriteLine(f(a, b));
        //}

    static void Print(Func<int, bool> f, int[] arr)
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