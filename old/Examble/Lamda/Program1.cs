class Program1
{
    static void Main1(string[] args)
    {
        Console.Write("Nhap vao so A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so B: ");
        int B = int.Parse(Console.ReadLine());

        //cach1
        //Func<int, int, int> cong = (a, b) => a + b;
        //Func<int, int, int> tru = (a, b) => a - b;
        //Func<int, int, int> nhan = (a, b) => a * b;
        //Func<int, int, int> chia = (a, b) => a / b;

        //Calculate(cong, A, B);
        //Calculate(nhan, A, B);
        //Calculate(chia, A, B);
        //Calculate(tru, A, B);

        //cach2
        Calculate((a, b) => a + b, A, B);
        Calculate((a, b) => a - b, A, B);
        Calculate((a, b) => a * b, A, B);
        Calculate((a, b) => a / b, A, B);
    }

    static void Calculate(Func<int, int, int> lamda,int a, int b)
    {
        Console.WriteLine(lamda(a, b));
    }
}